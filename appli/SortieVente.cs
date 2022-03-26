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
    public partial class SortieVente : DevComponents.DotNetBar.Office2007Form
    {
        double compteur;
        DataTable table;

        public SortieVente()
        {
            InitializeComponent();

            numeroCommande();
            chargerTableau();

            this.select1.Click += new System.EventHandler(this.select1_Executed);
            this.Bcout.Click += new System.EventHandler(this.Bcout_Executed);
            this.BEnregVente.Click += new System.EventHandler(this.BEnregVente_Executed);
            this.BAnnulerVente.Click += new System.EventHandler(this.BAnnulerVente_Executed);
            this.affiche.Click += new System.EventHandler(this.afficheT);
        }

        public void BEnregVente_Executed(object sender, EventArgs e)
        {
            calculer();
            sortie s = new sortie();
            vente q = new vente();
            const string message = "Voulez-vous enregister\n cette demande ?";
            const string caption = "Confirmation";
            const string messages = "Enregistrement éffectué.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //if (this.numEmploye.Text == "")
                //{
                //    MessageBox.Show("Warning\n Veillez selectionner l'employé qui retire l'(les) article(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
                double r = double.Parse(this.reduction.Value.ToString());
                    q.SetNumero(this.numVente.Text);
                    s.SetNumero(this.numVente.Text);
                    //s.SetNumEmp(this.numEmploye.Text);
                    s.SetMotif("Vente facture numéro " + numVente.Text);
                    s.SetDate(System.DateTime.Now.ToString());
                    s.SetNomClient(this.nomClient.Text + " " + this.prenomClient.Text);
                    q.SetDatevente(System.DateTime.Now.Date.ToShortDateString().ToString());
                    q.SetNomClient(this.nomClient.Text);
                    q.SetNumclient(this.numClient.Text);
                    q.SetReduction(r);

                    int test = 0;
                    for (int j = 0; j < this.articleCommande.Rows.Count - 1; j++)
                    {
                        if (double.Parse(this.articleCommande.Rows[j].Cells[2].Value.ToString()) > 0 || double.Parse(this.articleCommande.Rows[j].Cells[3].Value.ToString()) > 0)
                        {
                            
                            q.SetRef(this.articleCommande.Rows[j].Cells[0].Value.ToString());
                            s.SetQte(double.Parse(this.articleCommande.Rows[j].Cells[2].Value.ToString()));
                            s.SetRef(this.articleCommande.Rows[j].Cells[0].Value.ToString());
                            q.SetPrixT(double.Parse(this.articleCommande.Rows[j].Cells[4].Value.ToString()));
                            q.SetPrixU(double.Parse(this.articleCommande.Rows[j].Cells[3].Value.ToString()));
                            q.SetQte(double.Parse(this.articleCommande.Rows[j].Cells[2].Value.ToString()));

                            s.enregSorti(s);
                            q.enregVente(q);
                        }
                        else if (double.Parse(this.articleCommande.Rows[j].Cells[2].Value.ToString()) < 0 || double.Parse(this.articleCommande.Rows[j].Cells[3].Value.ToString()) > 0)
                        {
                            test = 1;
                            break;
                           
                        }
                    }
                    if (test == 1)
                    {
                        MessageBox.Show("Error\n Valeur incorrecte \n veillez vérifier les valeurs que vous avez entrées", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        q.enregVentes(q);
                        generePdf();
                        initialiser();
                        numeroCommande();
                        this.articleCommande.Rows.Clear();
                        chargerTableau();
                        
                    }
                //}
            }
        }

        public void generePdf()
        {
            string facture = numVente.Text + ".pdf";
            string dat = System.DateTime.Now.Year.ToString()+ System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString() + "_" + System.DateTime.Now.Hour.ToString()+ System.DateTime.Now.Minute.ToString() + System.DateTime.Now.Second.ToString() + ".pdf";
            this.q.Text = dat;
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 20, 20);
            PdfWriter.GetInstance(doc, new FileStream(facture, FileMode.Create));
            doc.Open();
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("logos.jpg");
            logo.ScalePercent(70f);
            //logo.SetAbsolutePosition(doc.PageSize.Width - 100 - 250, doc.PageSize.Height - 36 - 100);
            logo.Alignment = Element.ALIGN_CENTER;

            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

            doc.Add(logo);
            Paragraph p = new Paragraph("Facture N°: " + this.numVente.Text, new iTextSharp.text.Font(bfTimes, 14f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            p.Alignment = Element.ALIGN_CENTER;
            doc.Add(p);
            Paragraph p1 = new Paragraph();
            Phrase ph1 = new Phrase("\n Nom du client : ");
            Phrase pr1 = new Phrase(this.nomClient.Text + " "+this.prenomClient.Text + "\n \n", new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph1.Add(pr1);
            p1.Add(ph1);
            Phrase ph4 = new Phrase("\n Date : ");
            Phrase pr4 = new Phrase(System.DateTime.Now.ToString() + "\n \n", new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph4.Add(pr4);
            p1.Add(ph4);
            doc.Add(p1);
            charger();
            PdfPTable table = new PdfPTable(this.articleCommandes.Columns.Count);
            for (int j = 0; j < this.articleCommandes.Columns.Count; j++)
            {
                table.AddCell(new Phrase(this.articleCommandes.Columns[j].HeaderText));
            }
            table.HeaderRows = 1;
            for (int i = 0; i < this.articleCommandes.Rows.Count; i++)
            {
                for (int k = 0; k < this.articleCommandes.Columns.Count; k++)
                {
                    if (this.articleCommandes[k, i].Value != null)
                    {
                        table.AddCell(this.articleCommandes[k, i].Value.ToString());
                    }
                }
            }
            doc.Add(table);

            Paragraph p2 = new Paragraph();
            Phrase ph2 = new Phrase("\n Montant sans remise : ");
            Phrase pr2 = new Phrase(this.total.Text, new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph2.Add(pr2);
            p2.Add(ph2);
            Phrase ph3 = new Phrase("\n Reduction : ");
            Phrase pr3 = new Phrase(this.reduction.Text , new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph3.Add(pr3);
            p2.Add(ph3);
            Phrase ph5 = new Phrase("\n Net à payer : ");
            Phrase pr5 = new Phrase(this.montantReduction.Text, new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph5.Add(pr5);
            p2.Add(ph5);

            doc.Add(p2);
            doc.Close();
            vente v = new vente();           
            string val = facture;
            System.Diagnostics.Process.Start(val);
            v.SetPath(val);
            v.SetFacture(facture);
            v.SetNumero(numVente.Text);
            v.enregFactureVente(v);
        }
        public void charger()
        {
            Article art = new Article();
            for (int i = 0; i < this.articleCommande.Rows.Count - 1; i++)
            {
                for (int k = 0; k < this.TListeArticle.Columns.Count - 1; k++)
                {
                    if (this.articleCommande.Rows[i].Cells[0].Value == this.TListeArticle.Rows[k].Cells[0].Value)
                    {
                        int p = this.articleCommandes.Rows.Add();
                        this.articleCommandes.Rows[p].Cells[0].Value = this.TListeArticle.Rows[k].Cells[1].Value;
                        this.articleCommandes.Rows[p].Cells[1].Value = this.articleCommande.Rows[i].Cells[2].Value;
                        this.articleCommandes.Rows[p].Cells[2].Value = this.articleCommande.Rows[i].Cells[3].Value;
                        this.articleCommandes.Rows[p].Cells[3].Value = this.articleCommande.Rows[i].Cells[4].Value;
                        int dif = Convert.ToInt32(this.articleCommande.Rows[i].Cells[1].Value) - Convert.ToInt32(this.articleCommande.Rows[i].Cells[2].Value);
                        //this.q.Text = dif.ToString();
                        //art.SetQuantite(dif);
                        //art.SetReference(articleCommande.Rows[i].Cells[0].Value.ToString());
                        //art.modifArticleStock(art);
                    }
                }
            }
        }

        public void BAnnulerVente_Executed(object sender, EventArgs e)
        {
            initialiser();
        }

        public void initialiser()
        {
            this.nomClient.Text = "";
            this.numClient.Text = "";
            this.prenomClient.Text = "";
            this.typeClient.Text = "";
            this.total.Text = "";
            this.qteDem.Text = "";
            this.montantReduction.Text = "";
            this.reduction.Value = 0;
            this.articleCommande.Rows.Clear();
        }

        private void calculer()
        {
            int testeur = 1;
            double totale = 0;
            double totalArt = 0;
            for (int i = 0; i < this.articleCommande.Rows.Count - 1; i++)
            {
                if (double.Parse(this.articleCommande.Rows[i].Cells[3].Value.ToString()) <= 0 || double.Parse(this.articleCommande.Rows[i].Cells[2].Value.ToString()) <= 0)
                {
                    MessageBox.Show("Aucune valeur ne doit ête inférieur ou égale à 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    testeur = 0;
                    break;
                }
                else if (double.Parse(this.articleCommande.Rows[i].Cells[1].Value.ToString()) < double.Parse(this.articleCommande.Rows[i].Cells[2].Value.ToString()))
                {
                    MessageBox.Show("Article '" + this.articleCommande.Rows[i].Cells[0].Value.ToString() + "' " + "\nLa quantité demandée est supérieur à la quantité en stock", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    testeur = 0;
                    break;

                }
                else
                {
                    double prixU = double.Parse(this.articleCommande.Rows[i].Cells[3].Value.ToString());
                    double qte = double.Parse(this.articleCommande.Rows[i].Cells[2].Value.ToString());
                    this.articleCommande.Rows[i].Cells[4].Value = (qte * prixU).ToString();
                    totale += double.Parse(this.articleCommande.Rows[i].Cells[4].Value.ToString());
                    totalArt += qte;
                }
            }
            if (testeur == 1)
            {
                this.total.Text = totale.ToString(); //+ " "+"F CFA";
                this.qteDem.Text = totalArt.ToString();
                this.montantReduction.Text = (decimal.Parse(total.Text) - (decimal.Parse(total.Text) * reduction.Value) / 100).ToString() + " " + "F CFA";
                this.total.Text = totale.ToString() + " " + "F CFA";
            }
        }

        public void Bcout_Executed(object sender, EventArgs e)
        {
            calculer();
        }

        public void numeroCommande()
        {
            int dat = System.DateTime.Now.Year - 2000;
            //string dates = dat;
            int d = System.DateTime.Now.Year;
            ConnexionDB c = new ConnexionDB();
            string query = "Select numero from ventes";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    compteur = double.Parse(reader.GetValue(0).ToString());
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
                numVente.Text = dat.ToString() + "FAC00" + compteur;
            }
            else if ((compteur > 9) && (compteur < 100))
            {
                numVente.Text = dat.ToString() + "FAC0" + compteur;
            }
            else
            {
                numVente.Text = dat.ToString() + "FAC" + compteur;
            }
        }

        public void chargerTableau()
        {
            this.TListeArticle.RowHeadersVisible = false;
            this.TListeArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,designation,type,quantite,prix_revient,prix_recommande,prix_minimal,prix_maximal FROM article AS a,prix AS p WHERE a.reference=p.reference_prix";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TListeArticle.DataSource = bs;
            //this.TListeArticle.Columns[9].Visible = false;
            this.TListeArticle.Columns[1].Name = "Désignation";
            this.TListeArticle.Columns[0].HeaderText = "Référence";
            this.TListeArticle.Columns[1].HeaderText = "Désignation";
            this.TListeArticle.Columns[2].HeaderText = "Type";
            this.TListeArticle.Columns[3].HeaderText = "Quantité en stock";
            this.TListeArticle.Columns[4].HeaderText = "Prix de revient";
            this.TListeArticle.Columns[5].HeaderText = "Prix recommandé";
            this.TListeArticle.Columns[6].HeaderText = "Prix minimal";
            this.TListeArticle.Columns[7].HeaderText = "Prix maximal";

            for (int i = 0; i < this.TListeArticle.Rows.Count - 1; i++)
            {
                double pRec = double.Parse(this.TListeArticle.Rows[i].Cells[5].Value.ToString());
                double pMin = double.Parse(this.TListeArticle.Rows[i].Cells[6].Value.ToString());
                double pMax = double.Parse(this.TListeArticle.Rows[i].Cells[7].Value.ToString());
                double pRev = double.Parse(this.TListeArticle.Rows[i].Cells[4].Value.ToString());
                this.TListeArticle.Rows[i].Cells[5].Value = pRev + (pRev * pRec) / 100;
                this.TListeArticle.Rows[i].Cells[6].Value = pRev + (pRev * pMin) / 100;
                this.TListeArticle.Rows[i].Cells[7].Value = pRev + (pRev * pMax) / 100;
            }
        }

        private void chargerNumClient(string val)
        {
            this.numClient.Items.Clear();
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from client Where type_client = '" + val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("numero_client");
                    this.numClient.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void typeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "Select reduction from type_client Where nom = '" + this.typeClient.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.reduction.Text = reader.GetString("reduction");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if (typeClient.Text == "Occasionnel")
            //{
            //    numClient.Enabled = false;
            //    this.nomClient.ReadOnly = false;
            //    this.prenomClient.ReadOnly = false;
            //    this.numClient.Items.Clear();
            //}
            //else if (typeClient.Text == "Professionnel")
            //{
            //    this.numClient.Enabled = true;
            //    this.nomClient.ReadOnly = true;
            //    this.prenomClient.ReadOnly = true;
               chargerNumClient(typeClient.Text);
            //}
        }

        public void afficheT(object sender, EventArgs e)
        {
            chargerTableau();
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("reference LIKE '%{0}%'", this.TRech.Text);
            this.TListeArticle.DataSource = dv;
        }

        public void select1_Executed(object sender, EventArgs e)
        {
            int test = 0;
            //this.valeur.Text = this.articleCommande.Rows.Count.ToString();
            int y = this.TListeArticle.CurrentCellAddress.Y;
            for (int i = 0; i <= this.TListeArticle.Rows.Count - 1; i++)
            {
                if (this.TListeArticle.Rows[i].Selected)
                {
                    DataGridViewRow row = this.TListeArticle.Rows[i];
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
                        this.articleCommande.Rows[n].Cells[1].Value = row.Cells[3].Value.ToString();
                        this.articleCommande.Rows[n].Cells[2].Value = 0;
                        this.articleCommande.Rows[n].Cells[3].Value = 0;
                        this.articleCommande.Rows[n].Cells[4].Value = 0;
                    }
                    else if (test == 1)
                    {
                        MessageBox.Show("L'article " + row.Cells[1].Value.ToString() + "\n a déjà été sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //chargerTableau();
        }

        private void articleCommande_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string message = "Voulez-vous supprimer l'article '" + this.articleCommande.Rows[e.RowIndex].Cells[0].Value + "' \n de la liste?";
                const string caption = "Confirmation";

                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = this.articleCommande.Rows[e.RowIndex];
                    this.articleCommande.Rows.Remove(row);
                }
            }
        }

        private void numClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nomClient.Text = "";
            this.prenomClient.Text = "";
            ConnexionDB c = new ConnexionDB();
            string query = "Select nom_clients,prenom_client,reduction from client INNER JOIN type_client Where numero_client = '" + this.numClient.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.nomClient.Text = reader.GetString("nom_clients");
                    this.prenomClient.Text = reader.GetString("prenom_client");
                    this.reduction.Text = reader.GetString("reduction");
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
