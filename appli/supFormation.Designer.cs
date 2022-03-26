namespace appli
{
    partial class supFormation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codeFormation = new System.Windows.Forms.ComboBox();
            this.RechT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.intituleFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.minFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.maxFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.objectFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.modifFormation = new System.Windows.Forms.Button();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.listeFormation = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.annulerFormation = new System.Windows.Forms.Button();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._designation = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeFormation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.codeFormation);
            this.groupBox1.Controls.Add(this.RechT);
            this.groupBox1.Controls.Add(this.intituleFormation);
            this.groupBox1.Controls.Add(this.minFormation);
            this.groupBox1.Controls.Add(this.maxFormation);
            this.groupBox1.Controls.Add(this.objectFormation);
            this.groupBox1.Controls.Add(this.modifFormation);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.listeFormation);
            this.groupBox1.Controls.Add(this.annulerFormation);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this._designation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(79, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 470);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supprimer formation";
            // 
            // codeFormation
            // 
            this.codeFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeFormation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeFormation.FormattingEnabled = true;
            this.codeFormation.Location = new System.Drawing.Point(218, 30);
            this.codeFormation.Name = "codeFormation";
            this.codeFormation.Size = new System.Drawing.Size(196, 29);
            this.codeFormation.Sorted = true;
            this.codeFormation.TabIndex = 1;
            this.codeFormation.SelectedIndexChanged += new System.EventHandler(this.codeFormation_SelectedIndexChanged);
            // 
            // RechT
            // 
            // 
            // 
            // 
            this.RechT.Border.Class = "TextBoxBorder";
            this.RechT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RechT.Location = new System.Drawing.Point(625, 13);
            this.RechT.Name = "RechT";
            this.RechT.Size = new System.Drawing.Size(196, 26);
            this.RechT.TabIndex = 140;
            this.RechT.WatermarkText = "Filtrer le tableau par intitulé";
            this.RechT.TextChanged += new System.EventHandler(this.RechT_TextChanged);
            // 
            // intituleFormation
            // 
            // 
            // 
            // 
            this.intituleFormation.Border.Class = "TextBoxBorder";
            this.intituleFormation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intituleFormation.Location = new System.Drawing.Point(218, 72);
            this.intituleFormation.Name = "intituleFormation";
            this.intituleFormation.ReadOnly = true;
            this.intituleFormation.Size = new System.Drawing.Size(196, 26);
            this.intituleFormation.TabIndex = 2;
            // 
            // minFormation
            // 
            // 
            // 
            // 
            this.minFormation.Border.Class = "TextBoxBorder";
            this.minFormation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.minFormation.Location = new System.Drawing.Point(218, 108);
            this.minFormation.Name = "minFormation";
            this.minFormation.ReadOnly = true;
            this.minFormation.Size = new System.Drawing.Size(196, 26);
            this.minFormation.TabIndex = 3;
            // 
            // maxFormation
            // 
            // 
            // 
            // 
            this.maxFormation.Border.Class = "TextBoxBorder";
            this.maxFormation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.maxFormation.Location = new System.Drawing.Point(218, 144);
            this.maxFormation.Name = "maxFormation";
            this.maxFormation.ReadOnly = true;
            this.maxFormation.Size = new System.Drawing.Size(196, 26);
            this.maxFormation.TabIndex = 4;
            // 
            // objectFormation
            // 
            // 
            // 
            // 
            this.objectFormation.Border.Class = "TextBoxBorder";
            this.objectFormation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.objectFormation.Location = new System.Drawing.Point(470, 73);
            this.objectFormation.Multiline = true;
            this.objectFormation.Name = "objectFormation";
            this.objectFormation.ReadOnly = true;
            this.objectFormation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.objectFormation.Size = new System.Drawing.Size(351, 152);
            this.objectFormation.TabIndex = 5;
            // 
            // modifFormation
            // 
            this.modifFormation.AutoSize = true;
            this.modifFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifFormation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifFormation.Location = new System.Drawing.Point(218, 194);
            this.modifFormation.Name = "modifFormation";
            this.modifFormation.Size = new System.Drawing.Size(86, 31);
            this.modifFormation.TabIndex = 100;
            this.modifFormation.Text = "Supprimer";
            this.modifFormation.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.listeFormation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.listeFormation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listeFormation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeFormation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.listeFormation.ColumnHeadersHeight = 45;
            this.listeFormation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeFormation.DefaultCellStyle = dataGridViewCellStyle11;
            this.listeFormation.GridColor = System.Drawing.Color.Black;
            this.listeFormation.HighlightSelectedColumnHeaders = false;
            this.listeFormation.Location = new System.Drawing.Point(36, 232);
            this.listeFormation.Name = "listeFormation";
            this.listeFormation.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeFormation.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            // supFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "supFormation";
            this.Text = "Supprimer formation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeFormation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox codeFormation;
        private DevComponents.DotNetBar.Controls.TextBoxX RechT;
        private DevComponents.DotNetBar.Controls.TextBoxX intituleFormation;
        private DevComponents.DotNetBar.Controls.TextBoxX minFormation;
        private DevComponents.DotNetBar.Controls.TextBoxX maxFormation;
        private DevComponents.DotNetBar.Controls.TextBoxX objectFormation;
        private System.Windows.Forms.Button modifFormation;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX listeFormation;
        private System.Windows.Forms.Button annulerFormation;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX _designation;

    }
}