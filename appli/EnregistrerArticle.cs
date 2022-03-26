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
    public partial class EnregistrerArticle : DevComponents.DotNetBar.Office2007Form
    {
        public System.Windows.Forms.RichTextBox rtfText;
        
        public EnregistrerArticle()
        {
            InitializeComponent();
            BindDocumentCommands();
            chargerComboxType();

            //CommandFontBold
            this.CommandFontBold.Executed += new System.EventHandler(this.CommandFontBold_Executed);
            this.TDescriptionSommaire.SelectionChanged += new System.EventHandler(this.TextSelectionChanged);
            this.TDescriptionSommaire.TextChanged += new System.EventHandler(this.TDescriptionSommaire_TextChanged);

            //CommmandFontItalic
            this.CommandFontItalic.Executed += new System.EventHandler(this.CommandFontItalic_Executed);
            this.TDescriptionSommaire.SelectionChanged += new System.EventHandler(this.TextSelectionChanged);
            this.TDescriptionSommaire.TextChanged += new System.EventHandler(this.TDescriptionSommaire_TextChanged);

            //Enregistrer
            this.BEnregArticle.Click += new System.EventHandler(this.enregClick_Executed);

            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Executed);
        }

        public void DisableDocMenuItems()
        {
        }
        public void FormDeactivated()
        {
            DisableDocMenuItems();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 mdi = this.ParentForm as Form1;
            //mdi.labelPosition.Text = "";
            FormDeactivated();
        }

        private void CommandExecuted()
        {
            UpdateSelectionCommandsState();
        }

        private void CommandFontBold_Executed(object sender, EventArgs e)
        {
            if (TDescriptionSommaire.SelectionFont.Bold)
                TDescriptionSommaire.SelectionFont = new Font(TDescriptionSommaire.SelectionFont, (TDescriptionSommaire.SelectionFont.Style & ~(TDescriptionSommaire.SelectionFont.Style & FontStyle.Bold)));
            else
                TDescriptionSommaire.SelectionFont = new Font(TDescriptionSommaire.SelectionFont, (TDescriptionSommaire.SelectionFont.Style | FontStyle.Bold));
            CommandExecuted();
        }

        private void CommandFontItalic_Executed(object sender, EventArgs e)
        {
            if (TDescriptionSommaire.SelectionFont.Italic)
                TDescriptionSommaire.SelectionFont = new Font(TDescriptionSommaire.SelectionFont, (TDescriptionSommaire.SelectionFont.Style & ~(TDescriptionSommaire.SelectionFont.Style & FontStyle.Italic)));
            else
                TDescriptionSommaire.SelectionFont = new Font(TDescriptionSommaire.SelectionFont, (TDescriptionSommaire.SelectionFont.Style | FontStyle.Italic));
            CommandExecuted();
        }
        private void TextSelectionChanged(object sender, System.EventArgs e)
        {
            UpdateSelectionCommandsState();
        }

        private void UpdateSelectionCommandsState()
        {
            CommandFontBold.Checked = TDescriptionSommaire.SelectionFont.Bold;
            CommandFontItalic.Checked = TDescriptionSommaire.SelectionFont.Italic;

        }
        private void BindDocumentCommands()
        {
            buttonFontBold.Command = this.CommandFontBold;
            buttonFontItalic.Command = this.CommandFontItalic;
        }
        private void TDescriptionSommaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDesignation_TextChanged(object sender, EventArgs e)
        {

        }
        private void enregClick_Executed(object sender, EventArgs e)
        {
            Article art = new Article();
            prix p = new prix();
            const string message = "Voulez-vous vraiment enregister ?";
            const string caption = "Confirmation";
            const string messages = "Enregistrement éffectué.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                art.SetType(this.typeArticle.Text);
                art.SetReference(this.RefArticle.Text);
                art.SetDesignation(this.DesignArticle.Text);
                art.SetDescription(this.TDescriptionSommaire.Text);
                art.SetQuantite(int.Parse(this.QteArticle.Text));

                p.SetPrixRevient(double.Parse(this.PRevienArticle.Text));
                p.SetPrixRecommande(double.Parse(this.PRecomArticle.Text));
                p.SetPrixMinimal(double.Parse(this.PMinArticle.Text));
                p.SetPrixMaximal(double.Parse(this.PMaxArticle.Text));

                int q=art.enregistrerArticle(art);
                int v = p.enregPrix(p, art);
                if (q == 1 && v == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiser();
                    chargerComboxType();
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

        private void chargerComboxType()
        {
            this.typeArticle.Items.Clear();
            ConnexionDB c = new ConnexionDB();
            string query = "Select * from type";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            MySqlDataReader reader;

            try
            {
                c.con.Open();
                reader=cmd.ExecuteReader();

                while (reader.Read())
                {
                    string valeur =reader.GetString("reference");
                    this.typeArticle.Items.Add(valeur);
                }
                reader.Close();
                c.con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void initialiser()
        {
            this.QteArticle.Text = "";
            this.DesignArticle.Text = "";
            this.RefArticle.Text = "";
            this.typeArticle.Text = "";
            this.TDescriptionSommaire.Text = "";
            this.PRevienArticle.Text = "";
            this.PRecomArticle.Text = "";
            this.PMinArticle.Text = "";
            this.PMaxArticle.Text = "";
        }
     }
}