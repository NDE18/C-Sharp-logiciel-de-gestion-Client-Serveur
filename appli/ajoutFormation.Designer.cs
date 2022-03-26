namespace appli
{
    partial class ajoutFormation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutFormation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RechT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.codeFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.intituleFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.minFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.maxFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.objectFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.enregFormation = new System.Windows.Forms.Button();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.listeFormation = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.annulerFormation = new System.Windows.Forms.Button();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Veillez remplir le champ.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Veillez remplir le champ.");
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("veillez remplir le champ.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeFormation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.RechT);
            this.groupBox1.Controls.Add(this.codeFormation);
            this.groupBox1.Controls.Add(this.intituleFormation);
            this.groupBox1.Controls.Add(this.minFormation);
            this.groupBox1.Controls.Add(this.maxFormation);
            this.groupBox1.Controls.Add(this.objectFormation);
            this.groupBox1.Controls.Add(this.enregFormation);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.listeFormation);
            this.groupBox1.Controls.Add(this.annulerFormation);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(104, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 470);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvelle formation";
            // 
            // RechT
            // 
            this.RechT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.RechT.Border.Class = "TextBoxBorder";
            this.RechT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RechT.ForeColor = System.Drawing.Color.Black;
            this.RechT.Location = new System.Drawing.Point(625, 13);
            this.RechT.Name = "RechT";
            this.RechT.Size = new System.Drawing.Size(196, 26);
            this.RechT.TabIndex = 140;
            this.RechT.WatermarkText = "Filtrer le tableau par intitulé";
            this.RechT.TextChanged += new System.EventHandler(this.RechT_TextChanged);
            // 
            // codeFormation
            // 
            this.codeFormation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.codeFormation.Border.Class = "TextBoxBorder";
            this.codeFormation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codeFormation.ForeColor = System.Drawing.Color.Black;
            this.codeFormation.Location = new System.Drawing.Point(218, 36);
            this.codeFormation.Name = "codeFormation";
            this.codeFormation.Size = new System.Drawing.Size(196, 26);
            this.codeFormation.TabIndex = 1;
            this.superValidator1.SetValidator1(this.codeFormation, this.requiredFieldValidator1);
            // 
            // intituleFormation
            // 
            this.intituleFormation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.intituleFormation.Border.Class = "TextBoxBorder";
            this.intituleFormation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intituleFormation.ForeColor = System.Drawing.Color.Black;
            this.intituleFormation.Location = new System.Drawing.Point(218, 72);
            this.intituleFormation.Name = "intituleFormation";
            this.intituleFormation.Size = new System.Drawing.Size(196, 26);
            this.intituleFormation.TabIndex = 2;
            this.superValidator1.SetValidator1(this.intituleFormation, this.requiredFieldValidator2);
            // 
            // minFormation
            // 
            this.minFormation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.minFormation.Border.Class = "TextBoxBorder";
            this.minFormation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.minFormation.ForeColor = System.Drawing.Color.Black;
            this.minFormation.Location = new System.Drawing.Point(218, 108);
            this.minFormation.Name = "minFormation";
            this.minFormation.Size = new System.Drawing.Size(196, 26);
            this.minFormation.TabIndex = 3;
            this.superValidator1.SetValidator1(this.minFormation, this.regularExpressionValidator1);
            // 
            // maxFormation
            // 
            this.maxFormation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.maxFormation.Border.Class = "TextBoxBorder";
            this.maxFormation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.maxFormation.ForeColor = System.Drawing.Color.Black;
            this.maxFormation.Location = new System.Drawing.Point(218, 144);
            this.maxFormation.Name = "maxFormation";
            this.maxFormation.Size = new System.Drawing.Size(196, 26);
            this.maxFormation.TabIndex = 4;
            this.superValidator1.SetValidator1(this.maxFormation, this.regularExpressionValidator2);
            // 
            // objectFormation
            // 
            this.objectFormation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.objectFormation.Border.Class = "TextBoxBorder";
            this.objectFormation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.objectFormation.ForeColor = System.Drawing.Color.Black;
            this.objectFormation.Location = new System.Drawing.Point(470, 73);
            this.objectFormation.Multiline = true;
            this.objectFormation.Name = "objectFormation";
            this.objectFormation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.objectFormation.Size = new System.Drawing.Size(351, 152);
            this.objectFormation.TabIndex = 5;
            this.superValidator1.SetValidator1(this.objectFormation, this.requiredFieldValidator3);
            // 
            // enregFormation
            // 
            this.enregFormation.AutoSize = true;
            this.enregFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregFormation.Location = new System.Drawing.Point(218, 194);
            this.enregFormation.Name = "enregFormation";
            this.enregFormation.Size = new System.Drawing.Size(86, 31);
            this.enregFormation.TabIndex = 100;
            this.enregFormation.Text = "Enregistrer";
            this.enregFormation.UseVisualStyleBackColor = true;
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
            this.labelX5.Location = new System.Drawing.Point(470, 44);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(146, 23);
            this.labelX5.TabIndex = 98;
            this.labelX5.Text = "Objectif générale:";
            // 
            // listeFormation
            // 
            this.listeFormation.AllowUserToDeleteRows = false;
            this.listeFormation.AllowUserToResizeColumns = false;
            this.listeFormation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.listeFormation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeFormation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listeFormation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeFormation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listeFormation.ColumnHeadersHeight = 45;
            this.listeFormation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeFormation.DefaultCellStyle = dataGridViewCellStyle3;
            this.listeFormation.GridColor = System.Drawing.Color.Black;
            this.listeFormation.HighlightSelectedColumnHeaders = false;
            this.listeFormation.Location = new System.Drawing.Point(36, 232);
            this.listeFormation.Name = "listeFormation";
            this.listeFormation.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeFormation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listeFormation.RowHeadersVisible = false;
            this.listeFormation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeFormation.Size = new System.Drawing.Size(785, 232);
            this.listeFormation.TabIndex = 84;
            // 
            // annulerFormation
            // 
            this.annulerFormation.AutoSize = true;
            this.annulerFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annulerFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerFormation.Location = new System.Drawing.Point(328, 194);
            this.annulerFormation.Name = "annulerFormation";
            this.annulerFormation.Size = new System.Drawing.Size(86, 31);
            this.annulerFormation.TabIndex = 68;
            this.annulerFormation.Text = "Annuler";
            this.annulerFormation.UseVisualStyleBackColor = true;
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
            this.labelX3.Location = new System.Drawing.Point(36, 108);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(176, 23);
            this.labelX3.TabIndex = 64;
            this.labelX3.Text = "Durée minimal (en heure):";
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
            this.labelX2.Location = new System.Drawing.Point(36, 36);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(109, 23);
            this.labelX2.TabIndex = 63;
            this.labelX2.Text = "Code:";
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
            this.labelX1.Location = new System.Drawing.Point(36, 72);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 62;
            this.labelX1.Text = "Intitulé:";
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
            this._designation.Location = new System.Drawing.Point(36, 144);
            this._designation.Name = "_designation";
            this._designation.Size = new System.Drawing.Size(176, 23);
            this._designation.TabIndex = 61;
            this._designation.Text = "Durée maximal (en heure):";
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
            this.requiredFieldValidator1.ErrorMessage = "Veillez remplir le champ.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Veillez remplir le champ.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "Valeur incorrecte.\n Entrez des entiers positifs.";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^\\d+$";
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.ErrorMessage = "Valeur incorrecte.\n Entrez des entiers positifs.";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^\\d+$";
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "veillez remplir le champ.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // ajoutFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ajoutFormation";
            this.Text = "Nouvelle formation";
            this.Load += new System.EventHandler(this.ajoutFormation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeFormation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enregFormation;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX listeFormation;
        private System.Windows.Forms.Button annulerFormation;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX _designation;
        private DevComponents.DotNetBar.Controls.TextBoxX RechT;
        private DevComponents.DotNetBar.Controls.TextBoxX codeFormation;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX intituleFormation;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Controls.TextBoxX minFormation;
        private DevComponents.DotNetBar.Controls.TextBoxX maxFormation;
        private DevComponents.DotNetBar.Controls.TextBoxX objectFormation;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
    }
}