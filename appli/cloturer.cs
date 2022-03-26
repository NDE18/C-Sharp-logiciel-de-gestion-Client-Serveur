using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace appli
{
    class cloturer
    {
        private string num_prestation;
        private string reference;
        private string quantite;
        private string prix;
        private string produit;
        private string date;
        private string reduction;
        private string total;
        private string main;
        private string temps;

        public string GetNumPresta()
        {
            return this.num_prestation;
        }
        public void SetNumDep(string numDep)
        {
            this.num_prestation = numDep;
        }

        public string GetDate()
        {
            return this.date;
        }
        public void SetDate(string appa)
        {
            this.date = appa;
        }

        public string GetRef()
        {
            return this.reference;
        }
        public void SetRef(string dat)
        {
            this.reference = dat;
        }

        public string GetQte()
        {
            return this.quantite;
        }
        public void SetQte(string numClient)
        {
            this.quantite = numClient;
        }

        public string GetPrix()
        {
            return this.prix;
        }
        public void SetPrix(string nom)
        {
            this.prix = nom;
        }

        public string GetProduit()
        {
            return this.produit;
        }
        public void SetProduit(string diagno)
        {
            this.produit = diagno;
        }

        public string GetReduction()
        {
            return this.reduction;
        }
        public void SetReduction(string emp)
        {
            this.reduction = emp;
        }

        public string GetTotal()
        {
            return this.total;
        }
        public void SetTotal(string emp)
        {
            this.total = emp;
        }

        public string GetMain()
        {
            return this.main;
        }
        public void SetMain(string emp)
        {
            this.main = emp;
        }

        public string GetTemps()
        {
            return this.temps;
        }
        public void SetTemps(string emp)
        {
            this.temps = emp;
        }

        public int enregCloture(cloturer dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            num_prestation = GetNumPresta();
            main = GetMain();
            total = GetTotal();
            reduction = GetReduction();
            temps = GetTemps();
            date = GetDate();

            string query = "INSERT INTO prestationcloturer(num_cloturer, date_cloturer, main_cloturer, reduction_cloturer, temps_cloturer, montant_cloturer) VALUES('" + num_prestation + "', '" + date + "', '" + main + "', '" + reduction + "','" + temps + "','" + total + "')";
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

        public int enregArtCloture(cloturer dep)
        {
            int i = 1;
            ConnexionDB c = new ConnexionDB();
            //c.Connecter();
            num_prestation = GetNumPresta();
            reference = GetRef();
            quantite = GetQte();
            prix = GetPrix();
            produit = GetProduit();

            string query = "INSERT INTO articlecloturer(num_prestation, reference_cloturer, qte_cloturer, prixu_cloturer, produit_cloturer) VALUES('" + num_prestation + "', '" + reference + "', '" + quantite + "', '" + prix + "','" + produit + "')";
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
    }
}
