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
    public partial class choixArticle : DevComponents.DotNetBar.Controls.SlidePanel
    {
        public choixArticle()
        {
            InitializeComponent();
            chargerTableau();

            this.select1.Click += new System.EventHandler(this.select1_Executed);
            this.afficherDetail.Command = this.detailCommand;
            this.detailCommand.Executed += new System.EventHandler(this.afficherDetail_Executed);
            //this.selectTout.Click += new System.EventHandler(this.selectTout_Executed);
        }

        DataTable table;

        public void EditContextMenu()
        {
            bEditPopup.Displayed = false;
            bEditPopup.PopupMenu(Control.MousePosition);
        }

        public void chargerTableau()
        {
            this.TListeArticle.RowHeadersVisible = false;
            this.TListeArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            CheckBox check = new CheckBox();
            DataGridViewColumn col =new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM article AS a,prix AS p WHERE a.reference=p.reference";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TListeArticle.DataSource = bs;
            this.TListeArticle.Columns[9].Visible = false;
            this.TListeArticle.Columns[1].Name = "Désignation";
            this.TListeArticle.Columns[0].HeaderText = "Référence";
            this.TListeArticle.Columns[1].HeaderText = "Désignation";
            this.TListeArticle.Columns[2].HeaderText = "Type";
            this.TListeArticle.Columns[3].HeaderText = "Quantité en stock";
            this.TListeArticle.Columns[4].HeaderText = "Description";
            this.TListeArticle.Columns[0].Width = 125;
            this.TListeArticle.Columns[1].Width = 150;
            this.TListeArticle.Columns[2].Width = 150;
            this.TListeArticle.Columns[5].HeaderText = "Prix de revient";
            this.TListeArticle.Columns[6].HeaderText = "Prix recommandé";
            this.TListeArticle.Columns[7].HeaderText = "Prix minimal";
            this.TListeArticle.Columns[8].HeaderText = "Prix maximal";
            for (int j = 4; j <= 8; j++)
            {
                this.TListeArticle.Columns[j].Visible = false;
            }
            da.Update(table);
        }

        public void select1_Executed(object sender, EventArgs e)
        {
            int test = 0;
            int y = this.TListeArticle.CurrentCellAddress.Y;
            for(int i =0; i<=TListeArticle.Rows.Count -1; i++)
            {
                if(this.TListeArticle.Rows[i].Selected)
                {
                    DataGridViewRow row = this.TListeArticle.Rows[i];
                    for (int j = 0; j <= this.TArticleChoisi.Rows.Count - 1; j++)
                    {
                        if (row.Cells[0].Value == this.TArticleChoisi.Rows[j].Cells[0].Value)
                        {
                            test = 1;
                            break;
                        }
                    }
                    if(test == 0)
                    {
                        int n = this.TArticleChoisi.Rows.Add();
                        this.TArticleChoisi.Rows[n].Cells[0].Value = row.Cells[0].Value.ToString();
                        this.TArticleChoisi.Rows[n].Cells[1].Value = row.Cells[1].Value.ToString();
                        this.TArticleChoisi.Rows[n].Cells[2].Value = row.Cells[2].Value.ToString();
                        //this.TArticleChoisi.Rows[n].Cells[3].Value = row.Cells[3].Value.ToString();
                //        this.TRech.Text = i.ToString();
                    }
                    else if (test == 1)
                    {
                        MessageBox.Show("L'article " + row.Cells[1].Value.ToString() + "\n a déjà été sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("reference LIKE '%{0}%'", this.TRech.Text);
            this.TListeArticle.DataSource = dv;
            this.TListeArticle.Rows[1].Selected = true;
        }

        private void TArticleChoisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TListeArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TListeArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            detailArticle detail = new detailArticle();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TListeArticle.Rows[e.RowIndex];
                detailArticle c = new detailArticle();
                listeArticle l = new listeArticle();
                this.SlideOutButtonVisible = false;
            
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
                c.retourChoix.Visible = true;
                c.BAnnuler.Visible = false;
                c.prixRec.Text = "Prix recommandé(%):";
                c.prixMin.Text = "Prix minimal(%):";
                c.prixMax.Text = "Prix maximal(%):";
                c.retourChoix.Location = new Point(277, 439);
                c.BringToFront();
                
            }
        }

        private void TListeArticle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            this.EditContextMenu();
            this.TListeArticle.CurrentRow.Selected = true;
        }

        public void afficherDetail_Executed(object sender, EventArgs e)
        {
            //DataGridViewRow row = this.TListeArticle.CurrentRow;
            //detailArticle c = new detailArticle();
            //listeArticle l = new listeArticle();
            //this.SlideOutButtonVisible = false;

            //c.RefArticle.Text = row.Cells[0].Value.ToString();
            //c.DesignArticle.Text = row.Cells[1].Value.ToString();
            //c.typeArticle.Text = row.Cells[2].Value.ToString();
            //c.QteArticle.Text = row.Cells[3].Value.ToString();
            //c.TDescriptionSommaire.Text = row.Cells[4].Value.ToString();
            //c.PMinArticle.Text = row.Cells[7].Value.ToString();
            //c.PMaxArticle.Text = row.Cells[8].Value.ToString();
            //c.PRecomArticle.Text = row.Cells[6].Value.ToString();
            //c.PRevienArticle.Text = row.Cells[5].Value.ToString();
            //c.Location = new Point(0, 0);
            //this.Controls.Add(c);
            //c.retourChoix.Visible = true;
            //c.BAnnuler.Visible = false;
            //c.prixRec.Text = "Prix recommandé(%):";
            //c.prixMin.Text = "Prix minimal(%):";
            //c.prixMax.Text = "Prix maximal(%):";
            //c.retourChoix.Location = new Point(277, 439);
            //c.BringToFront();
        }
    }
}
