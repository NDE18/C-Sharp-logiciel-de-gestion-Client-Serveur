using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace appli
{
    public partial class demandeDevis : DevComponents.DotNetBar.Office2007Form
    {
        public demandeDevis()
        {
            InitializeComponent();

            this.SuspendLayout();
            controleDemandeDevis _FormDevis = new controleDemandeDevis();
            this.Controls.Add(_FormDevis);
            _FormDevis.Location = new Point(0, 0);
            _FormDevis.BringToFront();
            _FormDevis.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            _FormDevis.choisirArticle.Visible = false;
            _FormDevis.enregDevis.Visible = false;
            _FormDevis.annulerDevis.Visible = false;
            _FormDevis.Taide.Visible = false;
            this.ResumeLayout(false);          
        }

        private void demandeDevis_Load(object sender, EventArgs e)
        {

        }
    }
}
