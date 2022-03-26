using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace appli
{
    class depannage
    {
        private string num_depannage;
        private string date_depannage;
        private string num_client;
        private string nom_client;
        private string diagnostic;
        private string num_employe;
        private string appareil;
        private string types;

        public string GetType()
        {
            return this.types;
        }
        public void SetType(string typ)
        {
            this.types = typ;
        }

        public string GetNumDep()
        {
            return this.num_depannage;
        }
        public void SetNumDep(string numDep)
        {
            this.num_depannage = numDep;
        }

        public string GetAppareil()
        {
            return this.appareil;
        }
        public void SetAppareil(string appa)
        {
            this.appareil = appa;
        }

        public string GetDatDep()
        {
            return this.date_depannage;
        }
        public void SetDatDep(string dat)
        {
            this.date_depannage = dat;
        }

        public string GetNumClient()
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

        public string GetDiagno()
        {
            return this.diagnostic;
        }
        public void SetDiagno(string diagno)
        {
            this.diagnostic = diagno;
        }

        public string GetNumEmp()
        {
            return this.num_employe;
        }
        public void SetNumEmp(string emp)
        {
            this.num_employe = emp;
        }

        public depannage()
        {
            this.diagnostic = null;
            this.date_depannage = null;
            this.num_client = null;
            this.nom_client = null;
            this.num_depannage = null;
            this.num_employe = null;
        }

        public int enregDepannage(depannage dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            string statut = "En cours";
            num_depannage = dep.GetNumDep();
            date_depannage=dep.GetDatDep();
            nom_client = dep.GetNomClient();
            num_client = dep.GetNumClient();
            diagnostic = dep.GetDiagno();
            num_employe = dep.GetNumEmp();
            appareil = dep.GetAppareil();
            types = dep.GetType();

            string query = "INSERT INTO depannage(num_depannage, num_client, nom_client, num_employe, diagnostic, date_enregistrer, appareil_depannage, types_client, statut_depannage) VALUES('" + num_depannage + "', '" + num_client + "', '" + nom_client + "', '" + num_employe + "','" + diagnostic + "','" + date_depannage + "','" + appareil + "','" + types + "','" + statut + "')";
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
                i = 0;
            }
            return i;
        }

        public int modifDepannage(depannage dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            num_depannage = dep.GetNumDep();
            date_depannage = dep.GetDatDep();
            num_client = dep.GetNomClient();
            nom_client = dep.GetNomClient();
            diagnostic = dep.GetDiagno();
            num_employe = dep.GetNumEmp();

            string query = @"UPDATE depannage SET num_client = '" + num_client + "', nom_client = '" + nom_client + "', num_employe = '" + num_employe + "', diagnostic = '" + diagnostic + "', date_enregistrer = '" + date_depannage + "' WHERE num_depannage = '" + num_depannage + "'";
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
                i=0;
            }
            return i;
        }

        public int modifAttDepannage(depannage dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            num_depannage = dep.GetNumDep();
            date_depannage = dep.GetDatDep();
            num_client = dep.GetNomClient();
            nom_client = dep.GetNomClient();
            diagnostic = dep.GetDiagno();
            num_employe = dep.GetNumEmp();
            string val = "En cours";
            string query = @"UPDATE depannage SET statut_depannage = '" + val+ "', attribution_depannage = '" + num_employe + "' WHERE num_depannage = '" + num_depannage + "'";
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
                i = 0;
            }
            return i;
        }

        public int modifStatutDepannage(depannage dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            num_depannage = dep.GetNumDep();
            string valeur = "Clôturé";

            string query = @"UPDATE depannage SET statut_depannage = '" + valeur + "' WHERE num_depannage = '" + num_depannage + "'";
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
                i = 0;
            }
            return i;
        }

        public int suppDepannage(depannage dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            num_depannage = dep.GetNumDep();

            string query = "DELETE FROM depannage WHERE num_depannage='" + num_depannage + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            try
            {
                c.con.Open();
                cmd.ExecuteNonQuery();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i = 0;
            }
            return i;
        }
    }
}
