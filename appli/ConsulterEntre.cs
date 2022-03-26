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
    public partial class ConsulterEntre : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public ConsulterEntre()
        {
            InitializeComponent();
            chargerTableau();

            this.TResponsable.Visible = false;
            this.TMotif.Visible = false;
            this.TRech.Visible = true;
        }

        public void chargerTableau()
        {
            //this.TListeArticle.Rows.Clear();
            //ConnexionDB c = new ConnexionDB();
            //string query = "SELECT numero_entree,reference_entree,designation,type,quantite_entree,date_entree,provenance,nom_employe,prenom_employe FROM entree INNER JOIN article ON (reference_sortie = reference) INNER JOIN employe ON (responsable=numero_employe) ORDER BY date_entree DESC";
            //MySqlCommand cmd = new MySqlCommand(query, c.con);

            //da.SelectCommand = cmd;

            //table = new DataTable();
            //da.Fill(table);
            //BindingSource bs = new BindingSource();
            //bs.DataSource = table;
            //this.TListeArticle.DataSource = bs;
            //this.TListeArticle.Columns[0].HeaderText = "Numéro entré";
            //this.TListeArticle.Columns[1].HeaderText = "Référence";
            //this.TListeArticle.Columns[2].HeaderText = "Désignation";
            //this.TListeArticle.Columns[3].HeaderText = "Type";
            //this.TListeArticle.Columns[4].HeaderText = "Quantité entrée";
            //this.TListeArticle.Columns[5].HeaderText = "Date de entrée";
            //this.TListeArticle.Columns[6].HeaderText = "Motif";
            //this.TListeArticle.Columns[7].HeaderText = "Provenance";
            //this.TListeArticle.Columns[6].Width = 200;
            //this.TListeArticle.Columns[5].Width = 150;
            //this.TListeArticle.Columns[8].Visible = false;
        }


        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("reference_entree LIKE '%{0}%'", this.TRech.Text);
            this.TListeArticle.DataSource = dv;
        }

        private void TMotif_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("motif LIKE '%{0}%'", this.TMotif.Text);
            this.TListeArticle.DataSource = dv;
        }

        private void TResponsable_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("nom_employe LIKE '%{0}%'", this.TResponsable.Text);
            this.TListeArticle.DataSource = dv;
        }

        private void typeRech_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.typeRech.Text == "Référence")
            {
                this.TRech.Visible = true;
                this.TResponsable.Visible = false;
                this.TMotif.Visible = false;
            }
            else if (this.typeRech.Text == "Motif")
            {
                this.TRech.Visible = false;
                this.TResponsable.Visible = false;
                this.TMotif.Visible = true;
                this.TMotif.Location = new Point(724, 23);
            }
            else if (this.typeRech.Text == "Responsable")
            {
                this.TRech.Visible = false;
                this.TResponsable.Visible = true;
                this.TMotif.Visible = false;
                this.TResponsable.Location = new Point(724, 23);
            }
        }
    }
}
