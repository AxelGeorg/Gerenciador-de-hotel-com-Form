namespace Gerenciamento_de_Hotel.View.ConsumablesCRUD
{
    partial class UpdateConsumablesScreen
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
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txtb_consumablesAlterar = new System.Windows.Forms.TextBox();
            this.lbl_empAlterar = new System.Windows.Forms.Label();
            this.listView_consumables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_opcoesAlterar = new System.Windows.Forms.Label();
            this.cbox_opcoes = new System.Windows.Forms.ComboBox();
            this.txtb_novoAlterar = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.cbox_tipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(2, 1);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 11;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.Location = new System.Drawing.Point(451, 116);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(210, 23);
            this.btn_pesquisar.TabIndex = 35;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txtb_consumablesAlterar
            // 
            this.txtb_consumablesAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_consumablesAlterar.Location = new System.Drawing.Point(12, 117);
            this.txtb_consumablesAlterar.Name = "txtb_consumablesAlterar";
            this.txtb_consumablesAlterar.Size = new System.Drawing.Size(388, 20);
            this.txtb_consumablesAlterar.TabIndex = 34;
            this.txtb_consumablesAlterar.TextChanged += new System.EventHandler(this.txtb_consumablesAlterar_TextChanged);
            // 
            // lbl_empAlterar
            // 
            this.lbl_empAlterar.AutoSize = true;
            this.lbl_empAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_empAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_empAlterar.Location = new System.Drawing.Point(12, 78);
            this.lbl_empAlterar.Name = "lbl_empAlterar";
            this.lbl_empAlterar.Size = new System.Drawing.Size(291, 17);
            this.lbl_empAlterar.TabIndex = 33;
            this.lbl_empAlterar.Text = "Digite o nome do produto que deseja alterar:";
            // 
            // listView_consumables
            // 
            this.listView_consumables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_consumables.GridLines = true;
            this.listView_consumables.HideSelection = false;
            this.listView_consumables.Location = new System.Drawing.Point(12, 183);
            this.listView_consumables.Name = "listView_consumables";
            this.listView_consumables.Scrollable = false;
            this.listView_consumables.Size = new System.Drawing.Size(649, 59);
            this.listView_consumables.TabIndex = 36;
            this.listView_consumables.UseCompatibleStateImageBehavior = false;
            this.listView_consumables.View = System.Windows.Forms.View.Details;
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
            // lbl_opcoesAlterar
            // 
            this.lbl_opcoesAlterar.AutoSize = true;
            this.lbl_opcoesAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_opcoesAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_opcoesAlterar.Location = new System.Drawing.Point(12, 264);
            this.lbl_opcoesAlterar.Name = "lbl_opcoesAlterar";
            this.lbl_opcoesAlterar.Size = new System.Drawing.Size(205, 17);
            this.lbl_opcoesAlterar.TabIndex = 38;
            this.lbl_opcoesAlterar.Text = "Selecione o que deseja alterar:";
            // 
            // cbox_opcoes
            // 
            this.cbox_opcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_opcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_opcoes.FormattingEnabled = true;
            this.cbox_opcoes.Location = new System.Drawing.Point(15, 295);
            this.cbox_opcoes.Name = "cbox_opcoes";
            this.cbox_opcoes.Size = new System.Drawing.Size(202, 21);
            this.cbox_opcoes.TabIndex = 37;
            this.cbox_opcoes.SelectedIndexChanged += new System.EventHandler(this.cbox_opcoes_SelectedIndexChanged);
            // 
            // txtb_novoAlterar
            // 
            this.txtb_novoAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_novoAlterar.Location = new System.Drawing.Point(233, 296);
            this.txtb_novoAlterar.Name = "txtb_novoAlterar";
            this.txtb_novoAlterar.Size = new System.Drawing.Size(428, 20);
            this.txtb_novoAlterar.TabIndex = 39;
            this.txtb_novoAlterar.TextChanged += new System.EventHandler(this.txtb_novoAlterar_TextChanged);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_alterar.Location = new System.Drawing.Point(174, 339);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(317, 29);
            this.btn_alterar.TabIndex = 40;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // cbox_tipo
            // 
            this.cbox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo.FormattingEnabled = true;
            this.cbox_tipo.Location = new System.Drawing.Point(304, 296);
            this.cbox_tipo.Name = "cbox_tipo";
            this.cbox_tipo.Size = new System.Drawing.Size(279, 21);
            this.cbox_tipo.TabIndex = 41;
            this.cbox_tipo.SelectedIndexChanged += new System.EventHandler(this.cbox_tipo_SelectedIndexChanged);
            // 
            // UpdateConsumablesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.cbox_tipo);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.txtb_novoAlterar);
            this.Controls.Add(this.lbl_opcoesAlterar);
            this.Controls.Add(this.cbox_opcoes);
            this.Controls.Add(this.listView_consumables);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txtb_consumablesAlterar);
            this.Controls.Add(this.lbl_empAlterar);
            this.Controls.Add(this.btn_comeBack);
            this.Name = "UpdateConsumablesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateConsumablesScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txtb_consumablesAlterar;
        private System.Windows.Forms.Label lbl_empAlterar;
        private System.Windows.Forms.ListView listView_consumables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbl_opcoesAlterar;
        private System.Windows.Forms.ComboBox cbox_opcoes;
        private System.Windows.Forms.TextBox txtb_novoAlterar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.ComboBox cbox_tipo;
    }
}