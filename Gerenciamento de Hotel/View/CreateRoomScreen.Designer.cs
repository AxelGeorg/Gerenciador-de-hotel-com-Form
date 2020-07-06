namespace Gerenciamento_de_Hotel.View
{
    partial class CreateRoomScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_identificacao = new System.Windows.Forms.TextBox();
            this.txtb_qntdCasal = new System.Windows.Forms.TextBox();
            this.txtb_qntdSolteiro = new System.Windows.Forms.TextBox();
            this.txtb_peco = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Quartos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indentificação do Quarto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(479, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de camas de casal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(40, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade de camas de solteiro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(479, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço da diária R$";
            // 
            // txtb_identificacao
            // 
            this.txtb_identificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_identificacao.Location = new System.Drawing.Point(41, 140);
            this.txtb_identificacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_identificacao.Name = "txtb_identificacao";
            this.txtb_identificacao.Size = new System.Drawing.Size(377, 30);
            this.txtb_identificacao.TabIndex = 6;
            this.txtb_identificacao.TextChanged += new System.EventHandler(this.txt_identificacao_TextChanged);
            // 
            // txtb_qntdCasal
            // 
            this.txtb_qntdCasal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_qntdCasal.Location = new System.Drawing.Point(483, 140);
            this.txtb_qntdCasal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_qntdCasal.Name = "txtb_qntdCasal";
            this.txtb_qntdCasal.Size = new System.Drawing.Size(377, 30);
            this.txtb_qntdCasal.TabIndex = 7;
            // 
            // txtb_qntdSolteiro
            // 
            this.txtb_qntdSolteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_qntdSolteiro.Location = new System.Drawing.Point(41, 242);
            this.txtb_qntdSolteiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_qntdSolteiro.Name = "txtb_qntdSolteiro";
            this.txtb_qntdSolteiro.Size = new System.Drawing.Size(377, 30);
            this.txtb_qntdSolteiro.TabIndex = 8;
            // 
            // txtb_peco
            // 
            this.txtb_peco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_peco.Location = new System.Drawing.Point(483, 242);
            this.txtb_peco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_peco.Name = "txtb_peco";
            this.txtb_peco.Size = new System.Drawing.Size(377, 30);
            this.txtb_peco.TabIndex = 9;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(535, 414);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(313, 34);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(-1, -1);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(129, 34);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CreateRoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txtb_peco);
            this.Controls.Add(this.txtb_qntdSolteiro);
            this.Controls.Add(this.txtb_qntdCasal);
            this.Controls.Add(this.txtb_identificacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateRoomScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRoomScreen";
            this.Load += new System.EventHandler(this.CreateRoomScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_identificacao;
        private System.Windows.Forms.TextBox txtb_qntdCasal;
        private System.Windows.Forms.TextBox txtb_qntdSolteiro;
        private System.Windows.Forms.TextBox txtb_peco;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_back;
    }
}