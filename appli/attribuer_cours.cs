using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace appli
{
    class attribuer_cours
    {
        private string code_formation;
        private string numero_enseignant;

        public string GetCode()
        {
            return this.code_formation;
        }
        public void SetCode(string code)
        {
            this.code_formation = code;
        }

        public string GetNumero()
        {
            return this.numero_enseignant;
        }
        public void SetNumero(string num)
        {
            this.numero_enseignant = num;
        }

        public int attribCours(attribuer_cours a)
        {
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            int i = 1;
            numero_enseignant = a.GetNumero();
            code_formation = a.GetCode();
            string dat = System.DateTime.Now.ToString();

            string query = "INSERT INTO attribuer_cours(numero_enseignant,code_formation,date_attribution) VALUES('" + numero_enseignant + "', '" + code_formation + "', '" + dat + "')";
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

        public int retirerCours(attribuer_cours a)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            numero_enseignant = a.GetNumero();
            code_formation = a.GetCode();

            string query = "DELETE FROM attribuer_cours WHERE numero_enseignant = '" + numero_enseignant + "' AND code_formation ='" + code_formation + "'";
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
    }
}
