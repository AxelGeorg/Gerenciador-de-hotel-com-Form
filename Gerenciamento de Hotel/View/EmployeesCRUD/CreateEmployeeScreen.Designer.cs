﻿namespace Gerenciamento_de_Hotel.View
{
    partial class CreateEmployeeScreen
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
            this.txtb_sobrenome = new System.Windows.Forms.TextBox();
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_titulo = new System.Windows.Forms.TextBox();
            this.txtb_cpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_senha = new System.Windows.Forms.TextBox();
            this.txtb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_sobrenome
            // 
            this.txtb_sobrenome.Location = new System.Drawing.Point(484, 118);
            this.txtb_sobrenome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_sobrenome.Name = "txtb_sobrenome";
            this.txtb_sobrenome.Size = new System.Drawing.Size(397, 22);
            this.txtb_sobrenome.TabIndex = 11;
            this.txtb_sobrenome.TextChanged += new System.EventHandler(this.txtb_sobrenome_TextChanged);
            // 
            // txtb_nome
            // 
            this.txtb_nome.Location = new System.Drawing.Point(19, 118);
            this.txtb_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(397, 22);
            this.txtb_nome.TabIndex = 10;
            this.txtb_nome.Tag = "Oi";
            this.txtb_nome.TextChanged += new System.EventHandler(this.txtb_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite seu sobrenome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite seu nome:";
            // 
            // txtb_titulo
            // 
            this.txtb_titulo.Location = new System.Drawing.Point(484, 222);
            this.txtb_titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_titulo.Name = "txtb_titulo";
            this.txtb_titulo.Size = new System.Drawing.Size(397, 22);
            this.txtb_titulo.TabIndex = 15;
            this.txtb_titulo.TextChanged += new System.EventHandler(this.txtb_titulo_TextChanged);
            // 
            // txtb_cpf
            // 
            this.txtb_cpf.Location = new System.Drawing.Point(19, 222);
            this.txtb_cpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_cpf.Name = "txtb_cpf";
            this.txtb_cpf.Size = new System.Drawing.Size(397, 22);
            this.txtb_cpf.TabIndex = 14;
            this.txtb_cpf.Tag = "Oi";
            this.txtb_cpf.TextChanged += new System.EventHandler(this.txtb_cpf_TextChanged);
            this.txtb_cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpf);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Digite seu título:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digite seu CPF:";
            // 
            // txtb_senha
            // 
            this.txtb_senha.Location = new System.Drawing.Point(484, 325);
            this.txtb_senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_senha.Name = "txtb_senha";
            this.txtb_senha.Size = new System.Drawing.Size(397, 22);
            this.txtb_senha.TabIndex = 19;
            this.txtb_senha.TextChanged += new System.EventHandler(this.txtb_senha_TextChanged);
            // 
            // txtb_email
            // 
            this.txtb_email.Location = new System.Drawing.Point(19, 325);
            this.txtb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_email.Name = "txtb_email";
            this.txtb_email.Size = new System.Drawing.Size(397, 22);
            this.txtb_email.TabIndex = 18;
            this.txtb_email.Tag = "Oi";
            this.txtb_email.TextChanged += new System.EventHandler(this.txtb_email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Digite a sua senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Digite seu e-mail:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Location = new System.Drawing.Point(263, 414);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(349, 41);
            this.btn_cadastrar.TabIndex = 20;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // CreateEmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txtb_senha);
            this.Controls.Add(this.txtb_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_titulo);
            this.Controls.Add(this.txtb_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_sobrenome);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CreateEmployeeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateEmployeeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_sobrenome;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_titulo;
        private System.Windows.Forms.TextBox txtb_cpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_senha;
        private System.Windows.Forms.TextBox txtb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}