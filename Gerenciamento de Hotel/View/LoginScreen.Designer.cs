namespace Gerenciamento_de_Hotel
{
    partial class LoginScreen
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
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.txtb_email = new System.Windows.Forms.TextBox();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_esqueceuSenha = new System.Windows.Forms.Button();
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(41, 106);
            this.lb_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(123, 18);
            this.lb_email.TabIndex = 0;
            this.lb_email.Text = "Digite seu E-mail:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(41, 159);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(133, 18);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Digite a sua senha:";
            // 
            // txtb_email
            // 
            this.txtb_email.Location = new System.Drawing.Point(183, 107);
            this.txtb_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_email.Name = "txtb_email";
            this.txtb_email.Size = new System.Drawing.Size(299, 20);
            this.txtb_email.TabIndex = 2;
            this.txtb_email.Tag = "Oi";
            // 
            // txtb_password
            // 
            this.txtb_password.Location = new System.Drawing.Point(183, 160);
            this.txtb_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.Size = new System.Drawing.Size(299, 20);
            this.txtb_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Location = new System.Drawing.Point(254, 303);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(172, 28);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_esqueceuSenha
            // 
            this.btn_esqueceuSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_esqueceuSenha.Location = new System.Drawing.Point(553, 350);
            this.btn_esqueceuSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_esqueceuSenha.Name = "btn_esqueceuSenha";
            this.btn_esqueceuSenha.Size = new System.Drawing.Size(109, 28);
            this.btn_esqueceuSenha.TabIndex = 6;
            this.btn_esqueceuSenha.Text = "Esqueceu a Senha";
            this.btn_esqueceuSenha.UseVisualStyleBackColor = true;
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(2, 1);
            this.btn_comeBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 7;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.btn_esqueceuSenha);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtb_password);
            this.Controls.Add(this.txtb_email);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_email);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txtb_email;
        private System.Windows.Forms.TextBox txtb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_esqueceuSenha;
        private System.Windows.Forms.Button btn_comeBack;
    }
}