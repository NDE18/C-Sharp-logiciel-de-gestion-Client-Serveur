namespace appli
{
    partial class ajoutEnseignant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutEnseignant));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TRech = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.prenomEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.professionEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.adresseEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cniEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nomEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.listeEnseignant = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.BAnnuler = new System.Windows.Forms.Button();
            this.BEnregEnseignant = new System.Windows.Forms.Button();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.numEnseignant = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Veillez remplir le champ.");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Veillez remplir le champ.");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Veillez remplir le champ.");
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Veillez remplir le champ.");
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Veillez remplir le champ.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.regularExpressionValidator3 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeEnseignant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TRech);
            this.groupBox1.Controls.Add(this.prenomEnseignant);
            this.groupBox1.Controls.Add(this.professionEnseignant);
            this.groupBox1.Controls.Add(this.adresseEnseignant);
            this.groupBox1.Controls.Add(this.telEnseignant);
            this.groupBox1.Controls.Add(this.emailEnseignant);
            this.groupBox1.Controls.Add(this.cniEnseignant);
            this.groupBox1.Controls.Add(this.nomEnseignant);
            this.groupBox1.Controls.Add(this.listeEnseignant);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.BAnnuler);
            this.groupBox1.Controls.Add(this.BEnregEnseignant);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.numEnseignant);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(58, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(902, 479);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau enseignant";
            // 
            // TRech
            // 
            // 
            // 
            // 
            this.TRech.Border.Class = "TextBoxBorder";
            this.TRech.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TRech.Location = new System.Drawing.Point(629, 16);
            this.TRech.Name = "TRech";
            this.TRech.Size = new System.Drawing.Size(255, 26);
            this.TRech.TabIndex = 100;
            this.TRech.WatermarkText = "rechercher par nom";
            this.TRech.TextChanged += new System.EventHandler(this.TRech_TextChanged);
            // 
            // prenomEnseignant
            // 
            // 
            // 
            // 
            this.prenomEnseignant.Border.Class = "TextBoxBorder";
            this.prenomEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prenomEnseignant.Location = new System.Drawing.Point(97, 122);
            this.prenomEnseignant.Name = "prenomEnseignant";
            this.prenomEnseignant.Size = new System.Drawing.Size(255, 26);
            this.prenomEnseignant.TabIndex = 2;
            // 
            // professionEnseignant
            // 
            // 
            // 
            // 
            this.professionEnseignant.Border.Class = "TextBoxBorder";
            this.professionEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.professionEnseignant.Location = new System.Drawing.Point(97, 159);
            this.professionEnseignant.Name = "professionEnseignant";
            this.professionEnseignant.Size = new System.Drawing.Size(255, 26);
            this.professionEnseignant.TabIndex = 3;
            this.superValidator1.SetValidator1(this.professionEnseignant, this.requiredFieldValidator2);
            // 
            // adresseEnseignant
            // 
            // 
            // 
            // 
            this.adresseEnseignant.Border.Class = "TextBoxBorder";
            this.adresseEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.adresseEnseignant.Location = new System.Drawing.Point(97, 195);
            this.adresseEnseignant.Name = "adresseEnseignant";
            this.adresseEnseignant.Size = new System.Drawing.Size(255, 26);
            this.adresseEnseignant.TabIndex = 4;
            // 
            // telEnseignant
            // 
            // 
            // 
            // 
            this.telEnseignant.Border.Class = "TextBoxBorder";
            this.telEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.telEnseignant.Location = new System.Drawing.Point(629, 81);
            this.telEnseignant.Name = "telEnseignant";
            this.telEnseignant.Size = new System.Drawing.Size(255, 26);
            this.telEnseignant.TabIndex = 5;
            this.superValidator1.SetValidator1(this.telEnseignant, this.requiredFieldValidator3);
            this.superValidator1.SetValidator2(this.telEnseignant, this.regularExpressionValidator3);
            // 
            // emailEnseignant
            // 
            // 
            // 
            // 
            this.emailEnseignant.Border.Class = "TextBoxBorder";
            this.emailEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.emailEnseignant.Location = new System.Drawing.Point(629, 118);
            this.emailEnseignant.Name = "emailEnseignant";
            this.emailEnseignant.Size = new System.Drawing.Size(255, 26);
            this.emailEnseignant.TabIndex = 6;
            this.superValidator1.SetValidator1(this.emailEnseignant, this.requiredFieldValidator5);
            this.superValidator1.SetValidator2(this.emailEnseignant, this.regularExpressionValidator1);
            // 
            // cniEnseignant
            // 
            // 
            // 
            // 
            this.cniEnseignant.Border.Class = "TextBoxBorder";
            this.cniEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cniEnseignant.Location = new System.Drawing.Point(629, 155);
            this.cniEnseignant.Name = "cniEnseignant";
            this.cniEnseignant.Size = new System.Drawing.Size(255, 26);
            this.cniEnseignant.TabIndex = 7;
            this.superValidator1.SetValidator1(this.cniEnseignant, this.requiredFieldValidator4);
            this.superValidator1.SetValidator2(this.cniEnseignant, this.regularExpressionValidator2);
            // 
            // nomEnseignant
            // 
            // 
            // 
            // 
            this.nomEnseignant.Border.Class = "TextBoxBorder";
            this.nomEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nomEnseignant.Location = new System.Drawing.Point(97, 81);
            this.nomEnseignant.Name = "nomEnseignant";
            this.nomEnseignant.Size = new System.Drawing.Size(255, 26);
            this.nomEnseignant.TabIndex = 1;
            this.superValidator1.SetValidator1(this.nomEnseignant, this.requiredFieldValidator1);
            // 
            // listeEnseignant
            // 
            this.listeEnseignant.AllowUserToDeleteRows = false;
            this.listeEnseignant.AllowUserToResizeColumns = false;
            this.listeEnseignant.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.listeEnseignant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeEnseignant.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listeEnseignant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeEnseignant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listeEnseignant.ColumnHeadersHeight = 25;
            this.listeEnseignant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeEnseignant.DefaultCellStyle = dataGridViewCellStyle3;
            this.listeEnseignant.GridColor = System.Drawing.Color.Black;
            this.listeEnseignant.Location = new System.Drawing.Point(16, 226);
            this.listeEnseignant.Name = "listeEnseignant";
            this.listeEnseignant.ReadOnly = true;
            this.listeEnseignant.RowHeadersVisible = false;
            this.listeEnseignant.SelectAllSignVisible = false;
            this.listeEnseignant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeEnseignant.Size = new System.Drawing.Size(869, 237);
            this.listeEnseignant.TabIndex = 99;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(16, 194);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 73;
            this.labelX2.Text = "Adresse:";
            // 
            // BAnnuler
            // 
            this.BAnnuler.AutoSize = true;
            this.BAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnnuler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnnuler.Location = new System.Drawing.Point(793, 186);
            this.BAnnuler.Name = "BAnnuler";
            this.BAnnuler.Size = new System.Drawing.Size(91, 31);
            this.BAnnuler.TabIndex = 72;
            this.BAnnuler.Text = "Annuler";
            this.BAnnuler.UseVisualStyleBackColor = true;
            // 
            // BEnregEnseignant
            // 
            this.BEnregEnseignant.AutoSize = true;
            this.BEnregEnseignant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEnregEnseignant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEnregEnseignant.Location = new System.Drawing.Point(629, 186);
            this.BEnregEnseignant.Name = "BEnregEnseignant";
            this.BEnregEnseignant.Size = new System.Drawing.Size(86, 31);
            this.BEnregEnseignant.TabIndex = 71;
            this.BEnregEnseignant.Text = "Enregistrer";
            this.BEnregEnseignant.UseVisualStyleBackColor = true;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX8.Location = new System.Drawing.Point(16, 84);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(44, 23);
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
            this.labelX7.Location = new System.Drawing.Point(16, 121);
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
            this.labelX6.Location = new System.Drawing.Point(566, 80);
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
            this.labelX5.Location = new System.Drawing.Point(16, 158);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "Profession:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX4.Location = new System.Drawing.Point(566, 117);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "Email:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(566, 154);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "N° CNI:";
            // 
            // numEnseignant
            // 
            // 
            // 
            // 
            this.numEnseignant.BackgroundStyle.Class = "";
            this.numEnseignant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numEnseignant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEnseignant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numEnseignant.Location = new System.Drawing.Point(97, 47);
            this.numEnseignant.Name = "numEnseignant";
            this.numEnseignant.Size = new System.Drawing.Size(255, 23);
            this.numEnseignant.TabIndex = 2;
            this.numEnseignant.Text = "numero";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(16, 47);
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
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Veillez remplir le champ.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Veillez remplir le champ.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "Veillez remplir le champ.";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.EmptyValueIsValid = true;
            this.regularExpressionValidator1.ErrorMessage = "Email incorecte \n(ex:rodriguekongne@gmail.com).";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9" +
                "})$";
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "Veillez remplir le champ.";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.EmptyValueIsValid = true;
            this.regularExpressionValidator2.ErrorMessage = "Numero incorrect.";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^\\d{9}$";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Veillez remplir le champ.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // regularExpressionValidator3
            // 
            this.regularExpressionValidator3.EmptyValueIsValid = true;
            this.regularExpressionValidator3.ErrorMessage = "Numero incorrect \n(ex:675849536).";
            this.regularExpressionValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator3.ValidationExpression = "^\\d{9}$";
            // 
            // ajoutEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ajoutEnseignant";
            this.Text = "Enregistrer enseignant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeEnseignant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BAnnuler;
        private System.Windows.Forms.Button BEnregEnseignant;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX numEnseignant;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX listeEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX prenomEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX professionEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX adresseEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX telEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX emailEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX cniEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX nomEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX TRech;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator3;
    }
}