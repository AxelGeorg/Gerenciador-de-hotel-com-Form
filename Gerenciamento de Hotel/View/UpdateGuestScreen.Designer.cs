namespace Gerenciamento_de_Hotel.View
{
    partial class UpdateGuestScreen
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
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.txtb_novoAlterar = new System.Windows.Forms.TextBox();
            this.lbl_opcoesAlterar = new System.Windows.Forms.Label();
            this.cbox_opcoes = new System.Windows.Forms.ComboBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txtb_guestAlterar = new System.Windows.Forms.TextBox();
            this.lbl_empAlterar = new System.Windows.Forms.Label();
            this.listView_guest = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_barra2 = new System.Windows.Forms.Label();
            this.lbl_barra1 = new System.Windows.Forms.Label();
            this.txtb_mes = new System.Windows.Forms.TextBox();
            this.txtb_ano = new System.Windows.Forms.TextBox();
            this.txtb_dia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(1, 0);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 10;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // txtb_novoAlterar
            // 
            this.txtb_novoAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_novoAlterar.Location = new System.Drawing.Point(231, 273);
            this.txtb_novoAlterar.Name = "txtb_novoAlterar";
            this.txtb_novoAlterar.Size = new System.Drawing.Size(428, 20);
            this.txtb_novoAlterar.TabIndex = 36;
            this.txtb_novoAlterar.TextChanged += new System.EventHandler(this.txtb_novoAlterar_TextChanged);
            // 
            // lbl_opcoesAlterar
            // 
            this.lbl_opcoesAlterar.AutoSize = true;
            this.lbl_opcoesAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_opcoesAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_opcoesAlterar.Location = new System.Drawing.Point(9, 242);
            this.lbl_opcoesAlterar.Name = "lbl_opcoesAlterar";
            this.lbl_opcoesAlterar.Size = new System.Drawing.Size(205, 17);
            this.lbl_opcoesAlterar.TabIndex = 35;
            this.lbl_opcoesAlterar.Text = "Selecione o que deseja alterar:";
            // 
            // cbox_opcoes
            // 
            this.cbox_opcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_opcoes.FormattingEnabled = true;
            this.cbox_opcoes.Location = new System.Drawing.Point(12, 273);
            this.cbox_opcoes.Name = "cbox_opcoes";
            this.cbox_opcoes.Size = new System.Drawing.Size(185, 21);
            this.cbox_opcoes.TabIndex = 34;
            this.cbox_opcoes.SelectedIndexChanged += new System.EventHandler(this.cbox_opcoes_SelectedIndexChanged);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_alterar.Location = new System.Drawing.Point(176, 332);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(317, 29);
            this.btn_alterar.TabIndex = 33;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.Location = new System.Drawing.Point(402, 107);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(188, 23);
            this.btn_pesquisar.TabIndex = 32;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txtb_guestAlterar
            // 
            this.txtb_guestAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_guestAlterar.Location = new System.Drawing.Point(15, 110);
            this.txtb_guestAlterar.Name = "txtb_guestAlterar";
            this.txtb_guestAlterar.Size = new System.Drawing.Size(294, 20);
            this.txtb_guestAlterar.TabIndex = 30;
            this.txtb_guestAlterar.TextChanged += new System.EventHandler(this.txtb_guestAlterar_TextChanged);
            // 
            // lbl_empAlterar
            // 
            this.lbl_empAlterar.AutoSize = true;
            this.lbl_empAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_empAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_empAlterar.Location = new System.Drawing.Point(12, 71);
            this.lbl_empAlterar.Name = "lbl_empAlterar";
            this.lbl_empAlterar.Size = new System.Drawing.Size(288, 17);
            this.lbl_empAlterar.TabIndex = 29;
            this.lbl_empAlterar.Text = "Digite o CPF do hóspede que deseja alterar:";
            // 
            // listView_guest
            // 
            this.listView_guest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_guest.GridLines = true;
            this.listView_guest.HideSelection = false;
            this.listView_guest.Location = new System.Drawing.Point(15, 154);
            this.listView_guest.Name = "listView_guest";
            this.listView_guest.Scrollable = false;
            this.listView_guest.Size = new System.Drawing.Size(644, 76);
            this.listView_guest.TabIndex = 37;
            this.listView_guest.UseCompatibleStateImageBehavior = false;
            this.listView_guest.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 161;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPF";
            this.columnHeader3.Width = 161;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data de Nascimento";
            this.columnHeader4.Width = 161;
            // 
            // lbl_barra2
            // 
            this.lbl_barra2.AutoSize = true;
            this.lbl_barra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barra2.Location = new System.Drawing.Point(457, 271);
            this.lbl_barra2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_barra2.Name = "lbl_barra2";
            this.lbl_barra2.Size = new System.Drawing.Size(12, 18);
            this.lbl_barra2.TabIndex = 42;
            this.lbl_barra2.Text = "/";
            this.lbl_barra2.Visible = false;
            // 
            // lbl_barra1
            // 
            this.lbl_barra1.AutoSize = true;
            this.lbl_barra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barra1.Location = new System.Drawing.Point(387, 272);
            this.lbl_barra1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_barra1.Name = "lbl_barra1";
            this.lbl_barra1.Size = new System.Drawing.Size(12, 18);
            this.lbl_barra1.TabIndex = 41;
            this.lbl_barra1.Text = "/";
            this.lbl_barra1.Visible = false;
            // 
            // txtb_mes
            // 
            this.txtb_mes.Location = new System.Drawing.Point(402, 273);
            this.txtb_mes.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_mes.Name = "txtb_mes";
            this.txtb_mes.Size = new System.Drawing.Size(51, 20);
            this.txtb_mes.TabIndex = 40;
            this.txtb_mes.Tag = "Oi";
            this.txtb_mes.Visible = false;
            this.txtb_mes.TextChanged += new System.EventHandler(this.txtb_mes_TextChanged);
            // 
            // txtb_ano
            // 
            this.txtb_ano.Location = new System.Drawing.Point(472, 273);
            this.txtb_ano.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_ano.Name = "txtb_ano";
            this.txtb_ano.Size = new System.Drawing.Size(51, 20);
            this.txtb_ano.TabIndex = 39;
            this.txtb_ano.Tag = "Oi";
            this.txtb_ano.Visible = false;
            this.txtb_ano.TextChanged += new System.EventHandler(this.txtb_ano_TextChanged);
            // 
            // txtb_dia
            // 
            this.txtb_dia.Location = new System.Drawing.Point(332, 273);
            this.txtb_dia.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_dia.Name = "txtb_dia";
            this.txtb_dia.Size = new System.Drawing.Size(51, 20);
            this.txtb_dia.TabIndex = 38;
            this.txtb_dia.Tag = "Oi";
            this.txtb_dia.Visible = false;
            this.txtb_dia.TextChanged += new System.EventHandler(this.txtb_dia_TextChanged);
            // 
            // UpdateGuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.lbl_barra2);
            this.Controls.Add(this.lbl_barra1);
            this.Controls.Add(this.txtb_mes);
            this.Controls.Add(this.txtb_ano);
            this.Controls.Add(this.txtb_dia);
            this.Controls.Add(this.listView_guest);
            this.Controls.Add(this.txtb_novoAlterar);
            this.Controls.Add(this.lbl_opcoesAlterar);
            this.Controls.Add(this.cbox_opcoes);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txtb_guestAlterar);
            this.Controls.Add(this.lbl_empAlterar);
            this.Controls.Add(this.btn_comeBack);
            this.Name = "UpdateGuestScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateGuestScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.TextBox txtb_novoAlterar;
        private System.Windows.Forms.Label lbl_opcoesAlterar;
        private System.Windows.Forms.ComboBox cbox_opcoes;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txtb_guestAlterar;
        private System.Windows.Forms.Label lbl_empAlterar;
        private System.Windows.Forms.ListView listView_guest;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbl_barra2;
        private System.Windows.Forms.Label lbl_barra1;
        private System.Windows.Forms.TextBox txtb_mes;
        private System.Windows.Forms.TextBox txtb_ano;
        private System.Windows.Forms.TextBox txtb_dia;
    }
}