namespace appli
{
    partial class entrerLivraison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.annuler = new DevComponents.DotNetBar.ButtonX();
            this.BenregLivraison = new DevComponents.DotNetBar.ButtonX();
            this.listeArticle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantité_commande = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.quantité_livraison = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.numeroCommande = new System.Windows.Forms.ComboBox();
            this.fournisseur = new DevComponents.DotNetBar.LabelX();
            this.statutCommande = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dateCommande = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.commandEnregLivraison = new DevComponents.DotNetBar.Command(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.annuler);
            this.groupBox1.Controls.Add(this.BenregLivraison);
            this.groupBox1.Controls.Add(this.listeArticle);
            this.groupBox1.Controls.Add(this.numeroCommande);
            this.groupBox1.Controls.Add(this.fournisseur);
            this.groupBox1.Controls.Add(this.statutCommande);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.dateCommande);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 470);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvelle livraison";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // annuler
            // 
            this.annuler.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.annuler.Location = new System.Drawing.Point(624, 184);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(110, 35);
            this.annuler.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.annuler.TabIndex = 140;
            this.annuler.Text = "Annuler";
            // 
            // BenregLivraison
            // 
            this.BenregLivraison.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BenregLivraison.BackColor = System.Drawing.Color.White;
            this.BenregLivraison.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BenregLivraison.Location = new System.Drawing.Point(752, 184);
            this.BenregLivraison.Name = "BenregLivraison";
            this.BenregLivraison.Size = new System.Drawing.Size(110, 35);
            this.BenregLivraison.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BenregLivraison.TabIndex = 139;
            this.BenregLivraison.Text = "Enregistrer";
            // 
            // listeArticle
            // 
            this.listeArticle.AllowUserToDeleteRows = false;
            this.listeArticle.AllowUserToResizeColumns = false;
            this.listeArticle.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.listeArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeArticle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listeArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listeArticle.ColumnHeadersHeight = 50;
            this.listeArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listeArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.designation,
            this.type,
            this.quantité_commande,
            this.quantité_livraison});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeArticle.DefaultCellStyle = dataGridViewCellStyle3;
            this.listeArticle.GridColor = System.Drawing.Color.Black;
            this.listeArticle.Location = new System.Drawing.Point(46, 234);
            this.listeArticle.Name = "listeArticle";
            this.listeArticle.RowHeadersVisible = false;
            this.listeArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeArticle.Size = new System.Drawing.Size(816, 225);
            this.listeArticle.TabIndex = 138;
            // 
            // reference
            // 
            this.reference.HeaderText = "Référence";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            this.reference.Width = 150;
            // 
            // designation
            // 
            this.designation.HeaderText = "Désignation";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            this.designation.Width = 300;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 200;
            // 
            // quantité_commande
            // 
            // 
            // 
            // 
            this.quantité_commande.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.quantité_commande.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.quantité_commande.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.quantité_commande.BackgroundStyle.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantité_commande.HeaderText = "Quantité commandée";
            this.quantité_commande.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.quantité_commande.Name = "quantité_commande";
            this.quantité_commande.ReadOnly = true;
            // 
            // quantité_livraison
            // 
            // 
            // 
            // 
            this.quantité_livraison.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.quantité_livraison.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.quantité_livraison.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.quantité_livraison.BackgroundStyle.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantité_livraison.HeaderText = "Quantité livrée";
            this.quantité_livraison.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.quantité_livraison.Name = "quantité_livraison";
            // 
            // numeroCommande
            // 
            this.numeroCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeroCommande.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroCommande.FormattingEnabled = true;
            this.numeroCommande.Location = new System.Drawing.Point(179, 56);
            this.numeroCommande.Name = "numeroCommande";
            this.numeroCommande.Size = new System.Drawing.Size(216, 29);
            this.numeroCommande.Sorted = true;
            this.numeroCommande.TabIndex = 137;
            this.numeroCommande.SelectedIndexChanged += new System.EventHandler(this.numeroCommande_SelectedIndexChanged);
            // 
            // fournisseur
            // 
            // 
            // 
            // 
            this.fournisseur.BackgroundStyle.Class = "";
            this.fournisseur.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fournisseur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fournisseur.Location = new System.Drawing.Point(638, 60);
            this.fournisseur.Name = "fournisseur";
            this.fournisseur.Size = new System.Drawing.Size(200, 23);
            this.fournisseur.TabIndex = 104;
            // 
            // statutCommande
            // 
            // 
            // 
            // 
            this.statutCommande.BackgroundStyle.Class = "";
            this.statutCommande.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.statutCommande.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statutCommande.Location = new System.Drawing.Point(638, 104);
            this.statutCommande.Name = "statutCommande";
            this.statutCommande.Size = new System.Drawing.Size(200, 23);
            this.statutCommande.TabIndex = 103;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(508, 104);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(88, 23);
            this.labelX6.TabIndex = 102;
            this.labelX6.Text = "Statut:";
            // 
            // dateCommande
            // 
            // 
            // 
            // 
            this.dateCommande.BackgroundStyle.Class = "";
            this.dateCommande.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCommande.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCommande.Location = new System.Drawing.Point(179, 104);
            this.dateCommande.Name = "dateCommande";
            this.dateCommande.Size = new System.Drawing.Size(216, 23);
            this.dateCommande.TabIndex = 64;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(49, 57);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(109, 23);
            this.labelX2.TabIndex = 63;
            this.labelX2.Text = "Commande N°:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(49, 104);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 62;
            this.labelX1.Text = "Date:";
            // 
            // _designation
            // 
            // 
            // 
            // 
            this._designation.BackgroundStyle.Class = "";
            this._designation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._designation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._designation.Location = new System.Drawing.Point(508, 60);
            this._designation.Name = "_designation";
            this._designation.Size = new System.Drawing.Size(88, 23);
            this._designation.TabIndex = 61;
            this._designation.Text = "Fournisseur:";
            // 
            // commandEnregLivraison
            // 
            this.commandEnregLivraison.Name = "commandEnregLivraison";
            // 
            // entrerLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "entrerLivraison";
            this.Text = "Entrée en stock";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX fournisseur;
        private DevComponents.DotNetBar.LabelX statutCommande;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX dateCommande;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX _designation;
        private System.Windows.Forms.ComboBox numeroCommande;
        public DevComponents.DotNetBar.Controls.DataGridViewX listeArticle;
        private DevComponents.DotNetBar.Command commandEnregLivraison;
        public DevComponents.DotNetBar.ButtonX annuler;
        public DevComponents.DotNetBar.ButtonX BenregLivraison;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn quantité_commande;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn quantité_livraison;
    }
}