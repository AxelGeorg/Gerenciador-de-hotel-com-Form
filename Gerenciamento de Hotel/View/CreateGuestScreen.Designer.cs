namespace Gerenciamento_de_Hotel.View
{
    partial class CreateGuestScreen
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
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_cpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_dia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_ano = new System.Windows.Forms.TextBox();
            this.txtb_mes = new System.Windows.Forms.TextBox();
            this.lbl_barra1 = new System.Windows.Forms.Label();
            this.lbl_barra2 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(2, 1);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 28);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txtb_nome
            // 
            this.txtb_nome.Location = new System.Drawing.Point(26, 129);
            this.txtb_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(299, 20);
            this.txtb_nome.TabIndex = 24;
            this.txtb_nome.Tag = "Oi";
            this.txtb_nome.TextChanged += new System.EventHandler(this.txtb_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Digite o nome do hóspede:";
            // 
            // txtb_cpf
            // 
            this.txtb_cpf.Location = new System.Drawing.Point(349, 129);
            this.txtb_cpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_cpf.Name = "txtb_cpf";
            this.txtb_cpf.Size = new System.Drawing.Size(299, 20);
            this.txtb_cpf.TabIndex = 26;
            this.txtb_cpf.Tag = "Oi";
            this.txtb_cpf.TextChanged += new System.EventHandler(this.txtb_cpf_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Digite o CPF do hóspede";
            // 
            // txtb_dia
            // 
            this.txtb_dia.Location = new System.Drawing.Point(26, 208);
            this.txtb_dia.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_dia.Name = "txtb_dia";
            this.txtb_dia.Size = new System.Drawing.Size(51, 20);
            this.txtb_dia.TabIndex = 28;
            this.txtb_dia.Tag = "Oi";
            this.txtb_dia.TextChanged += new System.EventHandler(this.txtb_dia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Digite a data de nascimento do hóspede:";
            // 
            // txtb_ano
            // 
            this.txtb_ano.Location = new System.Drawing.Point(166, 208);
            this.txtb_ano.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_ano.Name = "txtb_ano";
            this.txtb_ano.Size = new System.Drawing.Size(51, 20);
            this.txtb_ano.TabIndex = 29;
            this.txtb_ano.Tag = "Oi";
            this.txtb_ano.TextChanged += new System.EventHandler(this.txtb_ano_TextChanged);
            // 
            // txtb_mes
            // 
            this.txtb_mes.Location = new System.Drawing.Point(96, 208);
            this.txtb_mes.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_mes.Name = "txtb_mes";
            this.txtb_mes.Size = new System.Drawing.Size(51, 20);
            this.txtb_mes.TabIndex = 30;
            this.txtb_mes.Tag = "Oi";
            this.txtb_mes.TextChanged += new System.EventHandler(this.txtb_mes_TextChanged);
            // 
            // lbl_barra1
            // 
            this.lbl_barra1.AutoSize = true;
            this.lbl_barra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barra1.Location = new System.Drawing.Point(80, 206);
            this.lbl_barra1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_barra1.Name = "lbl_barra1";
            this.lbl_barra1.Size = new System.Drawing.Size(12, 18);
            this.lbl_barra1.TabIndex = 31;
            this.lbl_barra1.Text = "/";
            // 
            // lbl_barra2
            // 
            this.lbl_barra2.AutoSize = true;
            this.lbl_barra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barra2.Location = new System.Drawing.Point(151, 206);
            this.lbl_barra2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_barra2.Name = "lbl_barra2";
            this.lbl_barra2.Size = new System.Drawing.Size(12, 18);
            this.lbl_barra2.TabIndex = 32;
            this.lbl_barra2.Text = "/";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(206, 295);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(262, 33);
            this.btn_cadastrar.TabIndex = 33;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // CreateGuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_barra2);
            this.Controls.Add(this.lbl_barra1);
            this.Controls.Add(this.txtb_mes);
            this.Controls.Add(this.txtb_ano);
            this.Controls.Add(this.txtb_dia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateGuestScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateGuestScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_dia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_ano;
        private System.Windows.Forms.TextBox txtb_mes;
        private System.Windows.Forms.Label lbl_barra1;
        private System.Windows.Forms.Label lbl_barra2;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}