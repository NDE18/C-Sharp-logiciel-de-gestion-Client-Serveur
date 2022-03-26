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
    public partial class SortieFabrication : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da = new MySqlDataAdapter();

        public SortieFabrication()
        {
            InitializeComponent();

            chargerNumFabrication();
            chargerNumEmploye();

            this.BEnregSortie.Click += new System.EventHandler(this.BEnregSortie_Executed);
            this.BAnnulerSortie.Click += new System.EventHandler(this.BAnnulerSortie_Executed);
        }

        public void BAnnulerSortie_Executed(object sender, EventArgs e)
        {
            initialiser();
        }

        public void BEnregSortie_Executed(object sender, EventArgs e)
        {
            sortie s = new sortie();
            QteArticlePrestation q = new QteArticlePrestation();
            const string message = "Voulez-vous enregister\n cette demande ?";
            const string caption = "Confirmation";
            const string messages = "Enregistrement éffectué.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (this.numEmploye.Text == "")
                {
                    MessageBox.Show("Warning\n Veillez selectionner l'employé qui retire l'(les) article(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    q.SetNumPrest(this.numFabrication.Text);
                    s.SetNumero(this.numFabrication.Text);
                    s.SetNumEmp(this.numEmploye.Text);
                    s.SetMotif("Fabrication numero " + numFabrication.Text);
                    s.SetDate(System.DateTime.Now.ToString());

                    int test = 0;
                    for (int j = 0; j < this.articleDemande.Rows.Count - 1; j++)
                    {
                        if (double.Parse(this.articleDemande.Rows[j].Cells[6].Value.ToString()) > 0)
                        {
                            double val = double.Parse(this.articleDemande.Rows[j].Cells[6].Value.ToString()) + double.Parse(this.articleDemande.Rows[j].Cells[5].Value.ToString());
                            q.SetQte(val);
                            q.SetRef(this.articleDemande.Rows[j].Cells[0].Value.ToString());
                            s.SetQte(double.Parse(this.articleDemande.Rows[j].Cells[6].Value.ToString()));
                            s.SetRef(this.articleDemande.Rows[j].Cells[0].Value.ToString());

                            s.enregSorti(s);
                            q.modifQteUtiliser(q);
                        }
                        else if(double.Parse(this.articleDemande.Rows[j].Cells[6].Value.ToString()) < 0)
                        {
                            break;
                            test = 1;
                        }
                    }
                    if(test == 1)
                    {
                         MessageBox.Show("Error\n Valeur incorrecte \n veillez vérifier les valeurs que vous avez entrées", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initialiser();
                    }
                }
            }
        }

        public void initialiser()
        {
             //this.articleDemande.Rows.Clear();
             //da.Update(table);
             this.numEmploye.Text = "";
             this.numFabrication.Text = "";
             this.dateEnreg.Text = "";
             this.enregPar.Text = "";
        }

        public void chargerTableau(string valeur)
        {
            this.articleDemande.RowHeadersVisible = false;
            this.articleDemande.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,designation,type,quantite,qte,qte_utilise,qte_retirer FROM qteprestation INNER JOIN article ON (reference_prestation = reference) WHERE num_prestation = '"+valeur+"'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.articleDemande.DataSource = bs;
            this.articleDemande.Columns[0].HeaderText = "Référence";
            this.articleDemande.Columns[1].HeaderText = "Désignation";
            this.articleDemande.Columns[2].HeaderText = "Type";
            this.articleDemande.Columns[3].HeaderText = "Quantité en stock";
            this.articleDemande.Columns[4].HeaderText = "Quantité nécéssaire";
            this.articleDemande.Columns[5].HeaderText = "Quantité utlisée";
            //DataGridViewColumn col = new DataGridViewColumn();
            //this.articleDemande.Columns.Add(col);
            this.articleDemande.Columns[6].HeaderText = "Quantité à sortir";
            for (int i = 3; i <= 6; i++)
            {
                this.articleDemande.Columns[i].Width = 75;
            }
            for (int i = 0; i <= 5; i++)
            {
                this.articleDemande.Columns[i].ReadOnly = true;
            }
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        private void chargerNumFabrication()
        {
            this.numFabrication.Items.Clear();
            ConnexionDB c = new ConnexionDB();
            string val  = "En cours";
            string query = "Select * from fabrication Where statut_fabrication = '"+ val +"'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("num_fabrication");
                    this.numFabrication.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chargerNumEmploye()
        {
            this.numEmploye.Items.Clear();
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
                    this.numEmploye.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void chargerChamp(string valeur)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "Select date_enregistrer,nom_employe,conception from fabrication INNER JOIN employe ON (num_employe = numero_employe) WHERE num_fabrication = '" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.enregPar.Text = reader.GetString("nom_employe");
                    this.dateEnreg.Text = reader.GetString("date_enregistrer");
                    this.TDescription.Text = reader.GetString("conception");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numFabrication_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerChamp(this.numFabrication.Text);
            chargerTableau(this.numFabrication.Text);
        }
    }
}
