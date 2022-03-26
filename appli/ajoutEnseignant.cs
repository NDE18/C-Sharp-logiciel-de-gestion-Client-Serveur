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
    public partial class ajoutEnseignant : DevComponents.DotNetBar.Office2007Form
    {
        int compteur = 0;
        DataTable table;
        MySqlDataAdapter da;

        public ajoutEnseignant()
        {
            InitializeComponent();
            numeroEnseignant();
            chargerTableau();

            this.BEnregEnseignant.Click += new System.EventHandler(this.BEnregEnseignant_Executed);
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Executed);
        }

        public void BEnregEnseignant_Executed(object sender, EventArgs e)
        {
            enseignant ens = new enseignant();
            const string message = "Voulez-vous vraiment enregister ?";
            const string caption = "Confirmation";
            const string messages = "Enregistrement éffectué.";
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
                
                int p = ens.enregEnseignant(ens);
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
            numeroEnseignant();

        }

        public void numeroEnseignant()
        {
            int dat = System.DateTime.Now.Year - 2000;
            //string dates = dat;
            int d = System.DateTime.Now.Year;
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from enseignant";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    compteur = compteur + 1;
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (compteur < 9)
            {
                this.numEnseignant.Text = dat.ToString() + "EN00" + compteur;
            }
            else if (compteur > 9)
            {
                this.numEnseignant.Text = dat.ToString() + "ENB0" + compteur;
            }
            else if(compteur==0)
            {
                this.numEnseignant.Text = dat.ToString() + "EN001" + compteur;
            }
        }
    }
}
