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
    public partial class validerSortie : DevComponents.DotNetBar.Office2007Form
    {
        MySqlDataAdapter da;
        DataTable table;
        public validerSortie()
        {
            InitializeComponent();
            chargerTableau();
            this.fcfa.Visible = false;
            this.fcfa2.Visible = false;
            this.pourcent.Visible = false;
            this.valider.Enabled = false;
            this.valider.Click += new System.EventHandler(this.valider_Executed);
        }


        private void chargerTableau()
        {
            //this.TListeVente.Rows.Clear();
            string statut = "Non validée";
            string query = "SELECT numero_fac,date_fac,facture,reduction FROM ventes where statut_fac ='" + statut + "'";
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
            this.TListeVente.Columns[3].Visible = false;
            this.TListeVente.Columns[1].Width = 200;
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("numero_fac LIKE '%{0}%'", this.TRech.Text);
            this.TListeVente.DataSource = dv;
        }

        private void TListeVente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.valider.Enabled = true;
            
            if (e.RowIndex >= 0)
            {
                this.listeArticle.Rows.Clear();
                this.numero.Text = this.TListeVente.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.reduction.Text = this.TListeVente.Rows[e.RowIndex].Cells[3].Value.ToString();
                ConnexionDB c = new ConnexionDB();
                string query = "SELECT reference_vente,quantite,qte_vente,prixU,prixT FROM vente INNER JOIN article ON (reference_vente = reference) where numero_vente = '" + this.numero.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, c.con);
                MySqlDataReader reader;
                c.con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int n = this.listeArticle.Rows.Add();
                    this.listeArticle.Rows[n].Cells[0].Value = reader.GetString("reference_vente");
                    this.listeArticle.Rows[n].Cells[1].Value = reader.GetString("quantite");
                    this.listeArticle.Rows[n].Cells[2].Value = reader.GetString("qte_vente");
                    this.listeArticle.Rows[n].Cells[3].Value = reader.GetString("prixU");
                    this.listeArticle.Rows[n].Cells[4].Value = reader.GetString("prixT");
                }
                reader.Close();
                c.con.Close();
                //System.Diagnostics.Process.Start(this.valeur.Text);
                this.sansReduction.Text = calculer().ToString();
                double resul = calculer();
                this.montant.Text = (resul -  (resul * double.Parse(this.reduction.Text)) / 100).ToString();// +"  FCFA";
                this.fcfa.Visible = true;
                this.fcfa2.Visible = true;
                this.pourcent.Visible = true;
            }
        }

        private void TListeVente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void valider_Executed(object sender, EventArgs e)
        {
            const string message = "Voulez-vous valider\n cette facture ?";
            const string caption = "Confirmation";
            const string messages = "Validation éffectuée.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                double m = double.Parse(this.montant.Text);
                vente v = new vente();
                v.SetNumero(this.numero.Text);
                v.SetMontant(m);
                v.MajStatutFacture(v);
                sortie s = new sortie();
                s.SetNumero(this.numero.Text);
                s.MajSorti(s);
                v.MajStatutVente(v);
                charger();
                chargerTableau();
                this.listeArticle.Rows.Clear();
                this.montant.Text = "";
                this.fcfa.Visible = false;
                this.fcfa2.Visible = false;
                this.pourcent.Visible = false;
                this.reduction.Text = "";
                this.sansReduction.Text = "";
                MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.valider.Enabled = false;
                
            }
        }

        public void charger()
        {
            Article art = new Article();
            for (int i = 0; i < this.listeArticle.Rows.Count - 1; i++)
            {
               
                    int dif = Convert.ToInt32(this.listeArticle.Rows[i].Cells[1].Value) - Convert.ToInt32(this.listeArticle.Rows[i].Cells[2].Value);
                    //this.q.Text = dif.ToString();
                    art.SetQuantite(dif);
                    art.SetReference(listeArticle.Rows[i].Cells[0].Value.ToString());
                    art.modifArticleStock(art);
            }
        }

        public double calculer()
        {
            int somme = 0;
            for (int i = 0; i < this.listeArticle.Rows.Count - 1; i++)
            {

                somme += Convert.ToInt32(this.listeArticle.Rows[i].Cells[4].Value);
                
            }
            return somme;
        }

        private void labelX7_Click(object sender, EventArgs e)
        {

        }
    }
}
