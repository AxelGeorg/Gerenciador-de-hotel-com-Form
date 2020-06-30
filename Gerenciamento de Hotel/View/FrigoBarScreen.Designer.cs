namespace Gerenciamento_de_Hotel.View
{
    partial class FrigoBarScreen
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_addFrigoBar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_criarQuarto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1, 1);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 28);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_addFrigoBar
            // 
            this.btn_addFrigoBar.Location = new System.Drawing.Point(222, 300);
            this.btn_addFrigoBar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addFrigoBar.Name = "btn_addFrigoBar";
            this.btn_addFrigoBar.Size = new System.Drawing.Size(235, 28);
            this.btn_addFrigoBar.TabIndex = 27;
            this.btn_addFrigoBar.Text = "Produto";
            this.btn_addFrigoBar.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(222, 254);
            this.btn_deletar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(235, 28);
            this.btn_deletar.TabIndex = 26;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(222, 209);
            this.btn_listar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(235, 28);
            this.btn_listar.TabIndex = 25;
            this.btn_listar.Text = "Verificar";
            this.btn_listar.UseVisualStyleBackColor = true;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(222, 163);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(235, 28);
            this.btn_atualizar.TabIndex = 24;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_criarQuarto
            // 
            this.btn_criarQuarto.Location = new System.Drawing.Point(222, 118);
            this.btn_criarQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_criarQuarto.Name = "btn_criarQuarto";
            this.btn_criarQuarto.Size = new System.Drawing.Size(235, 28);
            this.btn_criarQuarto.TabIndex = 23;
            this.btn_criarQuarto.Text = "Cadastrar";
            this.btn_criarQuarto.UseVisualStyleBackColor = true;
            this.btn_criarQuarto.Click += new System.EventHandler(this.btn_criarQuarto_Click);
            // 
            // FrigoBarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_addFrigoBar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_criarQuarto);
            this.Controls.Add(this.btn_back);
            this.Name = "FrigoBarScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrigoBarScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_addFrigoBar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_criarQuarto;
    }
}