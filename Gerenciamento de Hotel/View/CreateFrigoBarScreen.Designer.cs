namespace Gerenciamento_de_Hotel.View
{
    partial class CreateFrigoBarScreen
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
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.cbox_produto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_identificacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Location = new System.Drawing.Point(209, 320);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(262, 33);
            this.btn_cadastrar.TabIndex = 33;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // cbox_produto
            // 
            this.cbox_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_produto.FormattingEnabled = true;
            this.cbox_produto.Location = new System.Drawing.Point(34, 217);
            this.cbox_produto.Name = "cbox_produto";
            this.cbox_produto.Size = new System.Drawing.Size(389, 21);
            this.cbox_produto.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Selecione o Produto correspondente:";
            // 
            // txtb_identificacao
            // 
            this.txtb_identificacao.Location = new System.Drawing.Point(34, 127);
            this.txtb_identificacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_identificacao.Name = "txtb_identificacao";
            this.txtb_identificacao.Size = new System.Drawing.Size(389, 20);
            this.txtb_identificacao.TabIndex = 30;
            this.txtb_identificacao.Tag = "Oi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Digite a identificação desejada do frigobar:";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1, 1);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 28);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CreateFrigoBarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.cbox_produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_identificacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Name = "CreateFrigoBarScreen";
            this.Text = "CreateFrigoBarScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.ComboBox cbox_produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_identificacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
    }
}