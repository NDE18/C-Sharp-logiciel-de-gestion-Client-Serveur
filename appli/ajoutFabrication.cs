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
    public partial class ajoutFabrication : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table; 
        public ajoutFabrication()
        {
            InitializeComponent();
            chargerTableau();
            numDepannage();
            chargerAppareil();

            this.BEnregDepa.Click += new System.EventHandler(BEnregDepa_Executed);
            this.BAnnulerDepa.Click += new System.EventHandler(BAnnulerDepa_Executed);
        }

        public int tester()
        {
            int t = 0;
            for (int i = 0; i < articleChoisi.Rows.Count - 1; i++)
            {
                if (double.Parse(articleChoisi.Rows[i].Cells[2].Value.ToString()) < 0)
                {
                    MessageBox.Show("Quantité nécéssaire de l'article '" + articleChoisi.Rows[i].Cells[1].Value.ToString() + "'\n est incorrecte", " Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t = 1;
                    break;
                }
            }
            return t;
        }

        public void BAnnulerDepa_Executed(object sender, EventArgs e)
        {
            initialiser();
        }
        public void initialiser()
        {
            this.numero.Text = "";
            this.dateDebutDepa.Text = "";
            this.TDiagnostic.Text = "";
            this.qteAfabriquer.Value = 0;
            this.articleChoisi.Rows.Clear();
            this.appareil.Text = "";
        }

        public void BEnregDepa_Executed(object sender, EventArgs e)
        {
            fabrication d = new fabrication();
            QteArticlePrestation q = new QteArticlePrestation();
            if (this.appareil.Text == "")
            {
                MessageBox.Show("Veillez entrer le nom de l'appareil à fabriquer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                const string message = "Voulez-vous vraiment enregister ?";
                const string caption = "Confirmation";
                const string messages = "Enregistrement éffectué.";
                const string captions = "Information";
                int r = verifier();
                if (r == 0)
                {
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //int test = 0;
                        //if (this.typeClient.Text == "Professionnel")
                        //{
                        d.SetNumDep(this.numero.Text);
                        d.SetDatDep(this.dateDebutDepa.Text.ToString());
                        d.SetConcep(this.TDiagnostic.Text);

                        d.SetAppareil(this.appareil.Text);
                        for (int i = 0; i < articleChoisi.Rows.Count - 1; i++)
                        {
                            //DataGridViewRow row = this.articleChoisi.Rows[i];
                            //val = this.articleChoisi.Rows[i].Cells[2].Value.ToString();
                            q.SetQte(double.Parse(articleChoisi.Rows[i].Cells[2].Value.ToString()));
                            q.SetNumPrest(this.numero.Text);
                            q.SetRef(this.articleChoisi.Rows[i].Cells[0].Value.ToString());
                            q.enregPresta(q);
                        }
                        int p = d.enregfabrication(d);
                        if (p == 1)
                        {
                            MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            initialiser();
                            numDepannage();
                        }
                        //}
                    }
                    else if (result == DialogResult.No)
                    {
                        initialiser();
                        numDepannage();
                    }
                }
            }
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("reference LIKE '%{0}%'", this.TRech.Text);
            this.TArticle.DataSource = dv;
        }

        public void chargerTableau()
        {
            this.TArticle.RowHeadersVisible = false;
            this.TArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,designation,quantite FROM article";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TArticle.DataSource = bs;
            this.TArticle.Columns[0].HeaderText = "Référence";
            this.TArticle.Columns[1].HeaderText = "Désignation";
            this.TArticle.Columns[2].HeaderText = "Quantité en stock";
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }
        public void numDepannage()
        {
            int compteur = 0;
            int dat = System.DateTime.Now.Year - 2000;
            //string dates = dat;
            int d = System.DateTime.Now.Year;
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from fabrication";
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
                this.numero.Text = dat.ToString() + "FAB00" + compteur;
            }
            else if (compteur > 9)
            {
                this.numero.Text = dat.ToString() + "FAB0" + compteur;
            }
            else if (compteur == 0)
            {
                this.numero.Text = dat.ToString() + "FAB001" + compteur;
            }
        }

        private void TArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int test = 0;
                DataGridViewRow row = this.TArticle.Rows[e.RowIndex];
                for (int i = 0; i <= articleChoisi.Rows.Count - 1; i++)
                {
                    if (row.Cells["reference"].Value == this.articleChoisi.Rows[i].Cells[0].Value)
                    {
                        test = 1;
                        break;
                    }
                }
                if (test != 1)
                {
                    int n = this.articleChoisi.Rows.Add();
                    this.articleChoisi.Rows[n].Cells[0].Value = row.Cells["reference"].Value.ToString();
                    this.articleChoisi.Rows[n].Cells[1].Value = row.Cells["designation"].Value.ToString();
                    //TArticle.Rows.Remove(row);
                }
                else
                {
                    MessageBox.Show("Cette article a déjà été selectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int verifier()
        {
            int t = 0;
            for (int i = 0; i < articleChoisi.Rows.Count - 1; i++)
            {
                if (double.Parse(articleChoisi.Rows[i].Cells[2].Value.ToString()) < 0)
                {
                    MessageBox.Show("Quantité nécéssaire de l'article '" + articleChoisi.Rows[i].Cells[1].Value.ToString() + "'\n est incorrecte", " Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t = 1;
                    break;
                }
            }
            return t;
        }

        private void articleChoisi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            const string message = "Cet article va être supprimer de la liste.\n Voulez-vous continuer?";
            const string caption = "Confirmer suppression";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = this.articleChoisi.Rows[e.RowIndex];
                this.articleChoisi.Rows.Remove(row);
            }
        }
        public void chargerAppareil()
        {
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from article";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;
            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("reference");
                    this.appareil.Items.Add(valeur);
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
