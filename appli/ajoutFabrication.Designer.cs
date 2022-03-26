namespace appli
{
    partial class ajoutFabrication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AutreEntrer = new System.Windows.Forms.GroupBox();
            this.qteAfabriquer = new System.Windows.Forms.NumericUpDown();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.Quantité = new DevComponents.DotNetBar.LabelX();
            this.dateDebutDepa = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Conception = new System.Windows.Forms.GroupBox();
            this.TDiagnostic = new System.Windows.Forms.RichTextBox();
            this.numero = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BAnnulerDepa = new System.Windows.Forms.Button();
            this.BEnregDepa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TRech = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.TArticle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.articleChoisi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.choixRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choixDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choixQteNece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appareil = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.AutreEntrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qteAfabriquer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebutDepa)).BeginInit();
            this.Conception.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleChoisi)).BeginInit();
            this.SuspendLayout();
            // 
            // AutreEntrer
            // 
            this.AutreEntrer.Controls.Add(this.appareil);
            this.AutreEntrer.Controls.Add(this.qteAfabriquer);
            this.AutreEntrer.Controls.Add(this.labelX9);
            this.AutreEntrer.Controls.Add(this.Quantité);
            this.AutreEntrer.Controls.Add(this.dateDebutDepa);
            this.AutreEntrer.Controls.Add(this.Conception);
            this.AutreEntrer.Controls.Add(this.numero);
            this.AutreEntrer.Controls.Add(this.labelX3);
            this.AutreEntrer.Controls.Add(this.labelX1);
            this.AutreEntrer.Controls.Add(this.BAnnulerDepa);
            this.AutreEntrer.Controls.Add(this.BEnregDepa);
            this.AutreEntrer.Controls.Add(this.groupBox2);
            this.AutreEntrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutreEntrer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutreEntrer.Location = new System.Drawing.Point(47, 4);
            this.AutreEntrer.Name = "AutreEntrer";
            this.AutreEntrer.Size = new System.Drawing.Size(917, 509);
            this.AutreEntrer.TabIndex = 115;
            this.AutreEntrer.TabStop = false;
            // 
            // qteAfabriquer
            // 
            this.qteAfabriquer.Location = new System.Drawing.Point(145, 157);
            this.qteAfabriquer.Name = "qteAfabriquer";
            this.qteAfabriquer.Size = new System.Drawing.Size(216, 26);
            this.qteAfabriquer.TabIndex = 140;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX9.Location = new System.Drawing.Point(9, 112);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(137, 23);
            this.labelX9.TabIndex = 138;
            this.labelX9.Text = "Article à fabriquer:";
            // 
            // Quantité
            // 
            // 
            // 
            // 
            this.Quantité.BackgroundStyle.Class = "";
            this.Quantité.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Quantité.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantité.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Quantité.Location = new System.Drawing.Point(6, 156);
            this.Quantité.Name = "Quantité";
            this.Quantité.Size = new System.Drawing.Size(90, 23);
            this.Quantité.TabIndex = 135;
            this.Quantité.Text = "Quantité:";
            // 
            // dateDebutDepa
            // 
            // 
            // 
            // 
            this.dateDebutDepa.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateDebutDepa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDebutDepa.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateDebutDepa.ButtonDropDown.Visible = true;
            this.dateDebutDepa.IsPopupCalendarOpen = false;
            this.dateDebutDepa.Location = new System.Drawing.Point(145, 61);
            // 
            // 
            // 
            this.dateDebutDepa.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateDebutDepa.MonthCalendar.BackgroundStyle.Class = "";
            this.dateDebutDepa.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDebutDepa.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateDebutDepa.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateDebutDepa.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateDebutDepa.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateDebutDepa.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateDebutDepa.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateDebutDepa.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateDebutDepa.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateDebutDepa.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDebutDepa.MonthCalendar.DisplayMonth = new System.DateTime(2015, 8, 1, 0, 0, 0, 0);
            this.dateDebutDepa.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateDebutDepa.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateDebutDepa.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateDebutDepa.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateDebutDepa.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateDebutDepa.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateDebutDepa.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateDebutDepa.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDebutDepa.MonthCalendar.TodayButtonVisible = true;
            this.dateDebutDepa.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateDebutDepa.Name = "dateDebutDepa";
            this.dateDebutDepa.Size = new System.Drawing.Size(216, 26);
            this.dateDebutDepa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateDebutDepa.TabIndex = 131;
            this.dateDebutDepa.Value = new System.DateTime(2015, 10, 23, 20, 41, 18, 0);
            // 
            // Conception
            // 
            this.Conception.Controls.Add(this.TDiagnostic);
            this.Conception.Location = new System.Drawing.Point(10, 189);
            this.Conception.Name = "Conception";
            this.Conception.Size = new System.Drawing.Size(431, 277);
            this.Conception.TabIndex = 129;
            this.Conception.TabStop = false;
            this.Conception.Text = "Conception";
            // 
            // TDiagnostic
            // 
            this.TDiagnostic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDiagnostic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TDiagnostic.Location = new System.Drawing.Point(3, 22);
            this.TDiagnostic.Name = "TDiagnostic";
            this.TDiagnostic.Size = new System.Drawing.Size(425, 252);
            this.TDiagnostic.TabIndex = 115;
            this.TDiagnostic.Text = "";
            // 
            // numero
            // 
            // 
            // 
            // 
            this.numero.BackgroundStyle.Class = "";
            this.numero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(145, 16);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(216, 23);
            this.numero.TabIndex = 124;
            this.numero.Text = "Numero :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(9, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(73, 23);
            this.labelX3.TabIndex = 119;
            this.labelX3.Text = "Date:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(9, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(123, 23);
            this.labelX1.TabIndex = 118;
            this.labelX1.Text = "Numero :";
            // 
            // BAnnulerDepa
            // 
            this.BAnnulerDepa.AutoSize = true;
            this.BAnnulerDepa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnnulerDepa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnnulerDepa.Location = new System.Drawing.Point(332, 472);
            this.BAnnulerDepa.Name = "BAnnulerDepa";
            this.BAnnulerDepa.Size = new System.Drawing.Size(109, 31);
            this.BAnnulerDepa.TabIndex = 111;
            this.BAnnulerDepa.Text = "Annuler";
            this.BAnnulerDepa.UseVisualStyleBackColor = true;
            // 
            // BEnregDepa
            // 
            this.BEnregDepa.AutoSize = true;
            this.BEnregDepa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEnregDepa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEnregDepa.Location = new System.Drawing.Point(202, 472);
            this.BEnregDepa.Name = "BEnregDepa";
            this.BEnregDepa.Size = new System.Drawing.Size(109, 31);
            this.BEnregDepa.TabIndex = 110;
            this.BEnregDepa.Text = "Enregistrer";
            this.BEnregDepa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TRech);
            this.groupBox2.Controls.Add(this.labelX8);
            this.groupBox2.Controls.Add(this.labelX7);
            this.groupBox2.Controls.Add(this.TArticle);
            this.groupBox2.Controls.Add(this.articleChoisi);
            this.groupBox2.Location = new System.Drawing.Point(447, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 490);
            this.groupBox2.TabIndex = 130;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choix des articles pour fabrication";
            // 
            // TRech
            // 
            this.TRech.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TRech.Border.Class = "TextBoxBorder";
            this.TRech.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TRech.ForeColor = System.Drawing.Color.Black;
            this.TRech.Location = new System.Drawing.Point(243, 21);
            this.TRech.Name = "TRech";
            this.TRech.Size = new System.Drawing.Size(216, 26);
            this.TRech.TabIndex = 125;
            this.TRech.WatermarkText = "reference";
            this.TRech.TextChanged += new System.EventHandler(this.TRech_TextChanged);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX8.Location = new System.Drawing.Point(6, 258);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(137, 23);
            this.labelX8.TabIndex = 124;
            this.labelX8.Text = "Articles choisis";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX7.Location = new System.Drawing.Point(6, 25);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(137, 23);
            this.labelX7.TabIndex = 123;
            this.labelX7.Text = "Liste des articles";
            // 
            // TArticle
            // 
            this.TArticle.AllowUserToResizeColumns = false;
            this.TArticle.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.TArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TArticle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TArticle.ColumnHeadersHeight = 50;
            this.TArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TArticle.DefaultCellStyle = dataGridViewCellStyle3;
            this.TArticle.GridColor = System.Drawing.Color.Black;
            this.TArticle.HighlightSelectedColumnHeaders = false;
            this.TArticle.Location = new System.Drawing.Point(11, 54);
            this.TArticle.Name = "TArticle";
            this.TArticle.ReadOnly = true;
            this.TArticle.RowHeadersVisible = false;
            this.TArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TArticle.Size = new System.Drawing.Size(453, 199);
            this.TArticle.TabIndex = 108;
            this.TArticle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TArticle_CellDoubleClick);
            // 
            // articleChoisi
            // 
            this.articleChoisi.AllowUserToDeleteRows = false;
            this.articleChoisi.AllowUserToResizeColumns = false;
            this.articleChoisi.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.articleChoisi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.articleChoisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.articleChoisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articleChoisi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.articleChoisi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleChoisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.articleChoisi.ColumnHeadersHeight = 50;
            this.articleChoisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.articleChoisi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choixRef,
            this.choixDesignation,
            this.choixQteNece});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articleChoisi.DefaultCellStyle = dataGridViewCellStyle6;
            this.articleChoisi.GridColor = System.Drawing.Color.Black;
            this.articleChoisi.HighlightSelectedColumnHeaders = false;
            this.articleChoisi.Location = new System.Drawing.Point(6, 281);
            this.articleChoisi.Name = "articleChoisi";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleChoisi.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.articleChoisi.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.articleChoisi.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.articleChoisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articleChoisi.Size = new System.Drawing.Size(453, 203);
            this.articleChoisi.TabIndex = 114;
            this.articleChoisi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleChoisi_CellDoubleClick);
            // 
            // choixRef
            // 
            this.choixRef.FillWeight = 153F;
            this.choixRef.HeaderText = "Référence";
            this.choixRef.Name = "choixRef";
            this.choixRef.ReadOnly = true;
            // 
            // choixDesignation
            // 
            this.choixDesignation.HeaderText = "Désignation";
            this.choixDesignation.Name = "choixDesignation";
            this.choixDesignation.ReadOnly = true;
            // 
            // choixQteNece
            // 
            this.choixQteNece.FillWeight = 50F;
            this.choixQteNece.HeaderText = "Quantité nécéssaire";
            this.choixQteNece.Name = "choixQteNece";
            // 
            // appareil
            // 
            this.appareil.DisabledBackColor = System.Drawing.Color.Black;
            this.appareil.DisplayMember = "Text";
            this.appareil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.appareil.FormattingEnabled = true;
            this.appareil.ItemHeight = 20;
            this.appareil.Location = new System.Drawing.Point(145, 112);
            this.appareil.Name = "appareil";
            this.appareil.Size = new System.Drawing.Size(216, 26);
            this.appareil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.appareil.TabIndex = 145;
            this.appareil.WatermarkFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appareil.WatermarkText = "Référence";
            // 
            // ajoutFabrication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 516);
            this.Controls.Add(this.AutreEntrer);
            this.DoubleBuffered = true;
            this.Name = "ajoutFabrication";
            this.Text = "ajoutFabrication";
            this.AutreEntrer.ResumeLayout(false);
            this.AutreEntrer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qteAfabriquer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebutDepa)).EndInit();
            this.Conception.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleChoisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AutreEntrer;
        private System.Windows.Forms.NumericUpDown qteAfabriquer;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX Quantité;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateDebutDepa;
        private System.Windows.Forms.GroupBox Conception;
        private System.Windows.Forms.RichTextBox TDiagnostic;
        private DevComponents.DotNetBar.LabelX numero;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button BAnnulerDepa;
        private System.Windows.Forms.Button BEnregDepa;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX TRech;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.DataGridViewX TArticle;
        private DevComponents.DotNetBar.Controls.DataGridViewX articleChoisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn choixRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn choixDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn choixQteNece;
        private DevComponents.DotNetBar.Controls.ComboBoxEx appareil;
    }
}