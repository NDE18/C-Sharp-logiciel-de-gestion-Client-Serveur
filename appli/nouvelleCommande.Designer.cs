namespace appli
{
    partial class nouvelleCommande
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
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.numCommande = new DevComponents.DotNetBar.LabelX();
            this.fournisseurCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.numeroDevis = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nouvelCommande = new DevComponents.DotNetBar.ButtonX();
            this.listeArtCom = new DevComponents.DotNetBar.LabelX();
            this.taille = new DevComponents.DotNetBar.LabelX();
            this.Taide = new System.Windows.Forms.TextBox();
            this.ajoutArticle = new DevComponents.DotNetBar.ButtonX();
            this.annulerDevis = new DevComponents.DotNetBar.ButtonX();
            this.enregCommande = new DevComponents.DotNetBar.ButtonX();
            this.BChoixArticle = new DevComponents.DotNetBar.ButtonX();
            this.listeDevis = new System.Windows.Forms.GroupBox();
            this.rechArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.detail = new DevComponents.DotNetBar.LabelX();
            this.listeArticle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.select1 = new DevComponents.DotNetBar.ButtonX();
            this.TRechF = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LFiltrer = new DevComponents.DotNetBar.LabelX();
            this.articleCommande = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDmande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteCom = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.listeArticleMod = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dateCommande = new System.Windows.Forms.DateTimePicker();
            this.devisCommand = new DevComponents.DotNetBar.Command(this.components);
            this.ajoutArtCommand = new DevComponents.DotNetBar.Command(this.components);
            this.enregCommand = new DevComponents.DotNetBar.Command(this.components);
            this.groupBox1.SuspendLayout();
            this.listeDevis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticleMod)).BeginInit();
            this.SuspendLayout();
            // 
            // _designation
            // 
            // 
            // 
            // 
            this._designation.BackgroundStyle.Class = "";
            this._designation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._designation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._designation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._designation.Location = new System.Drawing.Point(8, 177);
            this._designation.Margin = new System.Windows.Forms.Padding(4);
            this._designation.Name = "_designation";
            this._designation.Size = new System.Drawing.Size(132, 34);
            this._designation.TabIndex = 61;
            this._designation.Text = "Fournisseur:";
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
            this.labelX1.Location = new System.Drawing.Point(8, 93);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(73, 34);
            this.labelX1.TabIndex = 62;
            this.labelX1.Text = "Date:";
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
            this.labelX2.Location = new System.Drawing.Point(8, 51);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(132, 34);
            this.labelX2.TabIndex = 63;
            this.labelX2.Text = "Commande N°:";
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
            this.labelX3.Location = new System.Drawing.Point(6, 135);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(143, 34);
            this.labelX3.TabIndex = 64;
            this.labelX3.Text = "Demande dévis N°:";
            // 
            // numCommande
            // 
            // 
            // 
            // 
            this.numCommande.BackgroundStyle.Class = "";
            this.numCommande.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numCommande.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCommande.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numCommande.Location = new System.Drawing.Point(148, 51);
            this.numCommande.Margin = new System.Windows.Forms.Padding(4);
            this.numCommande.Name = "numCommande";
            this.numCommande.Size = new System.Drawing.Size(246, 34);
            this.numCommande.TabIndex = 85;
            this.numCommande.Text = "Numéro commande";
            // 
            // fournisseurCombo
            // 
            this.fournisseurCombo.DisplayMember = "Text";
            this.fournisseurCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fournisseurCombo.FormattingEnabled = true;
            this.fournisseurCombo.ItemHeight = 20;
            this.fournisseurCombo.Location = new System.Drawing.Point(148, 185);
            this.fournisseurCombo.Margin = new System.Windows.Forms.Padding(4);
            this.fournisseurCombo.Name = "fournisseurCombo";
            this.fournisseurCombo.Size = new System.Drawing.Size(202, 26);
            this.fournisseurCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.fournisseurCombo.TabIndex = 87;
            // 
            // numeroDevis
            // 
            this.numeroDevis.DisplayMember = "Text";
            this.numeroDevis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numeroDevis.FormattingEnabled = true;
            this.numeroDevis.ItemHeight = 20;
            this.numeroDevis.Location = new System.Drawing.Point(148, 143);
            this.numeroDevis.Margin = new System.Windows.Forms.Padding(4);
            this.numeroDevis.Name = "numeroDevis";
            this.numeroDevis.Size = new System.Drawing.Size(202, 26);
            this.numeroDevis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.numeroDevis.TabIndex = 89;
            this.numeroDevis.WatermarkFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDevis.WatermarkText = "Numéro du dévis";
            this.numeroDevis.SelectedIndexChanged += new System.EventHandler(this.numeroDevis_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.nouvelCommande);
            this.groupBox1.Controls.Add(this.listeArtCom);
            this.groupBox1.Controls.Add(this.taille);
            this.groupBox1.Controls.Add(this.Taide);
            this.groupBox1.Controls.Add(this.ajoutArticle);
            this.groupBox1.Controls.Add(this.annulerDevis);
            this.groupBox1.Controls.Add(this.enregCommande);
            this.groupBox1.Controls.Add(this.BChoixArticle);
            this.groupBox1.Controls.Add(this.listeDevis);
            this.groupBox1.Controls.Add(this.dateCommande);
            this.groupBox1.Controls.Add(this.numeroDevis);
            this.groupBox1.Controls.Add(this.fournisseurCombo);
            this.groupBox1.Controls.Add(this.numCommande);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1020, 516);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // nouvelCommande
            // 
            this.nouvelCommande.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.nouvelCommande.BackColor = System.Drawing.Color.White;
            this.nouvelCommande.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.nouvelCommande.Location = new System.Drawing.Point(646, 135);
            this.nouvelCommande.Name = "nouvelCommande";
            this.nouvelCommande.Size = new System.Drawing.Size(167, 35);
            this.nouvelCommande.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.nouvelCommande.TabIndex = 125;
            this.nouvelCommande.Text = "Nouvelle commande";
            // 
            // listeArtCom
            // 
            // 
            // 
            // 
            this.listeArtCom.BackgroundStyle.Class = "";
            this.listeArtCom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listeArtCom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeArtCom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listeArtCom.Location = new System.Drawing.Point(450, 27);
            this.listeArtCom.Margin = new System.Windows.Forms.Padding(4);
            this.listeArtCom.Name = "listeArtCom";
            this.listeArtCom.Size = new System.Drawing.Size(246, 34);
            this.listeArtCom.TabIndex = 124;
            this.listeArtCom.Text = "listeArtCom";
            this.listeArtCom.Visible = false;
            // 
            // taille
            // 
            // 
            // 
            // 
            this.taille.BackgroundStyle.Class = "";
            this.taille.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.taille.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taille.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taille.Location = new System.Drawing.Point(424, 74);
            this.taille.Margin = new System.Windows.Forms.Padding(4);
            this.taille.Name = "taille";
            this.taille.Size = new System.Drawing.Size(246, 34);
            this.taille.TabIndex = 123;
            this.taille.Text = "Numéro commande";
            this.taille.Visible = false;
            // 
            // Taide
            // 
            this.Taide.BackColor = System.Drawing.Color.AliceBlue;
            this.Taide.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taide.Location = new System.Drawing.Point(750, 12);
            this.Taide.Multiline = true;
            this.Taide.Name = "Taide";
            this.Taide.ReadOnly = true;
            this.Taide.Size = new System.Drawing.Size(263, 96);
            this.Taide.TabIndex = 122;
            // 
            // ajoutArticle
            // 
            this.ajoutArticle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ajoutArticle.BackColor = System.Drawing.Color.White;
            this.ajoutArticle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ajoutArticle.Location = new System.Drawing.Point(450, 134);
            this.ajoutArticle.Name = "ajoutArticle";
            this.ajoutArticle.Size = new System.Drawing.Size(167, 35);
            this.ajoutArticle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ajoutArticle.TabIndex = 121;
            this.ajoutArticle.Text = "Ajouter article";
            // 
            // annulerDevis
            // 
            this.annulerDevis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.annulerDevis.BackColor = System.Drawing.Color.White;
            this.annulerDevis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.annulerDevis.Location = new System.Drawing.Point(450, 176);
            this.annulerDevis.Name = "annulerDevis";
            this.annulerDevis.Size = new System.Drawing.Size(167, 35);
            this.annulerDevis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.annulerDevis.TabIndex = 120;
            this.annulerDevis.Text = "Annuler";
            // 
            // enregCommande
            // 
            this.enregCommande.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.enregCommande.BackColor = System.Drawing.Color.White;
            this.enregCommande.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.enregCommande.Location = new System.Drawing.Point(646, 176);
            this.enregCommande.Name = "enregCommande";
            this.enregCommande.Size = new System.Drawing.Size(167, 35);
            this.enregCommande.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.enregCommande.TabIndex = 119;
            this.enregCommande.Text = "Enregistrer";
            // 
            // BChoixArticle
            // 
            this.BChoixArticle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BChoixArticle.BackColor = System.Drawing.Color.White;
            this.BChoixArticle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BChoixArticle.Location = new System.Drawing.Point(834, 176);
            this.BChoixArticle.Name = "BChoixArticle";
            this.BChoixArticle.Size = new System.Drawing.Size(167, 35);
            this.BChoixArticle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BChoixArticle.TabIndex = 118;
            this.BChoixArticle.Text = "Choisir les articles";
            // 
            // listeDevis
            // 
            this.listeDevis.Controls.Add(this.rechArticle);
            this.listeDevis.Controls.Add(this.detail);
            this.listeDevis.Controls.Add(this.listeArticle);
            this.listeDevis.Controls.Add(this.select1);
            this.listeDevis.Controls.Add(this.TRechF);
            this.listeDevis.Controls.Add(this.LFiltrer);
            this.listeDevis.Controls.Add(this.articleCommande);
            this.listeDevis.Controls.Add(this.listeArticleMod);
            this.listeDevis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listeDevis.Location = new System.Drawing.Point(8, 223);
            this.listeDevis.Name = "listeDevis";
            this.listeDevis.Size = new System.Drawing.Size(1005, 286);
            this.listeDevis.TabIndex = 117;
            this.listeDevis.TabStop = false;
            this.listeDevis.Text = "Liste de commande";
            // 
            // rechArticle
            // 
            this.rechArticle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.rechArticle.Border.Class = "TextBoxBorder";
            this.rechArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rechArticle.ForeColor = System.Drawing.Color.Black;
            this.rechArticle.Location = new System.Drawing.Point(297, 24);
            this.rechArticle.Name = "rechArticle";
            this.rechArticle.Size = new System.Drawing.Size(178, 26);
            this.rechArticle.TabIndex = 125;
            this.rechArticle.WatermarkText = "Référence article";
            this.rechArticle.TextChanged += new System.EventHandler(this.rechArticle_TextChanged);
            // 
            // detail
            // 
            // 
            // 
            // 
            this.detail.BackgroundStyle.Class = "";
            this.detail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.detail.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.detail.Location = new System.Drawing.Point(526, 17);
            this.detail.Margin = new System.Windows.Forms.Padding(4);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(328, 34);
            this.detail.TabIndex = 124;
            this.detail.Text = "Date:";
            // 
            // listeArticle
            // 
            this.listeArticle.AllowUserToDeleteRows = false;
            this.listeArticle.AllowUserToResizeColumns = false;
            this.listeArticle.AllowUserToResizeRows = false;
            this.listeArticle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listeArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listeArticle.ColumnHeadersHeight = 25;
            this.listeArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeArticle.DefaultCellStyle = dataGridViewCellStyle2;
            this.listeArticle.GridColor = System.Drawing.Color.Black;
            this.listeArticle.Location = new System.Drawing.Point(6, 55);
            this.listeArticle.Name = "listeArticle";
            this.listeArticle.ReadOnly = true;
            this.listeArticle.RowHeadersVisible = false;
            this.listeArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeArticle.Size = new System.Drawing.Size(469, 225);
            this.listeArticle.TabIndex = 122;
            // 
            // select1
            // 
            this.select1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.select1.BackColor = System.Drawing.Color.White;
            this.select1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.select1.Location = new System.Drawing.Point(481, 146);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(36, 35);
            this.select1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.select1.TabIndex = 121;
            this.select1.Text = ">";
            // 
            // TRechF
            // 
            this.TRechF.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TRechF.Border.Class = "TextBoxBorder";
            this.TRechF.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TRechF.ForeColor = System.Drawing.Color.Black;
            this.TRechF.Location = new System.Drawing.Point(297, 25);
            this.TRechF.Name = "TRechF";
            this.TRechF.Size = new System.Drawing.Size(178, 26);
            this.TRechF.TabIndex = 101;
            this.TRechF.WatermarkText = "Numéro de la commande";
            this.TRechF.TextChanged += new System.EventHandler(this.TRechF_TextChanged);
            // 
            // LFiltrer
            // 
            // 
            // 
            // 
            this.LFiltrer.BackgroundStyle.Class = "";
            this.LFiltrer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LFiltrer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFiltrer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LFiltrer.Location = new System.Drawing.Point(140, 24);
            this.LFiltrer.Name = "LFiltrer";
            this.LFiltrer.Size = new System.Drawing.Size(114, 23);
            this.LFiltrer.TabIndex = 93;
            this.LFiltrer.Text = "Filtrer le tableau:";
            // 
            // articleCommande
            // 
            this.articleCommande.AllowUserToDeleteRows = false;
            this.articleCommande.AllowUserToResizeColumns = false;
            this.articleCommande.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.articleCommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.articleCommande.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.articleCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.articleCommande.ColumnHeadersHeight = 50;
            this.articleCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.articleCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.designation,
            this.type,
            this.qteDmande,
            this.qteCom});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articleCommande.DefaultCellStyle = dataGridViewCellStyle5;
            this.articleCommande.GridColor = System.Drawing.Color.Black;
            this.articleCommande.HighlightSelectedColumnHeaders = false;
            this.articleCommande.Location = new System.Drawing.Point(526, 55);
            this.articleCommande.Name = "articleCommande";
            this.articleCommande.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.articleCommande.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.articleCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articleCommande.ShowCellToolTips = false;
            this.articleCommande.Size = new System.Drawing.Size(467, 225);
            this.articleCommande.TabIndex = 115;
            this.articleCommande.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleCommande_CellClick);
            this.articleCommande.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleCommande_CellDoubleClick);
            // 
            // reference
            // 
            this.reference.HeaderText = "Réference";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            this.reference.Width = 125;
            // 
            // designation
            // 
            this.designation.HeaderText = "Désignation";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            this.designation.Width = 150;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 150;
            // 
            // qteDmande
            // 
            this.qteDmande.HeaderText = "Quantité démandée";
            this.qteDmande.Name = "qteDmande";
            this.qteDmande.ReadOnly = true;
            // 
            // qteCom
            // 
            // 
            // 
            // 
            this.qteCom.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.qteCom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.qteCom.HeaderText = "Quantité commandée";
            this.qteCom.Name = "qteCom";
            this.qteCom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // listeArticleMod
            // 
            this.listeArticleMod.AllowUserToDeleteRows = false;
            this.listeArticleMod.AllowUserToResizeColumns = false;
            this.listeArticleMod.AllowUserToResizeRows = false;
            this.listeArticleMod.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listeArticleMod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeArticleMod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.listeArticleMod.ColumnHeadersHeight = 25;
            this.listeArticleMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeArticleMod.DefaultCellStyle = dataGridViewCellStyle8;
            this.listeArticleMod.GridColor = System.Drawing.Color.Black;
            this.listeArticleMod.Location = new System.Drawing.Point(6, 55);
            this.listeArticleMod.Name = "listeArticleMod";
            this.listeArticleMod.ReadOnly = true;
            this.listeArticleMod.RowHeadersVisible = false;
            this.listeArticleMod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeArticleMod.Size = new System.Drawing.Size(469, 225);
            this.listeArticleMod.TabIndex = 84;
            this.listeArticleMod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeArticleMod_CellClick);
            // 
            // dateCommande
            // 
            this.dateCommande.Location = new System.Drawing.Point(148, 106);
            this.dateCommande.Name = "dateCommande";
            this.dateCommande.Size = new System.Drawing.Size(202, 26);
            this.dateCommande.TabIndex = 90;
            // 
            // devisCommand
            // 
            this.devisCommand.Name = "devisCommand";
            // 
            // ajoutArtCommand
            // 
            this.ajoutArtCommand.Name = "ajoutArtCommand";
            // 
            // enregCommand
            // 
            this.enregCommand.Name = "enregCommand";
            // 
            // nouvelleCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1025, 529);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "nouvelleCommande";
            this.Text = "Nouvelle commande";
            this.Load += new System.EventHandler(this.supprimerArticle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.listeDevis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticleMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX _designation;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX numCommande;
        private DevComponents.DotNetBar.Controls.ComboBoxEx fournisseurCombo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx numeroDevis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateCommande;
        private System.Windows.Forms.GroupBox listeDevis;
        private DevComponents.DotNetBar.Controls.TextBoxX TRechF;
        private DevComponents.DotNetBar.LabelX LFiltrer;
        private DevComponents.DotNetBar.Controls.DataGridViewX articleCommande;
        public DevComponents.DotNetBar.Controls.DataGridViewX listeArticleMod;
        public DevComponents.DotNetBar.ButtonX annulerDevis;
        public DevComponents.DotNetBar.ButtonX enregCommande;
        public DevComponents.DotNetBar.ButtonX BChoixArticle;
        private DevComponents.DotNetBar.Command devisCommand;
        public DevComponents.DotNetBar.ButtonX ajoutArticle;
        public System.Windows.Forms.TextBox Taide;
        private DevComponents.DotNetBar.Command ajoutArtCommand;
        public DevComponents.DotNetBar.ButtonX select1;
        public DevComponents.DotNetBar.Controls.DataGridViewX listeArticle;
        private DevComponents.DotNetBar.LabelX taille;
        private DevComponents.DotNetBar.LabelX detail;
        private DevComponents.DotNetBar.LabelX listeArtCom;
        public DevComponents.DotNetBar.ButtonX nouvelCommande;
        private DevComponents.DotNetBar.Controls.TextBoxX rechArticle;
        private DevComponents.DotNetBar.Command enregCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDmande;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn qteCom;

    }
}