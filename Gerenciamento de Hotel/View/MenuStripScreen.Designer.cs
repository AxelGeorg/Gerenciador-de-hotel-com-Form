namespace Gerenciamento_de_Hotel.View
{
    partial class MenuStripScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStripScreen));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hóspedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarQuartosLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem,
            this.hóspedesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.verificarQuartosLivresToolStripMenuItem,
            this.informaçõesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1122, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesToolStripMenuItem1});
            this.hotelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.hotelToolStripMenuItem.Text = "Hotel";
            // 
            // informaçõesToolStripMenuItem1
            // 
            this.informaçõesToolStripMenuItem1.Name = "informaçõesToolStripMenuItem1";
            this.informaçõesToolStripMenuItem1.Size = new System.Drawing.Size(117, 26);
            this.informaçõesToolStripMenuItem1.Text = "Sair";
            this.informaçõesToolStripMenuItem1.Click += new System.EventHandler(this.informaçõesToolStripMenuItem1_Click);
            // 
            // hóspedesToolStripMenuItem
            // 
            this.hóspedesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hóspedesToolStripMenuItem.Name = "hóspedesToolStripMenuItem";
            this.hóspedesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.hóspedesToolStripMenuItem.Text = "Hóspedes";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem1});
            this.funcionáriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(129, 26);
            this.loginToolStripMenuItem1.Text = "Login";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click);
            // 
            // verificarQuartosLivresToolStripMenuItem
            // 
            this.verificarQuartosLivresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verificarQuartosLivresToolStripMenuItem.Name = "verificarQuartosLivresToolStripMenuItem";
            this.verificarQuartosLivresToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.verificarQuartosLivresToolStripMenuItem.Text = "Verificar quartos livres";
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.informaçõesToolStripMenuItem.Text = "Sobre";
            // 
            // MenuStripScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.BackgroundImage = global::Gerenciamento_de_Hotel.Properties.Resources.logo12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1122, 543);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuStripScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuStripScreen";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóspedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarQuartosLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
    }
}