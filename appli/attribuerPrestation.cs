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
    public partial class attribuerPrestation : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da = new MySqlDataAdapter();

        public attribuerPrestation()
        {
            InitializeComponent();

            numDepannage();
            numEmploye();
            chargerTableau();

            this.BEnregAtt.Click += new System.EventHandler(this.BEnregAtt_Executed);
            this.BAnnulerDepa.Click += new System.EventHandler(this.BAnnulerDepa_Executed);
        }

        public void BAnnulerDepa_Executed(object sender, EventArgs e)
        {
            initialiser();
        }

        public void BEnregAtt_Executed(object sender, EventArgs e)
        {
            depannage d = new depannage();
            QteArticlePrestation q = new QteArticlePrestation();
            //string val = null;
            if (this.numero.Text == "")
            {
                MessageBox.Show("Aucune prestation n'a été sélectionnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                const string message = "Voulez-vous vraiment enregister ?";
                const string caption = "Confirmation";
                const string messages = "Enregistrement éffectué.";
                const string captions = "Information";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    d.SetNumDep(this.numero.Text);
                    d.SetNumEmp(this.numEmp.Text);

                    int p = d.modifAttDepannage(d);
                    if (p == 1)
                    {
                        MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initialiser();
                        this.numero.Items.Clear();
                        numDepannage();
                        this.chargerTableau();
                    }
                }
                else if (result == DialogResult.No)
                {
                    initialiser();
                }
            }
        }

        public void initialiser()
        {
            this.numero.Text = "";
            this.numEmp.Text = "";
            this.nomEmp.Text = "";
            this.dateDebutDepa.Text = "";
            this.enregPar.Text = "";
        }
        public void numDepannage()
        {
            string val = "non attribuée";
            ConnexionDB c = new ConnexionDB();
            string query = "Select num_depannage from depannage where statut_depannage = '"+ val +"'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("num_depannage");
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
        
        public void numEmploye()
        {

            ConnexionDB c = new ConnexionDB();
            string query = "Select * from employe";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("numero_employe");
                    this.numEmp.Items.Add(valeur);
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
            string query = "SELECT date_enregistrer, nom_employe  FROM depannage INNER JOIN employe ON (num_employe=numero_employe) WHERE num_depannage='" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.dateDebutDepa.Text = reader.GetString("date_enregistrer").ToString();
                    this.enregPar.Text = reader.GetString("nom_employe").ToString();
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
            this.TListePresta.RowHeadersVisible = false;
            this.TListePresta.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string val = "non attribuée";
            string query = "SELECT num_depannage, date_enregistrer, appareil_depannage FROM depannage where statut_depannage = '"+ val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
           
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TListePresta.DataSource = bs;
            this.TListePresta.Columns[0].HeaderText = "Numero";
            this.TListePresta.Columns[1].HeaderText = "Date d'enregistrement";
            this.TListePresta.Columns[2].HeaderText = "Article à dépanner";
            this.TListePresta.Columns[0].Width = 200;
            this.TListePresta.Columns[1].Width = 200;
            this.TListePresta.Columns[2].Width = 350;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        private void numEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM employe Where numero_employe='" + numEmp.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.nomEmp.Text = reader.GetString("nom_employe").ToString();
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT date_enregistrer, nom_employe  FROM depannage INNER JOIN employe ON (num_employe=numero_employe) WHERE num_depannage='" + this.numero.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.dateDebutDepa.Text = reader.GetString("date_enregistrer").ToString();
                    this.enregPar.Text = reader.GetString("nom_employe").ToString();
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
