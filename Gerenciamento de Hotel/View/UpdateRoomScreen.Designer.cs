namespace Gerenciamento_de_Hotel.View
{
    partial class UpdateRoomScreen
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
            this.txtb_novoAlterar = new System.Windows.Forms.TextBox();
            this.lbl_opcoesAlterar = new System.Windows.Forms.Label();
            this.cbox_opcoes = new System.Windows.Forms.ComboBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txtb_roomAlterar = new System.Windows.Forms.TextBox();
            this.lbl_roomNumero = new System.Windows.Forms.Label();
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.listView_room = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtb_novoAlterar
            // 
            this.txtb_novoAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_novoAlterar.Location = new System.Drawing.Point(231, 280);
            this.txtb_novoAlterar.Name = "txtb_novoAlterar";
            this.txtb_novoAlterar.Size = new System.Drawing.Size(430, 20);
            this.txtb_novoAlterar.TabIndex = 37;
            this.txtb_novoAlterar.TextChanged += new System.EventHandler(this.txtb_novoAlterar_TextChanged);
            // 
            // lbl_opcoesAlterar
            // 
            this.lbl_opcoesAlterar.AutoSize = true;
            this.lbl_opcoesAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_opcoesAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_opcoesAlterar.Location = new System.Drawing.Point(9, 249);
            this.lbl_opcoesAlterar.Name = "lbl_opcoesAlterar";
            this.lbl_opcoesAlterar.Size = new System.Drawing.Size(205, 17);
            this.lbl_opcoesAlterar.TabIndex = 36;
            this.lbl_opcoesAlterar.Text = "Selecione o que deseja alterar:";
            // 
            // cbox_opcoes
            // 
            this.cbox_opcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_opcoes.FormattingEnabled = true;
            this.cbox_opcoes.Location = new System.Drawing.Point(12, 280);
            this.cbox_opcoes.Name = "cbox_opcoes";
            this.cbox_opcoes.Size = new System.Drawing.Size(185, 21);
            this.cbox_opcoes.TabIndex = 35;
            this.cbox_opcoes.SelectedIndexChanged += new System.EventHandler(this.cbox_opcoes_SelectedIndexChanged);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_alterar.Location = new System.Drawing.Point(176, 339);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(317, 29);
            this.btn_alterar.TabIndex = 34;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.Location = new System.Drawing.Point(417, 114);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(188, 23);
            this.btn_pesquisar.TabIndex = 33;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txtb_roomAlterar
            // 
            this.txtb_roomAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_roomAlterar.Location = new System.Drawing.Point(15, 117);
            this.txtb_roomAlterar.Name = "txtb_roomAlterar";
            this.txtb_roomAlterar.Size = new System.Drawing.Size(324, 20);
            this.txtb_roomAlterar.TabIndex = 31;
            this.txtb_roomAlterar.TextChanged += new System.EventHandler(this.txtb_roomAlterar_TextChanged);
            // 
            // lbl_roomNumero
            // 
            this.lbl_roomNumero.AutoSize = true;
            this.lbl_roomNumero.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_roomNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_roomNumero.Location = new System.Drawing.Point(12, 78);
            this.lbl_roomNumero.Name = "lbl_roomNumero";
            this.lbl_roomNumero.Size = new System.Drawing.Size(327, 17);
            this.lbl_roomNumero.TabIndex = 30;
            this.lbl_roomNumero.Text = "Digite a identificação do quarto que deseja alterar:";
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(1, 2);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 29;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // listView_room
            // 
            this.listView_room.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView_room.GridLines = true;
            this.listView_room.HideSelection = false;
            this.listView_room.Location = new System.Drawing.Point(12, 165);
            this.listView_room.Name = "listView_room";
            this.listView_room.Scrollable = false;
            this.listView_room.Size = new System.Drawing.Size(649, 63);
            this.listView_room.TabIndex = 38;
            this.listView_room.UseCompatibleStateImageBehavior = false;
            this.listView_room.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 35;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Número";
            this.columnHeader8.Width = 55;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Camas de casal";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Camas de Solteiro";
            this.columnHeader10.Width = 105;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Disponibilidade";
            this.columnHeader11.Width = 85;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Limpeza";
            this.columnHeader12.Width = 55;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Preço Diária";
            this.columnHeader13.Width = 70;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Preço Total";
            this.columnHeader14.Width = 67;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Quant. Pessoas";
            this.columnHeader15.Width = 87;
            // 
            // UpdateRoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.listView_room);
            this.Controls.Add(this.txtb_novoAlterar);
            this.Controls.Add(this.lbl_opcoesAlterar);
            this.Controls.Add(this.cbox_opcoes);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txtb_roomAlterar);
            this.Controls.Add(this.lbl_roomNumero);
            this.Controls.Add(this.btn_comeBack);
            this.Name = "UpdateRoomScreen";
            this.Text = "UpdateRoomScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_novoAlterar;
        private System.Windows.Forms.Label lbl_opcoesAlterar;
        private System.Windows.Forms.ComboBox cbox_opcoes;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txtb_roomAlterar;
        private System.Windows.Forms.Label lbl_roomNumero;
        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.ListView listView_room;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}