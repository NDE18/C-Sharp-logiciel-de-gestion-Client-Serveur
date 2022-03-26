namespace appli
{
    partial class EnregistrerArticle
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnregistrerArticle));
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.buttonFontItalic = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFontBold = new DevComponents.DotNetBar.ButtonItem();
            this.CommandFontBold = new DevComponents.DotNetBar.Command(this.components);
            this.CommandFontItalic = new DevComponents.DotNetBar.Command(this.components);
            this.enregCommand = new DevComponents.DotNetBar.Command(this.components);
            this.superTooltipArticle = new DevComponents.DotNetBar.SuperTooltip();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Valeur incorrecte.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Valeur incorrecte.");
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.BEnregArticle = new System.Windows.Forms.Button();
            this.BAnnuler = new System.Windows.Forms.Button();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.TDescriptionSommaire = new System.Windows.Forms.RichTextBox();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.QteArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PRevienArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DesignArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PMaxArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PMinArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PRecomArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefArticle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.typeArticle = new System.Windows.Forms.ComboBox();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator3 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Valeur incorrecte.");
            this.regularExpressionValidator6 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator5 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator4 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Valeur incorrecte.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Valeur incorrecte.");
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFontItalic
            // 
            this.buttonFontItalic.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontItalic.Image")));
            this.buttonFontItalic.Name = "buttonFontItalic";
            this.buttonFontItalic.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI);
            this.superTooltip1.SetSuperTooltip(this.buttonFontItalic, new DevComponents.DotNetBar.SuperTooltipInfo("Italic (Ctrl+I)", "", "Italicize the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontItalic.Text = "&Italic";
            // 
            // buttonFontBold
            // 
            this.buttonFontBold.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontBold.Image")));
            this.buttonFontBold.Name = "buttonFontBold";
            this.buttonFontBold.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
            this.superTooltip1.SetSuperTooltip(this.buttonFontBold, new DevComponents.DotNetBar.SuperTooltipInfo("Bold (Ctrl+B)", "", "Make selected text bold", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontBold.Text = "&Bold";
            // 
            // CommandFontBold
            // 
            this.CommandFontBold.Name = "CommandFontBold";
            // 
            // CommandFontItalic
            // 
            this.CommandFontItalic.Name = "CommandFontItalic";
            // 
            // enregCommand
            // 
            this.enregCommand.Name = "enregCommand";
            this.enregCommand.Text = "enregCommand";
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.EmptyValueIsValid = true;
            this.regularExpressionValidator1.ErrorMessage = "Valeur incorrecte.";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^[01]?[- .]?(\\([2-9]\\d{2}\\)|[2-9]\\d{2})[- .]?\\d{3}[- .]?\\d{4}$";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Valeur incorrecte.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Valeur incorrecte.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            this._designation.Location = new System.Drawing.Point(6, 141);
            this._designation.Name = "_designation";
            this._designation.Size = new System.Drawing.Size(88, 23);
            this._designation.TabIndex = 61;
            this._designation.Text = "Désignation:";
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
            this.labelX1.Location = new System.Drawing.Point(6, 102);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 62;
            this.labelX1.Text = "Réference:";
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
            this.labelX2.Location = new System.Drawing.Point(6, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 63;
            this.labelX2.Text = "Type:";
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
            this.labelX3.Location = new System.Drawing.Point(6, 180);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 64;
            this.labelX3.Text = "Quantité:";
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
            this.labelX4.Location = new System.Drawing.Point(6, 219);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(101, 23);
            this.labelX4.TabIndex = 65;
            this.labelX4.Text = "Prix de revient:";
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
            this.labelX5.Location = new System.Drawing.Point(392, 63);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(84, 23);
            this.labelX5.TabIndex = 66;
            this.labelX5.Text = "Description :";
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
            this.labelX6.Location = new System.Drawing.Point(6, 297);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(139, 23);
            this.labelX6.TabIndex = 67;
            this.labelX6.Text = "Prix minimal (%):";
            // 
            // BEnregArticle
            // 
            this.BEnregArticle.AutoSize = true;
            this.BEnregArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEnregArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEnregArticle.Location = new System.Drawing.Point(193, 433);
            this.BEnregArticle.Name = "BEnregArticle";
            this.BEnregArticle.Size = new System.Drawing.Size(86, 31);
            this.BEnregArticle.TabIndex = 69;
            this.BEnregArticle.Text = "Enregistrer";
            this.BEnregArticle.UseVisualStyleBackColor = true;
            // 
            // BAnnuler
            // 
            this.BAnnuler.AutoSize = true;
            this.BAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnnuler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnnuler.Location = new System.Drawing.Point(285, 433);
            this.BAnnuler.Name = "BAnnuler";
            this.BAnnuler.Size = new System.Drawing.Size(91, 31);
            this.BAnnuler.TabIndex = 70;
            this.BAnnuler.Text = "Annuler";
            this.BAnnuler.UseVisualStyleBackColor = true;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBarBackground2;
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.ribbonBar1.Location = new System.Drawing.Point(482, 38);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(59, 52);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 86;
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
            // TDescriptionSommaire
            // 
            this.TDescriptionSommaire.Location = new System.Drawing.Point(482, 63);
            this.TDescriptionSommaire.Name = "TDescriptionSommaire";
            this.TDescriptionSommaire.Size = new System.Drawing.Size(473, 405);
            this.TDescriptionSommaire.TabIndex = 87;
            this.TDescriptionSommaire.Text = "";
            this.superValidator1.SetValidator1(this.TDescriptionSommaire, this.requiredFieldValidator6);
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
            this.labelX8.Location = new System.Drawing.Point(6, 258);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(148, 23);
            this.labelX8.TabIndex = 89;
            this.labelX8.Text = "Prix recommandé (%):";
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
            this.labelX9.Location = new System.Drawing.Point(6, 336);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(139, 23);
            this.labelX9.TabIndex = 90;
            this.labelX9.Text = "Prix maximal (%):";
            // 
            // QteArticle
            // 
            this.QteArticle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.QteArticle.Border.Class = "TextBoxBorder";
            this.QteArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.QteArticle.ForeColor = System.Drawing.Color.Black;
            this.QteArticle.Location = new System.Drawing.Point(149, 177);
            this.QteArticle.Name = "QteArticle";
            this.QteArticle.Size = new System.Drawing.Size(216, 26);
            this.QteArticle.TabIndex = 97;
            this.superValidator1.SetValidator1(this.QteArticle, this.regularExpressionValidator2);
            // 
            // PRevienArticle
            // 
            this.PRevienArticle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.PRevienArticle.Border.Class = "TextBoxBorder";
            this.PRevienArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PRevienArticle.ForeColor = System.Drawing.Color.Black;
            this.PRevienArticle.Location = new System.Drawing.Point(149, 216);
            this.PRevienArticle.Name = "PRevienArticle";
            this.PRevienArticle.Size = new System.Drawing.Size(216, 26);
            this.PRevienArticle.TabIndex = 98;
            this.superValidator1.SetValidator1(this.PRevienArticle, this.regularExpressionValidator3);
            // 
            // DesignArticle
            // 
            this.DesignArticle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.DesignArticle.Border.Class = "TextBoxBorder";
            this.DesignArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DesignArticle.ForeColor = System.Drawing.Color.Black;
            this.DesignArticle.Location = new System.Drawing.Point(149, 138);
            this.DesignArticle.Name = "DesignArticle";
            this.DesignArticle.Size = new System.Drawing.Size(216, 26);
            this.DesignArticle.TabIndex = 99;
            this.superValidator1.SetValidator1(this.DesignArticle, this.requiredFieldValidator5);
            // 
            // PMaxArticle
            // 
            this.PMaxArticle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.PMaxArticle.Border.Class = "TextBoxBorder";
            this.PMaxArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PMaxArticle.ForeColor = System.Drawing.Color.Black;
            this.PMaxArticle.Location = new System.Drawing.Point(149, 333);
            this.PMaxArticle.Name = "PMaxArticle";
            this.PMaxArticle.Size = new System.Drawing.Size(216, 26);
            this.PMaxArticle.TabIndex = 100;
            this.superValidator1.SetValidator1(this.PMaxArticle, this.regularExpressionValidator6);
            // 
            // PMinArticle
            // 
            this.PMinArticle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.PMinArticle.Border.Class = "TextBoxBorder";
            this.PMinArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PMinArticle.ForeColor = System.Drawing.Color.Black;
            this.PMinArticle.Location = new System.Drawing.Point(149, 294);
            this.PMinArticle.Name = "PMinArticle";
            this.PMinArticle.Size = new System.Drawing.Size(216, 26);
            this.PMinArticle.TabIndex = 101;
            this.superValidator1.SetValidator1(this.PMinArticle, this.regularExpressionValidator5);
            // 
            // PRecomArticle
            // 
            this.PRecomArticle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.PRecomArticle.Border.Class = "TextBoxBorder";
            this.PRecomArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PRecomArticle.ForeColor = System.Drawing.Color.Black;
            this.PRecomArticle.Location = new System.Drawing.Point(149, 255);
            this.PRecomArticle.Name = "PRecomArticle";
            this.PRecomArticle.Size = new System.Drawing.Size(216, 26);
            this.PRecomArticle.TabIndex = 102;
            this.superValidator1.SetValidator1(this.PRecomArticle, this.regularExpressionValidator4);
            this.PRecomArticle.WatermarkText = "Entrer le pourcentage du prix recommandé";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.PRecomArticle);
            this.groupBox1.Controls.Add(this.PMinArticle);
            this.groupBox1.Controls.Add(this.PMaxArticle);
            this.groupBox1.Controls.Add(this.DesignArticle);
            this.groupBox1.Controls.Add(this.PRevienArticle);
            this.groupBox1.Controls.Add(this.QteArticle);
            this.groupBox1.Controls.Add(this.RefArticle);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.TDescriptionSommaire);
            this.groupBox1.Controls.Add(this.ribbonBar1);
            this.groupBox1.Controls.Add(this.typeArticle);
            this.groupBox1.Controls.Add(this.BAnnuler);
            this.groupBox1.Controls.Add(this.BEnregArticle);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau article";
            // 
            // RefArticle
            // 
            this.RefArticle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.RefArticle.Border.Class = "TextBoxBorder";
            this.RefArticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RefArticle.ForeColor = System.Drawing.Color.Black;
            this.RefArticle.Location = new System.Drawing.Point(149, 103);
            this.RefArticle.Name = "RefArticle";
            this.RefArticle.Size = new System.Drawing.Size(216, 26);
            this.RefArticle.TabIndex = 96;
            this.superValidator1.SetValidator1(this.RefArticle, this.requiredFieldValidator4);
            this.RefArticle.WatermarkText = "reference";
            // 
            // typeArticle
            // 
            this.typeArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeArticle.FormattingEnabled = true;
            this.typeArticle.Location = new System.Drawing.Point(149, 63);
            this.typeArticle.Name = "typeArticle";
            this.typeArticle.Size = new System.Drawing.Size(216, 27);
            this.typeArticle.Sorted = true;
            this.typeArticle.TabIndex = 77;
            this.typeArticle.UseWaitCursor = true;
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.EmptyValueIsValid = true;
            this.regularExpressionValidator2.ErrorMessage = "Valeur incorrecte.";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^\\d+$";
            // 
            // regularExpressionValidator3
            // 
            this.regularExpressionValidator3.EmptyValueIsValid = true;
            this.regularExpressionValidator3.ErrorMessage = "Valeur incorrecte.";
            this.regularExpressionValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator3.ValidationExpression = "^[0-9].*$";
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "Valeur incorrecte.";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator6
            // 
            this.regularExpressionValidator6.EmptyValueIsValid = true;
            this.regularExpressionValidator6.ErrorMessage = "Valeur incorrecte.";
            this.regularExpressionValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator6.ValidationExpression = "^[0-9].*$";
            // 
            // regularExpressionValidator5
            // 
            this.regularExpressionValidator5.EmptyValueIsValid = true;
            this.regularExpressionValidator5.ErrorMessage = "Valeur incorrecte.";
            this.regularExpressionValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator5.ValidationExpression = "^[0-9].*$";
            // 
            // regularExpressionValidator4
            // 
            this.regularExpressionValidator4.EmptyValueIsValid = true;
            this.regularExpressionValidator4.ErrorMessage = "Valeur incorrecte.";
            this.regularExpressionValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator4.ValidationExpression = "^[0-9].*$";
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "Valeur incorrecte.";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Valeur incorrecte.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // EnregistrerArticle
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EnregistrerArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enregistrer article";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Implementation des commandes
            

        #endregion

        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private DevComponents.DotNetBar.Command CommandFontBold;
        private DevComponents.DotNetBar.Command CommandFontItalic;
        private DevComponents.DotNetBar.Command enregCommand;
        private DevComponents.DotNetBar.SuperTooltip superTooltipArticle;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX PRecomArticle;
        private DevComponents.DotNetBar.Controls.TextBoxX PMinArticle;
        private DevComponents.DotNetBar.Controls.TextBoxX PMaxArticle;
        private DevComponents.DotNetBar.Controls.TextBoxX DesignArticle;
        private DevComponents.DotNetBar.Controls.TextBoxX PRevienArticle;
        private DevComponents.DotNetBar.Controls.TextBoxX QteArticle;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.RichTextBox TDescriptionSommaire;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ButtonItem buttonFontBold;
        private DevComponents.DotNetBar.ButtonItem buttonFontItalic;
        private System.Windows.Forms.Button BAnnuler;
        private System.Windows.Forms.Button BEnregArticle;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX _designation;
        private DevComponents.DotNetBar.Controls.TextBoxX RefArticle;
        private System.Windows.Forms.ComboBox typeArticle;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator3;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator4;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator5;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator6;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;






    }
}