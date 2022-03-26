namespace appli
{
    partial class ModifierClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numero = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.TClientEnreg = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.nomClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.prenomClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Rech = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.adresseClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BAnnuler = new System.Windows.Forms.Button();
            this.BModClient = new System.Windows.Forms.Button();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.type = new System.Windows.Forms.ComboBox();
            this.quartier = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TClientEnreg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quartier);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.TClientEnreg);
            this.groupBox1.Controls.Add(this.nomClient);
            this.groupBox1.Controls.Add(this.prenomClient);
            this.groupBox1.Controls.Add(this.Rech);
            this.groupBox1.Controls.Add(this.adresseClient);
            this.groupBox1.Controls.Add(this.telClient);
            this.groupBox1.Controls.Add(this.emailClient);
            this.groupBox1.Controls.Add(this.BAnnuler);
            this.groupBox1.Controls.Add(this.BModClient);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(64, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(893, 488);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier un client";
            // 
            // numero
            // 
            this.numero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.FormattingEnabled = true;
            this.numero.Location = new System.Drawing.Point(124, 38);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(255, 27);
            this.numero.TabIndex = 75;
            this.numero.SelectedIndexChanged += new System.EventHandler(this.numero_SelectedIndexChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(29, 151);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 74;
            this.labelX2.Text = "Type:";
            // 
            // TClientEnreg
            // 
            this.TClientEnreg.AllowUserToDeleteRows = false;
            this.TClientEnreg.AllowUserToResizeColumns = false;
            this.TClientEnreg.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.TClientEnreg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TClientEnreg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TClientEnreg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TClientEnreg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TClientEnreg.ColumnHeadersHeight = 50;
            this.TClientEnreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TClientEnreg.DefaultCellStyle = dataGridViewCellStyle7;
            this.TClientEnreg.GridColor = System.Drawing.Color.Black;
            this.TClientEnreg.HighlightSelectedColumnHeaders = false;
            this.TClientEnreg.Location = new System.Drawing.Point(29, 228);
            this.TClientEnreg.Name = "TClientEnreg";
            this.TClientEnreg.ReadOnly = true;
            this.TClientEnreg.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.TClientEnreg.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.TClientEnreg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TClientEnreg.Size = new System.Drawing.Size(832, 253);
            this.TClientEnreg.TabIndex = 6;
            this.TClientEnreg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TClientEnreg_CellClick);
            this.TClientEnreg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TClientEnreg_CellDoubleClick);
            // 
            // nomClient
            // 
            this.nomClient.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nomClient.Border.Class = "TextBoxBorder";
            this.nomClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nomClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomClient.Location = new System.Drawing.Point(124, 75);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(255, 26);
            this.nomClient.TabIndex = 1;
            // 
            // prenomClient
            // 
            this.prenomClient.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.prenomClient.Border.Class = "TextBoxBorder";
            this.prenomClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prenomClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prenomClient.Location = new System.Drawing.Point(124, 112);
            this.prenomClient.Name = "prenomClient";
            this.prenomClient.Size = new System.Drawing.Size(255, 26);
            this.prenomClient.TabIndex = 2;
            // 
            // Rech
            // 
            this.Rech.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Rech.Border.Class = "TextBoxBorder";
            this.Rech.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Rech.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rech.Location = new System.Drawing.Point(606, 16);
            this.Rech.Name = "Rech";
            this.Rech.Size = new System.Drawing.Size(255, 26);
            this.Rech.TabIndex = 7;
            this.Rech.WatermarkText = "Filtrer le tableau par nom";
            this.Rech.TextChanged += new System.EventHandler(this.Rech_TextChanged);
            // 
            // adresseClient
            // 
            this.adresseClient.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.adresseClient.Border.Class = "TextBoxBorder";
            this.adresseClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.adresseClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adresseClient.Location = new System.Drawing.Point(124, 196);
            this.adresseClient.Name = "adresseClient";
            this.adresseClient.Size = new System.Drawing.Size(255, 26);
            this.adresseClient.TabIndex = 3;
            // 
            // telClient
            // 
            this.telClient.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.telClient.Border.Class = "TextBoxBorder";
            this.telClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.telClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telClient.Location = new System.Drawing.Point(606, 108);
            this.telClient.Name = "telClient";
            this.telClient.Size = new System.Drawing.Size(255, 26);
            this.telClient.TabIndex = 4;
            this.superValidator1.SetValidator1(this.telClient, this.regularExpressionValidator1);
            // 
            // emailClient
            // 
            this.emailClient.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.emailClient.Border.Class = "TextBoxBorder";
            this.emailClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.emailClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailClient.Location = new System.Drawing.Point(606, 148);
            this.emailClient.Name = "emailClient";
            this.emailClient.Size = new System.Drawing.Size(255, 26);
            this.emailClient.TabIndex = 5;
            // 
            // BAnnuler
            // 
            this.BAnnuler.AutoSize = true;
            this.BAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnnuler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnnuler.Location = new System.Drawing.Point(781, 191);
            this.BAnnuler.Name = "BAnnuler";
            this.BAnnuler.Size = new System.Drawing.Size(80, 31);
            this.BAnnuler.TabIndex = 72;
            this.BAnnuler.Text = "Annuler";
            this.BAnnuler.UseVisualStyleBackColor = true;
            // 
            // BModClient
            // 
            this.BModClient.AutoSize = true;
            this.BModClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModClient.Location = new System.Drawing.Point(606, 191);
            this.BModClient.Name = "BModClient";
            this.BModClient.Size = new System.Drawing.Size(86, 31);
            this.BModClient.TabIndex = 71;
            this.BModClient.Text = "Modifier";
            this.BModClient.UseVisualStyleBackColor = true;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX8.Location = new System.Drawing.Point(29, 74);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 8;
            this.labelX8.Text = "Nom:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX7.Location = new System.Drawing.Point(29, 111);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 7;
            this.labelX7.Text = "Prenom:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX6.Location = new System.Drawing.Point(511, 111);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 6;
            this.labelX6.Text = "Tel:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX5.Location = new System.Drawing.Point(29, 195);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "Adresse:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX4.Location = new System.Drawing.Point(511, 151);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "Email:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(29, 37);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Numéro:";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.EmptyValueIsValid = true;
            this.regularExpressionValidator1.ErrorMessage = "Numéro de téléphone incorrect \n(ex: 675849536).";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^\\d{9}$";
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
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Elève",
            "Etudiant",
            "Occasionnel",
            "Professionnel"});
            this.type.Location = new System.Drawing.Point(124, 151);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(255, 27);
            this.type.TabIndex = 76;
            // 
            // quartier
            // 
            this.quartier.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.quartier.Border.Class = "TextBoxBorder";
            this.quartier.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.quartier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quartier.Location = new System.Drawing.Point(606, 71);
            this.quartier.Name = "quartier";
            this.quartier.Size = new System.Drawing.Size(255, 26);
            this.quartier.TabIndex = 77;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(511, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 78;
            this.labelX3.Text = "Quartier:";
            // 
            // ModifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1020, 514);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifierClient";
            this.Text = "Modifier client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TClientEnreg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox numero;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX TClientEnreg;
        private DevComponents.DotNetBar.Controls.TextBoxX nomClient;
        private DevComponents.DotNetBar.Controls.TextBoxX prenomClient;
        private DevComponents.DotNetBar.Controls.TextBoxX Rech;
        private DevComponents.DotNetBar.Controls.TextBoxX adresseClient;
        private DevComponents.DotNetBar.Controls.TextBoxX telClient;
        private DevComponents.DotNetBar.Controls.TextBoxX emailClient;
        private System.Windows.Forms.Button BAnnuler;
        private System.Windows.Forms.Button BModClient;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private System.Windows.Forms.ComboBox type;
        private DevComponents.DotNetBar.Controls.TextBoxX quartier;
        private DevComponents.DotNetBar.LabelX labelX3;

    }
}