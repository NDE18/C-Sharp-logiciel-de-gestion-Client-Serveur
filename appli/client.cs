using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace appli
{
    class client
    {

        private string Nom;
        private string Prenom;
        private string Adresse;
        private double Telephone;
        private string Email;
        private string NumeroClient;
        private string Type;
        private string Quartier;

        public string GetQuartier()
        {
            return this.Quartier;
        }

        public void SetQuartier(string q)
        {
            this.Quartier = q;
        }

        public string GetNum()
        {
            return this.NumeroClient;
        }

        public void SetNum(string num)
        {
            this.NumeroClient = num;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public void SetEmail(string email)
        {
            this.Email = email;
        }

        public string GetNom()
        {
            return this.Nom;
        }

        public void SetNom(string nom)
        {
            this.Nom = nom;
        }

        public string GetPrenom()
        {
            return this.Prenom;
        }

        public void SetPrenom(string prenom)
        {
            this.Prenom = prenom;
        }

        public string GetAdresse()
        {
            return this.Adresse;
        }

        public void SetAdresse(string adresse)
        {
            this.Adresse = adresse;
        }

        public double GetTelephone()
        {
            return this.Telephone;
        }

        public void SetTelephone(double tel)
        {
            this.Telephone = tel;
        }

        public string GetType()
        {
            return this.Type;
        }

        public void SetType(string type)
        {
            this.Type = type;
        }

       public client() 
       {
          this.NumeroClient=null;
          this.Nom = null;
          this.Prenom = null;
          this.Adresse = null;
          this.Telephone = 0;
          this.Email = null;
       }

       public int AjouterClient(client cl)
       {
           ConnexionDB c = new ConnexionDB();
           //c.Connecter();
           int i = 1;
           NumeroClient = cl.GetNum();
           Nom = cl.GetNom();
           Prenom = cl.GetPrenom();
           Adresse = cl.GetAdresse();
           Telephone = cl.GetTelephone();
           Email = cl.GetEmail();
           Type = cl.GetType();
           Quartier = cl.GetQuartier();
           string query = "INSERT INTO client(numero_client,nom_clients,prenom_client,adresse_client,tel_client,email_client,type_client,quartier_client) VALUES('" + NumeroClient + "', '" + Nom + "', '" + Prenom + "', '" + Adresse + "','" + Telephone + "','" + Email + "','" + Type + "','"+ Quartier +"')";
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
       public int SupprimerClient(client cl)
       {
           int i = 1;
           ConnexionDB c = new ConnexionDB();
           NumeroClient = cl.GetNum();
           string query = "DELETE FROM client WHERE numero_client = '" + NumeroClient + "'";
           MySqlCommand cmd = new MySqlCommand(query, c.con);
           MySqlDataReader reader;
           try
           {
               c.con.Open();
               reader = cmd.ExecuteReader();
               reader.Close();
               c.con.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
               i = 0;
           }
           return i;
       }

       public int ModifierClient(client cl)
       {
           ConnexionDB c = new ConnexionDB();
           //c.Connecter();
           int i = 1;
           NumeroClient = cl.GetNum();
           Nom = cl.GetNom();
           Prenom = cl.GetPrenom();
           Adresse = cl.GetAdresse();
           Telephone = cl.GetTelephone();
           Email = cl.GetEmail();
           Quartier = cl.GetQuartier();
           string query = @"UPDATE client SET type_client='"+ Type +"', nom_clients='" + Nom + "',prenom_client='" + Prenom + "',adresse_client='" + Adresse + "',tel_client='" + Telephone + "',email_client='" + Email + "',quartier_client='"+ Quartier+"' WHERE numero_client='" + NumeroClient + "'";
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
       //public void RetirerClient();
    }
}
