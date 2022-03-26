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
    public partial class SupprimerFabrication : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public SupprimerFabrication()
        {
            InitializeComponent();
            numDepannage();

            this.BSupDepa.Click += new System.EventHandler(this.BSupDepa_Executed);
            this.BAnnulerSupDepa.Click += new System.EventHandler(this.BAnnulerSupDepa_Executed);
        }

        private void SupprimerDepannage_Load(object sender, EventArgs e)
        {

        }

       
        void remplirChamp(string valeur)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM fabrication WHERE num_fabrication='" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.dateDebutDepa.Text = reader.GetString("date_enregistrer").ToString();
                    //this.typeClient.Text = reader.GetString("designation").ToString();
                    this.CnumClient.Text = reader.GetString("num_client").ToString();
                    this.nom.Text = reader.GetString("nom_client").ToString();
                    this.employe.Text = reader.GetString("num_employe").ToString();
                    this.TDiagnostic.Text = reader.GetString("diagnostic").ToString();
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void chargerArticlechoisi(string v)
        {
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,qte FROM qteprestation WHERE num_prestation='" + v + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.articleChoisi.DataSource = bs;
            this.articleChoisi.Columns[0].HeaderText = "Référence";
            this.articleChoisi.Columns[1].HeaderText = "Quantité nécessaire";
            this.articleChoisi.Columns[0].ReadOnly = true;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        public void numDepannage()
        {

            ConnexionDB c = new ConnexionDB();
            string query = "Select num_fabrication from fabrication";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("num_fabrication");
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

        public void BSupDepa_Executed(object sender, EventArgs e)
        {
            fabrication d = new fabrication();
            QteArticlePrestation q = new QteArticlePrestation();
            //string val = null;
            string message = "Voulez-vous supprimer l'enregistrement\n\t numéro" + " " +numero.Text+ "?";
            const string caption = "Confirmation";
            const string messages = "Enregistrement supprimé.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                d.SetNumDep(this.numero.Text);
                q.SetNumPrest(this.numero.Text);
                int p = d.suppFabrication(d);
                int s = q.supQte(q);
                if (p == 1 && s == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiser();
                    numDepannage();
                }
            }
            else if (result == DialogResult.No)
            {
                initialiser();
            }
        }

        public void initialiser()
        {
            this.numero.Text = "";
            this.dateDebutDepa.Text = "";
            this.TDiagnostic.Text = "";
            this.nom.Text = "";
            this.CnumClient.Text = "";
            this.employe.Text = "";
            this.typeClient.Text = "";
            this.articleChoisi.Rows.Clear();
        }

        private void numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamp(numero.Text);
            chargerArticlechoisi(numero.Text);
        }

        public void BAnnulerSupDepa_Executed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
