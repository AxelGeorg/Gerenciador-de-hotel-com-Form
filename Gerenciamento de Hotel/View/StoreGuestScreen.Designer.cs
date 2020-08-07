namespace Gerenciamento_de_Hotel.View
{
    partial class StoreGuestScreen
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
            this.btn_teste = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosDisponíveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seuHistóricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_teste
            // 
            this.btn_teste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teste.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_teste.Location = new System.Drawing.Point(293, 407);
            this.btn_teste.Margin = new System.Windows.Forms.Padding(4);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(324, 33);
            this.btn_teste.TabIndex = 36;
            this.btn_teste.Text = "teste";
            this.btn_teste.UseVisualStyleBackColor = true;
            this.btn_teste.Click += new System.EventHandler(this.btn_teste_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem,
            this.lojaToolStripMenuItem,
            this.históricoDeCompraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telaInicialToolStripMenuItem});
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.hotelToolStripMenuItem.Text = "Home";
            // 
            // telaInicialToolStripMenuItem
            // 
            this.telaInicialToolStripMenuItem.Name = "telaInicialToolStripMenuItem";
            this.telaInicialToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.telaInicialToolStripMenuItem.Text = "Tela inicial";
            this.telaInicialToolStripMenuItem.Click += new System.EventHandler(this.telaInicialToolStripMenuItem_Click);
            // 
            // lojaToolStripMenuItem
            // 
            this.lojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosDisponíveisToolStripMenuItem});
            this.lojaToolStripMenuItem.Name = "lojaToolStripMenuItem";
            this.lojaToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.lojaToolStripMenuItem.Text = "Loja";
            // 
            // produtosDisponíveisToolStripMenuItem
            // 
            this.produtosDisponíveisToolStripMenuItem.Name = "produtosDisponíveisToolStripMenuItem";
            this.produtosDisponíveisToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.produtosDisponíveisToolStripMenuItem.Text = "Produtos Disponíveis ";
            this.produtosDisponíveisToolStripMenuItem.Click += new System.EventHandler(this.produtosDisponíveisToolStripMenuItem_Click);
            // 
            // históricoDeCompraToolStripMenuItem
            // 
            this.históricoDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seuHistóricoToolStripMenuItem});
            this.históricoDeCompraToolStripMenuItem.Name = "históricoDeCompraToolStripMenuItem";
            this.históricoDeCompraToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.históricoDeCompraToolStripMenuItem.Text = "Histórico de compra";
            // 
            // seuHistóricoToolStripMenuItem
            // 
            this.seuHistóricoToolStripMenuItem.Name = "seuHistóricoToolStripMenuItem";
            this.seuHistóricoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.seuHistóricoToolStripMenuItem.Text = "Seu histórico";
            this.seuHistóricoToolStripMenuItem.Click += new System.EventHandler(this.seuHistóricoToolStripMenuItem_Click);
            // 
            // StoreGuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.btn_teste);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StoreGuestScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreGuestScreen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_teste;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosDisponíveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seuHistóricoToolStripMenuItem;
    }
}