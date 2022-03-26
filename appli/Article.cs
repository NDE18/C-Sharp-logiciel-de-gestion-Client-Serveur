using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;
using System.Data;
using System.Windows.Forms;

namespace appli
{
    class Article
    {
        public double GetPrixInterne()
         {
            return this._prixInterne;
        }

        public void SetPrixInterne(double montant)
        {
            this._prixInterne = montant;
        }

        public string GetReference()
        {
            return this._reference;
        }

        public void SetReference(string reference)
        {
            this._reference = reference;
        }

        public string GetDesignation()
        {
            return this._designation;
        }

        public void SetDesignation(string designation)
        {
            this._designation = designation;
        }

        public string GetTypes()
        {
            return this._type;
        }

        public void SetType(string type)
        {
            this._type = type;
        }

        public double GetPrixVente()
        {
            return this._prixVente;
        }

        public void SetPrixVente(int prix)
        {
            this._prixVente = prix;
        }

        public int GetQuantite()
        {
            return this._quantite;
        }

        public void SetQuantite(int quantite)
        {
            this._quantite = quantite;
        }

        public string GetDescription()
        {
            return this._description;
        }

        public void SetDescription(string description)
        {
            this._description = description;
        }

        public Article()
        {
            this._reference = null;
            this._designation = null;
            this._type = null;
            this._quantite = 0;
            this._prixVente = 0;
            this._prixInterne = 0;
            this._description = null;
        }

        public Article(string reference, string designation, string type, int quantite, double montant, double prix, string description)
        {
            this._reference = reference;
            this._designation = designation;
            this._type = type;
            this._quantite = quantite;
            this._prixVente = prix;
            this._description = description;
            this._prixInterne = montant;
        }
        public int enregistrerArticle(Article a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            _reference=a.GetReference();
            _designation=a.GetDesignation();
            _quantite=a.GetQuantite();
            _description=a.GetDescription();
            _type = a.GetTypes();
            string query = "INSERT INTO article(reference,designation,type,quantite,description) VALUES('"+_reference+"', '"+_designation+"', '"+_type+"', '"+_quantite+"','" +_description+"')";
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
            catch(Exception ex)
            {
                MessageBox.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }

        public int modifArticle(Article a, string r)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            _reference = a.GetReference();
            _designation = a.GetDesignation();
            _quantite = a.GetQuantite();
            _description = a.GetDescription();
            _type = a.GetTypes();
            string query = @"UPDATE article SET reference='" + _reference + "', designation='" + _designation + "', type='" + _type + "', quantite='" + _quantite + "',description='" + _description + "' WHERE (reference='" + r + "')";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            //MySqlDataReader read;
            try
            {
                c.con.Open();
                cmd.ExecuteNonQuery();
                //read.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }
        public int modifArticleStock(Article a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            _reference = a.GetReference();
            _designation = a.GetDesignation();
            _quantite = a.GetQuantite();
            _description = a.GetDescription();
            _type = a.GetTypes();
            string query = @"UPDATE article SET quantite='" + _quantite + "' WHERE (reference='" + _reference + "')";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            //MySqlDataReader read;
            try
            {
                c.con.Open();
                cmd.ExecuteNonQuery();
                //read.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }
        public int suppArticle(Article a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            _reference = a.GetReference();
            string query = "DELETE FROM article WHERE reference='" + _reference + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            try
            {
                c.con.Open();
                cmd.ExecuteNonQuery();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }
        //public void chargerTableau(string cmd)
        //{
        //    ConnexionDB c =new ConnexionDB();

        //    MySqlDataAdapter da = new MySqlDataAdapter(cmd, c.con);

        //    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);

        //    DataTable table = new DataTable();
        //    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
        //    da.Fill(table);
        //    bindingSource1.DataSource = table;
        //}

        private string _reference;
        private string _designation;
        private int _quantite;
        private string _type;
        private double _prixVente;
        private double _prixInterne;
        private string _description;
    }
}
