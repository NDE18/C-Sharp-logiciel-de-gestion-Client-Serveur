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
    public partial class retirerCours : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public retirerCours()
        {
            InitializeComponent();
            numeroEnseignant();
            chargerTableau();

            this.TRechF.Visible = true;
            this.enseignant.Visible = false;

            this.retirer.Click += new System.EventHandler(this.retirer_Executed);
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Executed);
        }

        public void retirer_Executed(object sender, EventArgs e)
        {
            if (numEnseignant.Text == "")
            {
                MessageBox.Show("Erreur\n veillez sélectionner\n le numero l'enseignant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (codeFormation.Text == "")
            {
                MessageBox.Show("Erreur\n veillez sélectionner\n le code de la formation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                attribuer_cours a = new attribuer_cours();
                string message = "Voulez-vous retirer le cours " + intituleFormation.Text + "\n à l'enseignant " + nomEnseignant.Text + " " + prenomEnseignant.Text + " ?";
                const string caption = "Confirmation";
                const string messages = "Opération éffectuée.";
                const string captions = "Information";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    a.SetNumero(this.numEnseignant.Text);
                    a.SetCode(this.codeFormation.Text);

                    int p = a.retirerCours(a);
                    if (p == 1)
                    {
                        MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chargerTableau();
                        initialiser();
                    }
                }
                else if (result == DialogResult.No)
                {
                    initialiser();
                }
            }
        }

        public void initialiser()
        {
            this.nomEnseignant.Text = "";
            this.prenomEnseignant.Text = "";
            this.professionEnseignant.Text = "";
            this.telEnseignant.Text = "";
            this.numEnseignant.Text = "";
            this.codeFormation.Text = "";
            this.intituleFormation.Text = "";
            this.TRechF.Visible = false;
            this.enseignant.Visible = false;
        }

        public void BAnnuler_Executed(object sender, EventArgs e)
        {
            initialiser();
        }

        private void codeFormation_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChampFormation(codeFormation.Text);
        }

        public void chargerTableau()
        {
            this.listeEnseignant.RowHeadersVisible = false;
            this.listeEnseignant.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT numero,nom,prenom,profession,telephone,code_formation,intitule,date_attribution FROM enseignant INNER JOIN attribuer_cours ON (numero=numero_enseignant) INNER JOIN formation ON (code_formation=code) ORDER BY date_attribution DESC";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.listeEnseignant.DataSource = bs;
            this.listeEnseignant.Columns[0].HeaderText = "Numéro";
            this.listeEnseignant.Columns[1].HeaderText = "Noms";
            this.listeEnseignant.Columns[2].HeaderText = "Prenom";
            this.listeEnseignant.Columns[3].HeaderText = "Profession";
            this.listeEnseignant.Columns[4].HeaderText = "N° de téléphone";
            this.listeEnseignant.Columns[5].HeaderText = "Code formation";
            this.listeEnseignant.Columns[6].HeaderText = "Intitulé formation";
            //this.listeEnseignant.Columns[7].HeaderText = "CNI";
            this.listeEnseignant.Columns[1].Width = 200;
            this.listeEnseignant.Columns[2].Width = 200;
            this.listeEnseignant.Columns[3].Width = 150;
            this.listeEnseignant.Columns[4].Width = 200;
            this.listeEnseignant.Columns[5].Width = 200;
            this.listeEnseignant.Columns[6].Width = 200;
            //this.listeEnseignant.Columns[7].Width = 200;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        private void numEnseignant_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamp(numEnseignant.Text);
            numFormation(numEnseignant.Text);
        }

        void remplirChamp(string valeur)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM enseignant WHERE numero ='" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.nomEnseignant.Text = reader.GetString("nom");
                    this.prenomEnseignant.Text = reader.GetString("prenom");
                    this.professionEnseignant.Text = reader.GetString("profession");
                    this.telEnseignant.Text = reader.GetString("telephone");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void numFormation(string val)
        {
            this.codeFormation.Items.Clear();
            ConnexionDB c = new ConnexionDB();
            string query = "Select code_formation from attribuer_cours Where numero_enseignant = '" + val + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("code_formation");
                    this.codeFormation.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void remplirChampFormation(string valeur)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM formation WHERE code='" + valeur + "'";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.intituleFormation.Text = reader.GetString("intitule");
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtrer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtrer.Text == "Formation")
            {
                this.TRechF.Visible = true;
                this.enseignant.Visible = false;
            }
            else if (filtrer.Text == "Enseignant")
            {
                this.TRechF.Visible = false;
                this.enseignant.Visible = true;
                this.enseignant.Location = new Point(760, 18);
            }
        }

        public void numeroEnseignant()
        {
            this.numEnseignant.Items.Clear();
            ConnexionDB c = new ConnexionDB();
            string query = "Select numero FROM enseignant";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("numero");
                    this.numEnseignant.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TRechF_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("intitule LIKE '%{0}%'", this.TRechF.Text);
            this.listeEnseignant.DataSource = dv;
        }

        private void enseignant_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("nom LIKE '%{0}%'", this.enseignant.Text);
            this.listeEnseignant.DataSource = dv;
        }
    }
}
