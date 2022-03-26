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
    public partial class AjoutDepannage : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;        

        public AjoutDepannage()
        {
            InitializeComponent();
            chargerTableau();
            numDepannage();
            chargerNumClient();
            chargerNomEmp();

            //CommandFontBold
            
            this.BEnregDepa.Click += new System.EventHandler(BEnregDepa_Executed);
            this.BAnnulerDepa.Click += new System.EventHandler(BAnnulerDepa_Executed);
            this.nom.ReadOnly = true;
        }
        private void CommandExecuted()
        {
            UpdateSelectionCommandsState();
        }

        private void CommandFontBold_Executed(object sender, EventArgs e)
        {
            if (TDiagnostic.SelectionFont.Bold)
                TDiagnostic.SelectionFont = new Font(TDiagnostic.SelectionFont, (TDiagnostic.SelectionFont.Style & ~(TDiagnostic.SelectionFont.Style & FontStyle.Bold)));
            else
                TDiagnostic.SelectionFont = new Font(TDiagnostic.SelectionFont, (TDiagnostic.SelectionFont.Style | FontStyle.Bold));
            CommandExecuted();
        }

        private void CommandFontItalic_Executed(object sender, EventArgs e)
        {
            if (TDiagnostic.SelectionFont.Italic)
                TDiagnostic.SelectionFont = new Font(TDiagnostic.SelectionFont, (TDiagnostic.SelectionFont.Style & ~(TDiagnostic.SelectionFont.Style & FontStyle.Italic)));
            else
                TDiagnostic.SelectionFont = new Font(TDiagnostic.SelectionFont, (TDiagnostic.SelectionFont.Style | FontStyle.Italic));
            CommandExecuted();
        }
        private void CommandFontUnderline_Executed(object sender, EventArgs e)
        {
            if (TDiagnostic.SelectionFont.Underline)
                TDiagnostic.SelectionFont = new Font(TDiagnostic.SelectionFont, (TDiagnostic.SelectionFont.Style & ~(TDiagnostic.SelectionFont.Style & FontStyle.Underline)));
            else
                TDiagnostic.SelectionFont = new Font(TDiagnostic.SelectionFont, (TDiagnostic.SelectionFont.Style | FontStyle.Underline));
            CommandExecuted();
        }
        private void TextSelectionChanged(object sender, System.EventArgs e)
        {
            UpdateSelectionCommandsState();
        }

        private void UpdateSelectionCommandsState()
        {
            CommandFontBold.Checked = TDiagnostic.SelectionFont.Bold;
            CommandFontItalic.Checked = TDiagnostic.SelectionFont.Italic;
            CommandFontUnderline.Checked = TDiagnostic.SelectionFont.Underline;

        }
        private void BindDocumentCommands()
        {
            
        }

        private void TDiagnostic_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjoutDepannage_Load(object sender, EventArgs e)
        {

        }

        private void numero_Click(object sender, EventArgs e)
        {

        }

        private void chargerNumClient()
        {
            this.CnumClient.Items.Clear();
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from client";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("numero_client");
                    this.CnumClient.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void typeClient_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if (typeClient.Text == "Occasionnel")
            //{
            //    this.CnumClient.Enabled = false;
            //    this.nom.ReadOnly = false;
            //    this.CnumClient.Items.Clear();
            //}
            //else if (this.typeClient.Text == "Professionnel")
            //{
            //    this.CnumClient.Enabled = true;
            //    this.nom.ReadOnly = true;
            
            //}
        }

        public void chargerTableau()
        {
            this.TArticle.RowHeadersVisible = false;
            this.TArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,designation,quantite FROM article";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TArticle.DataSource = bs;
            this.TArticle.Columns[0].HeaderText = "Référence";
            this.TArticle.Columns[1].HeaderText = "Désignation";
            this.TArticle.Columns[2].HeaderText = "Quantité en stock";
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("reference LIKE '%{0}%'", this.TRech.Text);
            this.TArticle.DataSource = dv;
        }

        public void numDepannage()
        {
            int compteur = 0;
            int dat = System.DateTime.Now.Year - 2000;
            //string dates = dat;
            int d = System.DateTime.Now.Year;
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from depannage";
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
            if (compteur < 9)
            {
                this.numero.Text = dat.ToString() + "DEP00" + compteur;
            }
            else if (compteur > 9)
            {
                this.numero.Text = dat.ToString() + "DEP0" + compteur;
            }
            else if (compteur == 0)
            {
                this.numero.Text = dat.ToString() + "DEP001" + compteur;
            }
        }

        private void TArticle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int test = 0;
                DataGridViewRow row = this.TArticle.Rows[e.RowIndex];
                for (int i = 0; i <= articleChoisi.Rows.Count - 1; i++)
                {
                    if (row.Cells["reference"].Value == this.articleChoisi.Rows[i].Cells[0].Value)
                    {
                        test = 1;
                        break;
                    }
                }
                if (test != 1)
                {
                    int n = this.articleChoisi.Rows.Add();
                    this.articleChoisi.Rows[n].Cells[0].Value = row.Cells["reference"].Value.ToString();
                    this.articleChoisi.Rows[n].Cells[1].Value = row.Cells["designation"].Value.ToString();
                    //TArticle.Rows.Remove(row);
                }
                else
                {
                    MessageBox.Show("Cette article a déjà été selectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int tester()
        {
            int t = 0;
            for (int i = 0; i < articleChoisi.Rows.Count - 1; i++)
            {
                if (double.Parse(articleChoisi.Rows[i].Cells[2].Value.ToString()) < 0)
                {
                    MessageBox.Show("Quantité nécéssaire de l'article '" + articleChoisi.Rows[i].Cells[1].Value.ToString() + "'\n est incorrecte", " Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    t = 1;
                    break;
                }
            }
            return t;
        }
        public void BEnregDepa_Executed(object sender, EventArgs e)
        {          
            depannage d = new depannage();
            QteArticlePrestation q = new QteArticlePrestation();
            const string message = "Voulez-vous vraiment enregister ?";
            const string caption = "Confirmation";
            const string messages = "Enregistrement éffectué.";
            const string captions = "Information";
            int r = tester();
            if (r == 0)
            {
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //int test = 0;
                    //if (this.typeClient.Text == "Professionnel")
                    //{
                    if (this.CnumClient.Text == "")
                    {
                        MessageBox.Show("Veillez sélectionner le type du client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        d.SetNumDep(this.numero.Text);
                        d.SetDatDep(this.dateDebutDepa.Text.ToString());
                        d.SetDiagno(this.TDiagnostic.Text);
                        d.SetNomClient(this.nom.Text);
                        d.SetNumClient(this.CnumClient.Text);
                        d.SetNumEmp(this.employe.Text);
                        d.SetAppareil(this.appareil.Text);
                        d.SetType(this.typeClient.Text);
                        for (int i = 0; i < articleChoisi.Rows.Count - 1; i++)
                        {
                            //DataGridViewRow row = this.articleChoisi.Rows[i];
                            //val = this.articleChoisi.Rows[i].Cells[2].Value.ToString();
                            q.SetQte(double.Parse(articleChoisi.Rows[i].Cells[2].Value.ToString()));
                            q.SetNumPrest(this.numero.Text);
                            q.SetRef(this.articleChoisi.Rows[i].Cells[0].Value.ToString());
                            q.enregPresta(q);
                        }
                        int p = d.enregDepannage(d);
                        if (p == 1)
                        {
                            MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            initialiser();
                            numDepannage();
                        }
                    }
                    //}
                }
                else if (result == DialogResult.No)
                {
                    initialiser();
                    numDepannage();
                }
            }
        }

        public void BAnnulerDepa_Executed(object sender, EventArgs e)
        {
            initialiser();
        }
        public void initialiser()
        {
            this.numero.Text = "";
            this.dateDebutDepa.Text = "";
            this.TDiagnostic.Text = "";
            this.nom.Text = "";
            this.CnumClient.Text = "";
            this.employe.Text = "";
            this.typeClient.Text = "";
            this.articleChoisi.Rows.Clear();
        }

        private void articleChoisi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            const string message = "Cet article va être supprimer de la liste.\n Voulez-vous continuer?";
            const string caption = "Confirmer suppression";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = this.articleChoisi.Rows[e.RowIndex];
                this.articleChoisi.Rows.Remove(row);
            }
        }

        private void CnumClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamp(CnumClient.Text);
        }

        void remplirChamp(string valeur)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM client WHERE numero_client='" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.typeClient.Text = reader.GetString("type_client").ToString();
                    this.nom.Text = reader.GetString("nom_clients").ToString();

                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void chargerNomEmp()
        {
            this.employe.Items.Clear();
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
                    this.employe.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
            //if (this.CnumClient.Text == "")
            //{
            //    this.nom.ReadOnly = false;
            //}
            //else
            //{
            //    this.nom.ReadOnly = false;
            //}
        }

        private void articleChoisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const string message = "Cet article va être supprimer de la liste \n Voulez-vous continuer ?";
            const string caption = "Avertissement";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                
                    DataGridViewRow row = this.articleChoisi.Rows[e.RowIndex];
                    this.articleChoisi.Rows.Remove(row);
                }
            }
        }
    }
}
