using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;


namespace appli
{
    class ConnexionDB
    {
        public MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;database=gigatronique");
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter da = new MySqlDataAdapter();
        public DataSet ds = new DataSet();
        //con.ConnectionString = "data source=localhost; port=3306; username=root; password=root ";
        //public void Connecter()
        //{
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        try
        //        {
        //            con.ConnectionString = "data source=localhost; port=3306; username=root; password=root ";
        //            con.Open();
        //            MessageBoxEx.Show("Connexion établie", "Error Detected in Input");
                    
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBoxEx message = new MessageBoxEx();
        //            MessageBoxEx.Show("connexion fermée");
        //        }
        //    }
        //}
        public void deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

       /* public SqlDataReader lireDB(string req)
        {
            return;
        }*/
    }
}
