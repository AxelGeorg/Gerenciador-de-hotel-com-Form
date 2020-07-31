namespace Gerenciamento_de_Hotel.View
{
    partial class DeleteEmployeeScreen
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
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.listViewDeletar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtb_empDeletar = new System.Windows.Forms.TextBox();
            this.lbl_empDeletar = new System.Windows.Forms.Label();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.Location = new System.Drawing.Point(478, 103);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(188, 23);
            this.btn_pesquisar.TabIndex = 28;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // listViewDeletar
            // 
            this.listViewDeletar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDeletar.GridLines = true;
            this.listViewDeletar.HideSelection = false;
            this.listViewDeletar.Location = new System.Drawing.Point(12, 182);
            this.listViewDeletar.Name = "listViewDeletar";
            this.listViewDeletar.Scrollable = false;
            this.listViewDeletar.Size = new System.Drawing.Size(654, 63);
            this.listViewDeletar.TabIndex = 27;
            this.listViewDeletar.UseCompatibleStateImageBehavior = false;
            this.listViewDeletar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sobrenome";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CPF";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Título";
            this.columnHeader5.Width = 109;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 109;
            // 
            // txtb_empDeletar
            // 
            this.txtb_empDeletar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_empDeletar.Location = new System.Drawing.Point(15, 104);
            this.txtb_empDeletar.Name = "txtb_empDeletar";
            this.txtb_empDeletar.Size = new System.Drawing.Size(408, 20);
            this.txtb_empDeletar.TabIndex = 26;
            this.txtb_empDeletar.TextChanged += new System.EventHandler(this.txtb_empDeletar_TextChanged);
            this.txtb_empDeletar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpf);
            // 
            // lbl_empDeletar
            // 
            this.lbl_empDeletar.AutoSize = true;
            this.lbl_empDeletar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_empDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_empDeletar.Location = new System.Drawing.Point(12, 65);
            this.lbl_empDeletar.Name = "lbl_empDeletar";
            this.lbl_empDeletar.Size = new System.Drawing.Size(306, 17);
            this.lbl_empDeletar.TabIndex = 25;
            this.lbl_empDeletar.Text = "Digite o CPF do funcionário que deseja deletar:";
            // 
            // btn_deletar
            // 
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deletar.Location = new System.Drawing.Point(182, 312);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(317, 29);
            this.btn_deletar.TabIndex = 29;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // DeleteEmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 358);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.listViewDeletar);
            this.Controls.Add(this.txtb_empDeletar);
            this.Controls.Add(this.lbl_empDeletar);
            this.Name = "DeleteEmployeeScreen";
            this.Text = "DeleteEmployeeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.ListView listViewDeletar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtb_empDeletar;
        private System.Windows.Forms.Label lbl_empDeletar;
        private System.Windows.Forms.Button btn_deletar;
    }
}