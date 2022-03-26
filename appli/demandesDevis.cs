using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace appli
{
    class demandesDevis
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

        public int enregArticleDevis(demandesDevis a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            reference = a.GetReference();
            numero = a.GetNumero();
            quantite = a.GetQuantite();
            date = a.GetDate();
            string query = "INSERT INTO article_choisi(reference_demande,numero,quantite_demande) VALUES('" + reference + "', '" + numero + "','" + quantite + "')";
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

        public int enregDevis(demandesDevis a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            reference = a.GetReference();
            numero = a.GetNumero();
            quantite = a.GetQuantite();
            date = a.GetDate();
            fournisseur = a.GetFournisseur();
            string query = "INSERT INTO demande_devis(num_devis,date,fournisseur) VALUES('" + numero + "','" + date+ "','"+ fournisseur +"')";
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

        public int enregCommande(demandesDevis a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            reference = a.GetReference();
            numero = a.GetNumero();
            quantite = a.GetQuantite();
            date = a.GetDate();
            fournisseur = a.GetFournisseur();
            statut = "En cours";
            string query = "INSERT INTO commande(numero_commande,date_commande,fournisseur,statut) VALUES('" + numero + "','" + date + "','"+fournisseur+"','"+statut+"')";
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

        public int enregArticleCommande(demandesDevis a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            reference = a.GetReference();
            numero = a.GetNumero();
            quantite = a.GetQuantite();
            date = a.GetDate();
            quantiteCommande = a.GetQuantiteCommande();
            string query = "INSERT INTO article_commande(reference_commande,numero_commande,quantite_demande,quantite_commande) VALUES('" + reference + "', '" + numero + "','" + quantite + "','"+quantiteCommande+"')";
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
    }
}
