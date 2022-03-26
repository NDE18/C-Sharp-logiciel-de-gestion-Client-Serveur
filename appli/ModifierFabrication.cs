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
    public partial class ModifierFabrication : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        DataTable tab;
        MySqlDataAdapter da;

        public ModifierFabrication()
        {
            InitializeComponent();
            chargerTableau();
            numDepannage();

            this.BEnregDepa.Click += new System.EventHandler(BEnregDepa_Executed);
            this.BAnnulerDepa.Click += new System.EventHandler(BAnnulerDepa_Executed);
        }

        public void chargerTableau()
        {
            this.TArticle.RowHeadersVisible = false;
            this.TArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference,designation,quantite FROM article";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
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

        public void numDepannage()
        {

            ConnexionDB c = new ConnexionDB();
            string query = "Select num_fabrication from fabrication";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("num_fabrication");
                    this.numero.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int verifier()
        {
            int t = 0;
            for (int i = 0; i < tableau.Rows.Count - 1; i++)
            {
                if (double.Parse(tableau.Rows[i].Cells[2].Value.ToString()) < 0)
                {
                    MessageBox.Show("Quantité nécéssaire de l'article '" + tableau.Rows[i].Cells[1].Value.ToString() + "'\n est incorrecte", " Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t = 1;
                    break;
                }
            }
            return t;
        }

        public void BEnregDepa_Executed(object sender, EventArgs e)
        {
            fabrication d =new fabrication();
            QteArticlePrestation q = new QteArticlePrestation();
            //string val = null;
            if (this.numero.Text == "")
            {
                MessageBox.Show("Aucune prestation n'a été sélectionnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int r = verifier();
                if (r == 0)
                {
                    string message = "Voulez-vous modifier l'enregistrement\n\t numéro" + " " + numero.Text + "?";
                    const string caption = "Confirmation";
                    const string messages = "Modification enregistrée.";
                    const string captions = "Information";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        d.SetNumDep(this.numero.Text);
                        d.SetDatDep(this.dateDebutDepa.Text.ToString());
                        d.SetConcep(this.TDiagnostic.Text);
                        d.SetNumEmp(this.employe.Text);
                        d.SetAppareil(this.appareil.Text);
                        d.SetQte(Convert.ToInt16(this.qteAfabriquer.Value));
                        q.SetNumPrest(this.numero.Text);                        
                        q.suppLigne(q);
                        for (int i = 0; i < tableau.Rows.Count - 1; i++)
                        {                          
                                q.SetQte(double.Parse(tableau.Rows[i].Cells[2].Value.ToString()));
                                q.SetRef(this.tableau.Rows[i].Cells[0].Value.ToString());
                                q.enregPresta(q);   
                        }
                        int p = d.modiFabrication(d);
                        if (p == 1)
                        {
                            MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            initialiser();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        initialiser();
                    }
                }
            }
        }

        public void BAnnulerDepa_Executed(object sender, EventArgs e)
        {
            this.Close();
        }

        public void initialiser()
        {
            this.numero.Text = "";
            this.dateDebutDepa.Text = "";
            this.qteAfabriquer.Text = "";
            this.appareil.Text = "";
            this.employe.Text = "";
            this.tableau.Rows.Clear();
        }

        private void numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamp(numero.Text);
            chargerArticlechoisi(numero.Text);
            chargesTableau();
        }

        void remplirChamp(string valeur)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM fabrication WHERE num_fabrication='" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.dateDebutDepa.Text = reader.GetString("date_enregistrer").ToString();
                    //this.typeClient.Text = reader.GetString("designation").ToString();
                    this.dateDebutDepa.Text = reader.GetString("date_enregistrer").ToString();
                    this.qteAfabriquer.Value = reader.GetDecimal("quantite_fabrication");
                    this.appareil.Text = reader.GetString("appareil");
                    this.employe.Text = reader.GetString("num_employe").ToString();
                    this.TDiagnostic.Text = reader.GetString("conception").ToString();
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void chargerArticlechoisi(string v)
        {
            this.TArticle.RowHeadersVisible = false;
            this.TArticle.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT reference_prestation,qte FROM qteprestation WHERE num_prestation='" + v + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            tab = new DataTable();
            da.Fill(tab);
            BindingSource bs = new BindingSource();
            bs.DataSource = tab;
            this.articleChoisi.DataSource = bs;
            this.articleChoisi.Columns[0].HeaderText = "Référence";
            this.articleChoisi.Columns[1].HeaderText = "Quantité nécessaire";
            this.articleChoisi.Columns[0].ReadOnly = true;
            //this.TArticle.Columns.Add(test);
            da.Update(tab);
        }
        public void chargesTableau()
        {
            num.Text = articleChoisi.Rows.Count.ToString();
            double compt = double.Parse(num.Text);
            this.tableau.Rows.Clear();
            for (int i = 0; i < articleChoisi.Rows.Count - 1; i++)
            {
                //DataGridViewRow row = this.articleChoisi.Rows[i];
                //val = this.articleChoisi.Rows[i].Cells[2].Value.ToString();
                i = this.tableau.Rows.Add();
                this.tableau.Rows[i].Cells[0].Value = articleChoisi.Rows[i].Cells[0].Value.ToString();
                this.tableau.Rows[i].Cells[2].Value = articleChoisi.Rows[i].Cells[1].Value.ToString();
                this.tableau.Rows[i].Cells[3].Value = 0;
                for (int j = 0; j < TArticle.Rows.Count - 1; j++)
                {
                    if (articleChoisi.Rows[i].Cells[0].Value.ToString() == TArticle.Rows[j].Cells[0].Value.ToString())
                    {
                        this.tableau.Rows[i].Cells[1].Value = TArticle.Rows[j].Cells[1].Value.ToString();
                        TArticle.ClearSelection();
                        //break;
                    }
                }
            }
            articleChoisi.Rows.Clear();
            num.Text = tableau.Rows.Count.ToString();
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("reference LIKE '%{0}%'", this.TRech.Text);
            this.TArticle.DataSource = dv;
        }

        private void rechArticleChoisi_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(tab);
            dv.RowFilter = String.Format("reference LIKE '%{0}%'", this.rechArticleChoisi.Text);
            this.tableau.DataSource = dv;
        }

        private void TArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int test = 0;

                if (numero.Text != "")
                {
                    DataGridViewRow row = this.TArticle.Rows[e.RowIndex];
                    for (int i = 0; i <= tableau.Rows.Count - 1; i++)
                    {
                        if (row.Cells["reference"].Value == this.tableau.Rows[i].Cells[0].Value)
                        {
                            test = 1;
                            break;
                        }
                    }
                    if (test != 1)
                    {
                        int n = this.tableau.Rows.Add();
                        this.tableau.Rows[n].Cells[0].Value = row.Cells["reference"].Value.ToString();
                        this.tableau.Rows[n].Cells[1].Value = row.Cells["designation"].Value.ToString();
                        this.tableau.Rows[n].Cells[3].Value = 1;
                        this.TArticle.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Cette article a déjà été selectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aucun numéro de depannage n'a été selectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tableau_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            QteArticlePrestation q = new QteArticlePrestation();
            const string message = "Cet article va être supprimer de la liste.\n Voulez-vous continuer?";
            const string caption = "Confirmer suppression";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = this.tableau.Rows[e.RowIndex];
                q.SetRef(row.Cells["reference"].Value.ToString());
                q.suppLigne(q);
                num.Text = (Convert.ToInt16(num.Text) - 1).ToString();
                tableau.Rows.Remove(row);
            }
        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
