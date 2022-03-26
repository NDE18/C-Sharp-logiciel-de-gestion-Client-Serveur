namespace appli
{
    partial class modifierCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifierCommande));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CStatut = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.CRechArticle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BRechArticle = new System.Windows.Forms.Button();
            this.CNumDevis = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.numeroCommande = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.fournisseurCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dateCommande = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.listeArticleMod = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_de_vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BChoixArticle = new System.Windows.Forms.Button();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticleMod)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.CStatut);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.CRechArticle);
            this.groupBox1.Controls.Add(this.BRechArticle);
            this.groupBox1.Controls.Add(this.CNumDevis);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.numeroCommande);
            this.groupBox1.Controls.Add(this.fournisseurCombo);
            this.groupBox1.Controls.Add(this.dateCommande);
            this.groupBox1.Controls.Add(this.listeArticleMod);
            this.groupBox1.Controls.Add(this.BChoixArticle);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 470);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier commande";
            // 
            // CStatut
            // 
            this.CStatut.DisplayMember = "Text";
            this.CStatut.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CStatut.FormattingEnabled = true;
            this.CStatut.ItemHeight = 20;
            this.CStatut.Location = new System.Drawing.Point(166, 194);
            this.CStatut.Name = "CStatut";
            this.CStatut.Size = new System.Drawing.Size(200, 26);
            this.CStatut.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CStatut.TabIndex = 104;
            this.CStatut.WatermarkFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(36, 197);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(88, 23);
            this.labelX6.TabIndex = 102;
            this.labelX6.Text = "Statut:";
            // 
            // CRechArticle
            // 
            this.CRechArticle.DisabledBackColor = System.Drawing.Color.Black;
            this.CRechArticle.DisplayMember = "Text";
            this.CRechArticle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CRechArticle.FormattingEnabled = true;
            this.CRechArticle.ItemHeight = 20;
            this.CRechArticle.Location = new System.Drawing.Point(534, 19);
            this.CRechArticle.Name = "CRechArticle";
            this.CRechArticle.Size = new System.Drawing.Size(206, 26);
            this.CRechArticle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CRechArticle.TabIndex = 101;
            this.CRechArticle.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRechArticle.WatermarkText = "Entrer le numéro de la commande";
            // 
            // BRechArticle
            // 
            this.BRechArticle.AutoSize = true;
            this.BRechArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRechArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRechArticle.Image = ((System.Drawing.Image)(resources.GetObject("BRechArticle.Image")));
            this.BRechArticle.Location = new System.Drawing.Point(508, 19);
            this.BRechArticle.Name = "BRechArticle";
            this.BRechArticle.Size = new System.Drawing.Size(27, 26);
            this.BRechArticle.TabIndex = 100;
            this.BRechArticle.UseVisualStyleBackColor = true;
            // 
            // CNumDevis
            // 
            this.CNumDevis.DisplayMember = "Text";
            this.CNumDevis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CNumDevis.FormattingEnabled = true;
            this.CNumDevis.ItemHeight = 20;
            this.CNumDevis.Location = new System.Drawing.Point(166, 132);
            this.CNumDevis.Name = "CNumDevis";
            this.CNumDevis.Size = new System.Drawing.Size(200, 26);
            this.CNumDevis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CNumDevis.TabIndex = 94;
            this.CNumDevis.WatermarkFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNumDevis.WatermarkText = "Numéro du dévis";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(419, 19);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(83, 23);
            this.labelX4.TabIndex = 93;
            this.labelX4.Text = "Rechercher:";
            // 
            // numeroCommande
            // 
            this.numeroCommande.DisplayMember = "Text";
            this.numeroCommande.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numeroCommande.FormattingEnabled = true;
            this.numeroCommande.ItemHeight = 20;
            this.numeroCommande.Location = new System.Drawing.Point(166, 57);
            this.numeroCommande.Name = "numeroCommande";
            this.numeroCommande.Size = new System.Drawing.Size(200, 26);
            this.numeroCommande.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.numeroCommande.TabIndex = 89;
            this.numeroCommande.WatermarkFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroCommande.WatermarkText = "Numéro du dévis";
            // 
            // fournisseurCombo
            // 
            this.fournisseurCombo.DisplayMember = "Text";
            this.fournisseurCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fournisseurCombo.FormattingEnabled = true;
            this.fournisseurCombo.ItemHeight = 20;
            this.fournisseurCombo.Location = new System.Drawing.Point(166, 162);
            this.fournisseurCombo.Name = "fournisseurCombo";
            this.fournisseurCombo.Size = new System.Drawing.Size(200, 26);
            this.fournisseurCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.fournisseurCombo.TabIndex = 87;
            // 
            // dateCommande
            // 
            // 
            // 
            // 
            this.dateCommande.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateCommande.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCommande.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateCommande.ButtonDropDown.Visible = true;
            this.dateCommande.IsPopupCalendarOpen = false;
            this.dateCommande.Location = new System.Drawing.Point(166, 96);
            // 
            // 
            // 
            this.dateCommande.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateCommande.MonthCalendar.BackgroundStyle.Class = "";
            this.dateCommande.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCommande.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateCommande.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateCommande.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateCommande.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateCommande.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateCommande.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateCommande.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateCommande.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateCommande.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCommande.MonthCalendar.DisplayMonth = new System.DateTime(2015, 8, 1, 0, 0, 0, 0);
            this.dateCommande.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateCommande.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateCommande.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateCommande.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateCommande.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateCommande.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateCommande.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateCommande.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCommande.MonthCalendar.TodayButtonVisible = true;
            this.dateCommande.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateCommande.Name = "dateCommande";
            this.dateCommande.Size = new System.Drawing.Size(200, 26);
            this.dateCommande.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateCommande.TabIndex = 86;
            this.dateCommande.Value = new System.DateTime(2015, 8, 17, 12, 57, 35, 0);
            // 
            // listeArticleMod
            // 
            this.listeArticleMod.AllowUserToDeleteRows = false;
            this.listeArticleMod.AllowUserToResizeColumns = false;
            this.listeArticleMod.AllowUserToResizeRows = false;
            this.listeArticleMod.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listeArticleMod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeArticleMod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listeArticleMod.ColumnHeadersHeight = 25;
            this.listeArticleMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listeArticleMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Designation,
            this.Type,
            this.Prix_de_vente,
            this.Detail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeArticleMod.DefaultCellStyle = dataGridViewCellStyle2;
            this.listeArticleMod.GridColor = System.Drawing.Color.Black;
            this.listeArticleMod.Location = new System.Drawing.Point(36, 232);
            this.listeArticleMod.Name = "listeArticleMod";
            this.listeArticleMod.ReadOnly = true;
            this.listeArticleMod.RowHeadersVisible = false;
            this.listeArticleMod.Size = new System.Drawing.Size(810, 232);
            this.listeArticleMod.TabIndex = 84;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Numéro commande";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 150;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Date";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            this.Designation.Width = 152;
            // 
            // Type
            // 
            this.Type.HeaderText = "Statut";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // Prix_de_vente
            // 
            this.Prix_de_vente.HeaderText = "Fournisseur";
            this.Prix_de_vente.Name = "Prix_de_vente";
            this.Prix_de_vente.ReadOnly = true;
            this.Prix_de_vente.Width = 150;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Détail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // BChoixArticle
            // 
            this.BChoixArticle.AutoSize = true;
            this.BChoixArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BChoixArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BChoixArticle.Location = new System.Drawing.Point(526, 189);
            this.BChoixArticle.Name = "BChoixArticle";
            this.BChoixArticle.Size = new System.Drawing.Size(214, 31);
            this.BChoixArticle.TabIndex = 68;
            this.BChoixArticle.Text = "Modifier les articles";
            this.BChoixArticle.UseVisualStyleBackColor = true;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(36, 129);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(135, 23);
            this.labelX3.TabIndex = 64;
            this.labelX3.Text = "Demande dévis N°:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(36, 57);
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
            this.labelX1.Location = new System.Drawing.Point(36, 93);
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
            this._designation.Location = new System.Drawing.Point(36, 165);
            this._designation.Name = "_designation";
            this._designation.Size = new System.Drawing.Size(88, 23);
            this._designation.TabIndex = 61;
            this._designation.Text = "Fournisseur:";
            // 
            // modifierCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "modifierCommande";
            this.Text = "Modifier commande";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticleMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CNumDevis;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx numeroCommande;
        private DevComponents.DotNetBar.Controls.ComboBoxEx fournisseurCombo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateCommande;
        private DevComponents.DotNetBar.Controls.DataGridViewX listeArticleMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_de_vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.Button BChoixArticle;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX _designation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CStatut;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CRechArticle;
        private System.Windows.Forms.Button BRechArticle;
    }
}