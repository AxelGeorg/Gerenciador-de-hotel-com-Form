namespace Gerenciamento_de_Hotel.View
{
    partial class EmployeeScreen
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
            this.btn_deletarEmp = new System.Windows.Forms.Button();
            this.btn_listarEmp = new System.Windows.Forms.Button();
            this.btn_atualizarEmp = new System.Windows.Forms.Button();
            this.btn_cadastrarEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(3, 3);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 9;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // btn_deletarEmp
            // 
            this.btn_deletarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletarEmp.Location = new System.Drawing.Point(214, 237);
            this.btn_deletarEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deletarEmp.Name = "btn_deletarEmp";
            this.btn_deletarEmp.Size = new System.Drawing.Size(235, 28);
            this.btn_deletarEmp.TabIndex = 8;
            this.btn_deletarEmp.Text = "Deletar";
            this.btn_deletarEmp.UseVisualStyleBackColor = true;
            this.btn_deletarEmp.Click += new System.EventHandler(this.btn_deletarEmp_Click);
            // 
            // btn_listarEmp
            // 
            this.btn_listarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listarEmp.Location = new System.Drawing.Point(214, 196);
            this.btn_listarEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listarEmp.Name = "btn_listarEmp";
            this.btn_listarEmp.Size = new System.Drawing.Size(235, 28);
            this.btn_listarEmp.TabIndex = 7;
            this.btn_listarEmp.Text = "Verificar";
            this.btn_listarEmp.UseVisualStyleBackColor = true;
            this.btn_listarEmp.Click += new System.EventHandler(this.btn_listarEmp_Click);
            // 
            // btn_atualizarEmp
            // 
            this.btn_atualizarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizarEmp.Location = new System.Drawing.Point(214, 149);
            this.btn_atualizarEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atualizarEmp.Name = "btn_atualizarEmp";
            this.btn_atualizarEmp.Size = new System.Drawing.Size(235, 28);
            this.btn_atualizarEmp.TabIndex = 6;
            this.btn_atualizarEmp.Text = "Atualizar";
            this.btn_atualizarEmp.UseVisualStyleBackColor = true;
            this.btn_atualizarEmp.Click += new System.EventHandler(this.btn_atualizarEmp_Click);
            // 
            // btn_cadastrarEmp
            // 
            this.btn_cadastrarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrarEmp.Location = new System.Drawing.Point(214, 101);
            this.btn_cadastrarEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cadastrarEmp.Name = "btn_cadastrarEmp";
            this.btn_cadastrarEmp.Size = new System.Drawing.Size(235, 28);
            this.btn_cadastrarEmp.TabIndex = 5;
            this.btn_cadastrarEmp.Text = "Cadastrar";
            this.btn_cadastrarEmp.UseVisualStyleBackColor = true;
            this.btn_cadastrarEmp.Click += new System.EventHandler(this.btn_cadastrarEmp_Click);
            // 
            // EmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.btn_deletarEmp);
            this.Controls.Add(this.btn_listarEmp);
            this.Controls.Add(this.btn_atualizarEmp);
            this.Controls.Add(this.btn_cadastrarEmp);
            this.Name = "EmployeeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.Button btn_deletarEmp;
        private System.Windows.Forms.Button btn_listarEmp;
        private System.Windows.Forms.Button btn_atualizarEmp;
        private System.Windows.Forms.Button btn_cadastrarEmp;
    }
}