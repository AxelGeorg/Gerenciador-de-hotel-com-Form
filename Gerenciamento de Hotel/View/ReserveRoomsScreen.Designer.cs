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
            this.cbox_quarto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.lbl_numeroQuartoFixo = new System.Windows.Forms.Label();
            this.lbl_precoDiariaFixo = new System.Windows.Forms.Label();
            this.lbl_quantMaxPessoasFixo = new System.Windows.Forms.Label();
            this.lbl_precpTotalFixo = new System.Windows.Forms.Label();
            this.lbl_quantCamasCasalFixo = new System.Windows.Forms.Label();
            this.lbl_camasSolteiroFixo = new System.Windows.Forms.Label();
            this.lbl_precpTotalA = new System.Windows.Forms.Label();
            this.lbl_precoDiariaA = new System.Windows.Forms.Label();
            this.lbl_quantMaxPessoasA = new System.Windows.Forms.Label();
            this.lbl_camasSolteiroA = new System.Windows.Forms.Label();
            this.lbl_quantCamasCasalA = new System.Windows.Forms.Label();
            this.lbl_numeroQuartoA = new System.Windows.Forms.Label();
            this.btn_reservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_cpf
            // 
            this.txtb_cpf.Location = new System.Drawing.Point(315, 144);
            this.txtb_cpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_cpf.Name = "txtb_cpf";
            this.txtb_cpf.Size = new System.Drawing.Size(292, 22);
            this.txtb_cpf.TabIndex = 4;
            this.txtb_cpf.Tag = "Oi";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(12, 138);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(230, 24);
            this.lb_cpf.TabIndex = 3;
            this.lb_cpf.Text = "Digite o CPF do Hóspede:";
            // 
            // txtb_quantDias
            // 
            this.txtb_quantDias.Location = new System.Drawing.Point(315, 208);
            this.txtb_quantDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_quantDias.Name = "txtb_quantDias";
            this.txtb_quantDias.Size = new System.Drawing.Size(292, 22);
            this.txtb_quantDias.TabIndex = 8;
            this.txtb_quantDias.Tag = "Oi";
            this.txtb_quantDias.TextChanged += new System.EventHandler(this.txtb_quantDias_TextChanged);
            // 
            // lb_quantDias
            // 
            this.lb_quantDias.AutoSize = true;
            this.lb_quantDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantDias.Location = new System.Drawing.Point(12, 206);
            this.lb_quantDias.Name = "lb_quantDias";
            this.lb_quantDias.Size = new System.Drawing.Size(258, 24);
            this.lb_quantDias.TabIndex = 7;
            this.lb_quantDias.Text = "Informe a quantidade de dias:";
            // 
            // cbox_quarto
            // 
            this.cbox_quarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_quarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_quarto.FormattingEnabled = true;
            this.cbox_quarto.Location = new System.Drawing.Point(315, 343);
            this.cbox_quarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox_quarto.Name = "cbox_quarto";
            this.cbox_quarto.Size = new System.Drawing.Size(292, 24);
            this.cbox_quarto.TabIndex = 9;
            this.cbox_quarto.SelectedIndexChanged += new System.EventHandler(this.cbox_quarto_SelectedIndexChanged);
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
            this.label2.Location = new System.Drawing.Point(636, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Informações do quarto selecionado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Para realizar filtro dos quartos:";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtrar.Location = new System.Drawing.Point(315, 273);
            this.btn_filtrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(293, 26);
            this.btn_filtrar.TabIndex = 13;
            this.btn_filtrar.Text = "Clique Aqui";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(3, 1);
            this.btn_comeBack.Margin = new System.Windows.Forms.Padding(4);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(129, 34);
            this.btn_comeBack.TabIndex = 20;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // lbl_numeroQuartoFixo
            // 
            this.lbl_numeroQuartoFixo.AutoSize = true;
            this.lbl_numeroQuartoFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroQuartoFixo.Location = new System.Drawing.Point(661, 138);
            this.lbl_numeroQuartoFixo.Name = "lbl_numeroQuartoFixo";
            this.lbl_numeroQuartoFixo.Size = new System.Drawing.Size(84, 24);
            this.lbl_numeroQuartoFixo.TabIndex = 21;
            this.lbl_numeroQuartoFixo.Text = "Número:";
            // 
            // lbl_precoDiariaFixo
            // 
            this.lbl_precoDiariaFixo.AutoSize = true;
            this.lbl_precoDiariaFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precoDiariaFixo.Location = new System.Drawing.Point(661, 347);
            this.lbl_precoDiariaFixo.Name = "lbl_precoDiariaFixo";
            this.lbl_precoDiariaFixo.Size = new System.Drawing.Size(141, 24);
            this.lbl_precoDiariaFixo.TabIndex = 23;
            this.lbl_precoDiariaFixo.Text = "Preço da diária:";
            // 
            // lbl_quantMaxPessoasFixo
            // 
            this.lbl_quantMaxPessoasFixo.AutoSize = true;
            this.lbl_quantMaxPessoasFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantMaxPessoasFixo.Location = new System.Drawing.Point(661, 277);
            this.lbl_quantMaxPessoasFixo.Name = "lbl_quantMaxPessoasFixo";
            this.lbl_quantMaxPessoasFixo.Size = new System.Drawing.Size(277, 24);
            this.lbl_quantMaxPessoasFixo.TabIndex = 24;
            this.lbl_quantMaxPessoasFixo.Text = "Quantidade máxima de pessoa:";
            // 
            // lbl_precpTotalFixo
            // 
            this.lbl_precpTotalFixo.AutoSize = true;
            this.lbl_precpTotalFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precpTotalFixo.Location = new System.Drawing.Point(892, 347);
            this.lbl_precpTotalFixo.Name = "lbl_precpTotalFixo";
            this.lbl_precpTotalFixo.Size = new System.Drawing.Size(103, 24);
            this.lbl_precpTotalFixo.TabIndex = 25;
            this.lbl_precpTotalFixo.Text = "Preço total:";
            // 
            // lbl_quantCamasCasalFixo
            // 
            this.lbl_quantCamasCasalFixo.AutoSize = true;
            this.lbl_quantCamasCasalFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantCamasCasalFixo.Location = new System.Drawing.Point(661, 183);
            this.lbl_quantCamasCasalFixo.Name = "lbl_quantCamasCasalFixo";
            this.lbl_quantCamasCasalFixo.Size = new System.Drawing.Size(275, 24);
            this.lbl_quantCamasCasalFixo.TabIndex = 26;
            this.lbl_quantCamasCasalFixo.Text = "Quantidade de camas de casal:";
            // 
            // lbl_camasSolteiroFixo
            // 
            this.lbl_camasSolteiroFixo.AutoSize = true;
            this.lbl_camasSolteiroFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_camasSolteiroFixo.Location = new System.Drawing.Point(661, 234);
            this.lbl_camasSolteiroFixo.Name = "lbl_camasSolteiroFixo";
            this.lbl_camasSolteiroFixo.Size = new System.Drawing.Size(292, 24);
            this.lbl_camasSolteiroFixo.TabIndex = 27;
            this.lbl_camasSolteiroFixo.Text = "Quantidade de camas de solteiro:";
            // 
            // lbl_precpTotalA
            // 
            this.lbl_precpTotalA.AutoSize = true;
            this.lbl_precpTotalA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precpTotalA.Location = new System.Drawing.Point(1008, 347);
            this.lbl_precpTotalA.Name = "lbl_precpTotalA";
            this.lbl_precpTotalA.Size = new System.Drawing.Size(71, 24);
            this.lbl_precpTotalA.TabIndex = 28;
            this.lbl_precpTotalA.Text = "precoT";
            // 
            // lbl_precoDiariaA
            // 
            this.lbl_precoDiariaA.AutoSize = true;
            this.lbl_precoDiariaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precoDiariaA.Location = new System.Drawing.Point(811, 347);
            this.lbl_precoDiariaA.Name = "lbl_precoDiariaA";
            this.lbl_precoDiariaA.Size = new System.Drawing.Size(72, 24);
            this.lbl_precoDiariaA.TabIndex = 29;
            this.lbl_precoDiariaA.Text = "precoD";
            // 
            // lbl_quantMaxPessoasA
            // 
            this.lbl_quantMaxPessoasA.AutoSize = true;
            this.lbl_quantMaxPessoasA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantMaxPessoasA.Location = new System.Drawing.Point(968, 277);
            this.lbl_quantMaxPessoasA.Name = "lbl_quantMaxPessoasA";
            this.lbl_quantMaxPessoasA.Size = new System.Drawing.Size(119, 24);
            this.lbl_quantMaxPessoasA.TabIndex = 30;
            this.lbl_quantMaxPessoasA.Text = "numPessoas";
            // 
            // lbl_camasSolteiroA
            // 
            this.lbl_camasSolteiroA.AutoSize = true;
            this.lbl_camasSolteiroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_camasSolteiroA.Location = new System.Drawing.Point(968, 234);
            this.lbl_camasSolteiroA.Name = "lbl_camasSolteiroA";
            this.lbl_camasSolteiroA.Size = new System.Drawing.Size(111, 24);
            this.lbl_camasSolteiroA.TabIndex = 31;
            this.lbl_camasSolteiroA.Text = "numSolteiro";
            // 
            // lbl_quantCamasCasalA
            // 
            this.lbl_quantCamasCasalA.AutoSize = true;
            this.lbl_quantCamasCasalA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantCamasCasalA.Location = new System.Drawing.Point(968, 183);
            this.lbl_quantCamasCasalA.Name = "lbl_quantCamasCasalA";
            this.lbl_quantCamasCasalA.Size = new System.Drawing.Size(94, 24);
            this.lbl_quantCamasCasalA.TabIndex = 32;
            this.lbl_quantCamasCasalA.Text = "numCasal";
            // 
            // lbl_numeroQuartoA
            // 
            this.lbl_numeroQuartoA.AutoSize = true;
            this.lbl_numeroQuartoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroQuartoA.Location = new System.Drawing.Point(755, 138);
            this.lbl_numeroQuartoA.Name = "lbl_numeroQuartoA";
            this.lbl_numeroQuartoA.Size = new System.Drawing.Size(105, 24);
            this.lbl_numeroQuartoA.TabIndex = 33;
            this.lbl_numeroQuartoA.Text = "numQuarto";
            // 
            // btn_reservar
            // 
            this.btn_reservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reservar.Location = new System.Drawing.Point(815, 390);
            this.btn_reservar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reservar.Name = "btn_reservar";
            this.btn_reservar.Size = new System.Drawing.Size(281, 32);
            this.btn_reservar.TabIndex = 34;
            this.btn_reservar.Text = "Reservar";
            this.btn_reservar.UseVisualStyleBackColor = true;
            this.btn_reservar.Click += new System.EventHandler(this.btn_reservar_Click);
            // 
            // ReserveRoomsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 437);
            this.Controls.Add(this.btn_reservar);
            this.Controls.Add(this.lbl_numeroQuartoA);
            this.Controls.Add(this.lbl_quantCamasCasalA);
            this.Controls.Add(this.lbl_camasSolteiroA);
            this.Controls.Add(this.lbl_quantMaxPessoasA);
            this.Controls.Add(this.lbl_precoDiariaA);
            this.Controls.Add(this.lbl_precpTotalA);
            this.Controls.Add(this.lbl_camasSolteiroFixo);
            this.Controls.Add(this.lbl_quantCamasCasalFixo);
            this.Controls.Add(this.lbl_precpTotalFixo);
            this.Controls.Add(this.lbl_quantMaxPessoasFixo);
            this.Controls.Add(this.lbl_precoDiariaFixo);
            this.Controls.Add(this.lbl_numeroQuartoFixo);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_quarto);
            this.Controls.Add(this.txtb_quantDias);
            this.Controls.Add(this.lb_quantDias);
            this.Controls.Add(this.txtb_cpf);
            this.Controls.Add(this.lb_cpf);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReserveRoomsScreen";
            this.Text = "ReserveRoomsScreen";
            this.Load += new System.EventHandler(this.ReserveRoomsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_cpf;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.TextBox txtb_quantDias;
        private System.Windows.Forms.Label lb_quantDias;
        private System.Windows.Forms.ComboBox cbox_quarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.Label lbl_numeroQuartoFixo;
        private System.Windows.Forms.Label lbl_precoDiariaFixo;
        private System.Windows.Forms.Label lbl_quantMaxPessoasFixo;
        private System.Windows.Forms.Label lbl_precpTotalFixo;
        private System.Windows.Forms.Label lbl_quantCamasCasalFixo;
        private System.Windows.Forms.Label lbl_camasSolteiroFixo;
        private System.Windows.Forms.Label lbl_precpTotalA;
        private System.Windows.Forms.Label lbl_precoDiariaA;
        private System.Windows.Forms.Label lbl_quantMaxPessoasA;
        private System.Windows.Forms.Label lbl_camasSolteiroA;
        private System.Windows.Forms.Label lbl_quantCamasCasalA;
        private System.Windows.Forms.Label lbl_numeroQuartoA;
        private System.Windows.Forms.Button btn_reservar;
    }
}