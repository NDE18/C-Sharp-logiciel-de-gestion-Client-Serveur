using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appli
{
    class fabrication
    {
        private string num_fabrication;
         private string date_fabrication;
        private string num_client;
        private string nom_client;
        private string conception;
        private string num_employe;
        private int qte;
        private string appareil;

        public string GetAppareil()
        {
            return this.appareil;
        }

        public void SetAppareil(string app)
        {
            this.appareil = app;
        }
        public string GetNumDep()
        {
            return this.num_fabrication;
        }
        public void SetNumDep(string numDep)
        {
            this.num_fabrication = numDep;
        }
        public int GetQte()
        {
            return this.qte;
        }

        public void SetQte(int q)
        {
            this.qte = q;
        }
        public string GetDatDep()
        {
            return this.date_fabrication;
        }
        public void SetDatDep(string dat)
        {
            this.date_fabrication = dat;
        }

        public string getNumClient()
        {
            return this.num_client;
        }
        public void SetNumClient(string numClient)
        {
            this.num_client = numClient;
        }

        public string GetNomClient()
        {
            return this.nom_client;
        }
        public void SetNomClient(string nom)
        {
            this.nom_client = nom;
        }

        public string GetConcep()
        {
            return this.conception;
        }
        public void SetConcep(string diagno)
        {
            this.conception = diagno;
        }

        public string GetNumEmp()
        {
            return this.num_employe;
        }
        public void SetNumEmp(string emp)
        {
            this.num_employe = emp;
        }

        public fabrication()
        {
            this.conception = null;
            this.date_fabrication = null;
            this.num_client = null;
            this.nom_client = null;
            this.num_fabrication = null;
            this.num_employe = null;
        }

        public int enregfabrication(fabrication dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            num_fabrication = dep.GetNumDep();
            date_fabrication=dep.GetDatDep();
            num_client = dep.GetNomClient();
            nom_client = dep.GetNomClient();
            conception = dep.GetConcep();
            num_employe = dep.GetNumEmp();
            appareil = dep.GetAppareil();
            qte = dep.GetQte();
            string statut = "non attribuée";

            string query = "INSERT INTO fabrication(num_fabrication, appareil, num_employe, conception, date_enregistrer,quantite_fabrication,statut_fabrication) VALUES ('" + num_fabrication + "','"+ appareil+"','" + num_employe + "','" + conception + "','" + date_fabrication + "','"+ qte +"', '"+ statut +"' )";
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
        public int modiFabrication(fabrication dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            num_fabrication = dep.GetNumDep();
            date_fabrication = dep.GetDatDep();
            num_client = dep.GetNomClient();
            nom_client = dep.GetNomClient();
            conception = dep.GetConcep();
            num_employe = dep.GetNumEmp();
            appareil = dep.GetAppareil();
            qte = dep.GetQte();

            string query = @"UPDATE fabrication SET quantite_fabrication = '" + qte + "', appareil = '" + appareil + "', num_employe = '" + num_employe + "', conception = '" + conception + "', date_enregistrer = '" + date_fabrication + "' WHERE num_fabrication = '" + num_fabrication + "'";
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

        public int modifAttFabrication(fabrication dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            num_fabrication = dep.GetNumDep();
            num_employe = dep.GetNumEmp();
            string val = "En cours";


            string query = @"UPDATE fabrication SET statut_fabrication = '" + val + "', attribuerA = '" + num_employe + "' WHERE num_fabrication = '" + num_fabrication + "'";
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

        public int sortiArtFabrication(fabrication dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            num_fabrication = dep.GetNumDep();
            date_fabrication = dep.GetDatDep();
            num_client = dep.GetNomClient();
            nom_client = dep.GetNomClient();
            conception = dep.GetConcep();
            num_employe = dep.GetNumEmp();

            string query = @"UPDATE fabrication SET num_client = '" + num_client + "', nom_client = '" + nom_client + "', num_employe = '" + num_employe + "', conception = '" + conception + "', date_enregistrer = '" + date_fabrication + "' WHERE num_fabrication = '" + num_fabrication + "'";
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

        public int suppFabrication(fabrication dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            num_fabrication = dep.GetNumDep();

            string query = "DELETE FROM fabrication WHERE num_fabrication='" + num_fabrication + "'";
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
