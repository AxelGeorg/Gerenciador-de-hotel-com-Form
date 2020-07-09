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
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txtb_quantCamaCasal = new System.Windows.Forms.TextBox();
            this.txt_identificacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_precoDiaria = new System.Windows.Forms.TextBox();
            this.txt_qunatCamaSolteiro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_qunatPessoas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(526, 386);
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
            // txtb_quantCamaCasal
            // 
            this.txtb_quantCamaCasal.Location = new System.Drawing.Point(481, 137);
            this.txtb_quantCamaCasal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_quantCamaCasal.Name = "txtb_quantCamaCasal";
            this.txtb_quantCamaCasal.Size = new System.Drawing.Size(397, 22);
            this.txtb_quantCamaCasal.TabIndex = 16;
            this.txtb_quantCamaCasal.TextChanged += new System.EventHandler(this.txtb_quantCamaCasal_TextChanged);
            this.txtb_quantCamaCasal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_quantCamaCasal_KeyPress);
            // 
            // txt_identificacao
            // 
            this.txt_identificacao.Location = new System.Drawing.Point(16, 137);
            this.txt_identificacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_identificacao.Name = "txt_identificacao";
            this.txt_identificacao.Size = new System.Drawing.Size(397, 22);
            this.txt_identificacao.TabIndex = 15;
            this.txt_identificacao.Tag = "Oi";
            //this.txt_identificacao.TextChanged += new System.EventHandler(this.txt_identificacao_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantidade de cama de casal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Identificação do Quarto:";
            // 
            // txt_precoDiaria
            // 
            this.txt_precoDiaria.Location = new System.Drawing.Point(484, 247);
            this.txt_precoDiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precoDiaria.Name = "txt_precoDiaria";
            this.txt_precoDiaria.Size = new System.Drawing.Size(397, 22);
            this.txt_precoDiaria.TabIndex = 20;
            //this.txt_precoDiaria.TextChanged += new System.EventHandler(this.txt_precoDiaria_TextChanged);
            this.txt_precoDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precoDiaria_KeyPress);
            // 
            // txt_qunatCamaSolteiro
            // 
            this.txt_qunatCamaSolteiro.Location = new System.Drawing.Point(19, 247);
            this.txt_qunatCamaSolteiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qunatCamaSolteiro.Name = "txt_qunatCamaSolteiro";
            this.txt_qunatCamaSolteiro.Size = new System.Drawing.Size(397, 22);
            this.txt_qunatCamaSolteiro.TabIndex = 19;
            this.txt_qunatCamaSolteiro.Tag = "Oi";
            this.txt_qunatCamaSolteiro.TextChanged += new System.EventHandler(this.txt_qunatCamaSolteiro_TextChanged);
            this.txt_qunatCamaSolteiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qunatCamaSolteiro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preço Diária R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantidade de cama de solteiro";
            // 
            // txt_qunatPessoas
            // 
            this.txt_qunatPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qunatPessoas.Location = new System.Drawing.Point(19, 386);
            this.txt_qunatPessoas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qunatPessoas.Name = "txt_qunatPessoas";
            this.txt_qunatPessoas.Size = new System.Drawing.Size(397, 27);
            this.txt_qunatPessoas.TabIndex = 22;
            this.txt_qunatPessoas.Tag = "Oi";
            //this.txt_qunatPessoas.TextChanged += new System.EventHandler(this.txt_qunatPessoas_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quantidade de pessoas no quarto:";
            // 
            // CreateRoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.txt_qunatPessoas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_precoDiaria);
            this.Controls.Add(this.txt_qunatCamaSolteiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_quantCamaCasal);
            this.Controls.Add(this.txt_identificacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_cadastrar);
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
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtb_quantCamaCasal;
        private System.Windows.Forms.TextBox txt_identificacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_precoDiaria;
        private System.Windows.Forms.TextBox txt_qunatCamaSolteiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_qunatPessoas;
        private System.Windows.Forms.Label label6;
    }
}