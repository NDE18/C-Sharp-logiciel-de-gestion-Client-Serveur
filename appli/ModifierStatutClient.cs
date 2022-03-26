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
    public partial class ModifierStatutClient : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public ModifierStatutClient()
        {
            InitializeComponent();

            chargerTableau();
            chargerNumClient();
            chargerTypeClient();

            this.BModClient.Click += new System.EventHandler(this.BModClient_Executed);
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Executed);
        }

        private void ModifierStatutClient_Load(object sender, EventArgs e)
        {

        }

        private void numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamp(this.numero.Text);
        }

        void remplirChamp(string val)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM client WHERE numero_client ='" + val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.nomClient.Text = reader.GetString("nom_clients").ToString();
                    this.prenomClient.Text = reader.GetString("prenom_client").ToString();
                    this.adresseClient.Text = reader.GetString("adresse_client").ToString();
                    this.telClient.Text = reader.GetString("tel_client").ToString();
                    this.emailClient.Text = reader.GetString("email_client").ToString();
                    this.type.Text = reader.GetString("type_client").ToString();
                    this.quartier.Text = reader.GetString("quartier_client").ToString();
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

        public void BModClient_Executed(object sender, EventArgs e)
        {
            client d = new client();
            string message = "Voulez-vous modifier le type \n du client numero" + " " + numero.Text + "?";
            const string caption = "Confirmation";
            const string messages = "Modification enregistrée.";
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
                d.SetType(this.type.Text);
                int i = d.ModifierClient(d);
                if (i == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                initialiser();
            }
            else if (result == DialogResult.No)
            {
                initialiser();
            }
        }

        public void BAnnuler_Executed(object sender, EventArgs e)
        {
            initialiser();
        }

        public void initialiser()
        {
            this.numero.Text = "";
            this.nomClient.Text = "";
            this.prenomClient.Text = "";
            this.adresseClient.Text = "";
            this.telClient.Text = "";
            this.type.Text = "";
            this.emailClient.Text = "";
            this.quartier.Text = "";
            chargerTableau();
        }

        private void Rech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("nom_clients LIKE '%{0}%'", this.Rech.Text);
            this.TClientEnreg.DataSource = dv;
        }

        private void chargerNumClient()
        {
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
                    string valeur = reader.GetString("numero_client");
                    this.numero.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chargerTypeClient()
        {
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from type_client";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("nom");
                    this.type.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TClientEnreg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TClientEnreg.Rows[e.RowIndex];
                this.nomClient.Text = row.Cells[1].Value.ToString();
                this.prenomClient.Text = row.Cells[2].Value.ToString();
                this.adresseClient.Text = row.Cells[4].Value.ToString();
                this.telClient.Text = row.Cells[5].Value.ToString();
                this.emailClient.Text = row.Cells[6].Value.ToString();
                this.type.Text = row.Cells[3].Value.ToString();
                this.numero.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
