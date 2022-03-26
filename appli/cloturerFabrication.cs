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
    public partial class cloturerFabrication : DevComponents.DotNetBar.Office2007Form
    {
        public cloturerFabrication()
        {
            InitializeComponent();

            chargerPresta();
            chargerNumEmploye();

            this.coutTotal.Click += new System.EventHandler(this.coutTotal_Executed);
        }

        private void numPrest_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerChamp(this.numPrest.Text);
            chargerTableau(this.numPrest.Text);
        }

        public void coutTotal_Executed(object sender, EventArgs e)
        {
            double totale = 0;
            double total = 0;
            for (int i = 0; i < this.TListeArticle.Rows.Count - 1; i++)
            {
                if (double.Parse(this.TListeArticle.Rows[i].Cells[9].Value.ToString()) < 0)
                {
                    MessageBox.Show("Aucune valeur ne doit ête inférieur à 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    double prixU = double.Parse(this.TListeArticle.Rows[i].Cells[9].Value.ToString());
                    double qte = double.Parse(this.TListeArticle.Rows[i].Cells[4].Value.ToString());
                    total += (qte * prixU);
                    this.TListeArticle.Rows[i].Cells[10].Value = (qte * prixU).ToString();

                    int n = this.TArticleChoisi.Rows.Add();
                    this.TArticleChoisi.Rows[n].Cells[0].Value = this.TListeArticle.Rows[i].Cells[0].Value;
                    this.TArticleChoisi.Rows[n].Cells[1].Value = this.TListeArticle.Rows[i].Cells[1].Value;
                    this.TArticleChoisi.Rows[n].Cells[2].Value = this.TListeArticle.Rows[i].Cells[4].Value;
                    this.TArticleChoisi.Rows[n].Cells[3].Value = this.TListeArticle.Rows[i].Cells[9].Value;
                    this.TArticleChoisi.Rows[n].Cells[4].Value = this.TListeArticle.Rows[i].Cells[10].Value;
                }
            }
            total += double.Parse(this.tempsMis.Value.ToString()) * double.Parse(prixMainDoeuvre.Value.ToString());
            total = total - (double.Parse(reduction.Value.ToString()) * total) / 100;
            this.montant.Text = total.ToString() + " " + "F CFA";
        }

        public void initialiser()
        {
            this.typeClient.Text = "";
            this.nomClient.Text = "";
            this.numclient.Text = "";
            this.auteur.Text = "";
            this.dateDebut.Text = "";
            this.reduction.Text = "";
            this.appareil.Text = 0.ToString();
        }

        public void chargerChamp(string val)
        {
            initialiser();
            ConnexionDB c = new ConnexionDB();
            string query = "Select nom_client,num_client,num_employe,date_enregistrer,appareil_depannage,type_client,reduction from fabrication INNER JOIN client ON (num_client=numero_client) INNER JOIN type_client ON (type_client = nom) Where num_depannage = '" + val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.typeClient.Text = reader.GetString("type_client");
                    this.nomClient.Text = reader.GetString("nom_client");
                    this.numclient.Text = reader.GetString("num_client");
                    this.auteur.Text = reader.GetString("num_employe");
                    this.dateDebut.Text = reader.GetString("date_enregistrer");
                    this.reduction.Text = reader.GetString("reduction");
                    this.appareil.Text = reader.GetString("appareil_depannage");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chargerPresta()
        {
            this.numPrest.Items.Clear();
            string val = "En cours";
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from fabrication Where statut_fabrication = '" + val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("num_fabrication");
                    this.numPrest.Items.Add(valeur);
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
            //string val = "En cours";
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

        public void chargerTableau(string val)
        {
            this.TListeArticle.RowHeadersVisible = false;
            this.TListeArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference_prestation,designation,type,prix_revient,prix_minimal,prix_maximal,prix_recommande,qte,qte_utilise FROM qteprestation INNER JOIN article ON (reference_prestation = reference) INNER JOIN prix ON (reference = reference_prix) WHERE num_prestation = '" + val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int n = this.TListeArticle.Rows.Add();
                    this.TListeArticle.Columns[1].Name = "Désignation";
                    this.TListeArticle.Rows[n].Cells[0].Value = reader.GetString("reference_prestation");
                    this.TListeArticle.Rows[n].Cells[1].Value = reader.GetString("designation");
                    this.TListeArticle.Rows[n].Cells[2].Value = reader.GetString("type");
                    this.TListeArticle.Rows[n].Cells[3].Value = reader.GetString("qte");
                    this.TListeArticle.Rows[n].Cells[4].Value = reader.GetString("qte_utilise");
                    this.TListeArticle.Rows[n].Cells[5].Value = reader.GetString("prix_revient");
                    this.TListeArticle.Rows[n].Cells[6].Value = reader.GetString("prix_minimal");
                    this.TListeArticle.Rows[n].Cells[7].Value = reader.GetString("prix_maximal");
                    this.TListeArticle.Rows[n].Cells[8].Value = reader.GetString("prix_recommande");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < this.TListeArticle.Rows.Count - 1; i++)
            {
                double pRec = double.Parse(this.TListeArticle.Rows[i].Cells[6].Value.ToString());
                double pMin = double.Parse(this.TListeArticle.Rows[i].Cells[7].Value.ToString());
                double pMax = double.Parse(this.TListeArticle.Rows[i].Cells[8].Value.ToString());
                double pRev = double.Parse(this.TListeArticle.Rows[i].Cells[5].Value.ToString());
                this.TListeArticle.Rows[i].Cells[6].Value = pRev + (pRev * pRec) / 100;
                this.TListeArticle.Rows[i].Cells[7].Value = pRev + (pRev * pMin) / 100;
                this.TListeArticle.Rows[i].Cells[8].Value = pRev + (pRev * pMax) / 100;
            }
        }
    }
}
