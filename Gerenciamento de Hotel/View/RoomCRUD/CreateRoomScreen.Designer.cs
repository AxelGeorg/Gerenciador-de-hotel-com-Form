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
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txtb_quantCamaCasal = new System.Windows.Forms.TextBox();
            this.txtb_identificacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_precoDiaria = new System.Windows.Forms.TextBox();
            this.txtb_qunatCamaSolteiro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_qunatPessoas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Location = new System.Drawing.Point(296, 383);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(313, 34);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txtb_quantCamaCasal
            // 
            this.txtb_quantCamaCasal.Location = new System.Drawing.Point(484, 108);
            this.txtb_quantCamaCasal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_quantCamaCasal.Name = "txtb_quantCamaCasal";
            this.txtb_quantCamaCasal.Size = new System.Drawing.Size(397, 22);
            this.txtb_quantCamaCasal.TabIndex = 16;
            this.txtb_quantCamaCasal.TextChanged += new System.EventHandler(this.txtb_quantCamaCasal_TextChanged);
            this.txtb_quantCamaCasal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_quantCamaCasal_KeyPress);
            // 
            // txtb_identificacao
            // 
            this.txtb_identificacao.Location = new System.Drawing.Point(19, 108);
            this.txtb_identificacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_identificacao.Name = "txtb_identificacao";
            this.txtb_identificacao.Size = new System.Drawing.Size(397, 22);
            this.txtb_identificacao.TabIndex = 15;
            this.txtb_identificacao.Tag = "Oi";
            this.txtb_identificacao.TextChanged += new System.EventHandler(this.txtb_identificacao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantidade de cama de casal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Identificação do Quarto:";
            // 
            // txtb_precoDiaria
            // 
            this.txtb_precoDiaria.Location = new System.Drawing.Point(484, 204);
            this.txtb_precoDiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_precoDiaria.Name = "txtb_precoDiaria";
            this.txtb_precoDiaria.Size = new System.Drawing.Size(397, 22);
            this.txtb_precoDiaria.TabIndex = 20;
            this.txtb_precoDiaria.TextChanged += new System.EventHandler(this.txtb_precoDiaria_TextChanged);
            this.txtb_precoDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precoDiaria_KeyPress);
            // 
            // txtb_qunatCamaSolteiro
            // 
            this.txtb_qunatCamaSolteiro.Location = new System.Drawing.Point(17, 204);
            this.txtb_qunatCamaSolteiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_qunatCamaSolteiro.Name = "txtb_qunatCamaSolteiro";
            this.txtb_qunatCamaSolteiro.Size = new System.Drawing.Size(397, 22);
            this.txtb_qunatCamaSolteiro.TabIndex = 19;
            this.txtb_qunatCamaSolteiro.Tag = "Oi";
            this.txtb_qunatCamaSolteiro.TextChanged += new System.EventHandler(this.txt_qunatCamaSolteiro_TextChanged);
            this.txtb_qunatCamaSolteiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qunatCamaSolteiro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preço Diária R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantidade de cama de solteiro";
            // 
            // txtb_qunatPessoas
            // 
            this.txtb_qunatPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_qunatPessoas.Location = new System.Drawing.Point(21, 305);
            this.txtb_qunatPessoas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_qunatPessoas.Name = "txtb_qunatPessoas";
            this.txtb_qunatPessoas.Size = new System.Drawing.Size(397, 27);
            this.txtb_qunatPessoas.TabIndex = 22;
            this.txtb_qunatPessoas.Tag = "Oi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quantidade de pessoas no quarto:";
            // 
            // CreateRoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 442);
            this.Controls.Add(this.txtb_qunatPessoas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_precoDiaria);
            this.Controls.Add(this.txtb_qunatCamaSolteiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_quantCamaCasal);
            this.Controls.Add(this.txtb_identificacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CreateRoomScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRoomScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txtb_quantCamaCasal;
        private System.Windows.Forms.TextBox txtb_identificacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_precoDiaria;
        private System.Windows.Forms.TextBox txtb_qunatCamaSolteiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_qunatPessoas;
        private System.Windows.Forms.Label label6;
    }
}