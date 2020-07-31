namespace Gerenciamento_de_Hotel.View
{
    partial class UpdateEmployeeScreen
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
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.listViewAlterar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtb_empAlterar = new System.Windows.Forms.TextBox();
            this.lbl_empAlterar = new System.Windows.Forms.Label();
            this.cbox_opcoes = new System.Windows.Forms.ComboBox();
            this.lbl_opcoesAlterar = new System.Windows.Forms.Label();
            this.txtb_novoAlterar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_alterar
            // 
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_alterar.Location = new System.Drawing.Point(176, 338);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(317, 29);
            this.btn_alterar.TabIndex = 25;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.Location = new System.Drawing.Point(400, 98);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(188, 23);
            this.btn_pesquisar.TabIndex = 24;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // listViewAlterar
            // 
            this.listViewAlterar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAlterar.GridLines = true;
            this.listViewAlterar.HideSelection = false;
            this.listViewAlterar.Location = new System.Drawing.Point(10, 136);
            this.listViewAlterar.Name = "listViewAlterar";
            this.listViewAlterar.Scrollable = false;
            this.listViewAlterar.Size = new System.Drawing.Size(654, 63);
            this.listViewAlterar.TabIndex = 23;
            this.listViewAlterar.UseCompatibleStateImageBehavior = false;
            this.listViewAlterar.View = System.Windows.Forms.View.Details;
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
            // txtb_empAlterar
            // 
            this.txtb_empAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_empAlterar.Location = new System.Drawing.Point(13, 101);
            this.txtb_empAlterar.Name = "txtb_empAlterar";
            this.txtb_empAlterar.Size = new System.Drawing.Size(294, 20);
            this.txtb_empAlterar.TabIndex = 22;
            this.txtb_empAlterar.TextChanged += new System.EventHandler(this.txtb_empAlterar_TextChanged);
            this.txtb_empAlterar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_cpf);
            // 
            // lbl_empAlterar
            // 
            this.lbl_empAlterar.AutoSize = true;
            this.lbl_empAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_empAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_empAlterar.Location = new System.Drawing.Point(10, 62);
            this.lbl_empAlterar.Name = "lbl_empAlterar";
            this.lbl_empAlterar.Size = new System.Drawing.Size(303, 17);
            this.lbl_empAlterar.TabIndex = 21;
            this.lbl_empAlterar.Text = "Digite o CPF do funcionário que deseja alterar:";
            // 
            // cbox_opcoes
            // 
            this.cbox_opcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_opcoes.FormattingEnabled = true;
            this.cbox_opcoes.Location = new System.Drawing.Point(10, 264);
            this.cbox_opcoes.Name = "cbox_opcoes";
            this.cbox_opcoes.Size = new System.Drawing.Size(185, 21);
            this.cbox_opcoes.TabIndex = 26;
            // 
            // lbl_opcoesAlterar
            // 
            this.lbl_opcoesAlterar.AutoSize = true;
            this.lbl_opcoesAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_opcoesAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_opcoesAlterar.Location = new System.Drawing.Point(7, 233);
            this.lbl_opcoesAlterar.Name = "lbl_opcoesAlterar";
            this.lbl_opcoesAlterar.Size = new System.Drawing.Size(205, 17);
            this.lbl_opcoesAlterar.TabIndex = 27;
            this.lbl_opcoesAlterar.Text = "Selecione o que deseja alterar:";
            // 
            // txtb_novoAlterar
            // 
            this.txtb_novoAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_novoAlterar.Location = new System.Drawing.Point(229, 264);
            this.txtb_novoAlterar.Name = "txtb_novoAlterar";
            this.txtb_novoAlterar.Size = new System.Drawing.Size(401, 20);
            this.txtb_novoAlterar.TabIndex = 28;
            this.txtb_novoAlterar.TextChanged += new System.EventHandler(this.txtb_novoAlterar_TextChanged);
            // 
            // UpdateEmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.txtb_novoAlterar);
            this.Controls.Add(this.lbl_opcoesAlterar);
            this.Controls.Add(this.cbox_opcoes);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.listViewAlterar);
            this.Controls.Add(this.txtb_empAlterar);
            this.Controls.Add(this.lbl_empAlterar);
            this.Name = "UpdateEmployeeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateEmployeeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.ListView listViewAlterar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtb_empAlterar;
        private System.Windows.Forms.Label lbl_empAlterar;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cbox_opcoes;
        private System.Windows.Forms.Label lbl_opcoesAlterar;
        private System.Windows.Forms.TextBox txtb_novoAlterar;
    }
}