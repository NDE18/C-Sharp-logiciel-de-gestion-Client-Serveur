using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appli
{
    public partial class connexion : DevComponents.DotNetBar.Office2007Form
    {
        
        public connexion()
        {
            
            InitializeComponent();
            //fo.gestock.Enabled = false;
            this.connecter.Click += new System.EventHandler(this.connecter_Executed);
        }

        public void connecter_Executed(object sender, EventArgs e)
        {
            
            ConnexionDB c = new ConnexionDB();

            string query = "Select mdp from employe where type_employe = '"+ this.fonction.Text +"' and login = '"+ this.login.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mdp.Text = reader.GetString("mdp");
                }
                reader.Close();
                c.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (pwd.Text == mdp.Text)
            {
                Form1 f = new Form1();
                f.activer();
                f.gestock.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }

        private void fonction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
