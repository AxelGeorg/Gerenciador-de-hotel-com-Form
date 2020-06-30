namespace Gerenciamento_de_Hotel.View
{
    partial class RoomScreen
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
            this.btn_criarQuarto = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.btn_addFrigoBar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_criarQuarto
            // 
            this.btn_criarQuarto.Location = new System.Drawing.Point(207, 121);
            this.btn_criarQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_criarQuarto.Name = "btn_criarQuarto";
            this.btn_criarQuarto.Size = new System.Drawing.Size(235, 28);
            this.btn_criarQuarto.TabIndex = 0;
            this.btn_criarQuarto.Text = "Cadastrar";
            this.btn_criarQuarto.UseVisualStyleBackColor = true;
            this.btn_criarQuarto.Click += new System.EventHandler(this.btn_criarQuarto_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(207, 166);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(235, 28);
            this.btn_atualizar.TabIndex = 1;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(207, 212);
            this.btn_listar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(235, 28);
            this.btn_listar.TabIndex = 2;
            this.btn_listar.Text = "Verificar";
            this.btn_listar.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(207, 257);
            this.btn_deletar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(235, 28);
            this.btn_deletar.TabIndex = 3;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(1, 2);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 4;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // btn_addFrigoBar
            // 
            this.btn_addFrigoBar.Location = new System.Drawing.Point(207, 303);
            this.btn_addFrigoBar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addFrigoBar.Name = "btn_addFrigoBar";
            this.btn_addFrigoBar.Size = new System.Drawing.Size(235, 28);
            this.btn_addFrigoBar.TabIndex = 5;
            this.btn_addFrigoBar.Text = "FrigoBares";
            this.btn_addFrigoBar.UseVisualStyleBackColor = true;
            this.btn_addFrigoBar.Click += new System.EventHandler(this.btn_addFrigoBar_Click);
            // 
            // RoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_addFrigoBar);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_criarQuarto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_criarQuarto;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.Button btn_addFrigoBar;
    }
}