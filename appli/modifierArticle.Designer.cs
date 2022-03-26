namespace appli
{
    partial class modifierArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifierArticle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PRevienArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.DesignArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.QteArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PRecomArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PMinArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PMaxArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TDescriptionSommaire = new System.Windows.Forms.RichTextBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonFontBold = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFontItalic = new DevComponents.DotNetBar.ButtonItem();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.bEditPopup = new DevComponents.DotNetBar.ButtonItem();
            this.Modifier = new DevComponents.DotNetBar.ButtonItem();
            this.TypeArticle = new System.Windows.Forms.ComboBox();
            this.RefArticle = new System.Windows.Forms.ComboBox();
            this.BAnnuler = new System.Windows.Forms.Button();
            this.BModifierArticle = new System.Windows.Forms.Button();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Valeur incorrecte.");
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.refe = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refe);
            this.groupBox1.Controls.Add(this.PRevienArticle);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.DesignArticle);
            this.groupBox1.Controls.Add(this.QteArticle);
            this.groupBox1.Controls.Add(this.PRecomArticle);
            this.groupBox1.Controls.Add(this.PMinArticle);
            this.groupBox1.Controls.Add(this.PMaxArticle);
            this.groupBox1.Controls.Add(this.TDescriptionSommaire);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.ribbonBar1);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.contextMenuBar1);
            this.groupBox1.Controls.Add(this.TypeArticle);
            this.groupBox1.Controls.Add(this.RefArticle);
            this.groupBox1.Controls.Add(this.BAnnuler);
            this.groupBox1.Controls.Add(this.BModifierArticle);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 480);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier article";
            // 
            // PRevienArticle
            // 
            // 
            // 
            // 
            this.PRevienArticle.Border.Class = "TextBoxBorder";
            this.PRevienArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PRevienArticle.Location = new System.Drawing.Point(149, 242);
            this.PRevienArticle.Name = "PRevienArticle";
            this.PRevienArticle.Size = new System.Drawing.Size(216, 26);
            this.PRevienArticle.TabIndex = 115;
            this.superValidator1.SetValidator1(this.PRevienArticle, this.regularExpressionValidator1);
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
            this.labelX4.Location = new System.Drawing.Point(6, 245);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(139, 23);
            this.labelX4.TabIndex = 114;
            this.labelX4.Text = "Prix de revient(f cfa):";
            // 
            // DesignArticle
            // 
            // 
            // 
            // 
            this.DesignArticle.Border.Class = "TextBoxBorder";
            this.DesignArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DesignArticle.Location = new System.Drawing.Point(149, 108);
            this.DesignArticle.Name = "DesignArticle";
            this.DesignArticle.Size = new System.Drawing.Size(216, 26);
            this.DesignArticle.TabIndex = 113;
            this.superValidator1.SetValidator1(this.DesignArticle, this.requiredFieldValidator1);
            // 
            // QteArticle
            // 
            // 
            // 
            // 
            this.QteArticle.Border.Class = "TextBoxBorder";
            this.QteArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.QteArticle.Location = new System.Drawing.Point(149, 196);
            this.QteArticle.Name = "QteArticle";
            this.QteArticle.Size = new System.Drawing.Size(216, 26);
            this.QteArticle.TabIndex = 112;
            this.superValidator1.SetValidator1(this.QteArticle, this.regularExpressionValidator2);
            // 
            // PRecomArticle
            // 
            // 
            // 
            // 
            this.PRecomArticle.Border.Class = "TextBoxBorder";
            this.PRecomArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PRecomArticle.Location = new System.Drawing.Point(149, 285);
            this.PRecomArticle.Name = "PRecomArticle";
            this.PRecomArticle.Size = new System.Drawing.Size(216, 26);
            this.PRecomArticle.TabIndex = 111;
            this.superValidator1.SetValidator1(this.PRecomArticle, this.regularExpressionValidator1);
            // 
            // PMinArticle
            // 
            // 
            // 
            // 
            this.PMinArticle.Border.Class = "TextBoxBorder";
            this.PMinArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PMinArticle.Location = new System.Drawing.Point(149, 330);
            this.PMinArticle.Name = "PMinArticle";
            this.PMinArticle.Size = new System.Drawing.Size(216, 26);
            this.PMinArticle.TabIndex = 110;
            this.superValidator1.SetValidator1(this.PMinArticle, this.regularExpressionValidator1);
            // 
            // PMaxArticle
            // 
            // 
            // 
            // 
            this.PMaxArticle.Border.Class = "TextBoxBorder";
            this.PMaxArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PMaxArticle.Location = new System.Drawing.Point(149, 374);
            this.PMaxArticle.Name = "PMaxArticle";
            this.PMaxArticle.Size = new System.Drawing.Size(216, 26);
            this.PMaxArticle.TabIndex = 109;
            this.superValidator1.SetValidator1(this.PMaxArticle, this.regularExpressionValidator1);
            // 
            // TDescriptionSommaire
            // 
            this.TDescriptionSommaire.Location = new System.Drawing.Point(482, 63);
            this.TDescriptionSommaire.Name = "TDescriptionSommaire";
            this.TDescriptionSommaire.Size = new System.Drawing.Size(473, 405);
            this.TDescriptionSommaire.TabIndex = 107;
            this.TDescriptionSommaire.Text = "";
            this.superValidator1.SetValidator1(this.TDescriptionSommaire, this.requiredFieldValidator2);
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
            this.labelX5.Location = new System.Drawing.Point(392, 67);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(153, 23);
            this.labelX5.TabIndex = 105;
            this.labelX5.Text = "Description :";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.ribbonBar1.Location = new System.Drawing.Point(482, 42);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(63, 52);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 106;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.BeginGroup = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFontBold,
            this.buttonFontItalic});
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
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX9.Location = new System.Drawing.Point(6, 373);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(139, 23);
            this.labelX9.TabIndex = 100;
            this.labelX9.Text = "Prix maximal (%):";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX8.Location = new System.Drawing.Point(6, 285);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(148, 23);
            this.labelX8.TabIndex = 99;
            this.labelX8.Text = "Prix recommandé (%):";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX10.Location = new System.Drawing.Point(6, 329);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(139, 23);
            this.labelX10.TabIndex = 98;
            this.labelX10.Text = "Prix minimal (%):";
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bEditPopup});
            this.contextMenuBar1.Location = new System.Drawing.Point(318, 356);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(121, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 84;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // bEditPopup
            // 
            this.bEditPopup.AutoExpandOnClick = true;
            this.bEditPopup.Name = "bEditPopup";
            this.bEditPopup.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bEditPopup.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Modifier});
            this.bEditPopup.Text = "bEditPopup";
            // 
            // Modifier
            // 
            this.Modifier.BeginGroup = true;
            this.Modifier.GlobalName = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            // 
            // TypeArticle
            // 
            this.TypeArticle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeArticle.FormattingEnabled = true;
            this.TypeArticle.Location = new System.Drawing.Point(149, 148);
            this.TypeArticle.Name = "TypeArticle";
            this.TypeArticle.Size = new System.Drawing.Size(216, 29);
            this.TypeArticle.Sorted = true;
            this.TypeArticle.TabIndex = 78;
            // 
            // RefArticle
            // 
            this.RefArticle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefArticle.FormattingEnabled = true;
            this.RefArticle.Location = new System.Drawing.Point(149, 63);
            this.RefArticle.Name = "RefArticle";
            this.RefArticle.Size = new System.Drawing.Size(216, 29);
            this.RefArticle.Sorted = true;
            this.RefArticle.TabIndex = 77;
            this.RefArticle.SelectedIndexChanged += new System.EventHandler(this.RefArticle_SelectedIndexChanged);
            // 
            // BAnnuler
            // 
            this.BAnnuler.AutoSize = true;
            this.BAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnnuler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnnuler.Location = new System.Drawing.Point(297, 433);
            this.BAnnuler.Name = "BAnnuler";
            this.BAnnuler.Size = new System.Drawing.Size(68, 31);
            this.BAnnuler.TabIndex = 70;
            this.BAnnuler.Text = "Annuler";
            this.BAnnuler.UseVisualStyleBackColor = true;
            // 
            // BModifierArticle
            // 
            this.BModifierArticle.AutoSize = true;
            this.BModifierArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModifierArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModifierArticle.Location = new System.Drawing.Point(201, 433);
            this.BModifierArticle.Name = "BModifierArticle";
            this.BModifierArticle.Size = new System.Drawing.Size(73, 31);
            this.BModifierArticle.TabIndex = 69;
            this.BModifierArticle.Text = "Modifier";
            this.BModifierArticle.UseVisualStyleBackColor = true;
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
            this.labelX3.Location = new System.Drawing.Point(6, 195);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 64;
            this.labelX3.Text = "Quantité:";
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
            this.labelX2.Location = new System.Drawing.Point(6, 151);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 63;
            this.labelX2.Text = "Type:";
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
            this.labelX1.Location = new System.Drawing.Point(6, 63);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 62;
            this.labelX1.Text = "Réference:";
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
            this._designation.Location = new System.Drawing.Point(6, 107);
            this._designation.Name = "_designation";
            this._designation.Size = new System.Drawing.Size(88, 23);
            this._designation.TabIndex = 61;
            this._designation.Text = "Désignation:";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Valeur incorrecte.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.EmptyValueIsValid = true;
            this.regularExpressionValidator2.ErrorMessage = "Valeur incorecte.";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^\\d+$";
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.EmptyValueIsValid = true;
            this.regularExpressionValidator1.ErrorMessage = "Valeur incorrecte.";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^[0-9].*$";
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
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // refe
            // 
            // 
            // 
            // 
            this.refe.BackgroundStyle.Class = "";
            this.refe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.refe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refe.Location = new System.Drawing.Point(392, 123);
            this.refe.Name = "refe";
            this.refe.Size = new System.Drawing.Size(75, 23);
            this.refe.TabIndex = 116;
            this.refe.Text = "Réference:";
            this.refe.Visible = false;
            // 
            // modifierArticle
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Name = "modifierArticle";
            this.Text = "Modifier article";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox RefArticle;
        private System.Windows.Forms.Button BAnnuler;
        private System.Windows.Forms.Button BModifierArticle;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX _designation;
        private System.Windows.Forms.ComboBox TypeArticle;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem bEditPopup;
        private DevComponents.DotNetBar.ButtonItem Modifier;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.RichTextBox TDescriptionSommaire;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ButtonItem buttonFontBold;
        private DevComponents.DotNetBar.ButtonItem buttonFontItalic;
        private DevComponents.DotNetBar.Controls.TextBoxX DesignArticle;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX QteArticle;
        private DevComponents.DotNetBar.Controls.TextBoxX PRecomArticle;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX PMinArticle;
        private DevComponents.DotNetBar.Controls.TextBoxX PMaxArticle;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private DevComponents.DotNetBar.Controls.TextBoxX PRevienArticle;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.LabelX refe;
    }
}