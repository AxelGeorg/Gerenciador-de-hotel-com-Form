namespace Gerenciamento_de_Hotel.View
{
    partial class GuestScreen
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
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_criarQuarto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(2, 2);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 9;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.Location = new System.Drawing.Point(208, 257);
            this.btn_deletar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(235, 28);
            this.btn_deletar.TabIndex = 8;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_verificar
            // 
            this.btn_verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verificar.Location = new System.Drawing.Point(208, 212);
            this.btn_verificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(235, 28);
            this.btn_verificar.TabIndex = 7;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.Location = new System.Drawing.Point(208, 166);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(235, 28);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_criarQuarto
            // 
            this.btn_criarQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_criarQuarto.Location = new System.Drawing.Point(208, 121);
            this.btn_criarQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_criarQuarto.Name = "btn_criarQuarto";
            this.btn_criarQuarto.Size = new System.Drawing.Size(235, 28);
            this.btn_criarQuarto.TabIndex = 5;
            this.btn_criarQuarto.Text = "Cadastrar";
            this.btn_criarQuarto.UseVisualStyleBackColor = true;
            this.btn_criarQuarto.Click += new System.EventHandler(this.btn_criarQuarto_Click);
            // 
            // GuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_criarQuarto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GuestScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_criarQuarto;
    }
}