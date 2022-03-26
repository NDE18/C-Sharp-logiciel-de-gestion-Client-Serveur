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
    public partial class supFormation : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public supFormation()
        {
            InitializeComponent();
            chargerTableau();
            numDepannage();

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
            string message = "Voulez-vous supprimer les informations\n de la formation de code  " + codeFormation.Text + "?";
            const string caption = "Confirmation";
            const string messages = "Suppression éffectuée.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                int p = f.suppFormation(f);
                if (p == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiser();
                    chargerTableau();
                    numDepannage();
                }
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

        public void numDepannage()
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
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
