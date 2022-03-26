using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appli
{
    public partial class detailArticle : DevComponents.DotNetBar.Controls.SlidePanel
    {
        listeArticle l = new listeArticle();
        public detailArticle()
        {
            InitializeComponent();
            //this.BAnnuler.Command = l.detail;
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Executed);

            this.retourChoix.Click += new System.EventHandler(this.retourChoix_Executed);
        }

        public void BAnnuler_Executed(object sender, EventArgs e)
        {
            controlListeArticle c = new controlListeArticle();
            this.SlideOutButtonVisible = true;
            this.Controls.Add(c);
            c.BringToFront();
            //c.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            //l.ResumeLayout(false);
        }

        public void retourChoix_Executed(object sender, EventArgs e)
        {
            controleDemandeDevis _FormDevis = new controleDemandeDevis();
            this.Controls.Add(_FormDevis);
            _FormDevis.Location = new Point(0, 0);
            _FormDevis.BringToFront();
            _FormDevis.listeArticleMod.Visible = false;
            _FormDevis.enregDevis.Visible = true;
           // _FormDevis.enregDevis.Location = new Point(844, 128);
            _FormDevis.BChoixArticle.Visible = false;
            _FormDevis.choisirArticle.Visible = true;
            _FormDevis.listeArticleMod.Visible = false;
            _FormDevis.enregDevis.Visible = true;
            _FormDevis.annulerDevis.Visible = true;
            _FormDevis.annulerDevis.Location = new Point(844, 128);
            _FormDevis.BChoixArticle.Visible = false;
        }
    }
}
