namespace appli
{
    partial class etatVente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AutreEntrer = new System.Windows.Forms.GroupBox();
            this.valeur = new DevComponents.DotNetBar.LabelX();
            this.affiche = new System.Windows.Forms.Button();
            this.TRech = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.TListeVente = new System.Windows.Forms.DataGridView();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.montant = new DevComponents.DotNetBar.LabelX();
            this.commandRecette = new DevComponents.DotNetBar.Command(this.components);
            this.AutreEntrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TListeVente)).BeginInit();
            this.SuspendLayout();
            // 
            // AutreEntrer
            // 
            this.AutreEntrer.Controls.Add(this.montant);
            this.AutreEntrer.Controls.Add(this.valeur);
            this.AutreEntrer.Controls.Add(this.affiche);
            this.AutreEntrer.Controls.Add(this.TRech);
            this.AutreEntrer.Controls.Add(this.labelX5);
            this.AutreEntrer.Controls.Add(this.TListeVente);
            this.AutreEntrer.Controls.Add(this.labelX9);
            this.AutreEntrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutreEntrer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutreEntrer.Location = new System.Drawing.Point(47, 18);
            this.AutreEntrer.Name = "AutreEntrer";
            this.AutreEntrer.Size = new System.Drawing.Size(923, 495);
            this.AutreEntrer.TabIndex = 114;
            this.AutreEntrer.TabStop = false;
            this.AutreEntrer.Text = "Etat des ventes";
            // 
            // valeur
            // 
            // 
            // 
            // 
            this.valeur.BackgroundStyle.Class = "";
            this.valeur.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.valeur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valeur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.valeur.Location = new System.Drawing.Point(390, 63);
            this.valeur.Name = "valeur";
            this.valeur.Size = new System.Drawing.Size(156, 23);
            this.valeur.TabIndex = 149;
            this.valeur.Text = "Filtrer le tableau par:";
            this.valeur.Visible = false;
            // 
            // affiche
            // 
            this.affiche.AutoSize = true;
            this.affiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.affiche.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affiche.Location = new System.Drawing.Point(747, 18);
            this.affiche.Name = "affiche";
            this.affiche.Size = new System.Drawing.Size(164, 31);
            this.affiche.TabIndex = 148;
            this.affiche.Text = "Recette journalière";
            this.affiche.UseVisualStyleBackColor = true;
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
            this.TRech.Location = new System.Drawing.Point(152, 20);
            this.TRech.Name = "TRech";
            this.TRech.Size = new System.Drawing.Size(194, 26);
            this.TRech.TabIndex = 138;
            this.TRech.WatermarkText = "Date de facturation";
            this.TRech.TextChanged += new System.EventHandler(this.TRech_TextChanged);
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
            this.labelX5.Location = new System.Drawing.Point(6, 23);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(140, 23);
            this.labelX5.TabIndex = 137;
            this.labelX5.Text = "Filtrer le tableau par:";
            // 
            // TListeVente
            // 
            this.TListeVente.AllowUserToResizeColumns = false;
            this.TListeVente.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.TListeVente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.TListeVente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TListeVente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TListeVente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.TListeVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TListeVente.DefaultCellStyle = dataGridViewCellStyle13;
            this.TListeVente.GridColor = System.Drawing.Color.Black;
            this.TListeVente.Location = new System.Drawing.Point(6, 52);
            this.TListeVente.Name = "TListeVente";
            this.TListeVente.ReadOnly = true;
            this.TListeVente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TListeVente.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.TListeVente.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.TListeVente.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.TListeVente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TListeVente.Size = new System.Drawing.Size(905, 434);
            this.TListeVente.TabIndex = 114;
            this.TListeVente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TListeVente_CellContentClick);
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
            // montant
            // 
            // 
            // 
            // 
            this.montant.BackgroundStyle.Class = "";
            this.montant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.montant.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.montant.Location = new System.Drawing.Point(443, 20);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(226, 23);
            this.montant.TabIndex = 150;
            // 
            // commandRecette
            // 
            this.commandRecette.Name = "commandRecette";
            // 
            // etatVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 516);
            this.Controls.Add(this.AutreEntrer);
            this.DoubleBuffered = true;
            this.Name = "etatVente";
            this.Text = "Etat des ventes";
            this.Load += new System.EventHandler(this.etatVente_Load);
            this.AutreEntrer.ResumeLayout(false);
            this.AutreEntrer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TListeVente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AutreEntrer;
        private System.Windows.Forms.Button affiche;
        private DevComponents.DotNetBar.Controls.TextBoxX TRech;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.DataGridView TListeVente;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX valeur;
        private DevComponents.DotNetBar.LabelX montant;
        private DevComponents.DotNetBar.Command commandRecette;

    }
}