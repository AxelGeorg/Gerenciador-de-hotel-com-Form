namespace Gerenciamento_de_Hotel.View.GuestCRUD
{
    partial class DeleteGuestScreen
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
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.listView_guest = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txtb_guestDeletar = new System.Windows.Forms.TextBox();
            this.lbl_roomNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_deletar
            // 
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deletar.Location = new System.Drawing.Point(165, 316);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(317, 29);
            this.btn_deletar.TabIndex = 50;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(1, 1);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 49;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // listView_guest
            // 
            this.listView_guest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView_guest.GridLines = true;
            this.listView_guest.HideSelection = false;
            this.listView_guest.Location = new System.Drawing.Point(19, 158);
            this.listView_guest.Name = "listView_guest";
            this.listView_guest.Scrollable = false;
            this.listView_guest.Size = new System.Drawing.Size(642, 63);
            this.listView_guest.TabIndex = 48;
            this.listView_guest.UseCompatibleStateImageBehavior = false;
            this.listView_guest.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 35;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nome";
            this.columnHeader8.Width = 240;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Data de Nasciemnto";
            this.columnHeader9.Width = 164;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.Location = new System.Drawing.Point(473, 105);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(188, 23);
            this.btn_pesquisar.TabIndex = 47;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txtb_guestDeletar
            // 
            this.txtb_guestDeletar.CausesValidation = false;
            this.txtb_guestDeletar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_guestDeletar.Location = new System.Drawing.Point(19, 108);
            this.txtb_guestDeletar.Name = "txtb_guestDeletar";
            this.txtb_guestDeletar.Size = new System.Drawing.Size(404, 20);
            this.txtb_guestDeletar.TabIndex = 46;
            this.txtb_guestDeletar.TextChanged += new System.EventHandler(this.txtb_guestDeletar_TextChanged);
            // 
            // lbl_roomNumero
            // 
            this.lbl_roomNumero.AutoSize = true;
            this.lbl_roomNumero.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_roomNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_roomNumero.Location = new System.Drawing.Point(16, 71);
            this.lbl_roomNumero.Name = "lbl_roomNumero";
            this.lbl_roomNumero.Size = new System.Drawing.Size(291, 17);
            this.lbl_roomNumero.TabIndex = 45;
            this.lbl_roomNumero.Text = "Digite o CPF do hóspede que deseja deletar:";
            // 
            // DeleteGuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.listView_guest);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txtb_guestDeletar);
            this.Controls.Add(this.lbl_roomNumero);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeleteGuestScreen";
            this.Text = "DeleteGuestScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.ListView listView_guest;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txtb_guestDeletar;
        private System.Windows.Forms.Label lbl_roomNumero;
    }
}