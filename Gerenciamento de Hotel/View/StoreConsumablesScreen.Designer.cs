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
            this.listView_consumables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_comprarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loja do hotel";
            // 
            // lbl_semProdutos
            // 
            this.lbl_semProdutos.AutoSize = true;
            this.lbl_semProdutos.Location = new System.Drawing.Point(258, 189);
            this.lbl_semProdutos.Name = "lbl_semProdutos";
            this.lbl_semProdutos.Size = new System.Drawing.Size(149, 13);
            this.lbl_semProdutos.TabIndex = 1;
            this.lbl_semProdutos.Text = "Não há produtos disponíveis!!";
            // 
            // lbl_ordenar
            // 
            this.lbl_ordenar.AutoSize = true;
            this.lbl_ordenar.Location = new System.Drawing.Point(12, 61);
            this.lbl_ordenar.Name = "lbl_ordenar";
            this.lbl_ordenar.Size = new System.Drawing.Size(66, 13);
            this.lbl_ordenar.TabIndex = 2;
            this.lbl_ordenar.Text = "Ordenar por:";
            // 
            // cbox_ordem
            // 
            this.cbox_ordem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ordem.FormattingEnabled = true;
            this.cbox_ordem.Location = new System.Drawing.Point(84, 58);
            this.cbox_ordem.Name = "cbox_ordem";
            this.cbox_ordem.Size = new System.Drawing.Size(134, 21);
            this.cbox_ordem.TabIndex = 3;
            this.cbox_ordem.SelectedIndexChanged += new System.EventHandler(this.cbox_ordem_SelectedIndexChanged);
            // 
            // listView_consumables
            // 
            this.listView_consumables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_consumables.FullRowSelect = true;
            this.listView_consumables.GridLines = true;
            this.listView_consumables.HideSelection = false;
            this.listView_consumables.Location = new System.Drawing.Point(11, 93);
            this.listView_consumables.Name = "listView_consumables";
            this.listView_consumables.Size = new System.Drawing.Size(650, 240);
            this.listView_consumables.TabIndex = 34;
            this.listView_consumables.UseCompatibleStateImageBehavior = false;
            this.listView_consumables.View = System.Windows.Forms.View.Details;
            this.listView_consumables.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ordenar);
            this.listView_consumables.SelectedIndexChanged += new System.EventHandler(this.listView_consumables_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Produto";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sabor";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Descrição";
            this.columnHeader5.Width = 180;
            // 
            // btn_comprarProduto
            // 
            this.btn_comprarProduto.Location = new System.Drawing.Point(231, 349);
            this.btn_comprarProduto.Name = "btn_comprarProduto";
            this.btn_comprarProduto.Size = new System.Drawing.Size(218, 28);
            this.btn_comprarProduto.TabIndex = 35;
            this.btn_comprarProduto.Text = "Comprar Item";
            this.btn_comprarProduto.UseVisualStyleBackColor = true;
            this.btn_comprarProduto.Click += new System.EventHandler(this.btn_comprarProduto_Click);
            // 
            // StoreConsumablesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_comprarProduto);
            this.Controls.Add(this.listView_consumables);
            this.Controls.Add(this.cbox_ordem);
            this.Controls.Add(this.lbl_ordenar);
            this.Controls.Add(this.lbl_semProdutos);
            this.Controls.Add(this.label1);
            this.Name = "StoreConsumablesScreen";
            this.Text = "StoreConsumablesScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_semProdutos;
        private System.Windows.Forms.Label lbl_ordenar;
        private System.Windows.Forms.ComboBox cbox_ordem;
        private System.Windows.Forms.ListView listView_consumables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_comprarProduto;
    }
}