namespace appli
{
    partial class AjoutDepannage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutDepannage));
            this.AutreEntrer = new System.Windows.Forms.GroupBox();
            this.appareil = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.CnumClient = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.typeClient = new System.Windows.Forms.ComboBox();
            this.nom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.employe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dateDebutDepa = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TDiagnostic = new System.Windows.Forms.RichTextBox();
            this.numero = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
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
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.CommandFontBold = new DevComponents.DotNetBar.Command(this.components);
            this.CommandFontItalic = new DevComponents.DotNetBar.Command(this.components);
            this.CommandFontUnderline = new DevComponents.DotNetBar.Command(this.components);
            this.AutreEntrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebutDepa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleChoisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AutreEntrer
            // 
            this.AutreEntrer.Controls.Add(this.appareil);
            this.AutreEntrer.Controls.Add(this.labelX9);
            this.AutreEntrer.Controls.Add(this.CnumClient);
            this.AutreEntrer.Controls.Add(this.typeClient);
            this.AutreEntrer.Controls.Add(this.nom);
            this.AutreEntrer.Controls.Add(this.employe);
            this.AutreEntrer.Controls.Add(this.labelX5);
            this.AutreEntrer.Controls.Add(this.dateDebutDepa);
            this.AutreEntrer.Controls.Add(this.groupBox1);
            this.AutreEntrer.Controls.Add(this.numero);
            this.AutreEntrer.Controls.Add(this.labelX6);
            this.AutreEntrer.Controls.Add(this.labelX4);
            this.AutreEntrer.Controls.Add(this.labelX3);
            this.AutreEntrer.Controls.Add(this.labelX1);
            this.AutreEntrer.Controls.Add(this.labelX2);
            this.AutreEntrer.Controls.Add(this.BAnnulerDepa);
            this.AutreEntrer.Controls.Add(this.BEnregDepa);
            this.AutreEntrer.Controls.Add(this.groupBox2);
            this.AutreEntrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutreEntrer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutreEntrer.Location = new System.Drawing.Point(50, -5);
            this.AutreEntrer.Name = "AutreEntrer";
            this.AutreEntrer.Size = new System.Drawing.Size(917, 509);
            this.AutreEntrer.TabIndex = 114;
            this.AutreEntrer.TabStop = false;
            // 
            // appareil
            // 
            this.appareil.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.appareil.Border.Class = "TextBoxBorder";
            this.appareil.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.appareil.ForeColor = System.Drawing.Color.Black;
            this.appareil.Location = new System.Drawing.Point(145, 224);
            this.appareil.Name = "appareil";
            this.appareil.Size = new System.Drawing.Size(216, 26);
            this.appareil.TabIndex = 139;
            this.superValidator1.SetValidator1(this.appareil, this.requiredFieldValidator3);
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
            this.labelX9.Location = new System.Drawing.Point(9, 227);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(137, 23);
            this.labelX9.TabIndex = 138;
            this.labelX9.Text = "Appareil à dépanner:";
            // 
            // CnumClient
            // 
            this.CnumClient.DisabledBackColor = System.Drawing.Color.Black;
            this.CnumClient.DisplayMember = "Text";
            this.CnumClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CnumClient.FormattingEnabled = true;
            this.CnumClient.ItemHeight = 20;
            this.CnumClient.Location = new System.Drawing.Point(145, 84);
            this.CnumClient.Name = "CnumClient";
            this.CnumClient.Size = new System.Drawing.Size(216, 26);
            this.CnumClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CnumClient.TabIndex = 137;
            this.CnumClient.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnumClient.SelectedIndexChanged += new System.EventHandler(this.CnumClient_SelectedIndexChanged);
            // 
            // typeClient
            // 
            this.typeClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeClient.FormattingEnabled = true;
            this.typeClient.Items.AddRange(new object[] {
            "Elève",
            "Etudiant",
            "Occasionnel",
            "Professionnel"});
            this.typeClient.Location = new System.Drawing.Point(145, 148);
            this.typeClient.Name = "typeClient";
            this.typeClient.Size = new System.Drawing.Size(216, 29);
            this.typeClient.Sorted = true;
            this.typeClient.TabIndex = 125;
            this.typeClient.SelectedIndexChanged += new System.EventHandler(this.typeClient_SelectedIndexChanged_1);
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nom.Border.Class = "TextBoxBorder";
            this.nom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nom.ForeColor = System.Drawing.Color.Black;
            this.nom.Location = new System.Drawing.Point(145, 116);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(216, 26);
            this.nom.TabIndex = 134;
            this.superValidator1.SetValidator1(this.nom, this.requiredFieldValidator3);
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // employe
            // 
            this.employe.DisabledBackColor = System.Drawing.Color.Black;
            this.employe.DisplayMember = "Text";
            this.employe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.employe.FormattingEnabled = true;
            this.employe.ItemHeight = 20;
            this.employe.Location = new System.Drawing.Point(145, 186);
            this.employe.Name = "employe";
            this.employe.Size = new System.Drawing.Size(216, 26);
            this.employe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.employe.TabIndex = 132;
            this.employe.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employe.WatermarkText = "nom et prenom";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX5.Location = new System.Drawing.Point(6, 155);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(90, 23);
            this.labelX5.TabIndex = 135;
            this.labelX5.Text = "Type client:";
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
            this.dateDebutDepa.Location = new System.Drawing.Point(145, 45);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TDiagnostic);
            this.groupBox1.Location = new System.Drawing.Point(10, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 200);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnostic";
            // 
            // TDiagnostic
            // 
            this.TDiagnostic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDiagnostic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TDiagnostic.Location = new System.Drawing.Point(3, 22);
            this.TDiagnostic.Name = "TDiagnostic";
            this.TDiagnostic.Size = new System.Drawing.Size(425, 175);
            this.TDiagnostic.TabIndex = 115;
            this.TDiagnostic.Text = "";
            this.superValidator1.SetValidator1(this.TDiagnostic, this.requiredFieldValidator2);
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
            this.numero.Click += new System.EventHandler(this.numero_Click);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX6.Location = new System.Drawing.Point(9, 189);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(90, 23);
            this.labelX6.TabIndex = 123;
            this.labelX6.Text = "Employé:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX4.Location = new System.Drawing.Point(6, 120);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(137, 23);
            this.labelX4.TabIndex = 120;
            this.labelX4.Text = "Nom client:";
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
            this.labelX3.Location = new System.Drawing.Point(9, 48);
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
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(6, 87);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 117;
            this.labelX2.Text = "Numéro client:";
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
            this.groupBox2.Text = "Choix des articles pour le dépannage";
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
            this.TArticle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TArticle_CellContentClick);
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
            this.articleChoisi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleChoisi_CellContentClick);
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
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // CommandFontBold
            // 
            this.CommandFontBold.Name = "CommandFontBold";
            // 
            // CommandFontItalic
            // 
            this.CommandFontItalic.Name = "CommandFontItalic";
            // 
            // CommandFontUnderline
            // 
            this.CommandFontUnderline.Name = "CommandFontUnderline";
            // 
            // AjoutDepannage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 516);
            this.Controls.Add(this.AutreEntrer);
            this.DoubleBuffered = true;
            this.Name = "AjoutDepannage";
            this.Text = "Nouveau dépannage";
            this.Load += new System.EventHandler(this.AjoutDepannage_Load);
            this.AutreEntrer.ResumeLayout(false);
            this.AutreEntrer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebutDepa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleChoisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AutreEntrer;
        private DevComponents.DotNetBar.LabelX numero;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.RichTextBox TDiagnostic;
        private DevComponents.DotNetBar.Controls.DataGridViewX articleChoisi;
        private System.Windows.Forms.Button BAnnulerDepa;
        private System.Windows.Forms.Button BEnregDepa;
        private DevComponents.DotNetBar.Controls.DataGridViewX TArticle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateDebutDepa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx employe;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX nom;
        private System.Windows.Forms.ComboBox typeClient;
        private DevComponents.DotNetBar.Controls.TextBoxX TRech;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn choixRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn choixDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn choixQteNece;
        private DevComponents.DotNetBar.Command CommandFontBold;
        private DevComponents.DotNetBar.Command CommandFontItalic;
        private DevComponents.DotNetBar.Command CommandFontUnderline;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CnumClient;
        private DevComponents.DotNetBar.Controls.TextBoxX appareil;
        private DevComponents.DotNetBar.LabelX labelX9;
    }
}