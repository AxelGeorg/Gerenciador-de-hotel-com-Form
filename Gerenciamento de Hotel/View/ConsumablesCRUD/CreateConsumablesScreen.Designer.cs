namespace Gerenciamento_de_Hotel.View.ConsumablesCRUD
{
    partial class CreateConsumablesScreen
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
            this.btn_back = new System.Windows.Forms.Button();
            this.txtb_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_tipo = new System.Windows.Forms.ComboBox();
            this.cbox_sabor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1, 2);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 28);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txtb_descricao
            // 
            this.txtb_descricao.Location = new System.Drawing.Point(163, 228);
            this.txtb_descricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_descricao.Name = "txtb_descricao";
            this.txtb_descricao.Size = new System.Drawing.Size(273, 20);
            this.txtb_descricao.TabIndex = 30;
            this.txtb_descricao.Tag = "Oi";
            this.txtb_descricao.TextChanged += new System.EventHandler(this.txtb_descricao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Digite a descrição:";
            // 
            // txtb_nome
            // 
            this.txtb_nome.Location = new System.Drawing.Point(163, 67);
            this.txtb_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(276, 20);
            this.txtb_nome.TabIndex = 28;
            this.txtb_nome.Tag = "Oi";
            this.txtb_nome.TextChanged += new System.EventHandler(this.txtb_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Digite o nome:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Location = new System.Drawing.Point(128, 287);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(262, 27);
            this.btn_cadastrar.TabIndex = 34;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Selecione o sabor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Selecione o tipo:";
            // 
            // cbox_tipo
            // 
            this.cbox_tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo.FormattingEnabled = true;
            this.cbox_tipo.Location = new System.Drawing.Point(163, 118);
            this.cbox_tipo.Name = "cbox_tipo";
            this.cbox_tipo.Size = new System.Drawing.Size(276, 21);
            this.cbox_tipo.TabIndex = 37;
            this.cbox_tipo.SelectedIndexChanged += new System.EventHandler(this.cbox_tipo_SelectedIndexChanged);
            // 
            // cbox_sabor
            // 
            this.cbox_sabor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_sabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_sabor.FormattingEnabled = true;
            this.cbox_sabor.Location = new System.Drawing.Point(163, 176);
            this.cbox_sabor.Name = "cbox_sabor";
            this.cbox_sabor.Size = new System.Drawing.Size(276, 21);
            this.cbox_sabor.TabIndex = 38;
            this.cbox_sabor.SelectedIndexChanged += new System.EventHandler(this.cbox_sabor_SelectedIndexChanged);
            // 
            // CreateConsumablesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 335);
            this.Controls.Add(this.cbox_sabor);
            this.Controls.Add(this.cbox_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txtb_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Name = "CreateConsumablesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateConsumablesScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtb_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_tipo;
        private System.Windows.Forms.ComboBox cbox_sabor;
    }
}