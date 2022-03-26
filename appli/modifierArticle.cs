using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;

namespace appli
{
    public partial class modifierArticle : DevComponents.DotNetBar.Office2007Form
    {
        public modifierArticle()
        {
            InitializeComponent();
            chargerComboxType();
            chargerComboxType2();
            autoComplete();

            this.BModifierArticle.Click += new System.EventHandler(this.BModifier_Executed);
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Executed);
        }

        public void EditContextMenu()
        {
            bEditPopup.Displayed = false;
            bEditPopup.PopupMenu(Control.MousePosition);
        }
        private void OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            modifierArticle mdi = null;
            mdi.EditContextMenu();
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

        void autoComplete()
        {
            RefArticle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            RefArticle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

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
                    coll.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.RefArticle.AutoCompleteCustomSource = coll;
        }

        private void chargerComboxType2()
        {
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from type";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur = reader.GetString("reference");
                    this.TypeArticle.Items.Add(valeur);
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
            refe.Text = this.RefArticle.Text;
        }
        void remplirChamp(string val)
        {
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT * FROM article AS a, prix AS p WHERE a.reference='"+val+"' AND a.reference=p.reference_prix";
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
                    this.TDescriptionSommaire.Text=reader.GetString("description").ToString();
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
        public void BModifier_Executed(object sender, EventArgs e)
        {
            Article art = new Article();
            prix p = new prix();
            const string message = "Voulez-vous  enregister les modifications ?";
            const string caption = "Confirmation";
            const string messages = "Modification éffectuée.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                art.SetType(this.TypeArticle.Text);
                art.SetReference(this.RefArticle.Text);
                art.SetDesignation(this.DesignArticle.Text);
                art.SetDescription(this.TDescriptionSommaire.Text);
                art.SetQuantite(int.Parse(this.QteArticle.Text));

                p.SetPrixRevient(double.Parse(this.PRevienArticle.Text));
                p.SetPrixRecommande(double.Parse(this.PRecomArticle.Text));
                p.SetPrixMinimal(double.Parse(this.PMinArticle.Text));
                p.SetPrixMaximal(double.Parse(this.PMaxArticle.Text));

                int q = art.modifArticle(art, refe.Text);
                int s = p.modifPrix(p, art, refe.Text);
                if (q == 1 && s == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiser();
                    //this.Refresh();
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