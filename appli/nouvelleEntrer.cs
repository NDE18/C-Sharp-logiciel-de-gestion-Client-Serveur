using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace appli
{
    class nouvelleEntrer
    {
        private string reference;
        private string numero;
        private double quantite;
        private string date;
        private string statut;
        private string fournisseur;
        private double quantiteCommande;

        public string GetReference()
        {
            return this.reference;
        }

        public void SetReference(string reference)
        {
            this.reference = reference;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public void SetNumero(string num)
        {
            this.numero = num;
        }

        public string GetDate()
        {
            return this.date;
        }

        public void SetDate(string dat)
        {
            this.date = dat;
        }

        public double GetQuantite()
        {
            return this.quantite;
        }

        public void SetQuantite(double q)
        {
            this.quantite = q;
        }

        public string GetStatut()
        {
            return this.statut;
        }
        public void SetStatut(string s)
        {
            this.statut = s;
        }

        public string GetFournisseur()
        {
            return fournisseur;
        }
        public void SetFournisseur(string f)
        {
            this.fournisseur = f;
        }

        public double GetQuantiteCommande()
        {
            return quantiteCommande;
        }
        public void SetQuantiteCommande(double q)
        {
            this.quantiteCommande = q;
        }

        public int MAJstock(nouvelleEntrer a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            reference = a.GetReference();
            //numero = a.GetNumero();
            int q = lireQuantiteStock(reference);
            quantite = a.GetQuantite() + q;
            //date = a.GetDate();
            //fournisseur = a.GetFournisseur();
            string query = @"UPDATE article SET quantite='" + quantite + "'where reference = '" + reference + "' ";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader read;
            try
            {
                c.con.Open();
                read = cmd.ExecuteReader();
                read.Close();
                c.con.Close();
                //MessageBoxEx.Show(message,caption,ok,i
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }

        public int MAJQteLivre(nouvelleEntrer a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            reference = a.GetReference();
            numero = a.GetNumero();
            //int q = lireQuantiteStock(reference);
            quantite = a.GetQuantite();
            //date = a.GetDate();
            //fournisseur = a.GetFournisseur();
            string query = @"UPDATE article_commande SET quantite_livraison='" + quantite + "'where numero_commande = '"+numero+"' and reference_commande = '" + reference + "' ";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader read;
            try
            {
                c.con.Open();
                read = cmd.ExecuteReader();
                read.Close();
                c.con.Close();
                //MessageBoxEx.Show(message,caption,ok,i
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }

        public int MAJcommande(nouvelleEntrer a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            reference = a.GetReference();
            numero = a.GetNumero();
            statut = a.GetStatut();
            //date = a.GetDate();
            //fournisseur = a.GetFournisseur();
            string query = @"UPDATE commande SET statut='" + statut + "'where numero_commande = '" + numero + "' ";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader read;
            try
            {
                c.con.Open();
                read = cmd.ExecuteReader();
                read.Close();
                c.con.Close();
                //MessageBoxEx.Show(message,caption,ok,i
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }

        int lireQuantiteStock(string valeur)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM article WHERE reference='" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;
            int q=0;
            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    q = reader.GetInt32("quantite");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return q;
        }
    }
}
