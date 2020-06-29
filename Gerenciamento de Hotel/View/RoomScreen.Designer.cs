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
            this.SuspendLayout();
            // 
            // btn_criarQuarto
            // 
            this.btn_criarQuarto.Location = new System.Drawing.Point(150, 57);
            this.btn_criarQuarto.Name = "btn_criarQuarto";
            this.btn_criarQuarto.Size = new System.Drawing.Size(87, 31);
            this.btn_criarQuarto.TabIndex = 0;
            this.btn_criarQuarto.Text = "Cadastrar";
            this.btn_criarQuarto.UseVisualStyleBackColor = true;
            this.btn_criarQuarto.Click += new System.EventHandler(this.btn_criarQuarto_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(452, 57);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 1;
            this.btn_atualizar.Text = "button2";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(150, 206);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(75, 23);
            this.btn_listar.TabIndex = 2;
            this.btn_listar.Text = "button3";
            this.btn_listar.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(452, 221);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 3;
            this.btn_deletar.Text = "button4";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // RoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 411);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_criarQuarto);
            this.Name = "RoomScreen";
            this.Text = "RoomScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_criarQuarto;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_deletar;
    }
}