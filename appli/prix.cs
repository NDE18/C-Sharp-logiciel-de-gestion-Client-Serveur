using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace appli
{
    class prix
    {
        private double _prixRevient;
        private double _prixRecommande;
        private double _prixMinimal;
        private double _prixMaximal;

        public double GetPrixRevient()
        {
            return _prixRevient;
        }
        public void SetPrixRevient(double Previent)
        {
            this._prixRevient = Previent;
        }

        public double GetPrixRecommande()
        {
            return _prixRecommande;
        }
        public void SetPrixRecommande(double Precommande)
        {
            this._prixRecommande = Precommande;
        }

        public double GetPrixMinimal()
        {
            return _prixMinimal;
        }
        public void SetPrixMinimal(double Pminimal)
        {
            this._prixMinimal = Pminimal;
        }

        public double GetPrixMaximal()
        {
            return _prixMaximal;
        }
        public void SetPrixMaximal(double Pmaximal)
        {
            this._prixMaximal = Pmaximal;
        }

        public prix()
        {
            this._prixRevient = 0;
            this._prixRecommande = 0;
            this._prixMinimal = 0;
            this._prixMaximal = 0;
        }

        public int enregPrix(prix p, Article a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();          
            _prixRevient= p.GetPrixRevient();
            _prixRecommande=p.GetPrixRecommande();
            _prixMinimal=p.GetPrixMinimal();
            _prixMinimal=p.GetPrixMaximal();
            string reference=a.GetReference();

            string query = "INSERT INTO prix(prix_revient,prix_recommande,prix_minimal,prix_maximal,reference_prix) VALUE ('" + _prixRevient + "','" + _prixRecommande + "','" + _prixMinimal + "','" + _prixMaximal + "','" + reference + "')";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;
            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }
        public int modifPrix(prix p, Article a, string r)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            _prixRevient = p.GetPrixRevient();
            _prixRecommande = p.GetPrixRecommande();
            _prixMinimal = p.GetPrixMinimal();
            _prixMaximal = p.GetPrixMaximal();
            string reference = a.GetReference();

            string query = @"UPDATE prix SET prix_revient='" + _prixRevient + "', prix_recommande='" + _prixRecommande + "',prix_minimal='" + _prixMinimal + "',prix_maximal='" + _prixMaximal + "',reference='" + reference + "' WHERE (reference='" + r + "')";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
           
            try
            {
                c.con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }
        public int suppPrix(Article a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            string reference = a.GetReference();
            string query = "DELETE FROM prix WHERE reference='" + reference + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            try
            {
                c.con.Open();
                cmd.ExecuteNonQuery();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }
    }
}
