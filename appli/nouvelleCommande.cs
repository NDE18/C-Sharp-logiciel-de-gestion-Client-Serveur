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
    public partial class nouvelleCommande : DevComponents.DotNetBar.Office2007Form
    {
       
        DataTable table;
        MySqlDataAdapter da;
        DataTable tab;

        public nouvelleCommande()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            numeroCommande();
            chargerCommande();
            chargerDevis();
            chargerFournisseur();

            this.numeroDevis.Command = this.devisCommand;
            this.devisCommand.Executed += new System.EventHandler(this.devisCommand_Executed);

            this.ajoutArticle.Command = this.ajoutArtCommand;
            this.ajoutArtCommand.Executed += new System.EventHandler(this.ajoutArtCommand_Executed);

            this.select1.Click += new System.EventHandler(this.select1_Executed);

            this.annulerDevis.Click += new System.EventHandler(this.annulerDevis_Executed);
            this.nouvelCommande.Click += new System.EventHandler(this.nouvelCommande_Executed);

            this.listeArticle.Visible = false;
            this.select1.Visible = false;
            // this.listeCache.Visible = true;
            this.detail.Visible = false;

            this.annulerDevis.Visible = false;
            this.enregCommande.Visible = false;
            this.BChoixArticle.Visible = false;
            this.ajoutArticle.Visible = true;
            this.ajoutArticle.Location = new Point(834, 176);
            this.nouvelCommande.Visible = false;
            this.rechArticle.Visible = false;

            listeArtCom.Text = 1.ToString();
            this.enregCommande.Command = this.enregCommand;
            this.enregCommand.Executed += new System.EventHandler(this.enregDevis_Executed);
        }

        public void enregDevis_Executed(object sender, EventArgs e)
        {
            //if (double.Parse(valeur.Text) == 0)
            //{
            //    MessageBox.Show("Vous n'avez pas choisi d'article", "Impossible d'enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
                demandesDevis d = new demandesDevis();
                const string message = "Voulez-vous enregister\n cette demande ?";
                const string caption = "Confirmation";
                const string messages = "Enregistrement éffectué.";
                const string captions = "Information";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    d.SetNumero(this.numCommande.Text);
                    d.SetDate(this.dateCommande.Text);
                    d.SetFournisseur(this.fournisseurCombo.Text);

                    int test = 0;
                    for (int j = 0; j < articleCommande.Rows.Count - 1; j++)
                    {
                        if (double.Parse(articleCommande.Rows[j].Cells[4].Value.ToString()) == 0)
                        {
                            test = 1;
                            MessageBox.Show("Erreur\n Veillez entrer la quantité à commander de l'article \'" + articleCommande.Rows[j].Cells[0].Value + "\'", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (test == 0)
                    {
                        int p = d.enregCommande(d);
                        for (int i = 0; i < articleCommande.Rows.Count - 1; i++)
                        {
                            d.SetQuantite(double.Parse(articleCommande.Rows[i].Cells[3].Value.ToString()));
                            d.SetQuantiteCommande(double.Parse(articleCommande.Rows[i].Cells[4].Value.ToString()));
                            d.SetReference(articleCommande.Rows[i].Cells[0].Value.ToString());
                            d.enregArticleCommande(d);
                        }

                        if (p == 1)
                        {
                            MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chargerCommande();
                            chargerDevis();
                            numeroCommande();
                            chargerFournisseur();
                            this.listeArticleMod.Visible = true;
                            this.listeArticle.Visible = false;
                            this.articleCommande.Rows.Clear();
                            this.fournisseurCombo.Text = "";
                        }
                    }
                    
                }
           // }
        }

        private void supprimerArticle_Load(object sender, EventArgs e)
        {

        }
        public void nouvelCommande_Executed(object sender, EventArgs e)
        {
            this.articleCommande.Rows.Clear();
            this.ajoutArticle.Visible = true;
            this.ajoutArticle.Location = new Point(834, 176);
            this.nouvelCommande.Visible = false;
            this.detail.Text = "Articles de la commande  " + "'" + numCommande.Text.ToString() + "'";
        }

        public void annulerDevis_Executed(object sender, EventArgs e)
        {
            listeArtCom.Text = 1.ToString();
            this.annulerDevis.Visible = false;
            this.enregCommande.Visible = false;
            this.BChoixArticle.Visible = false;
            this.ajoutArticle.Visible = true;
            this.ajoutArticle.Location = new Point(834, 176);

            this.listeArticle.Visible = false;
            this.listeArticle.Location = new Point(6, 55);
            this.listeArticleMod.Visible = true;
            this.select1.Visible = false;
            this.TRechF.Visible = true;
            this.rechArticle.Visible = false;
            this.articleCommande.Rows.Clear();
        }

        public void ajoutArtCommand_Executed(object sender, EventArgs e)
        {
            this.Taide.Text = "Sélectionnez le(s) article(s) à ajouter et clickez sur ' > '";
            this.rechArticle.Visible = true;
            this.TRechF.Visible = false;
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,designation,type,quantite FROM article ";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Update(table);
            tab = new DataTable();
            da.Fill(tab);
            BindingSource bs = new BindingSource();
            bs.DataSource = tab;
            this.listeArticle.DataSource = bs;

            this.listeArticle.Columns[0].HeaderText = "Référence";
            this.listeArticle.Columns[1].HeaderText = "Désignation";
            this.listeArticle.Columns[2].HeaderText = "Type";
            this.listeArticle.Columns[3].HeaderText = "Quantité en stock";
            this.listeArticle.Columns[0].Width = 125;
            this.listeArticle.Columns[1].Width = 150;
            this.listeArticle.Columns[2].Width = 150;
            this.listeArticle.Visible = true;
            this.listeArticle.Location = new Point(6, 55);
            this.listeArticleMod.Visible = false;
            this.select1.Visible = true;

            this.annulerDevis.Visible = true;
            this.enregCommande.Visible = true;
            this.BChoixArticle.Visible = false;
            this.ajoutArticle.Visible = false;
            this.nouvelCommande.Visible = false;
            this.annulerDevis.Location = new Point(834, 176);
        }

        public void devisCommand_Executed(object sender, EventArgs e)
        {
            
        }

        private void TRechF_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("numero_commande LIKE '%{0}%'", this.TRechF.Text);
            this.listeArticleMod.DataSource = dv;
        }

        public void numeroCommande()
        {
            double compteur = 0;
            int dat = System.DateTime.Now.Year - 2000;
            //string dates = dat;
            int d = System.DateTime.Now.Year;
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from commande";
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
            compteur = compteur + 1;
            if (compteur <= 9)
            {
                numCommande.Text = dat.ToString() + "COM00" + compteur;
            }
            else if ((compteur > 9) && (compteur < 100))
            {
                numCommande.Text = dat.ToString() + "COM0" + compteur;
            }
            else if (compteur == 0)
            {
                this.numCommande.Text = dat.ToString() + "COM001" + compteur;
            }
            else
            {
                numCommande.Text = dat.ToString() + "COM" + compteur;
            }
        }

        public void chargerTableau()
        {
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM commande";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.listeArticleMod.DataSource = bs;
            this.listeArticleMod.Columns[0].HeaderText = "Numéro";
            this.listeArticleMod.Columns[2].HeaderText = "Date";
            this.listeArticleMod.Columns[1].HeaderText = "Fournisseur";
            this.listeArticleMod.Columns[1].Width = 200;
            this.listeArticleMod.Columns[0].Width = 200;
            //this.listeArticleMod.Columns[0].ReadOnly = true;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        private void listeArticleMod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Taide.Text = "Clickez sur nouvelle commande pour créer une commande";
            this.articleCommande.Rows.Clear();
            listeArtCom.Text = 1.ToString();
            this.ajoutArticle.Visible = false;
            this.nouvelCommande.Visible = true;
            this.nouvelCommande.Location = new Point(834, 176);
            this.numeroDevis.Text = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listeArticleMod.Rows[e.RowIndex];
                this.detail.Visible = true;
                this.detail.Text = "Articles de la commande  " + "'" + row.Cells[0].Value.ToString() + "'";
                ConnexionDB c = new ConnexionDB();
                string query = "SELECT reference,designation,type,quantite_demande,quantite_commande FROM article_commande INNER JOIN article ON (reference = reference_commande) WHERE numero_commande = '" + row.Cells[0].Value.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(query, c.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                //    da.SelectCommand = cmd;

                //    tab = new DataTable();
                //    da.Update(tab);
                //    da.Fill(tab);
                //    BindingSource bs = new BindingSource();
                //    bs.DataSource = tab;
                //    this.listeCache.DataSource = bs;

                //    this.listeCache.Columns[0].HeaderText = "Référence";
                //    this.listeCache.Columns[1].HeaderText = "Désignation";
                //    this.listeCache.Columns[2].HeaderText = "Type";
                //    this.listeCache.Columns[3].HeaderText = "Quantité commandée";
                //    this.listeCache.Columns[0].Width = 125;
                //    this.listeCache.Columns[1].Width = 150;
                //    this.listeCache.Columns[2].Width = 150;

                //    this.articleCommande.Rows.Clear();
                //    this.articleCommande.Columns[3].HeaderText = "Quantité commandée";
                //    this.articleCommande.Columns[4].Visible = false;
                //    for (int i = 0; i < this.listeCache.Rows.Count - 1; i++)
                //    {
                //        DataGridViewRow row1 = this.listeCache.Rows[i];
                //        //DataGridViewRow row2 = this.articleCommande.Rows[i];
                //        int n = this.articleCommande.Rows.Add();
                //        this.articleCommande.Rows[n].Cells[0].Value = row1.Cells[0].Value.ToString();
                //        this.articleCommande.Rows[n].Cells[1].Value = row1.Cells[1].Value.ToString();
                //        this.articleCommande.Rows[n].Cells[2].Value = row1.Cells[2].Value.ToString();
                //        this.articleCommande.Rows[n].Cells[3].Value = row1.Cells[3].Value.ToString();
                //    }

                //}
                MySqlDataReader reader;
                try
                {
                    c.con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int n = this.articleCommande.Rows.Add();
                        this.articleCommande.Rows[n].Cells[0].Value = reader.GetString("reference");
                        this.articleCommande.Rows[n].Cells[1].Value = reader.GetString("designation");
                        this.articleCommande.Rows[n].Cells[2].Value = reader.GetString("type");
                        this.articleCommande.Rows[n].Cells[3].Value = reader.GetString("quantite_demande");
                        this.articleCommande.Rows[n].Cells[4].Value = reader.GetString("quantite_commande");
                    }
                    reader.Close();
                    c.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        public void chargerCommande()
        {
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT numero_commande,date_commande,nom_fournisseur,statut FROM commande INNER JOIN fournisseur ON (fournisseur = numero_fournisseur) ORDER BY numero_commande DESC";
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
            this.listeArticleMod.Columns[2].HeaderText = "Fournisseur";
            this.listeArticleMod.Columns[3].HeaderText = "Statut";
            this.listeArticleMod.Columns[1].Width = 200;
            this.listeArticleMod.Columns[0].Width = 200;
            //this.listeArticleMod.Columns[0].ReadOnly = true;
            //this.TArticle.Columns.Add(test);
            //da.Update(table);
        }

        public void chargerDevis()
        {
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
                    string valeur = reader.GetString("num_devis");
                    this.numeroDevis.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numeroDevis_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ajoutArticle.Visible = true;
            this.ajoutArticle.Location = new Point(834, 176);
            this.nouvelCommande.Visible = true;
            this.nouvelCommande.Location = new Point(646, 176);
            listeArtCom.Text = 0.ToString();
            this.articleCommande.Rows.Clear();
            this.detail.Visible = true;
            this.Taide.Text = "Clickez sur ' ajouter article ' pour augmenter les articles à commander";
            this.detail.Text = "Articles de la demande devis  " + "'" +numeroDevis.Text+ "'";
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,designation,type,quantite_demande FROM article_choisi INNER JOIN article ON (reference = reference_demande) WHERE numero = '" + this.numeroDevis.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;
            
            c.con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int n = this.articleCommande.Rows.Add();
                this.articleCommande.Rows[n].Cells[0].Value = reader.GetString("reference");
                this.articleCommande.Rows[n].Cells[1].Value = reader.GetString("designation");
                this.articleCommande.Rows[n].Cells[2].Value = reader.GetString("type");
                this.articleCommande.Rows[n].Cells[3].Value = reader.GetString("quantite_demande");
            }
            reader.Close();
            c.con.Close();
            chargerFournisseurDem(this.numeroDevis.Text);
            chargerFournisseur();
        }

        public void chargerFournisseurDem(string val)
        {
            this.fournisseurCombo.Items.Clear();
            ConnexionDB c = new ConnexionDB();
            string query = "Select fournisseur from demande_devis where num_devis = '" + val + "' ";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.fournisseurCombo.Text = reader.GetString("fournisseur");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        public void select1_Executed(object sender, EventArgs e)
        {
            int test = 0;
            //this.valeur.Text = this.articleCommande.Rows.Count.ToString();
            int y = this.listeArticle.CurrentCellAddress.Y;
            for (int i = 0; i <= this.listeArticle.Rows.Count - 1; i++)
            {
                if (this.listeArticle.Rows[i].Selected)
                {
                    DataGridViewRow row = this.listeArticle.Rows[i];
                    for (int j = 0; j <= this.articleCommande.Rows.Count - 1; j++)
                    {
                        if (row.Cells[0].Value == this.articleCommande.Rows[j].Cells[0].Value)
                        {
                            test = 1;
                            break;
                        }
                    }
                    if (test == 0)
                    {
                        int n = this.articleCommande.Rows.Add();
                        this.articleCommande.Rows[n].Cells[0].Value = row.Cells[0].Value.ToString();
                        this.articleCommande.Rows[n].Cells[1].Value = row.Cells[1].Value.ToString();
                        this.articleCommande.Rows[n].Cells[2].Value = row.Cells[2].Value.ToString();
                        this.articleCommande.Rows[n].Cells[3].Value = 0;
                        this.articleCommande.Rows[n].Cells[4].Value = 0;
                    }
                    else if (test == 1)
                    {
                        MessageBox.Show("L'article " + row.Cells[1].Value.ToString() + "\n a déjà été sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void articleCommande_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (double.Parse(listeArtCom.Text) == 0)
                {
                    DataGridViewRow row = this.articleCommande.Rows[e.RowIndex];
                    this.articleCommande.Rows.Remove(row);
                }
            }
        }

        private void articleCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.articleCommande.Rows[e.RowIndex];
                row.Cells[4].Selected = true;
            }
        }

        private void rechArticle_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tab);
            dv.RowFilter = String.Format("reference LIKE '%{0}%'", this.rechArticle.Text);
            this.listeArticle.DataSource = dv;
        }
    }
}
