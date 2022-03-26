namespace appli
{
    partial class retirerCours
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.filtrer = new System.Windows.Forms.ComboBox();
            this.codeFormation = new System.Windows.Forms.ComboBox();
            this.numEnseignant = new System.Windows.Forms.ComboBox();
            this.TRechF = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.prenomEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.professionEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.intituleFormation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nomEnseignant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.listeEnseignant = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.BAnnuler = new System.Windows.Forms.Button();
            this.retirer = new System.Windows.Forms.Button();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeEnseignant)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.enseignant);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.filtrer);
            this.groupBox1.Controls.Add(this.codeFormation);
            this.groupBox1.Controls.Add(this.numEnseignant);
            this.groupBox1.Controls.Add(this.TRechF);
            this.groupBox1.Controls.Add(this.prenomEnseignant);
            this.groupBox1.Controls.Add(this.professionEnseignant);
            this.groupBox1.Controls.Add(this.telEnseignant);
            this.groupBox1.Controls.Add(this.intituleFormation);
            this.groupBox1.Controls.Add(this.nomEnseignant);
            this.groupBox1.Controls.Add(this.listeEnseignant);
            this.groupBox1.Controls.Add(this.BAnnuler);
            this.groupBox1.Controls.Add(this.retirer);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(54, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(902, 479);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retirer un cours à un enseignant";
            // 
            // enseignant
            // 
            this.enseignant.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.enseignant.Border.Class = "TextBoxBorder";
            this.enseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.enseignant.ForeColor = System.Drawing.Color.Black;
            this.enseignant.Location = new System.Drawing.Point(389, 226);
            this.enseignant.Name = "enseignant";
            this.enseignant.Size = new System.Drawing.Size(124, 26);
            this.enseignant.TabIndex = 105;
            this.enseignant.WatermarkText = "Entrer le nom";
            this.enseignant.TextChanged += new System.EventHandler(this.enseignant_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(487, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(136, 23);
            this.labelX2.TabIndex = 104;
            this.labelX2.Text = "Filtrer le tableau par:";
            // 
            // filtrer
            // 
            this.filtrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrer.FormattingEnabled = true;
            this.filtrer.Items.AddRange(new object[] {
            "Enseignant",
            "Formation"});
            this.filtrer.Location = new System.Drawing.Point(629, 16);
            this.filtrer.Name = "filtrer";
            this.filtrer.Size = new System.Drawing.Size(118, 29);
            this.filtrer.Sorted = true;
            this.filtrer.TabIndex = 103;
            this.filtrer.SelectedIndexChanged += new System.EventHandler(this.filtrer_SelectedIndexChanged);
            // 
            // codeFormation
            // 
            this.codeFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeFormation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeFormation.FormattingEnabled = true;
            this.codeFormation.Location = new System.Drawing.Point(629, 75);
            this.codeFormation.Name = "codeFormation";
            this.codeFormation.Size = new System.Drawing.Size(255, 29);
            this.codeFormation.Sorted = true;
            this.codeFormation.TabIndex = 102;
            this.codeFormation.SelectedIndexChanged += new System.EventHandler(this.codeFormation_SelectedIndexChanged);
            // 
            // numEnseignant
            // 
            this.numEnseignant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numEnseignant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEnseignant.FormattingEnabled = true;
            this.numEnseignant.Location = new System.Drawing.Point(97, 41);
            this.numEnseignant.Name = "numEnseignant";
            this.numEnseignant.Size = new System.Drawing.Size(255, 29);
            this.numEnseignant.Sorted = true;
            this.numEnseignant.TabIndex = 101;
            this.numEnseignant.SelectedIndexChanged += new System.EventHandler(this.numEnseignant_SelectedIndexChanged);
            // 
            // TRechF
            // 
            this.TRechF.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TRechF.Border.Class = "TextBoxBorder";
            this.TRechF.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TRechF.ForeColor = System.Drawing.Color.Black;
            this.TRechF.Location = new System.Drawing.Point(760, 18);
            this.TRechF.Name = "TRechF";
            this.TRechF.Size = new System.Drawing.Size(124, 26);
            this.TRechF.TabIndex = 100;
            this.TRechF.WatermarkText = "Entrer l\'intitule";
            this.TRechF.TextChanged += new System.EventHandler(this.TRechF_TextChanged);
            // 
            // prenomEnseignant
            // 
            this.prenomEnseignant.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.prenomEnseignant.Border.Class = "TextBoxBorder";
            this.prenomEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prenomEnseignant.ForeColor = System.Drawing.Color.Black;
            this.prenomEnseignant.Location = new System.Drawing.Point(97, 122);
            this.prenomEnseignant.Name = "prenomEnseignant";
            this.prenomEnseignant.ReadOnly = true;
            this.prenomEnseignant.Size = new System.Drawing.Size(255, 26);
            this.prenomEnseignant.TabIndex = 2;
            // 
            // professionEnseignant
            // 
            this.professionEnseignant.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.professionEnseignant.Border.Class = "TextBoxBorder";
            this.professionEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.professionEnseignant.ForeColor = System.Drawing.Color.Black;
            this.professionEnseignant.Location = new System.Drawing.Point(97, 159);
            this.professionEnseignant.Name = "professionEnseignant";
            this.professionEnseignant.ReadOnly = true;
            this.professionEnseignant.Size = new System.Drawing.Size(255, 26);
            this.professionEnseignant.TabIndex = 3;
            // 
            // telEnseignant
            // 
            this.telEnseignant.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.telEnseignant.Border.Class = "TextBoxBorder";
            this.telEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.telEnseignant.ForeColor = System.Drawing.Color.Black;
            this.telEnseignant.Location = new System.Drawing.Point(97, 191);
            this.telEnseignant.Name = "telEnseignant";
            this.telEnseignant.ReadOnly = true;
            this.telEnseignant.Size = new System.Drawing.Size(255, 26);
            this.telEnseignant.TabIndex = 5;
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
            this.intituleFormation.Location = new System.Drawing.Point(629, 118);
            this.intituleFormation.Name = "intituleFormation";
            this.intituleFormation.ReadOnly = true;
            this.intituleFormation.Size = new System.Drawing.Size(255, 26);
            this.intituleFormation.TabIndex = 6;
            // 
            // nomEnseignant
            // 
            this.nomEnseignant.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nomEnseignant.Border.Class = "TextBoxBorder";
            this.nomEnseignant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nomEnseignant.ForeColor = System.Drawing.Color.Black;
            this.nomEnseignant.Location = new System.Drawing.Point(97, 81);
            this.nomEnseignant.Name = "nomEnseignant";
            this.nomEnseignant.ReadOnly = true;
            this.nomEnseignant.Size = new System.Drawing.Size(255, 26);
            this.nomEnseignant.TabIndex = 1;
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeEnseignant.DefaultCellStyle = dataGridViewCellStyle3;
            this.listeEnseignant.GridColor = System.Drawing.Color.Black;
            this.listeEnseignant.HighlightSelectedColumnHeaders = false;
            this.listeEnseignant.Location = new System.Drawing.Point(16, 226);
            this.listeEnseignant.Name = "listeEnseignant";
            this.listeEnseignant.ReadOnly = true;
            this.listeEnseignant.RowHeadersVisible = false;
            this.listeEnseignant.SelectAllSignVisible = false;
            this.listeEnseignant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeEnseignant.Size = new System.Drawing.Size(869, 237);
            this.listeEnseignant.TabIndex = 99;
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
            // retirer
            // 
            this.retirer.AutoSize = true;
            this.retirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retirer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirer.Location = new System.Drawing.Point(629, 186);
            this.retirer.Name = "retirer";
            this.retirer.Size = new System.Drawing.Size(86, 31);
            this.retirer.TabIndex = 71;
            this.retirer.Text = "Retirer";
            this.retirer.UseVisualStyleBackColor = true;
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
            this.labelX6.Location = new System.Drawing.Point(16, 194);
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
            this.labelX4.Location = new System.Drawing.Point(487, 81);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(118, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "Code formation:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(487, 122);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(118, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Intitulé formation:";
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
            // retirerCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "retirerCours";
            this.Text = "Retirer cours";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeEnseignant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX enseignant;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ComboBox filtrer;
        private System.Windows.Forms.ComboBox codeFormation;
        private System.Windows.Forms.ComboBox numEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX TRechF;
        private DevComponents.DotNetBar.Controls.TextBoxX prenomEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX professionEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX telEnseignant;
        private DevComponents.DotNetBar.Controls.TextBoxX intituleFormation;
        private DevComponents.DotNetBar.Controls.TextBoxX nomEnseignant;
        private DevComponents.DotNetBar.Controls.DataGridViewX listeEnseignant;
        private System.Windows.Forms.Button BAnnuler;
        private System.Windows.Forms.Button retirer;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;

    }
}