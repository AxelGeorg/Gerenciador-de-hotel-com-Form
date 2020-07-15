namespace Gerenciamento_de_Hotel.View
{
    partial class DeleteRoomScreen
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
            this.listView_room = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txtb_roomDeletar = new System.Windows.Forms.TextBox();
            this.lbl_roomNumero = new System.Windows.Forms.Label();
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.columnHeader15});
            this.listView_room.GridLines = true;
            this.listView_room.HideSelection = false;
            this.listView_room.Location = new System.Drawing.Point(18, 149);
            this.listView_room.Name = "listView_room";
            this.listView_room.Scrollable = false;
            this.listView_room.Size = new System.Drawing.Size(648, 63);
            this.listView_room.TabIndex = 42;
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
            this.columnHeader8.Width = 70;
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
            this.columnHeader12.Width = 72;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Preço Diária";
            this.columnHeader13.Width = 93;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Quant. Pessoas";
            this.columnHeader15.Width = 95;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.Location = new System.Drawing.Point(423, 98);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(188, 23);
            this.btn_pesquisar.TabIndex = 41;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txtb_roomDeletar
            // 
            this.txtb_roomDeletar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_roomDeletar.Location = new System.Drawing.Point(18, 99);
            this.txtb_roomDeletar.Name = "txtb_roomDeletar";
            this.txtb_roomDeletar.Size = new System.Drawing.Size(324, 20);
            this.txtb_roomDeletar.TabIndex = 40;
            // 
            // lbl_roomNumero
            // 
            this.lbl_roomNumero.AutoSize = true;
            this.lbl_roomNumero.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_roomNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_roomNumero.Location = new System.Drawing.Point(15, 62);
            this.lbl_roomNumero.Name = "lbl_roomNumero";
            this.lbl_roomNumero.Size = new System.Drawing.Size(326, 17);
            this.lbl_roomNumero.TabIndex = 39;
            this.lbl_roomNumero.Text = "Digite a identificação do quarto que deseja deletar";
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(2, 2);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 43;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deletar.Location = new System.Drawing.Point(183, 260);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(317, 29);
            this.btn_deletar.TabIndex = 44;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // DeleteRoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 345);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.listView_room);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txtb_roomDeletar);
            this.Controls.Add(this.lbl_roomNumero);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeleteRoomScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRoomScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_room;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txtb_roomDeletar;
        private System.Windows.Forms.Label lbl_roomNumero;
        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.Button btn_deletar;
    }
}