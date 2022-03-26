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
    public partial class controleDemandeDevis : DevComponents.DotNetBar.Controls.SlidePanel
    {
        int compteur = 0;
        DataTable table;
        MySqlDataAdapter da;
        DataTable tab;

        public controleDemandeDevis()
        {
            InitializeComponent();
            chargerTableau();
            chargersTableau();
            numDevis();
            chargerFournisseur();

            this.BChoixArticle.Command = this.choixCommand;
            this.choixCommand.Executed += new System.EventHandler(this.choixCommand_Executed);
            this.select1.Click += new System.EventHandler(this.select1_Executed);

            this.afficherDetail.Command = this.detailCommand;
            this.detailCommand.Executed += new System.EventHandler(this.afficherDetail_Executed);

            this.annulerDevis.Command = this.annulerCommand;
            this.annulerCommand.Executed += new System.EventHandler(this.annulerDevis_Executed);

            this.enregDevis.Command = this.enregCommand;
            this.enregCommand.Executed += new System.EventHandler(this.enregDevis_Executed);
        }
        public int tester()
        {
            int t = 0;
            for (int i = 0; i < articleDevis.Rows.Count - 1; i++)
            {
                if (double.Parse(articleDevis.Rows[i].Cells[2].Value.ToString()) < 0)
                {
                    MessageBox.Show("Quantité demandée de l'article '" + articleDevis.Rows[i].Cells[1].Value.ToString() + "'\n est incorrecte", " Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t = 1;
                    break;
                }
            }
            return t;
        }

        public void enregDevis_Executed(object sender, EventArgs e)
        {
            if (double.Parse(valeur.Text) == 0)
            {
                MessageBox.Show("Vous n'avez pas choisi d'article", "Impossible d'enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int r = tester();
                if (r == 0)
                {
                    demandesDevis d = new demandesDevis();
                    const string message = "Voulez-vous enregister\n cette demande ?";
                    const string caption = "Confirmation";
                    const string messages = "Enregistrement éffectué.";
                    const string captions = "Information";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        d.SetNumero(this.numeroDevis.Text);
                        d.SetDate(this.dateEnreg.Text);
                        d.SetFournisseur(this.fournisseurCombo.Text);

                        int test = 0;
                        for (int j = 0; j < TArticleChoisi.Rows.Count - 1; j++)
                        {
                            if (double.Parse(TArticleChoisi.Rows[j].Cells[3].Value.ToString()) == 0)
                            {
                                test = 1;
                                MessageBox.Show("Erreur\n Veillez entrer la quantité de l'article \'" + TArticleChoisi.Rows[j].Cells[0].Value + "\'", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (test == 0)
                        {
                            int p = d.enregDevis(d);
                            for (int i = 0; i < TArticleChoisi.Rows.Count - 1; i++)
                            {
                                d.SetQuantite(double.Parse(TArticleChoisi.Rows[i].Cells[3].Value.ToString()));
                                d.SetReference(TArticleChoisi.Rows[i].Cells[0].Value.ToString());
                                d.enregArticleDevis(d);
                            }

                            if (p == 1)
                            {
                                MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                numDevis();
                                this.TArticleChoisi.Rows.Clear();
                            }
                        }
                    }
                }
            }
        }

        public void annulerDevis_Executed(object sender, EventArgs e)
        {
            this.choisirArticle.Visible = false;
            this.listeDevis.Visible = true;
            this.enregDevis.Visible = false;
            this.annulerDevis.Visible = false;
            this.annulerDevis.Location = new Point(844, 128);
            this.BChoixArticle.Visible = true;
            this.Taide.Visible = false;
        }

        public void choixCommand_Executed(object sender, EventArgs e)
        {
            //this.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            //choixArticle c = new choixArticle();
            //demandeDevis d = new demandeDevis();
            //d.Text = "Choix du matériel";
            //this.SlideOutButtonVisible = true;
            //this.Controls.Add(c);
            //c.BringToFront();
            this.choisirArticle.Visible =true;
            this.listeDevis.Visible = false;
            this.enregDevis.Visible = true;
            this.annulerDevis.Visible = true;
            this.annulerDevis.Location = new Point(844, 128);
            this.BChoixArticle.Visible = false;
            this.Taide.Visible = true;
            this.Taide.Location = new Point(746, 10);
        }

        private void TRechF_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("date LIKE '%{0}%'", this.TRechF.Text);
            this.listeArticleMod.DataSource = dv;
        }

        public void numDevis()
        {
            int dat = System.DateTime.Now.Year - 2000;
            //string dates = dat;
            int d = System.DateTime.Now.Year;
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from demande_devis";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    compteur = compteur + 1;
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (compteur <= 9)
            {
                this.numeroDevis.Text = dat.ToString() + "DEV00" + compteur;
            }
            else if ((compteur > 9) && (compteur < 100))
            {
                this.numeroDevis.Text = dat.ToString() + "DEV0" + compteur;
            }
            else if (compteur == 0)
            {
                this.numeroDevis.Text = dat.ToString() + "DEV001" + compteur;
            }
            else
            {
                numeroDevis.Text = dat.ToString() + "DEV" + compteur;
            }
        }
        public void chargerTableau()
        {
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM demande_devis";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.listeArticleMod.DataSource = bs;
            this.listeArticleMod.Columns[0].HeaderText = "Numéro";
            this.listeArticleMod.Columns[1].HeaderText = "Date";
            this.listeArticleMod.Columns[1].Width = 200;
            this.listeArticleMod.Columns[0].Width = 200;
            //this.listeArticleMod.Columns[0].ReadOnly = true;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        public void chargersTableau()
        {
            this.TListeArticle.RowHeadersVisible = false;
            this.TListeArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            CheckBox check = new CheckBox();
            DataGridViewColumn col = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM article AS a,prix AS p WHERE a.reference=p.reference_prix ORDER BY a.quantite ASC";
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

        private void TListeArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //detailArticle detail = new detailArticle();
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.TListeArticle.Rows[e.RowIndex];
            //    detailArticle c = new detailArticle();
            //    listeArticle l = new listeArticle();
            //    this.SlideOutButtonVisible = false;

            //    c.RefArticle.Text = row.Cells[0].Value.ToString();
            //    c.DesignArticle.Text = row.Cells[1].Value.ToString();
            //    c.typeArticle.Text = row.Cells[2].Value.ToString();
            //    c.QteArticle.Text = row.Cells[3].Value.ToString();
            //    c.TDescriptionSommaire.Text = row.Cells[4].Value.ToString();
            //    c.PMinArticle.Text = row.Cells[7].Value.ToString();
            //    c.PMaxArticle.Text = row.Cells[8].Value.ToString();
            //    c.PRecomArticle.Text = row.Cells[6].Value.ToString();
            //    c.PRevienArticle.Text = row.Cells[5].Value.ToString();
            //    c.Location = new Point(0, 0);
            //    this.Controls.Add(c);
            //    c.retourChoix.Visible = true;
            //    c.BAnnuler.Visible = false;
            //    c.prixRec.Text = "Prix recommandé(%):";
            //    c.prixMin.Text = "Prix minimal(%):";
            //    c.prixMax.Text = "Prix maximal(%):";
            //    c.retourChoix.Location = new Point(277, 439);
            //    c.BringToFront();

            //}
        }

        public void select1_Executed(object sender, EventArgs e)
        {
            int test = 0;
            this.valeur.Text = this.TArticleChoisi.Rows.Count.ToString();
            int y = this.TListeArticle.CurrentCellAddress.Y;
            for (int i = 0; i <= TListeArticle.Rows.Count - 1; i++)
            {
                if (this.TListeArticle.Rows[i].Selected)
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
                    if (test == 0)
                    {
                        int n = this.TArticleChoisi.Rows.Add();
                        this.TArticleChoisi.Rows[n].Cells[0].Value = row.Cells[0].Value.ToString();
                        this.TArticleChoisi.Rows[n].Cells[1].Value = row.Cells[1].Value.ToString();
                        this.TArticleChoisi.Rows[n].Cells[2].Value = row.Cells[2].Value.ToString();
                        this.TArticleChoisi.Rows[n].Cells[3].Value = 0;
                       // this.TArticleChoisi.Rows[n].Cells[4].Value = 0;
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

        private void TListeArticle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            this.EditContextMenu();
        }

        public void EditContextMenu()
        {
            bEditPopup.Displayed = false;
            bEditPopup.PopupMenu(Control.MousePosition);
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

        private void TArticleChoisi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TArticleChoisi.Rows[e.RowIndex];
                string message = "Voulez-vous supprimer\n l'article "+ row.Cells[0].Value.ToString() +" de la liste ?";
                const string caption = "Confirmation";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.TArticleChoisi.Rows.Remove(row);
                }
            }
        }

        private void TListeArticle_MouseHover(object sender, EventArgs e)
        {
            this.Taide.Text = "Détail d'un article\n Double-clickez pour afficher.";
        }

        private void TArticleChoisi_MouseHover(object sender, EventArgs e)
        {
            if (double.Parse(valeur.Text) == 0)
            {
                this.Taide.Text = "Double-clickez pour supprimer un article de la liste.";
            }
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            this.Taide.Text = "Selectionnez les articles sur le tableau gauche et clickez sur \'>\' puis entrer la quantité.";
        }

        private void TListeArticle_MouseLeave(object sender, EventArgs e)
        {
            this.Taide.Text = "Selectionnez les articles sur le tableau gauche et clickez sur \'>\' puis entrer la quantité.";
        }

        private void TArticleChoisi_MouseLeave(object sender, EventArgs e)
        {
            this.Taide.Text = "Selectionnez les articles sur le tableau gauche et clickez sur \'>\' puis entrer la quantité.";
        }

        private void listeArticleMod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listeArticleMod.Rows[e.RowIndex];
                ConnexionDB c = new ConnexionDB();
                string query = "SELECT reference,designation,type,quantite_demande FROM article_choisi INNER JOIN article ON (reference = reference_demande) WHERE numero = '"+ row.Cells[0].Value.ToString()+"'";
                MySqlCommand cmd = new MySqlCommand(query, c.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                tab = new DataTable();
                da.Fill(tab);
                BindingSource bs = new BindingSource();
                bs.DataSource = tab;
                this.articleDevis.DataSource = bs;

                this.articleDevis.Columns[0].HeaderText = "Référence";
                this.articleDevis.Columns[1].HeaderText = "Désignation";
                this.articleDevis.Columns[2].HeaderText = "Type";
                this.articleDevis.Columns[3].HeaderText = "Quantité demandée";
                this.articleDevis.Columns[0].Width = 125;
                this.articleDevis.Columns[1].Width = 150;
                this.articleDevis.Columns[2].Width = 150;
            }
        }

        public void chargerFournisseur()
        {
            this.fournisseurCombo.Items.Clear();
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from fournisseur";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("numero_fournisseur");
                    this.fournisseurCombo.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
