using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appli
{
    public partial class modifierFormation : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public modifierFormation()
        {
            InitializeComponent();
            chargerTableau();
            numFormation();

            this.modifFormation.Click += new System.EventHandler(this.modifFormation_Executed);
            this.annulerFormation.Click += new System.EventHandler(this.annulerFormation_Executed);
        }

        public void modifFormation_Executed(object sender, EventArgs e)
        {
            formation f = new formation();
            f.SetCode(this.codeFormation.Text);
            f.SetIntitule(this.intituleFormation.Text);
            f.SetDureMin(double.Parse(this.minFormation.Text));
            f.SetDureMax(double.Parse(maxFormation.Text));
            f.SetObjectif(objectFormation.Text);
            string message = "Voulez-vous modifier les informations\n de la formation de code  "+ codes.Text + "?";
            const string caption = "Confirmation";
            const string messages = "Modification éffectuée.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                int p = f.modifFormation(f, codes.Text);
                if (p == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiser();
                    chargerTableau();
                    numFormation();
                }
            }
            else if (result == DialogResult.No)
            {
                initialiser();
            }
        }

        public void annulerFormation_Executed(object sender, EventArgs e)
        {
            initialiser();
        }

        public void initialiser()
        {
            this.objectFormation.Text = "";
            this.codeFormation.Text = "";
            this.intituleFormation.Text = "";
            this.maxFormation.Text = "";
            this.minFormation.Text = "";
        }

        public void numFormation()
        {

            ConnexionDB c = new ConnexionDB();
            string query = "Select code from formation";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("code");
                    this.codeFormation.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void remplirChamp(string valeur)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM formation WHERE code='" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.codeFormation.Text = reader.GetString("code");
                    this.intituleFormation.Text = reader.GetString("intitule");
                    this.minFormation.Text = reader.GetString("dure_min");
                    this.maxFormation.Text = reader.GetString("dure_max");
                    this.objectFormation.Text = reader.GetString("objectif");
                    this.codes.Text = reader.GetString("code");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RechT_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("intitule LIKE '%{0}%'", this.RechT.Text);
            this.listeFormation.DataSource = dv;
        }

        private void codeFormation_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamp(codeFormation.Text);
        }

        public void chargerTableau()
        {
            this.listeFormation.RowHeadersVisible = false;
            this.listeFormation.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT code,intitule,dure_min,dure_max,objectif FROM formation";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.listeFormation.DataSource = bs;
            this.listeFormation.Columns[0].HeaderText = "Code";
            this.listeFormation.Columns[1].HeaderText = "Intitulé";
            this.listeFormation.Columns[2].HeaderText = "Durée minimal";
            this.listeFormation.Columns[3].HeaderText = "Durée maximal";
            this.listeFormation.Columns[4].HeaderText = "Objectif";
            this.listeFormation.Columns[1].Width = 250;
            this.listeFormation.Columns[4].Width = 300;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        private void listeFormation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listeFormation.Rows[e.RowIndex];
                this.codeFormation.Text = row.Cells[0].Value.ToString();
                this.intituleFormation.Text = row.Cells[1].Value.ToString();
                this.minFormation.Text = row.Cells[2].Value.ToString();
                this.maxFormation.Text = row.Cells[3].Value.ToString();
                this.objectFormation.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
