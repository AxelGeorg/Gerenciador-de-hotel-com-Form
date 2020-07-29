namespace Gerenciamento_de_Hotel.View
{
    partial class CloseRoomsScreen
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
            this.txtb_cpf = new System.Windows.Forms.TextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.txtb_hospede = new System.Windows.Forms.TextBox();
            this.lbl_hospede = new System.Windows.Forms.Label();
            this.txtb_quarto = new System.Windows.Forms.TextBox();
            this.lbl_quarto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_precoTotal = new System.Windows.Forms.TextBox();
            this.rbtn_efetuado = new System.Windows.Forms.RadioButton();
            this.rbtn_pendente = new System.Windows.Forms.RadioButton();
            this.btn_checkOut = new System.Windows.Forms.Button();
            this.lbl_cliqueEnter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb_cpf
            // 
            this.txtb_cpf.Location = new System.Drawing.Point(186, 43);
            this.txtb_cpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_cpf.Name = "txtb_cpf";
            this.txtb_cpf.Size = new System.Drawing.Size(220, 20);
            this.txtb_cpf.TabIndex = 23;
            this.txtb_cpf.Tag = "Oi";
            this.txtb_cpf.TextChanged += new System.EventHandler(this.txtb_cpf_TextChanged);
            this.txtb_cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_cpf_KeyPress);
            this.txtb_cpf.Leave += new System.EventHandler(this.txtb_cpf_Leave);
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(9, 41);
            this.lb_cpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(181, 18);
            this.lb_cpf.TabIndex = 22;
            this.lb_cpf.Text = "Digite o CPF do Hóspede:";
            // 
            // txtb_hospede
            // 
            this.txtb_hospede.Enabled = false;
            this.txtb_hospede.Location = new System.Drawing.Point(90, 112);
            this.txtb_hospede.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_hospede.Name = "txtb_hospede";
            this.txtb_hospede.Size = new System.Drawing.Size(184, 20);
            this.txtb_hospede.TabIndex = 25;
            this.txtb_hospede.Tag = "Oi";
            // 
            // lbl_hospede
            // 
            this.lbl_hospede.AutoSize = true;
            this.lbl_hospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hospede.Location = new System.Drawing.Point(9, 112);
            this.lbl_hospede.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hospede.Name = "lbl_hospede";
            this.lbl_hospede.Size = new System.Drawing.Size(72, 18);
            this.lbl_hospede.TabIndex = 24;
            this.lbl_hospede.Text = "Hóspede:";
            // 
            // txtb_quarto
            // 
            this.txtb_quarto.Enabled = false;
            this.txtb_quarto.Location = new System.Drawing.Point(90, 147);
            this.txtb_quarto.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_quarto.Name = "txtb_quarto";
            this.txtb_quarto.Size = new System.Drawing.Size(184, 20);
            this.txtb_quarto.TabIndex = 27;
            this.txtb_quarto.Tag = "Oi";
            // 
            // lbl_quarto
            // 
            this.lbl_quarto.AutoSize = true;
            this.lbl_quarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quarto.Location = new System.Drawing.Point(9, 147);
            this.lbl_quarto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_quarto.Name = "lbl_quarto";
            this.lbl_quarto.Size = new System.Drawing.Size(58, 18);
            this.lbl_quarto.TabIndex = 26;
            this.lbl_quarto.Text = "Quarto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Preço Total a Pagar:";
            // 
            // txtb_precoTotal
            // 
            this.txtb_precoTotal.Enabled = false;
            this.txtb_precoTotal.Location = new System.Drawing.Point(148, 221);
            this.txtb_precoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_precoTotal.Name = "txtb_precoTotal";
            this.txtb_precoTotal.Size = new System.Drawing.Size(126, 20);
            this.txtb_precoTotal.TabIndex = 29;
            this.txtb_precoTotal.Tag = "Oi";
            // 
            // rbtn_efetuado
            // 
            this.rbtn_efetuado.AutoSize = true;
            this.rbtn_efetuado.Enabled = false;
            this.rbtn_efetuado.Location = new System.Drawing.Point(82, 272);
            this.rbtn_efetuado.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_efetuado.Name = "rbtn_efetuado";
            this.rbtn_efetuado.Size = new System.Drawing.Size(125, 17);
            this.rbtn_efetuado.TabIndex = 30;
            this.rbtn_efetuado.TabStop = true;
            this.rbtn_efetuado.Text = "Pagamento Efetuado";
            this.rbtn_efetuado.UseVisualStyleBackColor = true;
            this.rbtn_efetuado.CheckedChanged += new System.EventHandler(this.rbtn_efetuado_CheckedChanged);
            // 
            // rbtn_pendente
            // 
            this.rbtn_pendente.AutoSize = true;
            this.rbtn_pendente.Enabled = false;
            this.rbtn_pendente.Location = new System.Drawing.Point(218, 272);
            this.rbtn_pendente.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_pendente.Name = "rbtn_pendente";
            this.rbtn_pendente.Size = new System.Drawing.Size(128, 17);
            this.rbtn_pendente.TabIndex = 31;
            this.rbtn_pendente.TabStop = true;
            this.rbtn_pendente.Text = "Pagamento Pendente";
            this.rbtn_pendente.UseVisualStyleBackColor = true;
            this.rbtn_pendente.CheckedChanged += new System.EventHandler(this.rbtn_pendente_CheckedChanged);
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.Enabled = false;
            this.btn_checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkOut.Location = new System.Drawing.Point(162, 324);
            this.btn_checkOut.Margin = new System.Windows.Forms.Padding(2);
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(99, 27);
            this.btn_checkOut.TabIndex = 32;
            this.btn_checkOut.Text = "Check-Out";
            this.btn_checkOut.UseVisualStyleBackColor = true;
            this.btn_checkOut.Click += new System.EventHandler(this.btn_checkOut_Click);
            // 
            // lbl_cliqueEnter
            // 
            this.lbl_cliqueEnter.AutoSize = true;
            this.lbl_cliqueEnter.Location = new System.Drawing.Point(270, 65);
            this.lbl_cliqueEnter.Name = "lbl_cliqueEnter";
            this.lbl_cliqueEnter.Size = new System.Drawing.Size(136, 13);
            this.lbl_cliqueEnter.TabIndex = 33;
            this.lbl_cliqueEnter.Text = "Clique Enter para pesquisar";
            // 
            // CloseRoomsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 375);
            this.Controls.Add(this.lbl_cliqueEnter);
            this.Controls.Add(this.btn_checkOut);
            this.Controls.Add(this.rbtn_pendente);
            this.Controls.Add(this.rbtn_efetuado);
            this.Controls.Add(this.txtb_precoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_quarto);
            this.Controls.Add(this.lbl_quarto);
            this.Controls.Add(this.txtb_hospede);
            this.Controls.Add(this.lbl_hospede);
            this.Controls.Add(this.txtb_cpf);
            this.Controls.Add(this.lb_cpf);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CloseRoomsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Check-Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtb_cpf;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.TextBox txtb_hospede;
        private System.Windows.Forms.Label lbl_hospede;
        private System.Windows.Forms.TextBox txtb_quarto;
        private System.Windows.Forms.Label lbl_quarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_precoTotal;
        private System.Windows.Forms.RadioButton rbtn_efetuado;
        private System.Windows.Forms.RadioButton rbtn_pendente;
        private System.Windows.Forms.Button btn_checkOut;
        private System.Windows.Forms.Label lbl_cliqueEnter;
    }
}