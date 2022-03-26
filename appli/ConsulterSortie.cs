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
    public partial class ConsulterSortie : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table ;
        MySqlDataAdapter da= new MySqlDataAdapter();

        public ConsulterSortie()
        {
            InitializeComponent();

            chargerTableau();

            this.TResponsable.Visible = false;
            this.TMotif.Visible = false;
            this.TRech.Visible = true;
            this.rechClient.Visible = false;
        }

        private void CRechArticle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void chargerTableau()
        {
            this.TListeArticle.Rows.Clear();
            ConnexionDB c = new ConnexionDB();
            string statut = "Non validé";
            string query = "SELECT numero_sortie,reference_sortie,designation,type,quantite_sortie,date_sortie,motif,nom_employe,nom_destinataire,prenom_employe FROM sortie INNER JOIN article ON (reference_sortie = reference) INNER JOIN employe ON (responsable=numero_employe) where statut_sortie !='"+statut+
            "'ORDER BY date_sortie DESC";
            MySqlCommand cmd = new MySqlCommand(query, c.con);

            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TListeArticle.DataSource = bs;
            this.TListeArticle.Columns[0].HeaderText = "Numéro sortie";
            this.TListeArticle.Columns[1].HeaderText = "Référence";
            this.TListeArticle.Columns[2].HeaderText = "Désignation";
            this.TListeArticle.Columns[3].HeaderText = "Type";
            this.TListeArticle.Columns[4].HeaderText = "Quantité sortie";
            this.TListeArticle.Columns[5].HeaderText = "Date de sortie";
            this.TListeArticle.Columns[6].HeaderText = "Motif";
            this.TListeArticle.Columns[7].HeaderText = "Sortie par";
            this.TListeArticle.Columns[8].HeaderText = "Nom du client";
            this.TListeArticle.Columns[6].Width = 300;
            this.TListeArticle.Columns[5].Width = 150;
            this.TListeArticle.Columns[9].Visible = false;
        }

        private void typeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.typeRech.Text == "Référence")
            {
                this.TRech.Visible = true;
                this.TResponsable.Visible = false;
                this.TMotif.Visible = false;
                this.rechClient.Visible = false;
            }
            else if (this.typeRech.Text == "Motif")
            {
                this.TRech.Visible = false;
                this.TResponsable.Visible = false;
                this.rechClient.Visible = false;
                this.TMotif.Visible = true;
                this.TMotif.Location = new Point(510, 21);
            }
            else if (this.typeRech.Text == "Client")
            {
                this.TRech.Visible = false;
                this.TResponsable.Visible = false;
                this.TMotif.Visible = false;
                this.rechClient.Visible = true;
                this.rechClient.Location = new Point(510, 21);
            }
            else if (this.typeRech.Text == "Responsable")
            {
                this.TRech.Visible = false;
                this.TResponsable.Visible = true;
                this.TMotif.Visible = false;
                this.rechClient.Visible = false;
                this.TResponsable.Location = new Point(510, 21);
            }
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("reference_sortie LIKE '%{0}%'", this.TRech.Text);
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
        public void afficheT(object sender, EventArgs e)
        {
            chargerTableau();
        }

        private void rechClient_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("nom_destinataire LIKE '%{0}%'", this.rechClient.Text);
            this.TListeArticle.DataSource = dv;
        }
    }
}
