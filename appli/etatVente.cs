using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace appli
{
    public partial class etatVente : DevComponents.DotNetBar.Office2007Form
    {
        MySqlDataAdapter da;
        DataTable table;
        public etatVente()
        {
            InitializeComponent();
            chargerTableau();
            
            this.affiche.Click += new System.EventHandler(this.affiche_Executed);
        }

        private void etatVente_Load(object sender, EventArgs e)
        {

        }
        private void chargerTableau()
        {
            string statut = "Validée";
            string query = "SELECT numero_fac,date_fac,facture,montant FROM ventes where statut_fac ='" + statut +"'";
            ConnexionDB c = new ConnexionDB();
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TListeVente.DataSource = bs;
            //this.TListeArticle.Columns[9].Visible = false;
            this.TListeVente.Columns[0].HeaderText = "Numéro facture";
            this.TListeVente.Columns[1].HeaderText = "Date de facturation";
            this.TListeVente.Columns[2].HeaderText = "Facture";
            this.TListeVente.Columns[3].HeaderText = "Montant en F CFA";
            this.TListeVente.Columns[0].Width = 150;
            this.TListeVente.Columns[1].Width = 305;
            this.TListeVente.Columns[2].Width = 150;
            this.TListeVente.Columns[3].Width = 300;
        }

        private void TListeVente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string val;
                this.valeur.Text = this.TListeVente.Rows[e.RowIndex].Cells[0].Value.ToString();
                ConnexionDB c = new ConnexionDB();
                string query = "SELECT chemin FROM ventes where numero_fac = '" + this.TListeVente.Rows[e.RowIndex].Cells[0].Value.ToString() +"'";
                MySqlCommand cmd = new MySqlCommand(query, c.con);
                MySqlDataReader reader;
                c.con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.valeur.Text = reader.GetString("chemin");
                }
                reader.Close();
                c.con.Close();
                System.Diagnostics.Process.Start(this.valeur.Text);
            }
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("date_fac LIKE '%{0}%'", this.TRech.Text);
            this.TListeVente.DataSource = dv;
        }

        private void affiche_Executed(Object sender, EventArgs e)
        {
            int somme = 0;
            for (int i = 0; i < this.TListeVente.Rows.Count - 1; i++)
            {
                if (this.TListeVente.Rows[i].Cells[1].Value.ToString() == System.DateTime.Now.Date.ToShortDateString().ToString())
                {
                    somme += Convert.ToInt32(this.TListeVente.Rows[i].Cells[3].Value);
                }
            }
            this.montant.Text = somme.ToString()+" F CFA";
        }
    }
}
