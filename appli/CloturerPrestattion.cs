using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace appli
{
    public partial class CloturerPrestattion : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public CloturerPrestattion()
        {
            InitializeComponent();

            chargerPresta();
            chargerNumEmploye();

            this.coutTotal.Click += new System.EventHandler(this.coutTotal_Executed);
            this.BEnregCloture.Click += new System.EventHandler(this.BEnregCloture_Executed);
            this.BAnnulerCloture.Click += new System.EventHandler(this.BAnnulerCloture_Executed);
        }

        public void BAnnulerCloture_Executed(object sender, EventArgs e)
        {
            initialiser();
        }

        public void BEnregCloture_Executed(object sender, EventArgs e)
        {
            calcule();
            const string messages = "Enregistrement éffectué.\n Voulez afficher le fichier pdf ?";
            const string captions = "?";
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 20, 20);
            PdfWriter w = PdfWriter.GetInstance(doc, new FileStream("C://Users//NDE//pdf//Dépannage//dépannage.pdf", FileMode.Create));
            doc.Open();

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("logos.jpg");
            logo.ScalePercent(30f);
            //logo.SetAbsolutePosition(doc.PageSize.Width - 100 - 250, doc.PageSize.Height - 36 - 100);
            logo.Alignment = Element.ALIGN_CENTER;

            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            
            doc.Add(logo);

            Paragraph p = new Paragraph("GIGATRONIK", new iTextSharp.text.Font(bfTimes, 14f, iTextSharp.text.Font.BOLD,iTextSharp.text.BaseColor.BLACK));
            p.Alignment = Element.ALIGN_CENTER;       
            doc.Add(p);

            Paragraph p1 = new Paragraph();
            //p1.Alignment = Element.ALIGN_LEFT;
            Paragraph p2 = new Paragraph();
            p2.Alignment = Element.ALIGN_RIGHT;
            Phrase ph = new Phrase("\n \n Facture numéro : ");
            Phrase pr = new Phrase(this.numPrest.Text, new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph.Add(pr);
            p1.Add(ph);
            //doc.Add(p1);

            Phrase ph1 = new Phrase("\n Nom du client : ");
            Phrase pr1 = new Phrase(this.nomClient.Text, new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph1.Add(pr1);
            p1.Add(ph1);
            //doc.Add(p1);
            
            Phrase ph2 = new Phrase("\n Appareil dépanné : ");
            Phrase pr2 = new Phrase(this.appareil.Text, new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph2.Add(pr2);
            p1.Add(ph2);
            //doc.Add(p1);
            

            Phrase ph3 = new Phrase("\n Date de facturation : ");
            Phrase pr3 = new Phrase(this.dateFin.Text, new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph3.Add(pr3);
            p1.Add(ph3);

            Phrase ph4 = new Phrase("\n Temps mis : ");
            Phrase pr4 = new Phrase(this.tempsMis.Text + " h", new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph4.Add(pr4);
            p1.Add(ph4);
            Phrase ph5 = new Phrase("\n Main d'oeuvre (/heure) : ");
            Phrase pr5 = new Phrase(this.prixMainDoeuvre.Text + " F CFA", new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph5.Add(pr5);
            p1.Add(ph5);

            Phrase ph6 = new Phrase("\n Réduction : ");
            Phrase pr6 = new Phrase(this.reduction.Text + "%", new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph6.Add(pr6);
            p1.Add(ph6);
            Phrase ph7 = new Phrase("\n Montant total : ");
            Phrase pr7 = new Phrase(this.montant.Text, new iTextSharp.text.Font(bfTimes, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            ph7.Add(pr7);
            p1.Add(ph7);
            //doc.Add(p2);
            doc.Add(p1);

            Paragraph p3 = new Paragraph("\n \n Articles utilisés\n \n", new iTextSharp.text.Font(bfTimes, 14f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            p3.Alignment = Element.ALIGN_CENTER;
            doc.Add(p3);

            PdfPTable table = new PdfPTable(this.TArticleChoisi.Columns.Count);
            for (int j = 0; j<this.TArticleChoisi.Columns.Count; j++)
            {
                table.AddCell(new Phrase(this.TArticleChoisi.Columns[j].HeaderText));
            }
            table.HeaderRows = 1;
            for (int i = 0; i < this.TArticleChoisi.Rows.Count; i++)
            {
                for (int k = 0; k < this.TArticleChoisi.Columns.Count; k++)
                {
                    if (this.TArticleChoisi[k, i].Value != null)
                    {
                        table.AddCell(this.TArticleChoisi[k, i].Value.ToString());
                    }
                }
            }
            doc.Add(table);
            doc.Close();
            System.Diagnostics.Process.Start("C:\\Users\\NDE\\pdf\\Dépannage\\dépannage.pdf");
            //System.Diagnostics.Process.Start("C:\\Users\\NDE\\pdf\\Dépannage\\dépannage.pdf");
            depannage d = new depannage();
            d.SetNumDep(this.numPrest.Text);
            int m = d.modifStatutDepannage(d);
            int l = enregistrer();
            if ((l == this.TListeArticle.Rows.Count - 1) && (m == 1))
            {
                chargerPresta();
                initialiser();
                MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            System.Diagnostics.Process.Start("C:\\Users\\NDE\\pdf\\Dépannage\\dépannage.pdf");
        }

        public int enregistrer()
        {
            int j = 0;
            string message = "Voulez-vous clôturer \n la prestation numéro '"+this.numPrest.Text+"' ?";
            const string caption = "Confirmation";
            
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cloturer c = new cloturer();
                c.SetNumDep(this.numPrest.Text);
                c.SetDate(this.dateFin.Text);
                c.SetMain(this.prixMainDoeuvre.Text);
                c.SetTotal(this.montant.Text);
                c.SetReduction(this.reduction.Value.ToString());
                c.SetTemps(this.tempsMis.Value.ToString());
                int p = c.enregCloture(c);

                if (p == 1)
                {
                    
                    for (int i = 0; i < this.TListeArticle.Rows.Count-1; i++)
                    {
                        c.SetRef(this.TListeArticle.Rows[i].Cells[0].Value.ToString());
                        c.SetQte(this.TListeArticle.Rows[i].Cells[4].Value.ToString());
                        c.SetPrix(this.TListeArticle.Rows[i].Cells[9].Value.ToString());
                        c.SetProduit(this.TListeArticle.Rows[i].Cells[10].Value.ToString());
                        int k=c.enregArtCloture(c);
                        if (k == 1)
                        {
                            j += 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }              
            }
            return j;
        }

        public void coutTotal_Executed(object sender, EventArgs e)
        {
            calcule();
        }

        public void calcule()
        {
            double totale = 0;
            double total = 0;
            for (int i = 0; i < this.TListeArticle.Rows.Count - 1; i++)
            {
                if (double.Parse(this.TListeArticle.Rows[i].Cells[9].Value.ToString()) <= 0)
                {
                    MessageBox.Show("Aucune valeur ne doit ête inférieur ou égale à 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    double prixU = double.Parse(this.TListeArticle.Rows[i].Cells[9].Value.ToString());
                    double qte = double.Parse(this.TListeArticle.Rows[i].Cells[4].Value.ToString());
                    total += (qte * prixU);
                    this.TListeArticle.Rows[i].Cells[10].Value = (qte * prixU).ToString();

                    int n = this.TArticleChoisi.Rows.Add();
                    this.TArticleChoisi.Rows[n].Cells[0].Value = this.TListeArticle.Rows[i].Cells[0].Value;
                    this.TArticleChoisi.Rows[n].Cells[1].Value = this.TListeArticle.Rows[i].Cells[1].Value;
                    this.TArticleChoisi.Rows[n].Cells[2].Value = this.TListeArticle.Rows[i].Cells[4].Value;
                    this.TArticleChoisi.Rows[n].Cells[3].Value = this.TListeArticle.Rows[i].Cells[9].Value;
                    this.TArticleChoisi.Rows[n].Cells[4].Value = this.TListeArticle.Rows[i].Cells[10].Value;
                }
            }
            total += double.Parse(this.tempsMis.Value.ToString()) * double.Parse(prixMainDoeuvre.Value.ToString());
            total = total - (double.Parse(reduction.Value.ToString()) * total) / 100;
            this.montant.Text = total.ToString() + " " + "F CFA";
        }

        private void buttonFontItalic_Click(object sender, EventArgs e)
        {

        }

        public void initialiser()
        {
            this.typeClient.Text = "";
            this.nomClient.Text = "";
            this.numclient.Text = "";
            this.auteur.Text = "";
            this.dateDebut.Text = "";
            this.reduction.Text = "0,00";
            this.appareil.Text = "";
            this.dateFin.Text="";
            this.prixMainDoeuvre.Text="";
            this.montant.Text="";
            this.tempsMis.Value=0;
            this.numEmploye.Text = "";
            this.numPrest.Text = "";
            this.TListeArticle.Rows.Clear();
            this.TArticleChoisi.Rows.Clear();
        }

        public void chargerChamp(string val)
        {
            initialiser();
            ConnexionDB c = new ConnexionDB();
            string query = "Select nom_client,num_client,num_employe,date_enregistrer,appareil_depannage,type_client,reduction from depannage INNER JOIN client ON (num_client=numero_client) INNER JOIN type_client ON (type_client = nom) Where num_depannage = '" + val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.typeClient.Text = reader.GetString("type_client");
                    this.nomClient.Text = reader.GetString("nom_client");
                    this.numclient.Text = reader.GetString("num_client");
                    this.auteur.Text = reader.GetString("num_employe");
                    this.dateDebut.Text = reader.GetString("date_enregistrer");
                    this.reduction.Text = reader.GetString("reduction");
                    this.appareil.Text = reader.GetString("appareil_depannage");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chargerPresta()
        {
            this.numPrest.Items.Clear();
            string val = "En cours";
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from depannage Where statut_depannage = '" + val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("num_depannage");
                    this.numPrest.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void chargerNumEmploye()
        {
            this.numEmploye.Items.Clear();
            //string val = "En cours";
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from employe";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("numero_employe");
                    this.numEmploye.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numPrest_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerChamp(this.numPrest.Text);
            chargerTableau(this.numPrest.Text);
        }

        public void chargerTableau(string val)
        {
            this.TListeArticle.Rows.Clear();
            this.TListeArticle.RowHeadersVisible = false;
            this.TListeArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference_prestation,designation,type,prix_revient,prix_minimal,prix_maximal,prix_recommande,qte,qte_utilise FROM qteprestation INNER JOIN article ON (reference_prestation = reference) INNER JOIN prix ON (reference = reference_prix) WHERE num_prestation = '" + val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int n = this.TListeArticle.Rows.Add();
                    this.TListeArticle.Columns[1].Name = "Désignation";
                    this.TListeArticle.Rows[n].Cells[0].Value = reader.GetString("reference_prestation");
                    this.TListeArticle.Rows[n].Cells[1].Value = reader.GetString("designation");
                    this.TListeArticle.Rows[n].Cells[2].Value = reader.GetString("type");
                    this.TListeArticle.Rows[n].Cells[3].Value = reader.GetString("qte");
                    this.TListeArticle.Rows[n].Cells[4].Value = reader.GetString("qte_utilise");
                    this.TListeArticle.Rows[n].Cells[5].Value = reader.GetString("prix_revient");
                    this.TListeArticle.Rows[n].Cells[6].Value = reader.GetString("prix_minimal");
                    this.TListeArticle.Rows[n].Cells[7].Value = reader.GetString("prix_maximal");
                    this.TListeArticle.Rows[n].Cells[8].Value = reader.GetString("prix_recommande");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

    }
}
