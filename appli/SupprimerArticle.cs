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
    public partial class SupprimerArticle : Form
    {
        public SupprimerArticle()
        {
            InitializeComponent();
            chargerComboxType();

            this.BSupprimerArticle.Click += new System.EventHandler(this.BSupprimerArticle_Executed);
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Executed);
        }

        void remplirChamp(string val)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM article AS a, prix AS p WHERE a.reference='" + val + "' AND a.reference=p.reference_prix";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.QteArticle.Text = reader.GetString("quantite").ToString();
                    this.DesignArticle.Text = reader.GetString("designation").ToString();
                    this.TypeArticle.Text = reader.GetString("type").ToString();
                    this.TDescriptionSommaire.Text = reader.GetString("description").ToString();
                    this.PRevienArticle.Text = reader.GetString("prix_revient").ToString();
                    this.PRecomArticle.Text = reader.GetString("prix_recommande").ToString();
                    this.PMinArticle.Text = reader.GetString("prix_minimal").ToString();
                    this.PMaxArticle.Text = reader.GetString("prix_maximal").ToString();
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chargerComboxType()
        {
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from article";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("reference");
                    this.RefArticle.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamp(this.RefArticle.Text);
        }

        public void BSupprimerArticle_Executed(object sender, EventArgs e)
        {
            Article art = new Article();
            prix p = new prix();
            art.SetReference(this.RefArticle.Text);
            string message = "Voulez-vous  vraiment supprimer l'article "+ RefArticle.Text + "?";
            const string caption = "Confirmation";
            const string messages = "Suppression éffectuée.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int q = art.suppArticle(art);
                int s = p.suppPrix(art);
                if (q == 1 && s == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiser();
                    this.Refresh();
                }
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        public void BAnnuler_Executed(object sender, EventArgs e)
        {
            this.Close();
        }

        public void initialiser()
        {
            this.QteArticle.Text = "";
            this.DesignArticle.Text = "";
            this.RefArticle.Text = "";
            this.TypeArticle.Text = "";
            this.TDescriptionSommaire.Text = "";
            this.PRevienArticle.Text = "";
            this.PRecomArticle.Text = "";
            this.PMinArticle.Text = "";
            this.PMaxArticle.Text = "";
        }
    }
}
