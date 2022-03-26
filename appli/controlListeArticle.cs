using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appli
{
    public partial class controlListeArticle : DevComponents.DotNetBar.Controls.SlidePanel
    {
        public controlListeArticle()
        {
            InitializeComponent();
            chargerTableau();
        }

        DataTable table;

        public void chargerTableau()
        {
            this.TListeArticle.RowHeadersVisible = false;
            this.TListeArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,designation,type,quantite,description,prix_revient,prix_recommande,prix_minimal,prix_maximal FROM article AS a,prix AS p WHERE a.reference=p.reference_prix";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TListeArticle.DataSource = bs;
            this.TListeArticle.Columns[0].HeaderText = "Référence";
            this.TListeArticle.Columns[1].HeaderText = "Désignation";
            this.TListeArticle.Columns[2].HeaderText = "Type";
            this.TListeArticle.Columns[3].HeaderText = "Quantité en stock";
            this.TListeArticle.Columns[4].HeaderText = "Description";
            this.TListeArticle.Columns[4].Width = 200;
            this.TListeArticle.Columns[5].HeaderText = "Prix de revient";
            this.TListeArticle.Columns[6].HeaderText = "Prix recommandé";
            this.TListeArticle.Columns[7].HeaderText = "Prix minimal";
            this.TListeArticle.Columns[8].HeaderText = "Prix maximal";
            da.Update(table);
            for (int i = 0; i < this.TListeArticle.Rows.Count - 1; i++)
            {
                double pRec = double.Parse(this.TListeArticle.Rows[i].Cells[6].Value.ToString());
                double pMin = double.Parse(this.TListeArticle.Rows[i].Cells[7].Value.ToString());
                double pMax = double.Parse(this.TListeArticle.Rows[i].Cells[8].Value.ToString());
                double pRev = double.Parse(this.TListeArticle.Rows[i].Cells[5].Value.ToString());
                this.TListeArticle.Rows[i].Cells[6].Value = pRev + (pRev * pRec) / 100;
                this.TListeArticle.Rows[i].Cells[7].Value = pRev + (pRev * pMin) / 100;
                this.TListeArticle.Rows[i].Cells[8].Value = pRev + (pRev * pMax) / 100;
            }
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("reference LIKE '%{0}%'", this.TRech.Text);
            this.TListeArticle.DataSource = dv;
        }

        private void TListeArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detailArticle detail = new detailArticle();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TListeArticle.Rows[e.RowIndex];
                detailArticle c = new detailArticle();
                listeArticle l = new listeArticle();
                this.SlideOutButtonVisible = false;
                //this.ShowModalPanel(c, DevComponents.DotNetBar.Controls.eSlideSide.Right);
                c.RefArticle.Text = row.Cells[0].Value.ToString();
                c.DesignArticle.Text = row.Cells[1].Value.ToString();
                c.typeArticle.Text = row.Cells[2].Value.ToString();
                c.QteArticle.Text = row.Cells[3].Value.ToString();
                c.TDescriptionSommaire.Text = row.Cells[4].Value.ToString();
                c.PMinArticle.Text = row.Cells[7].Value.ToString();
                c.PMaxArticle.Text = row.Cells[8].Value.ToString();
                c.PRecomArticle.Text = row.Cells[6].Value.ToString();
                c.PRevienArticle.Text = row.Cells[5].Value.ToString();
                c.Location = new Point(0, 0);
                this.Controls.Add(c);
                c.retourChoix.Visible =false;
                c.BAnnuler.Visible = true;
                c.retourChoix.Location = new Point(277, 439);
                c.prixRec.Text = "Prix recommandé:";
                c.prixMin.Text = "Prix minimal:";
                c.prixMax.Text = "Prix maximal:";
                c.BringToFront();
                //this.Visible = false;
                //this.SendToBack();
                //c.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
                
            }
        }
    }
}
