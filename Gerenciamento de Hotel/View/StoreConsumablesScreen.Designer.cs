namespace Gerenciamento_de_Hotel.View
{
    partial class StoreConsumablesScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_semProdutos = new System.Windows.Forms.Label();
            this.lbl_ordenar = new System.Windows.Forms.Label();
            this.cbox_ordem = new System.Windows.Forms.ComboBox();
            this.btn_comprarProduto = new System.Windows.Forms.Button();
            this.listView_consumables = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loja do hotel";
            // 
            // lbl_semProdutos
            // 
            this.lbl_semProdutos.AutoSize = true;
            this.lbl_semProdutos.Location = new System.Drawing.Point(344, 233);
            this.lbl_semProdutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_semProdutos.Name = "lbl_semProdutos";
            this.lbl_semProdutos.Size = new System.Drawing.Size(194, 17);
            this.lbl_semProdutos.TabIndex = 1;
            this.lbl_semProdutos.Text = "Não há produtos disponíveis!!";
            // 
            // lbl_ordenar
            // 
            this.lbl_ordenar.AutoSize = true;
            this.lbl_ordenar.Location = new System.Drawing.Point(16, 75);
            this.lbl_ordenar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ordenar.Name = "lbl_ordenar";
            this.lbl_ordenar.Size = new System.Drawing.Size(90, 17);
            this.lbl_ordenar.TabIndex = 2;
            this.lbl_ordenar.Text = "Ordenar por:";
            // 
            // cbox_ordem
            // 
            this.cbox_ordem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ordem.FormattingEnabled = true;
            this.cbox_ordem.Location = new System.Drawing.Point(112, 71);
            this.cbox_ordem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_ordem.Name = "cbox_ordem";
            this.cbox_ordem.Size = new System.Drawing.Size(177, 24);
            this.cbox_ordem.TabIndex = 3;
            this.cbox_ordem.SelectedIndexChanged += new System.EventHandler(this.cbox_ordem_SelectedIndexChanged);
            // 
            // btn_comprarProduto
            // 
            this.btn_comprarProduto.Location = new System.Drawing.Point(308, 430);
            this.btn_comprarProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_comprarProduto.Name = "btn_comprarProduto";
            this.btn_comprarProduto.Size = new System.Drawing.Size(291, 34);
            this.btn_comprarProduto.TabIndex = 35;
            this.btn_comprarProduto.Text = "Comprar Item";
            this.btn_comprarProduto.UseVisualStyleBackColor = true;
            this.btn_comprarProduto.Click += new System.EventHandler(this.btn_comprarProduto_Click);
            // 
            // listView_consumables
            // 
            this.listView_consumables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView_consumables.FullRowSelect = true;
            this.listView_consumables.GridLines = true;
            this.listView_consumables.HideSelection = false;
            this.listView_consumables.Location = new System.Drawing.Point(16, 116);
            this.listView_consumables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_consumables.Name = "listView_consumables";
            this.listView_consumables.Scrollable = false;
            this.listView_consumables.Size = new System.Drawing.Size(864, 286);
            this.listView_consumables.TabIndex = 36;
            this.listView_consumables.UseCompatibleStateImageBehavior = false;
            this.listView_consumables.View = System.Windows.Forms.View.Details;
            this.listView_consumables.SelectedIndexChanged += new System.EventHandler(this.listView_consumables_SelectedIndexChanged_1);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nome";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Produto";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sabor";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Preço";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Descrição";
            this.columnHeader11.Width = 150;
            // 
            // StoreConsumablesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.listView_consumables);
            this.Controls.Add(this.btn_comprarProduto);
            this.Controls.Add(this.cbox_ordem);
            this.Controls.Add(this.lbl_ordenar);
            this.Controls.Add(this.lbl_semProdutos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "StoreConsumablesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreConsumablesScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_semProdutos;
        private System.Windows.Forms.Label lbl_ordenar;
        private System.Windows.Forms.ComboBox cbox_ordem;
        private System.Windows.Forms.Button btn_comprarProduto;
        private System.Windows.Forms.ListView listView_consumables;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}