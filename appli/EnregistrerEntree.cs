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
    public partial class EnregistrerEntree : DevComponents.DotNetBar.Office2007Form
    {
        public EnregistrerEntree()
        {
            InitializeComponent();
            chargerFabrication();

            this.ChoixCommand.Executed += new System.EventHandler(this.ChoixCommand_Executed);
        }

        private void Chargement(object sender, EventArgs e)
        {
           
        }

        private void ChoixCommand_Executed(object sender, EventArgs e)
        {
          
        }
        public void chargerFabrication()
        {
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from fabrication";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;
            this.numeroFabrication.Items.Clear();
            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("num_fabrication");
                    this.numeroFabrication.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numeroFabrication_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT appareil,designation,type,quantite_fabrication,quantite_entrer FROM fabrication INNER JOIN article ON (reference = appareil) WHERE num_fabrication = '" + this.numeroFabrication.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;
            this.listeArticle.Rows.Clear();
            c.con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int n = this.listeArticle.Rows.Add();
                this.listeArticle.Rows[n].Cells[0].Value = reader.GetString("appareil");
                this.listeArticle.Rows[n].Cells[1].Value = reader.GetString("designation");
                this.listeArticle.Rows[n].Cells[2].Value = reader.GetString("type");
                this.listeArticle.Rows[n].Cells[3].Value = reader.GetString("quantite_fabrication");
                this.listeArticle.Rows[n].Cells[4].Value = reader.GetString("quantite_entrer");
            }
            reader.Close();
            c.con.Close();
        }

        private void CRechArticle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
