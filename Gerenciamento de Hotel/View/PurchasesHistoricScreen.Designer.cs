namespace Gerenciamento_de_Hotel.View
{
    partial class PurchasesHistoricScreen
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
            this.listView_historico = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_historico
            // 
            this.listView_historico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_historico.GridLines = true;
            this.listView_historico.HideSelection = false;
            this.listView_historico.Location = new System.Drawing.Point(9, 10);
            this.listView_historico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView_historico.Name = "listView_historico";
            this.listView_historico.Scrollable = false;
            this.listView_historico.Size = new System.Drawing.Size(340, 253);
            this.listView_historico.TabIndex = 0;
            this.listView_historico.UseCompatibleStateImageBehavior = false;
            this.listView_historico.View = System.Windows.Forms.View.Details;
            this.listView_historico.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produto";
            this.columnHeader1.Width = 296;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preço";
            this.columnHeader2.Width = 154;
            // 
            // PurchasesHistoricScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 271);
            this.Controls.Add(this.listView_historico);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PurchasesHistoricScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchasesHistoricScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_historico;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}