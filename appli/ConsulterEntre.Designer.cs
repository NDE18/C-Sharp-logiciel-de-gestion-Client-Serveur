namespace appli
{
    partial class ConsulterEntre
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
            this.AutreEntrer = new System.Windows.Forms.GroupBox();
            this.TMotif = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TResponsable = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TRech = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.typeRech = new System.Windows.Forms.ComboBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.TListeArticle = new System.Windows.Forms.DataGridView();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.AutreEntrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TListeArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // AutreEntrer
            // 
            this.AutreEntrer.Controls.Add(this.TMotif);
            this.AutreEntrer.Controls.Add(this.TResponsable);
            this.AutreEntrer.Controls.Add(this.TRech);
            this.AutreEntrer.Controls.Add(this.typeRech);
            this.AutreEntrer.Controls.Add(this.labelX5);
            this.AutreEntrer.Controls.Add(this.TListeArticle);
            this.AutreEntrer.Controls.Add(this.labelX9);
            this.AutreEntrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutreEntrer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutreEntrer.Location = new System.Drawing.Point(47, 18);
            this.AutreEntrer.Name = "AutreEntrer";
            this.AutreEntrer.Size = new System.Drawing.Size(917, 480);
            this.AutreEntrer.TabIndex = 114;
            this.AutreEntrer.TabStop = false;
            this.AutreEntrer.Text = "Fiche des entrées en stock";
            // 
            // TMotif
            // 
            this.TMotif.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TMotif.Border.Class = "TextBoxBorder";
            this.TMotif.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TMotif.ForeColor = System.Drawing.Color.Black;
            this.TMotif.Location = new System.Drawing.Point(581, 272);
            this.TMotif.Name = "TMotif";
            this.TMotif.Size = new System.Drawing.Size(187, 26);
            this.TMotif.TabIndex = 140;
            this.TMotif.WatermarkText = "Entrer le motif";
            this.TMotif.TextChanged += new System.EventHandler(this.TMotif_TextChanged);
            // 
            // TResponsable
            // 
            this.TResponsable.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TResponsable.Border.Class = "TextBoxBorder";
            this.TResponsable.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TResponsable.ForeColor = System.Drawing.Color.Black;
            this.TResponsable.Location = new System.Drawing.Point(581, 304);
            this.TResponsable.Name = "TResponsable";
            this.TResponsable.Size = new System.Drawing.Size(187, 26);
            this.TResponsable.TabIndex = 139;
            this.TResponsable.WatermarkText = "Entrer le nom du responsable";
            this.TResponsable.TextChanged += new System.EventHandler(this.TResponsable_TextChanged);
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
            this.TRech.Location = new System.Drawing.Point(724, 24);
            this.TRech.Name = "TRech";
            this.TRech.Size = new System.Drawing.Size(187, 26);
            this.TRech.TabIndex = 138;
            this.TRech.WatermarkText = "Entrez la référence";
            this.TRech.TextChanged += new System.EventHandler(this.TRech_TextChanged);
            // 
            // typeRech
            // 
            this.typeRech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeRech.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeRech.FormattingEnabled = true;
            this.typeRech.Items.AddRange(new object[] {
            "Motif",
            "Référence",
            "Responsable"});
            this.typeRech.Location = new System.Drawing.Point(532, 21);
            this.typeRech.Name = "typeRech";
            this.typeRech.Size = new System.Drawing.Size(167, 29);
            this.typeRech.Sorted = true;
            this.typeRech.TabIndex = 136;
            this.typeRech.SelectedIndexChanged += new System.EventHandler(this.typeRech_SelectedIndexChanged);
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
            this.labelX5.Location = new System.Drawing.Point(395, 26);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(140, 23);
            this.labelX5.TabIndex = 137;
            this.labelX5.Text = "Filtrer le tableau par:";
            // 
            // TListeArticle
            // 
            this.TListeArticle.AllowUserToResizeColumns = false;
            this.TListeArticle.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.TListeArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TListeArticle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TListeArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TListeArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TListeArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TListeArticle.DefaultCellStyle = dataGridViewCellStyle3;
            this.TListeArticle.GridColor = System.Drawing.Color.Black;
            this.TListeArticle.Location = new System.Drawing.Point(6, 55);
            this.TListeArticle.Name = "TListeArticle";
            this.TListeArticle.ReadOnly = true;
            this.TListeArticle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TListeArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TListeArticle.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.TListeArticle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TListeArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TListeArticle.Size = new System.Drawing.Size(905, 419);
            this.TListeArticle.TabIndex = 114;
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
            this.labelX9.Location = new System.Drawing.Point(368, 34);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(88, 23);
            this.labelX9.TabIndex = 61;
            this.labelX9.Text = ":";
            // 
            // ConsulterEntre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 516);
            this.Controls.Add(this.AutreEntrer);
            this.DoubleBuffered = true;
            this.Name = "ConsulterEntre";
            this.Text = "Consulter les entrées";
            this.AutreEntrer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TListeArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AutreEntrer;
        private DevComponents.DotNetBar.Controls.TextBoxX TMotif;
        private DevComponents.DotNetBar.Controls.TextBoxX TResponsable;
        private DevComponents.DotNetBar.Controls.TextBoxX TRech;
        private System.Windows.Forms.ComboBox typeRech;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.DataGridView TListeArticle;
        private DevComponents.DotNetBar.LabelX labelX9;

    }
}