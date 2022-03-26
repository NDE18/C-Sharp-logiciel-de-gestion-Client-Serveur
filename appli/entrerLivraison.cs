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
    public partial class entrerLivraison : DevComponents.DotNetBar.Office2007Form
    {
        MySqlDataAdapter da;
        DataTable tab;

        public entrerLivraison()
        {
            InitializeComponent();

            chargerCommande();
            this.BenregLivraison.Command = this.commandEnregLivraison;
            this.commandEnregLivraison.Executed += new EventHandler(this.enregLivraison_Executed);
        }

        private void enregLivraison_Executed(object sender, EventArgs e)
        {
             nouvelleEntrer d = new nouvelleEntrer();
                const string message = "Voulez-vous enregister\n cette demande ?";
                const string caption = "Confirmation";
                const string messages = "Enregistrement éffectué.";
                const string captions = "Information";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    d.SetNumero(this.numeroCommande.Text);
                    d.SetDate(this.dateCommande.Text);
                    //d.SetFournisseur(this.fournisseurCombo.Text);

                    int test = 0;
                    for (int j = 0; j < listeArticle.Rows.Count - 1; j++)
                    {
                        if (double.Parse(listeArticle.Rows[j].Cells[4].Value.ToString()) < 0)
                        {
                            test = 1;
                            MessageBox.Show("Erreur\n Veillez entrer la quantité à commander de l'article \'" + listeArticle.Rows[j].Cells[4].Value + "\'", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    
                    if (test == 0)
                    {
                        int p = -1;
                        int q = comparer();
                        if (q == 1)
                        {
                            d.SetStatut("Complète");
                            p = d.MAJcommande(d);
                        }
                        else
                        {
                            d.SetStatut("Incomplète");
                            p = d.MAJcommande(d);
                        }
                        for (int i = 0; i < listeArticle.Rows.Count - 1; i++)
                        {
                            d.SetQuantite(double.Parse(listeArticle.Rows[i].Cells[4].Value.ToString()));
                            d.SetReference(listeArticle.Rows[i].Cells[0].Value.ToString());
                            d.MAJQteLivre(d);
                            d.MAJstock(d);
                        }

                        if (p == 1)
                        {
                            MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chargerCommande();
                            this.numeroCommande.Text = "";
                            this.dateCommande.Text = "";
                            this.fournisseur.Text = "";
                            this.statutCommande.Text = "";
                            this.listeArticle.Rows.Clear();
                        }
                    }
                    
                }
                
        }

        public int comparer()
        {
            int tests = 1;
            for (int j = 0; j < listeArticle.Rows.Count - 1; j++)
            {
                if (double.Parse(listeArticle.Rows[j].Cells[3].Value.ToString()) != double.Parse(listeArticle.Rows[j].Cells[4].Value.ToString()))
                {
                    tests = 0;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return tests;
        }

        public void chargerCommande()
        {
            string statut1 = "En cours";
            string statut2 = "Incomplete";
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from commande where statut = '"+statut1+"' or statut = '"+statut2+"'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;
            this.numeroCommande.Items.Clear();
            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("numero_commande");
                    this.numeroCommande.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void charger(string num)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from commande where numero_commande ='" + num + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.dateCommande.Text = reader.GetString("date_commande");
                    this.fournisseur.Text = reader.GetString("fournisseur");
                    this.statutCommande.Text = reader.GetString("statut");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numeroCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            charger(this.numeroCommande.Text);
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,designation,type,quantite_commande,quantite_livraison FROM article_commande INNER JOIN article ON (reference = reference_commande) WHERE numero_commande = '" + this.numeroCommande.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;
            this.listeArticle.Rows.Clear();
            c.con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int n = this.listeArticle.Rows.Add();
                this.listeArticle.Rows[n].Cells[0].Value = reader.GetString("reference");
                this.listeArticle.Rows[n].Cells[1].Value = reader.GetString("designation");
                this.listeArticle.Rows[n].Cells[2].Value = reader.GetString("type");
                this.listeArticle.Rows[n].Cells[3].Value = reader.GetString("quantite_commande");
                this.listeArticle.Rows[n].Cells[4].Value = reader.GetString("quantite_livraison");
            }
            reader.Close();
            c.con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
