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
            this.btn_comeBack.Margin = new System.Windows.Forms.Padding(4);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(129, 34);
            this.btn_comeBack.TabIndex = 9;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.Location = new System.Drawing.Point(277, 316);
            this.btn_deletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(313, 34);
            this.btn_deletar.TabIndex = 8;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_verificar
            // 
            this.btn_verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verificar.Location = new System.Drawing.Point(277, 261);
            this.btn_verificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(313, 34);
            this.btn_verificar.TabIndex = 7;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.Location = new System.Drawing.Point(277, 204);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(313, 34);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_criarQuarto
            // 
            this.btn_criarQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_criarQuarto.Location = new System.Drawing.Point(277, 149);
            this.btn_criarQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_criarQuarto.Name = "btn_criarQuarto";
            this.btn_criarQuarto.Size = new System.Drawing.Size(313, 34);
            this.btn_criarQuarto.TabIndex = 5;
            this.btn_criarQuarto.Text = "Cadastrar";
            this.btn_criarQuarto.UseVisualStyleBackColor = true;
            this.btn_criarQuarto.Click += new System.EventHandler(this.btn_criarQuarto_Click);
            // 
            // GuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_criarQuarto);
            this.Name = "GuestScreen";
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