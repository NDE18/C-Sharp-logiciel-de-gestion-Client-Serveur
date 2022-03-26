namespace appli
{
    partial class SupprimerDepannage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AutreEntrer = new System.Windows.Forms.GroupBox();
            this.numero = new System.Windows.Forms.ComboBox();
            this.dateDebutDepa = new DevComponents.DotNetBar.LabelX();
            this.CnumClient = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TDiagnostic = new System.Windows.Forms.RichTextBox();
            this.employe = new DevComponents.DotNetBar.LabelX();
            this.typeClient = new DevComponents.DotNetBar.LabelX();
            this.nom = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.BAnnulerSupDepa = new System.Windows.Forms.Button();
            this.BSupDepa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.articleChoisi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tableau = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.choixRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choixDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choixQteNece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutreEntrer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleChoisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // AutreEntrer
            // 
            this.AutreEntrer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AutreEntrer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutreEntrer.Controls.Add(this.numero);
            this.AutreEntrer.Controls.Add(this.dateDebutDepa);
            this.AutreEntrer.Controls.Add(this.CnumClient);
            this.AutreEntrer.Controls.Add(this.groupBox1);
            this.AutreEntrer.Controls.Add(this.employe);
            this.AutreEntrer.Controls.Add(this.typeClient);
            this.AutreEntrer.Controls.Add(this.nom);
            this.AutreEntrer.Controls.Add(this.labelX6);
            this.AutreEntrer.Controls.Add(this.labelX5);
            this.AutreEntrer.Controls.Add(this.labelX4);
            this.AutreEntrer.Controls.Add(this.labelX3);
            this.AutreEntrer.Controls.Add(this.labelX1);
            this.AutreEntrer.Controls.Add(this.labelX2);
            this.AutreEntrer.Controls.Add(this.BAnnulerSupDepa);
            this.AutreEntrer.Controls.Add(this.BSupDepa);
            this.AutreEntrer.Controls.Add(this.groupBox2);
            this.AutreEntrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutreEntrer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutreEntrer.Location = new System.Drawing.Point(46, 12);
            this.AutreEntrer.Name = "AutreEntrer";
            this.AutreEntrer.Size = new System.Drawing.Size(921, 509);
            this.AutreEntrer.TabIndex = 115;
            this.AutreEntrer.TabStop = false;
            // 
            // numero
            // 
            this.numero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numero.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.FormattingEnabled = true;
            this.numero.Location = new System.Drawing.Point(150, 16);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(216, 29);
            this.numero.Sorted = true;
            this.numero.TabIndex = 137;
            this.numero.SelectedIndexChanged += new System.EventHandler(this.numero_SelectedIndexChanged);
            // 
            // dateDebutDepa
            // 
            // 
            // 
            // 
            this.dateDebutDepa.BackgroundStyle.Class = "";
            this.dateDebutDepa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDebutDepa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutDepa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateDebutDepa.Location = new System.Drawing.Point(150, 49);
            this.dateDebutDepa.Name = "dateDebutDepa";
            this.dateDebutDepa.Size = new System.Drawing.Size(200, 23);
            this.dateDebutDepa.TabIndex = 136;
            // 
            // CnumClient
            // 
            // 
            // 
            // 
            this.CnumClient.BackgroundStyle.Class = "";
            this.CnumClient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CnumClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnumClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CnumClient.Location = new System.Drawing.Point(150, 90);
            this.CnumClient.Name = "CnumClient";
            this.CnumClient.Size = new System.Drawing.Size(300, 23);
            this.CnumClient.TabIndex = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TDiagnostic);
            this.groupBox1.Location = new System.Drawing.Point(474, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 487);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnostic";
            // 
            // TDiagnostic
            // 
            this.TDiagnostic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDiagnostic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TDiagnostic.Location = new System.Drawing.Point(3, 22);
            this.TDiagnostic.Name = "TDiagnostic";
            this.TDiagnostic.Size = new System.Drawing.Size(435, 462);
            this.TDiagnostic.TabIndex = 115;
            this.TDiagnostic.Text = "";
            // 
            // employe
            // 
            // 
            // 
            // 
            this.employe.BackgroundStyle.Class = "";
            this.employe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.employe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employe.Location = new System.Drawing.Point(150, 190);
            this.employe.Name = "employe";
            this.employe.Size = new System.Drawing.Size(300, 23);
            this.employe.TabIndex = 128;
            // 
            // typeClient
            // 
            // 
            // 
            // 
            this.typeClient.BackgroundStyle.Class = "";
            this.typeClient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.typeClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.typeClient.Location = new System.Drawing.Point(150, 155);
            this.typeClient.Name = "typeClient";
            this.typeClient.Size = new System.Drawing.Size(300, 23);
            this.typeClient.TabIndex = 127;
            // 
            // nom
            // 
            // 
            // 
            // 
            this.nom.BackgroundStyle.Class = "";
            this.nom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nom.Location = new System.Drawing.Point(150, 119);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(300, 23);
            this.nom.TabIndex = 126;
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
            this.labelX6.Location = new System.Drawing.Point(9, 189);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(90, 23);
            this.labelX6.TabIndex = 123;
            this.labelX6.Text = "Employé:";
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
            this.labelX5.Location = new System.Drawing.Point(9, 154);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(73, 23);
            this.labelX5.TabIndex = 122;
            this.labelX5.Text = "Type:";
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
            this.labelX4.Location = new System.Drawing.Point(6, 118);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(138, 23);
            this.labelX4.TabIndex = 120;
            this.labelX4.Text = "Appareil à dépanner:";
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
            this.labelX3.Location = new System.Drawing.Point(9, 48);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(73, 23);
            this.labelX3.TabIndex = 119;
            this.labelX3.Text = "Date:";
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
            this.labelX1.Location = new System.Drawing.Point(9, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(123, 23);
            this.labelX1.TabIndex = 118;
            this.labelX1.Text = "Numero :";
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
            this.labelX2.Location = new System.Drawing.Point(6, 86);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 117;
            this.labelX2.Text = "Numéro client:";
            // 
            // BAnnulerSupDepa
            // 
            this.BAnnulerSupDepa.AutoSize = true;
            this.BAnnulerSupDepa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnnulerSupDepa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnnulerSupDepa.Location = new System.Drawing.Point(353, 472);
            this.BAnnulerSupDepa.Name = "BAnnulerSupDepa";
            this.BAnnulerSupDepa.Size = new System.Drawing.Size(109, 31);
            this.BAnnulerSupDepa.TabIndex = 111;
            this.BAnnulerSupDepa.Text = "Annuler";
            this.BAnnulerSupDepa.UseVisualStyleBackColor = true;
            // 
            // BSupDepa
            // 
            this.BSupDepa.AutoSize = true;
            this.BSupDepa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSupDepa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSupDepa.Location = new System.Drawing.Point(223, 472);
            this.BSupDepa.Name = "BSupDepa";
            this.BSupDepa.Size = new System.Drawing.Size(109, 31);
            this.BSupDepa.TabIndex = 110;
            this.BSupDepa.Text = "Supprimer";
            this.BSupDepa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableau);
            this.groupBox2.Controls.Add(this.articleChoisi);
            this.groupBox2.Location = new System.Drawing.Point(4, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 231);
            this.groupBox2.TabIndex = 130;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articles choisis";
            // 
            // articleChoisi
            // 
            this.articleChoisi.AllowUserToDeleteRows = false;
            this.articleChoisi.AllowUserToResizeColumns = false;
            this.articleChoisi.AllowUserToResizeRows = false;
            this.articleChoisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.articleChoisi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.articleChoisi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleChoisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.articleChoisi.ColumnHeadersHeight = 50;
            this.articleChoisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articleChoisi.DefaultCellStyle = dataGridViewCellStyle7;
            this.articleChoisi.GridColor = System.Drawing.Color.Black;
            this.articleChoisi.Location = new System.Drawing.Point(5, 25);
            this.articleChoisi.Name = "articleChoisi";
            this.articleChoisi.ReadOnly = true;
            this.articleChoisi.RowHeadersVisible = false;
            this.articleChoisi.Size = new System.Drawing.Size(453, 203);
            this.articleChoisi.TabIndex = 114;
            this.articleChoisi.Visible = false;
            // 
            // tableau
            // 
            this.tableau.AllowUserToDeleteRows = false;
            this.tableau.AllowUserToResizeColumns = false;
            this.tableau.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tableau.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableau.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableau.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableau.ColumnHeadersHeight = 50;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choixRef,
            this.choixDesignation,
            this.choixQteNece});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableau.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableau.GridColor = System.Drawing.Color.Black;
            this.tableau.HighlightSelectedColumnHeaders = false;
            this.tableau.Location = new System.Drawing.Point(0, 43);
            this.tableau.Name = "tableau";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableau.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableau.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.tableau.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableau.Size = new System.Drawing.Size(453, 206);
            this.tableau.TabIndex = 116;
            // 
            // choixRef
            // 
            this.choixRef.FillWeight = 153F;
            this.choixRef.HeaderText = "Référence";
            this.choixRef.Name = "choixRef";
            this.choixRef.ReadOnly = true;
            // 
            // choixDesignation
            // 
            this.choixDesignation.HeaderText = "Désignation";
            this.choixDesignation.Name = "choixDesignation";
            this.choixDesignation.ReadOnly = true;
            // 
            // choixQteNece
            // 
            this.choixQteNece.FillWeight = 50F;
            this.choixQteNece.HeaderText = "Quantité nécéssaire";
            this.choixQteNece.Name = "choixQteNece";
            // 
            // SupprimerDepannage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 518);
            this.Controls.Add(this.AutreEntrer);
            this.DoubleBuffered = true;
            this.Name = "SupprimerDepannage";
            this.Text = "Supprimer dépannage";
            this.Load += new System.EventHandler(this.SupprimerDepannage_Load);
            this.AutreEntrer.ResumeLayout(false);
            this.AutreEntrer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articleChoisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AutreEntrer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox TDiagnostic;
        private DevComponents.DotNetBar.LabelX employe;
        private DevComponents.DotNetBar.LabelX typeClient;
        private DevComponents.DotNetBar.LabelX nom;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Button BAnnulerSupDepa;
        private System.Windows.Forms.Button BSupDepa;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX articleChoisi;
        private DevComponents.DotNetBar.LabelX dateDebutDepa;
        private DevComponents.DotNetBar.LabelX CnumClient;
        private System.Windows.Forms.ComboBox numero;
        private DevComponents.DotNetBar.Controls.DataGridViewX tableau;
        private System.Windows.Forms.DataGridViewTextBoxColumn choixRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn choixDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn choixQteNece;
    }
}