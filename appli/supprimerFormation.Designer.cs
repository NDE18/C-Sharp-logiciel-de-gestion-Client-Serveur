namespace appli
{
    partial class supprimerFormation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supprimerFormation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CRechFormation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BRechFormation = new System.Windows.Forms.Button();
            this.suppFormation = new System.Windows.Forms.Button();
            this.objectFormation = new System.Windows.Forms.TextBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.maxFormation = new System.Windows.Forms.TextBox();
            this.codeFormation = new System.Windows.Forms.TextBox();
            this.intitulFormation = new System.Windows.Forms.TextBox();
            this.minFormation = new System.Windows.Forms.TextBox();
            this.listeArticleMod = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annulerFormation = new System.Windows.Forms.Button();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticleMod)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.CRechFormation);
            this.groupBox1.Controls.Add(this.BRechFormation);
            this.groupBox1.Controls.Add(this.suppFormation);
            this.groupBox1.Controls.Add(this.objectFormation);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.maxFormation);
            this.groupBox1.Controls.Add(this.codeFormation);
            this.groupBox1.Controls.Add(this.intitulFormation);
            this.groupBox1.Controls.Add(this.minFormation);
            this.groupBox1.Controls.Add(this.listeArticleMod);
            this.groupBox1.Controls.Add(this.annulerFormation);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(122, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 470);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supprimer formation";
            // 
            // CRechFormation
            // 
            this.CRechFormation.DisabledBackColor = System.Drawing.Color.Black;
            this.CRechFormation.DisplayMember = "Text";
            this.CRechFormation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CRechFormation.FormattingEnabled = true;
            this.CRechFormation.ItemHeight = 20;
            this.CRechFormation.Location = new System.Drawing.Point(534, 33);
            this.CRechFormation.Name = "CRechFormation";
            this.CRechFormation.Size = new System.Drawing.Size(206, 26);
            this.CRechFormation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CRechFormation.TabIndex = 103;
            this.CRechFormation.WatermarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRechFormation.WatermarkText = "Entrer le code ou l\'intitulé";
            // 
            // BRechFormation
            // 
            this.BRechFormation.AutoSize = true;
            this.BRechFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRechFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRechFormation.Image = ((System.Drawing.Image)(resources.GetObject("BRechFormation.Image")));
            this.BRechFormation.Location = new System.Drawing.Point(510, 33);
            this.BRechFormation.Name = "BRechFormation";
            this.BRechFormation.Size = new System.Drawing.Size(27, 26);
            this.BRechFormation.TabIndex = 102;
            this.BRechFormation.UseVisualStyleBackColor = true;
            // 
            // suppFormation
            // 
            this.suppFormation.AutoSize = true;
            this.suppFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppFormation.Location = new System.Drawing.Point(173, 195);
            this.suppFormation.Name = "suppFormation";
            this.suppFormation.Size = new System.Drawing.Size(86, 31);
            this.suppFormation.TabIndex = 100;
            this.suppFormation.Text = "Supprimer";
            this.suppFormation.UseVisualStyleBackColor = true;
            // 
            // objectFormation
            // 
            this.objectFormation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objectFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectFormation.Location = new System.Drawing.Point(389, 127);
            this.objectFormation.Multiline = true;
            this.objectFormation.Name = "objectFormation";
            this.objectFormation.ReadOnly = true;
            this.objectFormation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.objectFormation.Size = new System.Drawing.Size(351, 99);
            this.objectFormation.TabIndex = 99;
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
            this.labelX5.Location = new System.Drawing.Point(389, 91);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(146, 23);
            this.labelX5.TabIndex = 98;
            this.labelX5.Text = "Objectif générale:";
            // 
            // maxFormation
            // 
            this.maxFormation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxFormation.Location = new System.Drawing.Point(168, 145);
            this.maxFormation.Name = "maxFormation";
            this.maxFormation.ReadOnly = true;
            this.maxFormation.Size = new System.Drawing.Size(196, 26);
            this.maxFormation.TabIndex = 97;
            // 
            // codeFormation
            // 
            this.codeFormation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeFormation.Location = new System.Drawing.Point(168, 37);
            this.codeFormation.Name = "codeFormation";
            this.codeFormation.ReadOnly = true;
            this.codeFormation.Size = new System.Drawing.Size(196, 26);
            this.codeFormation.TabIndex = 96;
            // 
            // intitulFormation
            // 
            this.intitulFormation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intitulFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intitulFormation.Location = new System.Drawing.Point(168, 73);
            this.intitulFormation.Name = "intitulFormation";
            this.intitulFormation.ReadOnly = true;
            this.intitulFormation.Size = new System.Drawing.Size(196, 26);
            this.intitulFormation.TabIndex = 95;
            // 
            // minFormation
            // 
            this.minFormation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minFormation.Location = new System.Drawing.Point(168, 109);
            this.minFormation.Name = "minFormation";
            this.minFormation.ReadOnly = true;
            this.minFormation.Size = new System.Drawing.Size(196, 26);
            this.minFormation.TabIndex = 94;
            // 
            // listeArticleMod
            // 
            this.listeArticleMod.AllowUserToDeleteRows = false;
            this.listeArticleMod.AllowUserToResizeColumns = false;
            this.listeArticleMod.AllowUserToResizeRows = false;
            this.listeArticleMod.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listeArticleMod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeArticleMod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listeArticleMod.ColumnHeadersHeight = 45;
            this.listeArticleMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listeArticleMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.intitule,
            this.dureMin,
            this.dureMax,
            this.objectif});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeArticleMod.DefaultCellStyle = dataGridViewCellStyle6;
            this.listeArticleMod.GridColor = System.Drawing.Color.Black;
            this.listeArticleMod.Location = new System.Drawing.Point(36, 232);
            this.listeArticleMod.Name = "listeArticleMod";
            this.listeArticleMod.ReadOnly = true;
            this.listeArticleMod.RowHeadersVisible = false;
            this.listeArticleMod.Size = new System.Drawing.Size(704, 232);
            this.listeArticleMod.TabIndex = 84;
            // 
            // code
            // 
            this.code.HeaderText = "Code ";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // intitule
            // 
            this.intitule.HeaderText = "Intulé";
            this.intitule.Name = "intitule";
            this.intitule.ReadOnly = true;
            this.intitule.Width = 250;
            // 
            // dureMin
            // 
            this.dureMin.HeaderText = "Durée minimal";
            this.dureMin.Name = "dureMin";
            this.dureMin.ReadOnly = true;
            this.dureMin.Width = 75;
            // 
            // dureMax
            // 
            this.dureMax.HeaderText = "Durée maximal";
            this.dureMax.Name = "dureMax";
            this.dureMax.ReadOnly = true;
            this.dureMax.Width = 75;
            // 
            // objectif
            // 
            this.objectif.HeaderText = "Objectif général";
            this.objectif.Name = "objectif";
            this.objectif.ReadOnly = true;
            this.objectif.Width = 300;
            // 
            // annulerFormation
            // 
            this.annulerFormation.AutoSize = true;
            this.annulerFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annulerFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerFormation.Location = new System.Drawing.Point(278, 195);
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
            this.labelX3.Size = new System.Drawing.Size(135, 23);
            this.labelX3.TabIndex = 64;
            this.labelX3.Text = "Durée minimal:";
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
            this._designation.Size = new System.Drawing.Size(109, 23);
            this._designation.TabIndex = 61;
            this._designation.Text = "Durée maximal:";
            // 
            // supprimerFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "supprimerFormation";
            this.Text = "Supprimer formation";
            this.Load += new System.EventHandler(this.supprimerFormation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeArticleMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CRechFormation;
        private System.Windows.Forms.Button BRechFormation;
        private System.Windows.Forms.Button suppFormation;
        private System.Windows.Forms.TextBox objectFormation;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.TextBox maxFormation;
        private System.Windows.Forms.TextBox codeFormation;
        private System.Windows.Forms.TextBox intitulFormation;
        private System.Windows.Forms.TextBox minFormation;
        private DevComponents.DotNetBar.Controls.DataGridViewX listeArticleMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectif;
        private System.Windows.Forms.Button annulerFormation;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX _designation;
    }
}