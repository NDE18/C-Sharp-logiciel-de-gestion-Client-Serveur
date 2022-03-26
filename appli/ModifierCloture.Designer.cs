namespace appli
{
    partial class ModifierCloture
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.articleDemande = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteNecessaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteUtiliser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixMinimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixMaximal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixRecommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtePrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numEmploye = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.dureePrestation = new DevComponents.Editors.DoubleInput();
            this.dateFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateDebut = new DevComponents.DotNetBar.LabelX();
            this.typeClient = new DevComponents.DotNetBar.LabelX();
            this.client = new DevComponents.DotNetBar.LabelX();
            this.numDepa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.montant = new DevComponents.DotNetBar.LabelX();
            this.auteur = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.prixMainDoeuvre = new DevComponents.Editors.DoubleInput();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.BAnnulerCloture = new System.Windows.Forms.Button();
            this.BModifierCloture = new System.Windows.Forms.Button();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleDemande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dureePrestation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixMainDoeuvre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.numEmploye);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.dureePrestation);
            this.groupBox1.Controls.Add(this.dateFin);
            this.groupBox1.Controls.Add(this.dateDebut);
            this.groupBox1.Controls.Add(this.typeClient);
            this.groupBox1.Controls.Add(this.client);
            this.groupBox1.Controls.Add(this.numDepa);
            this.groupBox1.Controls.Add(this.montant);
            this.groupBox1.Controls.Add(this.auteur);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.prixMainDoeuvre);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.BAnnulerCloture);
            this.groupBox1.Controls.Add(this.BModifierCloture);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 470);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.articleDemande);
            this.groupBox2.Location = new System.Drawing.Point(10, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 216);
            this.groupBox2.TabIndex = 144;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articles";
            // 
            // articleDemande
            // 
            this.articleDemande.AllowUserToDeleteRows = false;
            this.articleDemande.AllowUserToResizeColumns = false;
            this.articleDemande.AllowUserToResizeRows = false;
            this.articleDemande.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.articleDemande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleDemande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articleDemande.ColumnHeadersHeight = 50;
            this.articleDemande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.articleDemande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.designation,
            this.type,
            this.qteNecessaire,
            this.qteUtiliser,
            this.prixMinimal,
            this.prixMaximal,
            this.prixRecommande,
            this.qtePrix});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articleDemande.DefaultCellStyle = dataGridViewCellStyle2;
            this.articleDemande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articleDemande.GridColor = System.Drawing.Color.Black;
            this.articleDemande.Location = new System.Drawing.Point(3, 22);
            this.articleDemande.Name = "articleDemande";
            this.articleDemande.ReadOnly = true;
            this.articleDemande.RowHeadersVisible = false;
            this.articleDemande.Size = new System.Drawing.Size(895, 191);
            this.articleDemande.TabIndex = 119;
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
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // qteNecessaire
            // 
            this.qteNecessaire.HeaderText = "Quantité nécéssaire";
            this.qteNecessaire.Name = "qteNecessaire";
            this.qteNecessaire.ReadOnly = true;
            this.qteNecessaire.Width = 90;
            // 
            // qteUtiliser
            // 
            this.qteUtiliser.HeaderText = "Quantité utilisée";
            this.qteUtiliser.Name = "qteUtiliser";
            this.qteUtiliser.ReadOnly = true;
            this.qteUtiliser.Width = 60;
            // 
            // prixMinimal
            // 
            this.prixMinimal.HeaderText = "Prix minimal";
            this.prixMinimal.Name = "prixMinimal";
            this.prixMinimal.ReadOnly = true;
            // 
            // prixMaximal
            // 
            this.prixMaximal.HeaderText = "Prix maximal";
            this.prixMaximal.Name = "prixMaximal";
            this.prixMaximal.ReadOnly = true;
            // 
            // prixRecommande
            // 
            this.prixRecommande.HeaderText = "Prix recommandé";
            this.prixRecommande.Name = "prixRecommande";
            this.prixRecommande.ReadOnly = true;
            // 
            // qtePrix
            // 
            this.qtePrix.HeaderText = "Montant";
            this.qtePrix.Name = "qtePrix";
            this.qtePrix.ReadOnly = true;
            // 
            // numEmploye
            // 
            this.numEmploye.DisabledBackColor = System.Drawing.Color.Black;
            this.numEmploye.DisplayMember = "Text";
            this.numEmploye.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numEmploye.FormattingEnabled = true;
            this.numEmploye.ItemHeight = 20;
            this.numEmploye.Location = new System.Drawing.Point(711, 57);
            this.numEmploye.Name = "numEmploye";
            this.numEmploye.Size = new System.Drawing.Size(200, 26);
            this.numEmploye.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.numEmploye.TabIndex = 143;
            this.numEmploye.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEmploye.WatermarkText = "Numéro de l\'employé";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(556, 60);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(133, 23);
            this.labelX10.TabIndex = 142;
            this.labelX10.Text = "Réalisée par:";
            // 
            // dureePrestation
            // 
            // 
            // 
            // 
            this.dureePrestation.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dureePrestation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dureePrestation.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dureePrestation.Increment = 1D;
            this.dureePrestation.Location = new System.Drawing.Point(711, 97);
            this.dureePrestation.Name = "dureePrestation";
            this.dureePrestation.ShowUpDown = true;
            this.dureePrestation.Size = new System.Drawing.Size(200, 26);
            this.dureePrestation.TabIndex = 141;
            // 
            // dateFin
            // 
            // 
            // 
            // 
            this.dateFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateFin.ButtonDropDown.Visible = true;
            this.dateFin.IsPopupCalendarOpen = false;
            this.dateFin.Location = new System.Drawing.Point(711, 16);
            // 
            // 
            // 
            this.dateFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFin.MonthCalendar.BackgroundStyle.Class = "";
            this.dateFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateFin.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFin.MonthCalendar.DisplayMonth = new System.DateTime(2015, 8, 1, 0, 0, 0, 0);
            this.dateFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateFin.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFin.MonthCalendar.TodayButtonVisible = true;
            this.dateFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(200, 26);
            this.dateFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateFin.TabIndex = 139;
            // 
            // dateDebut
            // 
            // 
            // 
            // 
            this.dateDebut.BackgroundStyle.Class = "";
            this.dateDebut.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDebut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.Location = new System.Drawing.Point(165, 171);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(200, 23);
            this.dateDebut.TabIndex = 138;
            this.dateDebut.Text = "dateDebut";
            // 
            // typeClient
            // 
            // 
            // 
            // 
            this.typeClient.BackgroundStyle.Class = "";
            this.typeClient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.typeClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeClient.Location = new System.Drawing.Point(165, 133);
            this.typeClient.Name = "typeClient";
            this.typeClient.Size = new System.Drawing.Size(139, 23);
            this.typeClient.TabIndex = 137;
            this.typeClient.Text = "type client";
            // 
            // client
            // 
            // 
            // 
            // 
            this.client.BackgroundStyle.Class = "";
            this.client.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.client.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.Location = new System.Drawing.Point(165, 95);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(249, 23);
            this.client.TabIndex = 136;
            this.client.Text = "client";
            // 
            // numDepa
            // 
            this.numDepa.DisabledBackColor = System.Drawing.Color.Black;
            this.numDepa.DisplayMember = "Text";
            this.numDepa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numDepa.FormattingEnabled = true;
            this.numDepa.ItemHeight = 20;
            this.numDepa.Location = new System.Drawing.Point(165, 16);
            this.numDepa.Name = "numDepa";
            this.numDepa.Size = new System.Drawing.Size(200, 26);
            this.numDepa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.numDepa.TabIndex = 135;
            this.numDepa.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDepa.WatermarkText = "Numéro";
            this.numDepa.SelectedIndexChanged += new System.EventHandler(this.numDepa_SelectedIndexChanged);
            // 
            // montant
            // 
            // 
            // 
            // 
            this.montant.BackgroundStyle.Class = "";
            this.montant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.montant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant.Location = new System.Drawing.Point(711, 170);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(200, 23);
            this.montant.TabIndex = 98;
            this.montant.Text = "montant";
            // 
            // auteur
            // 
            // 
            // 
            // 
            this.auteur.BackgroundStyle.Class = "";
            this.auteur.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.auteur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteur.Location = new System.Drawing.Point(165, 58);
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(139, 23);
            this.auteur.TabIndex = 97;
            this.auteur.Text = "auteur";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(556, 170);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(139, 23);
            this.labelX7.TabIndex = 96;
            this.labelX7.Text = "Coût total:";
            // 
            // prixMainDoeuvre
            // 
            // 
            // 
            // 
            this.prixMainDoeuvre.BackgroundStyle.Class = "DateTimeInputBackground";
            this.prixMainDoeuvre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prixMainDoeuvre.ButtonFreeText.Checked = true;
            this.prixMainDoeuvre.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.prixMainDoeuvre.FreeTextEntryMode = true;
            this.prixMainDoeuvre.Increment = 0.01D;
            this.prixMainDoeuvre.Location = new System.Drawing.Point(711, 135);
            this.prixMainDoeuvre.LockUpdateChecked = false;
            this.prixMainDoeuvre.MaxValue = 100D;
            this.prixMainDoeuvre.MinValue = 0D;
            this.prixMainDoeuvre.Name = "prixMainDoeuvre";
            this.prixMainDoeuvre.ShowUpDown = true;
            this.prixMainDoeuvre.Size = new System.Drawing.Size(200, 26);
            this.prixMainDoeuvre.TabIndex = 94;
            this.prixMainDoeuvre.WatermarkText = "prix en F CFA";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(556, 132);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(162, 23);
            this.labelX9.TabIndex = 90;
            this.labelX9.Text = "Main d\'oeuvre (/heure):";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(556, 19);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(133, 23);
            this.labelX8.TabIndex = 89;
            this.labelX8.Text = "Date de fin:";
            // 
            // BAnnulerCloture
            // 
            this.BAnnulerCloture.AutoSize = true;
            this.BAnnulerCloture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnnulerCloture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnnulerCloture.Location = new System.Drawing.Point(821, 433);
            this.BAnnulerCloture.Name = "BAnnulerCloture";
            this.BAnnulerCloture.Size = new System.Drawing.Size(91, 31);
            this.BAnnulerCloture.TabIndex = 70;
            this.BAnnulerCloture.Text = "Annuler";
            this.BAnnulerCloture.UseVisualStyleBackColor = true;
            // 
            // BModifierCloture
            // 
            this.BModifierCloture.AutoSize = true;
            this.BModifierCloture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModifierCloture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModifierCloture.Location = new System.Drawing.Point(729, 433);
            this.BModifierCloture.Name = "BModifierCloture";
            this.BModifierCloture.Size = new System.Drawing.Size(86, 31);
            this.BModifierCloture.TabIndex = 69;
            this.BModifierCloture.Text = "Modifier";
            this.BModifierCloture.UseVisualStyleBackColor = true;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(556, 94);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(139, 23);
            this.labelX6.TabIndex = 67;
            this.labelX6.Text = "Durée (en heure):";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(10, 171);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(101, 23);
            this.labelX4.TabIndex = 65;
            this.labelX4.Text = "Date de début:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(10, 133);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(101, 23);
            this.labelX3.TabIndex = 64;
            this.labelX3.Text = "Type du client:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(10, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(133, 23);
            this.labelX2.TabIndex = 63;
            this.labelX2.Text = "Numero prestation:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(10, 57);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 62;
            this.labelX1.Text = "Auteur:";
            // 
            // _designation
            // 
            // 
            // 
            // 
            this._designation.BackgroundStyle.Class = "";
            this._designation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._designation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._designation.Location = new System.Drawing.Point(10, 95);
            this._designation.Name = "_designation";
            this._designation.Size = new System.Drawing.Size(88, 23);
            this._designation.TabIndex = 61;
            this._designation.Text = "Client:";
            // 
            // ModifierCloture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 514);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "ModifierCloture";
            this.Text = "Modifier ";
            this.Load += new System.EventHandler(this.ModifierCloture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articleDemande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dureePrestation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixMainDoeuvre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX articleDemande;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteNecessaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteUtiliser;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixMinimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixMaximal;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixRecommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtePrix;
        private DevComponents.DotNetBar.Controls.ComboBoxEx numEmploye;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.Editors.DoubleInput dureePrestation;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateFin;
        private DevComponents.DotNetBar.LabelX dateDebut;
        private DevComponents.DotNetBar.LabelX typeClient;
        private DevComponents.DotNetBar.LabelX client;
        private DevComponents.DotNetBar.Controls.ComboBoxEx numDepa;
        private DevComponents.DotNetBar.LabelX montant;
        private DevComponents.DotNetBar.LabelX auteur;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.DoubleInput prixMainDoeuvre;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.Button BAnnulerCloture;
        private System.Windows.Forms.Button BModifierCloture;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX _designation;
    }
}