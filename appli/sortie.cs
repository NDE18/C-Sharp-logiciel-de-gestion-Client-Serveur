using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace appli
{
    class sortie
    {
        private string numero;
        private string reference;
        private string num_employe;
        private string motif;
        private double quantite;
        private string dates;
        private string nomClient;

        public string GetNomClient()
        {
            return this.nomClient;
        }

        public void SetNomClient(string nom)
        {
            this.nomClient = nom;
        }

        public string GetNumero()
        {
            return this.numero;
        }
        public void SetNumero(string num)
        {
            this.numero = num;
        }

        public string GetRef()
        {
            return this.reference;
        }
        public void SetRef(string refe)
        {
            this.reference = refe;
        }

        public string GetMotif()
        {
            return this.motif;
        }
        public void SetMotif(string mot)
        {
            this.motif = mot;
        }

        public string GetNumEmp()
        {
            return this.num_employe;
        }
        public void SetNumEmp(string num)
        {
            this.num_employe = num;
        }

        public string GetDate()
        {
            return this.dates;
        }
        public void SetDate(string dat)
        {
            this.dates = dat;
        }

        public double GetQte()
        {
            return this.quantite;
        }
        public void SetQte(double qte)
        {
            this.quantite = qte;
        }

        public void enregSorti(sortie q)
        {
            ConnexionDB c = new ConnexionDB();
            quantite = q.GetQte();
            reference = q.GetRef();
            numero = q.GetNumero();
            motif = q.GetMotif();
            dates = q.GetDate();
            num_employe = q.GetNumEmp();
            nomClient = q.GetNomClient();
            string num = "15EM001";
            string statut = "Non validée";
            string query = "INSERT INTO sortie (numero, reference_sortie, quantite_sortie, responsable, date_sortie, motif,nom_destinataire,statut_sortie) VALUES ('" + numero + "','" + reference + "', '" + quantite + "', '" + num + "', '" + dates + "', '" + motif + "', '" + nomClient + "', '" + statut + "')";
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

        public void MajSorti(sortie q)
        {
            ConnexionDB c = new ConnexionDB();;
            numero = q.GetNumero();
            string statut = "Validée";
            string query = @"UPDATE sortie SET statut_sortie = '" + statut + "' where numero = '" + numero + "'";
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

    }
}
