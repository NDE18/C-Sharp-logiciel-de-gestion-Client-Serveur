namespace appli
{
    partial class EnregistrerEntree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnregistrerEntree));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listeArticle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantité_commande = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.quantité_livraison = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.dateEntrer = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.numeroFabrication = new System.Windows.Forms.ComboBox();
            this.annuler = new DevComponents.DotNetBar.ButtonX();
            this.BenregLivraison = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.BRechArticle = new System.Windows.Forms.Button();
            this.CRechArticle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ChoixCommand = new DevComponents.DotNetBar.Command(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEntrer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.listeArticle);
            this.groupBox1.Controls.Add(this.dateEntrer);
            this.groupBox1.Controls.Add(this.numeroFabrication);
            this.groupBox1.Controls.Add(this.annuler);
            this.groupBox1.Controls.Add(this.BenregLivraison);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.Controls.Add(this.BRechArticle);
            this.groupBox1.Controls.Add(this.CRechArticle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 486);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrer une nouvelle entrée";
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
            this.listeArticle.Location = new System.Drawing.Point(49, 186);
            this.listeArticle.Name = "listeArticle";
            this.listeArticle.RowHeadersVisible = false;
            this.listeArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeArticle.Size = new System.Drawing.Size(826, 288);
            this.listeArticle.TabIndex = 145;
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
            this.quantité_commande.HeaderText = "Quantité prévue";
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
            this.quantité_livraison.HeaderText = "Quantité entrée";
            this.quantité_livraison.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.quantité_livraison.Name = "quantité_livraison";
            // 
            // dateEntrer
            // 
            // 
            // 
            // 
            this.dateEntrer.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateEntrer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateEntrer.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateEntrer.ButtonDropDown.Visible = true;
            this.dateEntrer.IsPopupCalendarOpen = false;
            this.dateEntrer.Location = new System.Drawing.Point(199, 105);
            // 
            // 
            // 
            this.dateEntrer.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateEntrer.MonthCalendar.BackgroundStyle.Class = "";
            this.dateEntrer.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateEntrer.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateEntrer.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateEntrer.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateEntrer.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateEntrer.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateEntrer.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateEntrer.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateEntrer.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateEntrer.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateEntrer.MonthCalendar.DisplayMonth = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dateEntrer.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateEntrer.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateEntrer.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateEntrer.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateEntrer.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateEntrer.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateEntrer.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateEntrer.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateEntrer.MonthCalendar.TodayButtonVisible = true;
            this.dateEntrer.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateEntrer.Name = "dateEntrer";
            this.dateEntrer.Size = new System.Drawing.Size(216, 26);
            this.dateEntrer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateEntrer.TabIndex = 144;
            // 
            // numeroFabrication
            // 
            this.numeroFabrication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeroFabrication.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroFabrication.FormattingEnabled = true;
            this.numeroFabrication.Location = new System.Drawing.Point(199, 52);
            this.numeroFabrication.Name = "numeroFabrication";
            this.numeroFabrication.Size = new System.Drawing.Size(216, 29);
            this.numeroFabrication.Sorted = true;
            this.numeroFabrication.TabIndex = 143;
            this.numeroFabrication.SelectedIndexChanged += new System.EventHandler(this.numeroFabrication_SelectedIndexChanged);
            // 
            // annuler
            // 
            this.annuler.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.annuler.Location = new System.Drawing.Point(636, 106);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(110, 30);
            this.annuler.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.annuler.TabIndex = 142;
            this.annuler.Text = "Annuler";
            // 
            // BenregLivraison
            // 
            this.BenregLivraison.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BenregLivraison.BackColor = System.Drawing.Color.White;
            this.BenregLivraison.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BenregLivraison.Location = new System.Drawing.Point(765, 106);
            this.BenregLivraison.Name = "BenregLivraison";
            this.BenregLivraison.Size = new System.Drawing.Size(110, 30);
            this.BenregLivraison.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BenregLivraison.TabIndex = 141;
            this.BenregLivraison.Text = "Enregistrer";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(49, 107);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 24);
            this.labelX1.TabIndex = 115;
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
            this._designation.Location = new System.Drawing.Point(49, 57);
            this._designation.Name = "_designation";
            this._designation.Size = new System.Drawing.Size(111, 24);
            this._designation.TabIndex = 114;
            this._designation.Text = "N° fabrication :";
            // 
            // BRechArticle
            // 
            this.BRechArticle.AutoSize = true;
            this.BRechArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRechArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRechArticle.Image = ((System.Drawing.Image)(resources.GetObject("BRechArticle.Image")));
            this.BRechArticle.Location = new System.Drawing.Point(537, 13);
            this.BRechArticle.Name = "BRechArticle";
            this.BRechArticle.Size = new System.Drawing.Size(27, 26);
            this.BRechArticle.TabIndex = 112;
            this.BRechArticle.UseVisualStyleBackColor = true;
            // 
            // CRechArticle
            // 
            this.CRechArticle.DisabledBackColor = System.Drawing.Color.Black;
            this.CRechArticle.DisplayMember = "Text";
            this.CRechArticle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CRechArticle.FormattingEnabled = true;
            this.CRechArticle.ItemHeight = 20;
            this.CRechArticle.Location = new System.Drawing.Point(570, 13);
            this.CRechArticle.Name = "CRechArticle";
            this.CRechArticle.Size = new System.Drawing.Size(206, 26);
            this.CRechArticle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CRechArticle.TabIndex = 113;
            this.CRechArticle.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRechArticle.WatermarkText = "Type, référence ou désignation";
            this.CRechArticle.SelectedIndexChanged += new System.EventHandler(this.CRechArticle_SelectedIndexChanged);
            // 
            // ChoixCommand
            // 
            this.ChoixCommand.Name = "ChoixCommand";
            // 
            // EnregistrerEntree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "EnregistrerEntree";
            this.Text = "Nouvelle entrée";
            this.Load += new System.EventHandler(this.Chargement);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEntrer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CRechArticle;
        private System.Windows.Forms.Button BRechArticle;
        private DevComponents.DotNetBar.Command ChoixCommand;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX _designation;
        public DevComponents.DotNetBar.ButtonX annuler;
        public DevComponents.DotNetBar.ButtonX BenregLivraison;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateEntrer;
        private System.Windows.Forms.ComboBox numeroFabrication;
        public DevComponents.DotNetBar.Controls.DataGridViewX listeArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn quantité_commande;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn quantité_livraison;
    }
}