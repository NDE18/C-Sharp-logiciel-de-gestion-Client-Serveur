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
    public partial class modifierEnseignant : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public modifierEnseignant()
        {
            InitializeComponent();

            chargerTableau();
            numeroEnseignant();

            this.modifEnseignant.Click += new System.EventHandler(this.modifEnseignant_Executed);
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Executed);
        }

        public void modifEnseignant_Executed(object sender, EventArgs e)
        {
            enseignant ens = new enseignant();
            string message = "Voulez-vous modifier les informations\n de l'enseignant numero " + numEnseignant.Text +"  ?";
            const string caption = "Confirmation";
            const string messages = "Modification éffectuée.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ens.SetAdresse(this.adresseEnseignant.Text);
                ens.SetCni(double.Parse(this.cniEnseignant.Text));
                ens.SetEmail(this.emailEnseignant.Text);
                ens.SetNom(this.nomEnseignant.Text);
                ens.SetNum(this.numEnseignant.Text);
                ens.SetPrenom(this.prenomEnseignant.Text);
                ens.SetTelephone(double.Parse(this.telEnseignant.Text));
                ens.SetProfession(this.professionEnseignant.Text);

                int p = ens.modifEnseignant(ens);
                if (p == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chargerTableau();
                    initialiser();
                }
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        public void BAnnuler_Executed(object sender, EventArgs e)
        {
            initialiser();
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("nom LIKE '%{0}%'", this.TRech.Text);
            this.listeEnseignant.DataSource = dv;
        }
        public void chargerTableau()
        {
            this.listeEnseignant.RowHeadersVisible = false;
            this.listeEnseignant.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM enseignant";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.listeEnseignant.DataSource = bs;
            this.listeEnseignant.Columns[0].HeaderText = "Numéro";
            this.listeEnseignant.Columns[1].HeaderText = "Noms";
            this.listeEnseignant.Columns[2].HeaderText = "Prenom";
            this.listeEnseignant.Columns[3].HeaderText = "Profession";
            this.listeEnseignant.Columns[4].HeaderText = "Adresse";
            this.listeEnseignant.Columns[5].HeaderText = "CNI";
            this.listeEnseignant.Columns[6].HeaderText = "N° de téléphone";
            this.listeEnseignant.Columns[7].HeaderText = "Email";
            this.listeEnseignant.Columns[1].Width = 200;
            this.listeEnseignant.Columns[2].Width = 200;
            this.listeEnseignant.Columns[3].Width = 150;
            this.listeEnseignant.Columns[4].Width = 200;
            this.listeEnseignant.Columns[5].Width = 200;
            this.listeEnseignant.Columns[6].Width = 200;
            this.listeEnseignant.Columns[7].Width = 200;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        public void initialiser()
        {
            this.nomEnseignant.Text = "";
            this.prenomEnseignant.Text = "";
            this.adresseEnseignant.Text = "";
            this.professionEnseignant.Text = "";
            this.cniEnseignant.Text = "";
            this.telEnseignant.Text = "";
            this.emailEnseignant.Text = "";
            this.numEnseignant.Text = "";
            numeroEnseignant();

        }
        public void numeroEnseignant()
        {
            this.numEnseignant.Items.Clear();
            ConnexionDB c = new ConnexionDB();
            string query = "Select numero FROM enseignant";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("numero");
                    this.numEnseignant.Items.Add(valeur);
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
            string query = "SELECT * FROM enseignant WHERE numero ='" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.nomEnseignant.Text = reader.GetString("nom");
                    this.prenomEnseignant.Text = reader.GetString("prenom");
                    this.adresseEnseignant.Text = reader.GetString("adresse");
                    this.professionEnseignant.Text = reader.GetString("profession");
                    this.cniEnseignant.Text = reader.GetString("cni");
                    this.telEnseignant.Text = reader.GetString("telephone");
                    this.emailEnseignant.Text = reader.GetString("email");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numEnseignant_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamp(numEnseignant.Text);
        }

        private void listeEnseignant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listeEnseignant.Rows[e.RowIndex];
                this.numEnseignant.Text = row.Cells[0].Value.ToString();
                this.nomEnseignant.Text = row.Cells[1].Value.ToString();
                this.prenomEnseignant.Text = row.Cells[2].Value.ToString();
                this.adresseEnseignant.Text = row.Cells[3].Value.ToString();
                this.professionEnseignant.Text = row.Cells[4].Value.ToString();
                this.cniEnseignant.Text = row.Cells[5].Value.ToString();
                this.telEnseignant.Text = row.Cells[6].Value.ToString();
                this.emailEnseignant.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
