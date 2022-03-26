using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace appli
{
    class vente
    {
        private string numero;
        private string numclient;
        private string numemploye;
        private string datevente;
        private string nomclient;
        private string reference;
        private double prixU;
        private double prixT;
        private double quantite;
        private string path;
        private string facture;
        private double montant;
        private double reduction;

        public double GetQte()
        {
            return this.quantite;
        }
        public void SetQte(double qte)
        {
            this.quantite = qte;
        }
        public double GetPrixT()
        {
            return prixT;
        }
        public void SetPrixT(double p)
        {
            this.prixT = p;
        }

        public double GetPrixU()
        {
            return prixU;
        }
        public void SetPrixU(double p)
        {
            this.prixU = p;
        }

        public string GetRef()
        {
            return this.reference;
        }
        public void SetRef(string refe)
        {
            this.reference = refe;
        }
        public string GetNumero()
        {
            return this.numero;
        }
        public void SetNumero(string num)
        {
            this.numero = num;
        }

        public string GetNumclient()
        {
            return this.numclient;
        }
        public void SetNumclient(string num)
        {
            this.numclient = num;
        }

        public string GetNumemploye()
        {
            return this.numemploye;
        }
        public void SetNumeroemploye(string num)
        {
            this.numemploye = num;
        }

        public string GetDatevente()
        {
            return datevente;
        }
        public void SetDatevente(string dat)
        {
            this.datevente = dat;
        }

        public string GetNomClient()
        {
            return this.nomclient;
        }
        public void SetNomClient(string nom)
        {
            this.nomclient = nom;
        }

        public string GetPath()
        {
            return this.path;
        }
        public void SetPath(string p)
        {
            this.path = p;
        }

        public string GetFacture()
        {
            return this.facture;
        }
        public void SetFacture(string f)
        {
            this.facture = f;
        }

        public double GetMontant()
        {
            return this.montant;
        }
        public void SetMontant(double f)
        {
            this.montant = f;
        }

        public double GetReduction()
        {
            return this.reduction;
        }
        public void SetReduction(double f)
        {
            this.reduction = f;
        }

        public void enregVente(vente v)
        {
            ConnexionDB c = new ConnexionDB();
            numero = v.GetNumero();
            numclient = v.GetNumclient();
            numemploye = v.GetNumemploye();
            datevente = v.GetDatevente();
            nomclient = v.GetNomClient();
            reference = v.GetRef();
            prixU = v.GetPrixU();
            prixT = v.GetPrixT();
            quantite = v.GetQte();
            string statut = "Non validée";

            string query = "INSERT INTO vente (numero_vente, numclient_vente, num_employe, date_vente, prixU, prixT, qte_vente, reference_vente, statut_vente) VALUES ('" + numero + "','" + numclient + "', '" + numemploye + "', '" + datevente + "', '" + prixU + "', '" + prixT + "', '" + quantite + "', '" + reference + "', '" + statut + "')";
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

        public void enregVentes(vente v)
        {
            ConnexionDB c = new ConnexionDB();
            numero = v.GetNumero();
            datevente = v.GetDatevente();
            reduction = v.GetReduction();
            string statut = "Non validée";
            string query = "INSERT INTO ventes (numero_fac, date_fac, statut_fac, reduction) VALUES ('" + numero + "', '" + datevente + "', '" + statut + "', '" + reduction + "')";
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

        public void enregFactureVente(vente v)
        {
            ConnexionDB c = new ConnexionDB();
            numero = v.GetNumero();
            path = v.GetPath();
            facture = v.GetFacture();
            string query = @"UPDATE ventes SET facture = '" + facture +"', chemin = '" + path + "' where numero_fac = '" + numero + "'";
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

        public void MajStatutFacture(vente v)
        {
            ConnexionDB c = new ConnexionDB();
            numero = v.GetNumero();
            montant = v.GetMontant();
            string statut = "Validée";
            string query = @"UPDATE ventes SET statut_fac = '" + statut + "', montant = '" + montant +"' where numero_fac = '" + numero + "'";
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

        public void MajStatutVente(vente v)
        {
            ConnexionDB c = new ConnexionDB();
            numero = v.GetNumero();
            string statut = "Validée";
            string query = @"UPDATE vente SET statut_vente = '" + statut + "' where numero_vente = '" + numero + "'";
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
