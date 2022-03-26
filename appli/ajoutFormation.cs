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
    public partial class ajoutFormation : DevComponents.DotNetBar.Office2007Form
    {
        DataTable table;
        MySqlDataAdapter da;

        public ajoutFormation()
        {
            InitializeComponent();
            chargerTableau();

            this.enregFormation.Click += new System.EventHandler(this.enregFormation_Executed);
            this.annulerFormation.Click += new System.EventHandler(this.annulerFormation_Executed);
        }

        public void enregFormation_Executed(object sender, EventArgs e)
        {
            formation f= new formation();
            f.SetCode(this.codeFormation.Text);
            f.SetIntitule(this.intituleFormation.Text);
            f.SetDureMin(double.Parse(this.minFormation.Text));
            f.SetDureMax(double.Parse(maxFormation.Text));
            f.SetObjectif(objectFormation.Text);
            const string message = "Voulez-vous vraiment enregister ?";
            const string caption = "Confirmation";
            const string messages = "Enregistrement éffectué.";
            const string captions = "Information";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                int p = f.enregFormation(f);
                if (p == 1)
                {
                    MessageBox.Show(messages, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiser();
                    chargerTableau();
                }
            }
        }

        public void annulerFormation_Executed(object sender, EventArgs e)
        {
            initialiser();
        }

        public void initialiser()
        {
            this.objectFormation.Text = "";
            this.codeFormation.Text = "";
            this.intituleFormation.Text = "";
            this.maxFormation.Text = "";
            this.minFormation.Text = "";
        }

        private void RechT_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("intitule LIKE '%{0}%'", this.RechT.Text);
            this.listeFormation.DataSource = dv;
        }
        public void chargerTableau()
        {
            this.listeFormation.RowHeadersVisible = false;
            this.listeFormation.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT code,intitule,dure_min,dure_max,objectif FROM formation";
            MySqlCommand cmd = new MySqlCommand(query, c.con);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.listeFormation.DataSource = bs;
            this.listeFormation.Columns[0].HeaderText = "Code";
            this.listeFormation.Columns[1].HeaderText = "Intitulé";
            this.listeFormation.Columns[2].HeaderText = "Durée minimal";
            this.listeFormation.Columns[3].HeaderText = "Durée maximal";
            this.listeFormation.Columns[4].HeaderText = "Objectif";
            this.listeFormation.Columns[1].Width = 250;
            this.listeFormation.Columns[4].Width = 300;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }

        private void ajoutFormation_Load(object sender, EventArgs e)
        {

        }
    }
}
