namespace appli
{
    partial class listeArticle
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
            this.detail = new DevComponents.DotNetBar.Command(this.components);
            this.superTooltipDetail = new DevComponents.DotNetBar.SuperTooltip();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // detail
            // 
            this.detail.Name = "detail";
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1010, 517);
            this.panel.TabIndex = 0;
            // 
            // listeArticle
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1010, 517);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "listeArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des articles";
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Command detail;
        private DevComponents.DotNetBar.SuperTooltip superTooltipDetail;
        private System.Windows.Forms.Panel panel;


    }
}