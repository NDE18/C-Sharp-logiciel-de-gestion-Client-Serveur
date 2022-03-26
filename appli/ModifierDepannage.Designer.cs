namespace appli
{
    partial class ModifierDepannage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierDepannage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonFontBold = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFontItalic = new DevComponents.DotNetBar.ButtonItem();
            this.AutreEntrer = new System.Windows.Forms.GroupBox();
            this.dateDebutDepa = new DevComponents.DotNetBar.LabelX();
            this.num = new DevComponents.DotNetBar.LabelX();
            this.numero = new System.Windows.Forms.ComboBox();
            this.employe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TDiagnostic = new System.Windows.Forms.RichTextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BAnnulerDepa = new System.Windows.Forms.Button();
            this.BEnregDepa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechArticleChoisi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TRech = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.TArticle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.articleChoisi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CommandFontBold = new DevComponents.DotNetBar.Command(this.components);
            this.CommandFontItalic = new DevComponents.DotNetBar.Command(this.components);
            this.CommandFontUnderline = new DevComponents.DotNetBar.Command(this.components);
            this.CnumClient = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.typeClient = new System.Windows.Forms.ComboBox();
            this.nom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.AutreEntrer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleChoisi)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFontBold
            // 
            this.buttonFontBold.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontBold.Image")));
            this.buttonFontBold.Name = "buttonFontBold";
            this.buttonFontBold.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
            this.buttonFontBold.Text = "&Bold";
            // 
            // buttonFontItalic
            // 
            this.buttonFontItalic.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontItalic.Image")));
            this.buttonFontItalic.Name = "buttonFontItalic";
            this.buttonFontItalic.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI);
            this.buttonFontItalic.Text = "&Italic";
            // 
            // AutreEntrer
            // 
            this.AutreEntrer.Controls.Add(this.CnumClient);
            this.AutreEntrer.Controls.Add(this.typeClient);
            this.AutreEntrer.Controls.Add(this.nom);
            this.AutreEntrer.Controls.Add(this.labelX5);
            this.AutreEntrer.Controls.Add(this.labelX4);
            this.AutreEntrer.Controls.Add(this.labelX9);
            this.AutreEntrer.Controls.Add(this.dateDebutDepa);
            this.AutreEntrer.Controls.Add(this.num);
            this.AutreEntrer.Controls.Add(this.numero);
            this.AutreEntrer.Controls.Add(this.employe);
            this.AutreEntrer.Controls.Add(this.groupBox1);
            this.AutreEntrer.Controls.Add(this.labelX6);
            this.AutreEntrer.Controls.Add(this.labelX3);
            this.AutreEntrer.Controls.Add(this.labelX1);
            this.AutreEntrer.Controls.Add(this.BAnnulerDepa);
            this.AutreEntrer.Controls.Add(this.BEnregDepa);
            this.AutreEntrer.Controls.Add(this.groupBox2);
            this.AutreEntrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutreEntrer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutreEntrer.Location = new System.Drawing.Point(46, 12);
            this.AutreEntrer.Name = "AutreEntrer";
            this.AutreEntrer.Size = new System.Drawing.Size(921, 509);
            this.AutreEntrer.TabIndex = 115;
            this.AutreEntrer.TabStop = false;
            // 
            // dateDebutDepa
            // 
            // 
            // 
            // 
            this.dateDebutDepa.BackgroundStyle.Class = "";
            this.dateDebutDepa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDebutDepa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutDepa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateDebutDepa.Location = new System.Drawing.Point(165, 48);
            this.dateDebutDepa.Name = "dateDebutDepa";
            this.dateDebutDepa.Size = new System.Drawing.Size(216, 23);
            this.dateDebutDepa.TabIndex = 139;
            // 
            // num
            // 
            // 
            // 
            // 
            this.num.BackgroundStyle.Class = "";
            this.num.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num.Location = new System.Drawing.Point(374, 138);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(73, 23);
            this.num.TabIndex = 138;
            this.num.Text = "Date:";
            this.num.Visible = false;
            // 
            // numero
            // 
            this.numero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numero.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.FormattingEnabled = true;
            this.numero.Location = new System.Drawing.Point(165, 13);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(216, 29);
            this.numero.Sorted = true;
            this.numero.TabIndex = 136;
            this.numero.SelectedIndexChanged += new System.EventHandler(this.numero_SelectedIndexChanged);
            // 
            // employe
            // 
            this.employe.DisabledBackColor = System.Drawing.Color.Black;
            this.employe.DisplayMember = "Text";
            this.employe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.employe.FormattingEnabled = true;
            this.employe.ItemHeight = 20;
            this.employe.Location = new System.Drawing.Point(165, 186);
            this.employe.Name = "employe";
            this.employe.Size = new System.Drawing.Size(216, 26);
            this.employe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.employe.TabIndex = 132;
            this.employe.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TDiagnostic);
            this.groupBox1.Location = new System.Drawing.Point(10, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 223);
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
            this.TDiagnostic.Size = new System.Drawing.Size(425, 198);
            this.TDiagnostic.TabIndex = 115;
            this.TDiagnostic.Text = "";
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
            this.labelX3.Size = new System.Drawing.Size(150, 23);
            this.labelX3.TabIndex = 119;
            this.labelX3.Text = "Date d\'enregistrement:";
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
            this.BEnregDepa.Text = "Modifier";
            this.BEnregDepa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableau);
            this.groupBox2.Controls.Add(this.rechArticleChoisi);
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
            this.groupBox2.Text = "Choix des article pour le dépannage";
            // 
            // tableau
            // 
            this.tableau.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.designation,
            this.quantite,
            this.ajout});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableau.DefaultCellStyle = dataGridViewCellStyle14;
            this.tableau.Location = new System.Drawing.Point(6, 281);
            this.tableau.Name = "tableau";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableau.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tableau.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.tableau.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.tableau.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tableau.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableau.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tableau.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.tableau.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableau.Size = new System.Drawing.Size(453, 203);
            this.tableau.TabIndex = 116;
            this.tableau.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellDoubleClick);
            // 
            // reference
            // 
            this.reference.HeaderText = "Reference";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            this.reference.Width = 150;
            // 
            // designation
            // 
            this.designation.HeaderText = "Désignation";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            this.designation.Width = 200;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
            // 
            // ajout
            // 
            this.ajout.HeaderText = "ajout";
            this.ajout.Name = "ajout";
            this.ajout.Visible = false;
            // 
            // rechArticleChoisi
            // 
            this.rechArticleChoisi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.rechArticleChoisi.Border.Class = "TextBoxBorder";
            this.rechArticleChoisi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rechArticleChoisi.ForeColor = System.Drawing.Color.Black;
            this.rechArticleChoisi.Location = new System.Drawing.Point(243, 250);
            this.rechArticleChoisi.Name = "rechArticleChoisi";
            this.rechArticleChoisi.Size = new System.Drawing.Size(216, 26);
            this.rechArticleChoisi.TabIndex = 126;
            this.rechArticleChoisi.WatermarkText = "reference";
            this.rechArticleChoisi.TextChanged += new System.EventHandler(this.rechArticleChoisi_TextChanged);
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
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.TArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.TArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TArticle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.TArticle.ColumnHeadersHeight = 50;
            this.TArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TArticle.DefaultCellStyle = dataGridViewCellStyle19;
            this.TArticle.GridColor = System.Drawing.Color.Black;
            this.TArticle.HighlightSelectedColumnHeaders = false;
            this.TArticle.Location = new System.Drawing.Point(6, 50);
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
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.articleChoisi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            this.articleChoisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.articleChoisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articleChoisi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.articleChoisi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleChoisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.articleChoisi.ColumnHeadersHeight = 50;
            this.articleChoisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articleChoisi.DefaultCellStyle = dataGridViewCellStyle22;
            this.articleChoisi.GridColor = System.Drawing.Color.Black;
            this.articleChoisi.HighlightSelectedColumnHeaders = false;
            this.articleChoisi.Location = new System.Drawing.Point(6, 281);
            this.articleChoisi.Name = "articleChoisi";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleChoisi.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.articleChoisi.RowHeadersVisible = false;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.articleChoisi.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.articleChoisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articleChoisi.Size = new System.Drawing.Size(453, 203);
            this.articleChoisi.TabIndex = 114;
            this.articleChoisi.Visible = false;
            this.articleChoisi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleChoisi_CellContentClick);
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
            // CnumClient
            // 
            this.CnumClient.DisabledBackColor = System.Drawing.Color.Black;
            this.CnumClient.DisplayMember = "Text";
            this.CnumClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CnumClient.FormattingEnabled = true;
            this.CnumClient.ItemHeight = 20;
            this.CnumClient.Location = new System.Drawing.Point(165, 74);
            this.CnumClient.Name = "CnumClient";
            this.CnumClient.Size = new System.Drawing.Size(216, 26);
            this.CnumClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CnumClient.TabIndex = 147;
            this.CnumClient.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.typeClient.Location = new System.Drawing.Point(165, 144);
            this.typeClient.Name = "typeClient";
            this.typeClient.Size = new System.Drawing.Size(216, 29);
            this.typeClient.Sorted = true;
            this.typeClient.TabIndex = 143;
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
            this.nom.Location = new System.Drawing.Point(165, 106);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(216, 26);
            this.nom.TabIndex = 145;
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
            this.labelX5.Location = new System.Drawing.Point(9, 145);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(90, 23);
            this.labelX5.TabIndex = 146;
            this.labelX5.Text = "Type client:";
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
            this.labelX4.Location = new System.Drawing.Point(9, 110);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(137, 23);
            this.labelX4.TabIndex = 141;
            this.labelX4.Text = "Nom client:";
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
            this.labelX9.Location = new System.Drawing.Point(9, 77);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(106, 23);
            this.labelX9.TabIndex = 140;
            this.labelX9.Text = "Numéro client:";
            // 
            // ModifierDepannage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 518);
            this.Controls.Add(this.AutreEntrer);
            this.DoubleBuffered = true;
            this.Name = "ModifierDepannage";
            this.Text = "Modifier dépannage";
            this.AutreEntrer.ResumeLayout(false);
            this.AutreEntrer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleChoisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem buttonFontBold;
        private DevComponents.DotNetBar.ButtonItem buttonFontItalic;
        private System.Windows.Forms.GroupBox AutreEntrer;
        private System.Windows.Forms.ComboBox numero;
        private DevComponents.DotNetBar.Controls.ComboBoxEx employe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox TDiagnostic;
        private DevComponents.DotNetBar.LabelX labelX6;
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
        private DevComponents.DotNetBar.Command CommandFontBold;
        private DevComponents.DotNetBar.Command CommandFontItalic;
        private DevComponents.DotNetBar.Command CommandFontUnderline;
        private DevComponents.DotNetBar.Controls.TextBoxX rechArticleChoisi;
        private System.Windows.Forms.DataGridView tableau;
        private DevComponents.DotNetBar.LabelX num;
        private DevComponents.DotNetBar.LabelX dateDebutDepa;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajout;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CnumClient;
        private System.Windows.Forms.ComboBox typeClient;
        private DevComponents.DotNetBar.Controls.TextBoxX nom;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX9;
    }
}