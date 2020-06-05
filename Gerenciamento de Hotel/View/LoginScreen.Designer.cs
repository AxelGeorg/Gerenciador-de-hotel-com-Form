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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_pwr = new System.Windows.Forms.Button();
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(47, 58);
            this.lb_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(88, 13);
            this.lb_email.TabIndex = 0;
            this.lb_email.Text = "Digite seu E-mail:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(47, 108);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(98, 13);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Digite a sua senha:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(149, 55);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(201, 20);
            this.txt_email.TabIndex = 2;
            this.txt_email.Tag = "Oi";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(149, 105);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(201, 20);
            this.txt_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(305, 158);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 28);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(305, 208);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(109, 28);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "Cadastrar";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // btn_pwr
            // 
            this.btn_pwr.Location = new System.Drawing.Point(36, 208);
            this.btn_pwr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pwr.Name = "btn_pwr";
            this.btn_pwr.Size = new System.Drawing.Size(109, 28);
            this.btn_pwr.TabIndex = 6;
            this.btn_pwr.Text = "Esqueceu a Senha";
            this.btn_pwr.UseVisualStyleBackColor = true;
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Location = new System.Drawing.Point(0, 0);
            this.btn_comeBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(54, 19);
            this.btn_comeBack.TabIndex = 7;
            this.btn_comeBack.Text = "<--";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.btn_pwr);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_email);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_pwr;
        private System.Windows.Forms.Button btn_comeBack;
    }
}