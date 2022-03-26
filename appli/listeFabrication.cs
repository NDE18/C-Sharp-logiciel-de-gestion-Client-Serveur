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
    public partial class listeFabrication : Form
    {
        DataTable table;
        MySqlDataAdapter da = new MySqlDataAdapter();

        public listeFabrication()
        {
            InitializeComponent();
            chargerTableau();
        }

        private void TRech_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = String.Format("appareil LIKE '%{0}%'", this.TRech.Text);
            this.TListePresta.DataSource = dv;
        }
        public void chargerTableau()
        {
            this.TListePresta.RowHeadersVisible = false;
            this.TListePresta.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridViewColumn test = new DataGridViewColumn();
            ConnexionDB c = new ConnexionDB();
            string query = "SELECT num_fabrication, date_enregistrer,appareil,quantite_fabrication, statut_fabrication FROM fabrication ";
            MySqlCommand cmd = new MySqlCommand(query, c.con);

            da.SelectCommand = cmd;

            table = new DataTable();
            da.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            this.TListePresta.DataSource = bs;
            this.TListePresta.Columns[0].HeaderText = "Numero";
            this.TListePresta.Columns[1].HeaderText = "Date d'enregistrement";
            this.TListePresta.Columns[2].HeaderText = "Article à fabriquer";
            this.TListePresta.Columns[3].HeaderText = "Quantité à fabriquer";
            this.TListePresta.Columns[4].HeaderText = "Statut";
            this.TListePresta.Columns[0].Width = 200;
            this.TListePresta.Columns[4].Width = 200;
            this.TListePresta.Columns[1].Width = 200;
            this.TListePresta.Columns[2].Width = 200;
            this.TListePresta.Columns[3].Width = 200;
            //this.TArticle.Columns.Add(test);
            da.Update(table);
        }
    }
}
