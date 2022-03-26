using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appli
{
    class enseignant
    {
        private string Nom;
        private string Prenom;
        private string Adresse;
        private double Telephone;
        private string Email;
        private string Numero;
        private string Profession;
        private double cni;

        public string GetNum()
        {
            return this.Numero;
        }

        public void SetNum(string num)
        {
            this.Numero = num;
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

        public string GetProfession()
        {
            return this.Profession;
        }

        public void SetProfession(string prof)
        {
            this.Profession=prof;
        }

        public double GetCni()
        {
            return this.cni;
        }

        public void SetCni(double Cni)
        {
            this.cni = Cni;
        }

       public enseignant() 
       {
          this.Numero=null;
          this.Nom = null;
          this.Prenom = null;
          this.Adresse = null;
          this.Telephone = 0;
          this.Email = null;
          this.Profession = null;
          this.cni = 0;
       }

       public int enregEnseignant(enseignant ens)
       {
           ConnexionDB c = new ConnexionDB();
           //c.Connecter();
           int i = 1;
           Numero = ens.GetNum();
           Nom = ens.GetNom();
           Prenom = ens.GetPrenom();
           Adresse = ens.GetAdresse();
           Telephone = ens.GetTelephone();
           Email = ens.GetEmail();
           Profession = ens.GetProfession();
           cni = ens.GetCni();

           string query = "INSERT INTO enseignant(numero,nom,prenom,adresse,telephone,email,profession,cni) VALUES('" + Numero + "', '" + Nom + "', '" + Prenom + "', '" + Adresse + "','" + Telephone + "','" + Email + "','" + Profession + "','" + cni + "')";
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
       public int suppEnseignant(enseignant ens)
       {
           int i = 1;
           ConnexionDB c = new ConnexionDB();
           Numero = ens.GetNum();
           string query = "DELETE FROM enseignant WHERE numero = '" + Numero + "'";
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

       public int modifEnseignant(enseignant ens)
       {
           ConnexionDB c = new ConnexionDB();
           //c.Connecter();
           int i = 1;
           Numero = ens.GetNum();
           Nom = ens.GetNom();
           Prenom = ens.GetPrenom();
           Adresse = ens.GetAdresse();
           Telephone = ens.GetTelephone();
           Email = ens.GetEmail();
           Profession = ens.GetProfession();
           cni = ens.GetCni();

           string query = @"UPDATE enseignant SET profession='"+ Profession +"', nom='" + Nom + "',prenom='" + Prenom + "',adresse='" + Adresse + "',telephone='" + Telephone + "',email='" + Email + "',cni='" + cni + "' WHERE numero='" + Numero + "'";
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
