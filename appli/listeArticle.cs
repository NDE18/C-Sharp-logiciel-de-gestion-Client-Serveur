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
    public partial class listeArticle : DevComponents.DotNetBar.Office2007Form
    {
        
        public listeArticle()
        {
            InitializeComponent();
            chargerTableau();
        }

        DataTable table;
       
        public void chargerTableau()
        {
            controlListeArticle c = new controlListeArticle();
            this.Controls.Add(c);
            c.BringToFront();
            //this.ResumeLayout(false);
            //this.SuspendLayout();
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {

        }

        private void TListeArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel.Visible = false;
        }
    }
}