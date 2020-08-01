namespace Gerenciamento_de_Hotel.View
{
    partial class LoginGuestScreen
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
            this.txtb_cpfGuest = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(2, 2);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 30;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // txtb_cpfGuest
            // 
            this.txtb_cpfGuest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_cpfGuest.Location = new System.Drawing.Point(170, 96);
            this.txtb_cpfGuest.Name = "txtb_cpfGuest";
            this.txtb_cpfGuest.Size = new System.Drawing.Size(324, 20);
            this.txtb_cpfGuest.TabIndex = 33;
            this.txtb_cpfGuest.TextChanged += new System.EventHandler(this.txtb_cpfGuest_TextChanged);
            this.txtb_cpfGuest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mascara_cpf);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_cpf.Location = new System.Drawing.Point(47, 97);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(117, 17);
            this.lbl_cpf.TabIndex = 32;
            this.lbl_cpf.Text = "Digite o seu CPF:";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_entrar.Location = new System.Drawing.Point(152, 191);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(243, 27);
            this.btn_entrar.TabIndex = 35;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // LoginGuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 242);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txtb_cpfGuest);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.btn_comeBack);
            this.Name = "LoginGuestScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginGuestScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.TextBox txtb_cpfGuest;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Button btn_entrar;
    }
}