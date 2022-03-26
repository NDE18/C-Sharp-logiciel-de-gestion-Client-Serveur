using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace appli
{
    class formation
    {
        private string code;
        private string intitule;
        private double dure_max;
        private double dure_min;
        private string objectif;

        public string GetCode()
        {
            return this.code;
        }
        public void SetCode(string c)
        {
            this.code = c;
        }

        public string GetIntitule()
        {
            return this.intitule;
        }
        public void SetIntitule(string intit)
        {
            this.intitule = intit;
        }

        public double GetDureMin()
        {
            return this.dure_min;
        }
        public void SetDureMin(double min)
        {
            this.dure_min = min;
        }

        public double GetDureMax()
        {
            return this.dure_max;
        }

        public void SetDureMax(double max)
        {
            this.dure_max = max;
        }

        public string GetObjectif()
        {
            return this.objectif;
        }
        public void SetObjectif(string obj)
        {
            this.objectif = obj;
        }

        public int enregFormation(formation f)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            code = this.GetCode();
            intitule = this.GetIntitule();
            dure_max = this.GetDureMax();
            dure_min = this.GetDureMin();
            objectif = this.GetObjectif();

            string query = "INSERT INTO formation(code,intitule,dure_max,dure_min,objectif) VALUES('" + code + "', '" + intitule + "', '" + dure_min + "', '" + dure_max + "','" + objectif + "')";
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

        public int modifFormation(formation f, string val)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            code = this.GetCode();
            intitule = this.GetIntitule();
            dure_max = this.GetDureMax();
            dure_min = this.GetDureMin();
            objectif = this.GetObjectif();

            string query = @"UPDATE formation SET code = '" + code + "', intitule = '" + intitule + "', dure_min = '" + dure_min + "', dure_max = '" + dure_max + "', objectif = '" + objectif + "' WHERE code = '" + val + "'";
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

        public int suppFormation(formation f)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            code = this.GetCode();

            string query = "DELETE FROM formation WHERE code ='" + code + "'";
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
