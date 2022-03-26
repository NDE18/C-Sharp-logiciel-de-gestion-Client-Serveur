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
    public partial class AjoutClient : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public AjoutClient()
        {
            InitializeComponent();

            chargerTableau();
            numClient();

            this.BEnregClient.Click += new System.EventHandler(this.BEnregClient_Executed);
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Executed);
        }

        public void chargerTableau()
        {
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT numero_client,nom_clients,prenom_client,type_client,adresse_client,tel_client,email_client FROM client";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TClientEnreg.DataSource = bs;
            this.TClientEnreg.Columns[0].HeaderText = "Numéro";
            this.TClientEnreg.Columns[1].HeaderText = "Noms";
            this.TClientEnreg.Columns[2].HeaderText = "Prenoms";
            this.TClientEnreg.Columns[3].HeaderText = "Type";
            this.TClientEnreg.Columns[4].HeaderText = "Adresse";
            this.TClientEnreg.Columns[5].HeaderText = "Téléphone";
            this.TClientEnreg.Columns[6].HeaderText = "Email";
            this.TClientEnreg.Columns[1].Width = 200;
            this.TClientEnreg.Columns[2].Width = 200;
            this.TClientEnreg.Columns[0].ReadOnly = true;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        public void numClient()
        {
            int compteur = 0;
            int dat = System.DateTime.Now.Year - 2000;
            //string dates = dat;
            int d = System.DateTime.Now.Year;
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from client";
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
                this.numero.Text = dat.ToString() + "CL00" + compteur;
            }
            else if (compteur > 9)
            {
                this.numero.Text = dat.ToString() + "CL0" + compteur;
            }
            else if (compteur == 0)
            {
                this.numero.Text = dat.ToString() + "CL001" + compteur;
            }
        }

        public void BEnregClient_Executed(object sender, EventArgs e)
        {
            client d = new client();
            const string message = "Voulez-vous vraiment enregister ?";
            const string caption = "Confirmation";
            const string messages = "Enregistrement éffectué.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                d.SetNum(this.numero.Text);
                d.SetNom(this.nomClient.Text);
                d.SetPrenom(this.prenomClient.Text);
                d.SetAdresse(this.adresseClient.Text);
                d.SetTelephone(double.Parse(this.telClient.Text));
                d.SetEmail(this.emailClient.Text);
                d.SetType(this.typeClient.Text);
                d.SetQuartier(this.quartier.Text);
                int i =d.AjouterClient(d);
                if (i == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiser();
                    numClient();
                }
                
            }
            else if (result == DialogResult.No)
            {
                initialiser();
            }
        }

        public void initialiser()
        {
            //this.numero.Text = "";
            this.nomClient.Text = "";
            this.numero.Text = "";
            this.prenomClient.Text = "";
            this.adresseClient.Text = "";
            this.telClient.Text = "";
            this.emailClient.Text = "";
            this.typeClient.Text = "";
            this.quartier.Text = "";
            chargerTableau();
        }

        public void BAnnuler_Executed(object sender, EventArgs e)
        {
            initialiser();
            //this.Close();
        }

        private void Rech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("nom_clients LIKE '%{0}%'", this.Rech.Text);
            this.TClientEnreg.DataSource = dv;
        }

    }
}
