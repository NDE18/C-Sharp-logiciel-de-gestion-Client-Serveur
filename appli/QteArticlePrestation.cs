using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appli
{
    class QteArticlePrestation
    {
        private string num_prestation;
        private string reference;
        private double qte;

        public string GetNumPrest()
        {
            return this.num_prestation;
        }
        public void SetNumPrest(string num)
        {
            this.num_prestation = num;
        }

        public string GetRef()
        {
            return this.reference;
        }
        public void SetRef(string refe)
        {
            this.reference = refe;
        }

        public double GetQte()
        {
            return this.qte;
        }
        public void SetQte(double q)
        {
            this.qte = q;
        }

        public QteArticlePrestation()
        {
            this.qte = 0;
            this.reference = null;
            this.num_prestation = null;
        }

        public void enregPresta(QteArticlePrestation q)
        {
            ConnexionDB c = new ConnexionDB();
            qte = q.GetQte();
            reference = q.GetRef();
            num_prestation = q.GetNumPrest();


            string query = "INSERT INTO qteprestation(num_prestation,reference_prestation,qte) VALUES('" + num_prestation + "', '" + reference + "', '" + qte + "')";
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
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void suppLigne(QteArticlePrestation a)
        {
            ConnexionDB c = new ConnexionDB();
            reference = a.GetRef();
            num_prestation = a.GetNumPrest();
            string query = "DELETE FROM qtePrestation WHERE num_prestation='" + num_prestation + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            try
            {
                c.con.Open();
                cmd.ExecuteNonQuery();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void modifQte(QteArticlePrestation q)
        {
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            reference = q.GetRef();
            qte = q.GetQte();
            num_prestation = q.GetNumPrest();
            string query = @"UPDATE qteprestation SET reference_prestation='" + reference + "', num_prestation='" + num_prestation + "', qte='" + qte + "' WHERE (reference_prestation='" + reference + "' AND num_prestation='" + num_prestation + "')";
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
            }
        }

        public int modifQteUtiliser(QteArticlePrestation q)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            reference = q.GetRef();
            qte = q.GetQte();
            num_prestation = q.GetNumPrest();
            string query = @"UPDATE qteprestation SET qte_utilise='" + qte + "' WHERE (reference_prestation='" + reference + "' AND num_prestation='" + num_prestation + "')";
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

        public int supQte(QteArticlePrestation q)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            num_prestation = q.GetNumPrest();
            string query = "DELETE FROM qtePrestation WHERE num_prestation ='" + num_prestation + "'";
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
    }
}
