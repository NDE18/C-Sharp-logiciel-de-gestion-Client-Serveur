namespace appli
{
    partial class SortieFabrication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortieFabrication));
            this.AutreEntrer = new System.Windows.Forms.GroupBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.numEmploye = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.TDescription = new System.Windows.Forms.RichTextBox();
            this.articleDemande = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.enregPar = new DevComponents.DotNetBar.LabelX();
            this.dateEnreg = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.numFabrication = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.BAnnulerSortie = new System.Windows.Forms.Button();
            this.BEnregSortie = new System.Windows.Forms.Button();
            this.AutreEntrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleDemande)).BeginInit();
            this.SuspendLayout();
            // 
            // AutreEntrer
            // 
            this.AutreEntrer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AutreEntrer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutreEntrer.Controls.Add(this.labelX4);
            this.AutreEntrer.Controls.Add(this.numEmploye);
            this.AutreEntrer.Controls.Add(this.labelX3);
            this.AutreEntrer.Controls.Add(this.TDescription);
            this.AutreEntrer.Controls.Add(this.articleDemande);
            this.AutreEntrer.Controls.Add(this.enregPar);
            this.AutreEntrer.Controls.Add(this.dateEnreg);
            this.AutreEntrer.Controls.Add(this.labelX2);
            this.AutreEntrer.Controls.Add(this.labelX1);
            this.AutreEntrer.Controls.Add(this.numFabrication);
            this.AutreEntrer.Controls.Add(this.labelX5);
            this.AutreEntrer.Controls.Add(this.BAnnulerSortie);
            this.AutreEntrer.Controls.Add(this.BEnregSortie);
            this.AutreEntrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutreEntrer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutreEntrer.Location = new System.Drawing.Point(3, 12);
            this.AutreEntrer.Name = "AutreEntrer";
            this.AutreEntrer.Size = new System.Drawing.Size(1004, 470);
            this.AutreEntrer.TabIndex = 113;
            this.AutreEntrer.TabStop = false;
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
            this.labelX4.Location = new System.Drawing.Point(486, 19);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(86, 23);
            this.labelX4.TabIndex = 122;
            this.labelX4.Text = "Description:";
            // 
            // numEmploye
            // 
            this.numEmploye.DisabledBackColor = System.Drawing.Color.Black;
            this.numEmploye.DisplayMember = "Text";
            this.numEmploye.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numEmploye.FormattingEnabled = true;
            this.numEmploye.ItemHeight = 20;
            this.numEmploye.Location = new System.Drawing.Point(164, 151);
            this.numEmploye.Name = "numEmploye";
            this.numEmploye.Size = new System.Drawing.Size(224, 26);
            this.numEmploye.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.numEmploye.TabIndex = 121;
            this.numEmploye.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEmploye.WatermarkText = "Numéro";
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
            this.labelX3.Location = new System.Drawing.Point(9, 151);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(140, 23);
            this.labelX3.TabIndex = 120;
            this.labelX3.Text = "Retirer par:";
            // 
            // TDescription
            // 
            this.TDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TDescription.Location = new System.Drawing.Point(578, 19);
            this.TDescription.Name = "TDescription";
            this.TDescription.ReadOnly = true;
            this.TDescription.Size = new System.Drawing.Size(420, 445);
            this.TDescription.TabIndex = 119;
            this.TDescription.Text = "";
            // 
            // articleDemande
            // 
            this.articleDemande.AllowUserToDeleteRows = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articleDemande.DefaultCellStyle = dataGridViewCellStyle2;
            this.articleDemande.GridColor = System.Drawing.Color.Black;
            this.articleDemande.HighlightSelectedColumnHeaders = false;
            this.articleDemande.Location = new System.Drawing.Point(9, 203);
            this.articleDemande.Name = "articleDemande";
            this.articleDemande.RowHeadersVisible = false;
            this.articleDemande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articleDemande.Size = new System.Drawing.Size(563, 221);
            this.articleDemande.TabIndex = 118;
            // 
            // enregPar
            // 
            // 
            // 
            // 
            this.enregPar.BackgroundStyle.Class = "";
            this.enregPar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.enregPar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregPar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enregPar.Location = new System.Drawing.Point(164, 111);
            this.enregPar.Name = "enregPar";
            this.enregPar.Size = new System.Drawing.Size(316, 23);
            this.enregPar.TabIndex = 117;
            // 
            // dateEnreg
            // 
            // 
            // 
            // 
            this.dateEnreg.BackgroundStyle.Class = "";
            this.dateEnreg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateEnreg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnreg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateEnreg.Location = new System.Drawing.Point(164, 65);
            this.dateEnreg.Name = "dateEnreg";
            this.dateEnreg.Size = new System.Drawing.Size(224, 23);
            this.dateEnreg.TabIndex = 116;
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
            this.labelX2.Location = new System.Drawing.Point(9, 108);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(140, 23);
            this.labelX2.TabIndex = 115;
            this.labelX2.Text = "Enregistré par:";
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
            this.labelX1.Location = new System.Drawing.Point(9, 65);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(170, 23);
            this.labelX1.TabIndex = 114;
            this.labelX1.Text = "Date d\'enregistrement:";
            // 
            // numFabrication
            // 
            this.numFabrication.DisabledBackColor = System.Drawing.Color.Black;
            this.numFabrication.DisplayMember = "Text";
            this.numFabrication.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numFabrication.FormattingEnabled = true;
            this.numFabrication.ItemHeight = 20;
            this.numFabrication.Location = new System.Drawing.Point(164, 22);
            this.numFabrication.Name = "numFabrication";
            this.numFabrication.Size = new System.Drawing.Size(224, 26);
            this.numFabrication.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.numFabrication.TabIndex = 113;
            this.numFabrication.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFabrication.WatermarkText = "numéro d\'enregistrement";
            this.numFabrication.SelectedIndexChanged += new System.EventHandler(this.numFabrication_SelectedIndexChanged);
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
            this.labelX5.Location = new System.Drawing.Point(9, 22);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(140, 23);
            this.labelX5.TabIndex = 63;
            this.labelX5.Text = "Numéro prestation:";
            // 
            // BAnnulerSortie
            // 
            this.BAnnulerSortie.AutoSize = true;
            this.BAnnulerSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnnulerSortie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnnulerSortie.Location = new System.Drawing.Point(486, 433);
            this.BAnnulerSortie.Name = "BAnnulerSortie";
            this.BAnnulerSortie.Size = new System.Drawing.Size(86, 31);
            this.BAnnulerSortie.TabIndex = 111;
            this.BAnnulerSortie.Text = "Annuler";
            this.BAnnulerSortie.UseVisualStyleBackColor = true;
            // 
            // BEnregSortie
            // 
            this.BEnregSortie.AutoSize = true;
            this.BEnregSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEnregSortie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEnregSortie.Location = new System.Drawing.Point(394, 433);
            this.BEnregSortie.Name = "BEnregSortie";
            this.BEnregSortie.Size = new System.Drawing.Size(86, 31);
            this.BEnregSortie.TabIndex = 110;
            this.BEnregSortie.Text = "Enregistrer";
            this.BEnregSortie.UseVisualStyleBackColor = true;
            // 
            // SortieFabrication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.AutreEntrer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortieFabrication";
            this.Text = "Sortie pour fabrication";
            this.AutreEntrer.ResumeLayout(false);
            this.AutreEntrer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleDemande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AutreEntrer;
        private DevComponents.DotNetBar.LabelX enregPar;
        private DevComponents.DotNetBar.LabelX dateEnreg;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx numFabrication;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Button BAnnulerSortie;
        private System.Windows.Forms.Button BEnregSortie;
        private DevComponents.DotNetBar.Controls.DataGridViewX articleDemande;
        private System.Windows.Forms.RichTextBox TDescription;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx numEmploye;
        private DevComponents.DotNetBar.LabelX labelX3;

    }
}