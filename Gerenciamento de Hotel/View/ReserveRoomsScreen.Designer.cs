namespace Gerenciamento_de_Hotel.View
{
    partial class ReserveRoomsScreen
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
            this.txtb_quantDias = new System.Windows.Forms.TextBox();
            this.lb_quantDias = new System.Windows.Forms.Label();
            this.cb_quarto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_cpf
            // 
            this.txtb_cpf.Location = new System.Drawing.Point(307, 171);
            this.txtb_cpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_cpf.Name = "txtb_cpf";
            this.txtb_cpf.Size = new System.Drawing.Size(226, 22);
            this.txtb_cpf.TabIndex = 4;
            this.txtb_cpf.Tag = "Oi";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(12, 168);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(230, 24);
            this.lb_cpf.TabIndex = 3;
            this.lb_cpf.Text = "Digite o CPF do Hóspede:";
            // 
            // txtb_quantDias
            // 
            this.txtb_quantDias.Location = new System.Drawing.Point(307, 223);
            this.txtb_quantDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_quantDias.Name = "txtb_quantDias";
            this.txtb_quantDias.Size = new System.Drawing.Size(226, 22);
            this.txtb_quantDias.TabIndex = 8;
            this.txtb_quantDias.Tag = "Oi";
            // 
            // lb_quantDias
            // 
            this.lb_quantDias.AutoSize = true;
            this.lb_quantDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantDias.Location = new System.Drawing.Point(12, 223);
            this.lb_quantDias.Name = "lb_quantDias";
            this.lb_quantDias.Size = new System.Drawing.Size(258, 24);
            this.lb_quantDias.TabIndex = 7;
            this.lb_quantDias.Text = "Informe a quantidade de dias:";
            // 
            // cb_quarto
            // 
            this.cb_quarto.FormattingEnabled = true;
            this.cb_quarto.Location = new System.Drawing.Point(307, 341);
            this.cb_quarto.Name = "cb_quarto";
            this.cb_quarto.Size = new System.Drawing.Size(226, 24);
            this.cb_quarto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione o quarto para reserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Informações do quarto selecionado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Para realizar filtro dos quartos";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(307, 278);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(226, 26);
            this.btn_filtrar.TabIndex = 13;
            this.btn_filtrar.Text = "Clique Aqui";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            // 
            // ReserveRoomsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 437);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_quarto);
            this.Controls.Add(this.txtb_quantDias);
            this.Controls.Add(this.lb_quantDias);
            this.Controls.Add(this.txtb_cpf);
            this.Controls.Add(this.lb_cpf);
            this.Name = "ReserveRoomsScreen";
            this.Text = "ReserveRoomsScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_cpf;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.TextBox txtb_quantDias;
        private System.Windows.Forms.Label lb_quantDias;
        private System.Windows.Forms.ComboBox cb_quarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_filtrar;
    }
}