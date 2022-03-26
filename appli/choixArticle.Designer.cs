namespace appli
{
    partial class choixArticle
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.TRech = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectTout = new DevComponents.DotNetBar.ButtonX();
            this.select1 = new DevComponents.DotNetBar.ButtonX();
            this.TArticleChoisi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.TListeArticle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.bEditPopup = new DevComponents.DotNetBar.ButtonItem();
            this.afficherDetail = new DevComponents.DotNetBar.ButtonItem();
            this.detailCommand = new DevComponents.DotNetBar.Command(this.components);
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TArticleChoisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TListeArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(37, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(136, 23);
            this.labelX2.TabIndex = 111;
            this.labelX2.Text = "Filtrer le tableau par:";
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
            this.TRech.Location = new System.Drawing.Point(257, 20);
            this.TRech.Name = "TRech";
            this.TRech.Size = new System.Drawing.Size(216, 26);
            this.TRech.TabIndex = 110;
            this.TRech.WatermarkText = "reference";
            this.TRech.TextChanged += new System.EventHandler(this.TRech_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.contextMenuBar1);
            this.groupBox1.Controls.Add(this.selectTout);
            this.groupBox1.Controls.Add(this.select1);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.TArticleChoisi);
            this.groupBox1.Controls.Add(this.TListeArticle);
            this.groupBox1.Controls.Add(this.TRech);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 464);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste";
            // 
            // selectTout
            // 
            this.selectTout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.selectTout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.selectTout.Location = new System.Drawing.Point(479, 271);
            this.selectTout.Name = "selectTout";
            this.selectTout.Size = new System.Drawing.Size(44, 38);
            this.selectTout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.selectTout.TabIndex = 113;
            this.selectTout.Text = ">>";
            // 
            // select1
            // 
            this.select1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.select1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.select1.Location = new System.Drawing.Point(479, 165);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(44, 38);
            this.select1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.select1.TabIndex = 112;
            this.select1.Text = ">";
            // 
            // TArticleChoisi
            // 
            this.TArticleChoisi.AllowUserToDeleteRows = false;
            this.TArticleChoisi.AllowUserToResizeColumns = false;
            this.TArticleChoisi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.TArticleChoisi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TArticleChoisi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TArticleChoisi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TArticleChoisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TArticleChoisi.ColumnHeadersHeight = 50;
            this.TArticleChoisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TArticleChoisi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.designation,
            this.type,
            this.quantite});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TArticleChoisi.DefaultCellStyle = dataGridViewCellStyle3;
            this.TArticleChoisi.GridColor = System.Drawing.Color.Black;
            this.TArticleChoisi.HighlightSelectedColumnHeaders = false;
            this.TArticleChoisi.Location = new System.Drawing.Point(529, 52);
            this.TArticleChoisi.Name = "TArticleChoisi";
            this.TArticleChoisi.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.TArticleChoisi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TArticleChoisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TArticleChoisi.ShowCellToolTips = false;
            this.TArticleChoisi.Size = new System.Drawing.Size(467, 406);
            this.TArticleChoisi.TabIndex = 111;
            this.TArticleChoisi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TArticleChoisi_CellContentClick);
            // 
            // TListeArticle
            // 
            this.TListeArticle.AllowUserToDeleteRows = false;
            this.TListeArticle.AllowUserToResizeColumns = false;
            this.TListeArticle.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.TListeArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TListeArticle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TListeArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TListeArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TListeArticle.ColumnHeadersHeight = 50;
            this.TListeArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TListeArticle.DefaultCellStyle = dataGridViewCellStyle7;
            this.TListeArticle.GridColor = System.Drawing.Color.Black;
            this.TListeArticle.HighlightSelectedColumnHeaders = false;
            this.TListeArticle.Location = new System.Drawing.Point(6, 52);
            this.TListeArticle.Name = "TListeArticle";
            this.TListeArticle.ReadOnly = true;
            this.TListeArticle.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.TListeArticle.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.TListeArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TListeArticle.ShowCellToolTips = false;
            this.TListeArticle.Size = new System.Drawing.Size(467, 406);
            this.TListeArticle.TabIndex = 99;
            this.TListeArticle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TListeArticle_CellClick);
            this.TListeArticle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TListeArticle_CellDoubleClick);
            this.TListeArticle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TListeArticle_MouseDown);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bEditPopup});
            this.contextMenuBar1.Location = new System.Drawing.Point(455, 231);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(150, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 114;
            this.contextMenuBar1.TabStop = false;
            // 
            // bEditPopup
            // 
            this.bEditPopup.AutoExpandOnClick = true;
            this.bEditPopup.GlobalName = "bEditPopup";
            this.bEditPopup.Name = "bEditPopup";
            this.bEditPopup.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bEditPopup.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.afficherDetail});
            this.bEditPopup.Text = "bEditPopup";
            // 
            // afficherDetail
            // 
            this.afficherDetail.BeginGroup = true;
            this.afficherDetail.GlobalName = "afficherDetail";
            this.afficherDetail.ImageIndex = 5;
            this.afficherDetail.Name = "afficherDetail";
            this.afficherDetail.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.afficherDetail.Text = "Afficher détail";
            // 
            // detailCommand
            // 
            this.detailCommand.Name = "detailCommand";
            // 
            // reference
            // 
            this.reference.HeaderText = "Référence";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            this.reference.Width = 125;
            // 
            // designation
            // 
            this.designation.HeaderText = "Désignation";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            this.designation.Width = 150;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 150;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantité demandée";
            this.quantite.Name = "quantite";
            // 
            // choixArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "choixArticle";
            this.Size = new System.Drawing.Size(1026, 521);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TArticleChoisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TListeArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX TRech;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX TListeArticle;
        private DevComponents.DotNetBar.Controls.DataGridViewX TArticleChoisi;
        private DevComponents.DotNetBar.ButtonX selectTout;
        private DevComponents.DotNetBar.ButtonX select1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem bEditPopup;
        private DevComponents.DotNetBar.ButtonItem afficherDetail;
        private DevComponents.DotNetBar.Command detailCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
    }
}
