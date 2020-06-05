namespace Gerenciamento_de_Hotel.View
{
    partial class PanelScreen
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
            this.bnt_bedrooms = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_bedrooms
            // 
            this.bnt_bedrooms.Location = new System.Drawing.Point(116, 89);
            this.bnt_bedrooms.Name = "bnt_bedrooms";
            this.bnt_bedrooms.Size = new System.Drawing.Size(191, 28);
            this.bnt_bedrooms.TabIndex = 0;
            this.bnt_bedrooms.Text = "Verificar quartos";
            this.bnt_bedrooms.UseVisualStyleBackColor = true;
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(116, 132);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(191, 28);
            this.btn_employee.TabIndex = 1;
            this.btn_employee.Text = "Funcionários";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Location = new System.Drawing.Point(1, 0);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(54, 19);
            this.btn_comeBack.TabIndex = 2;
            this.btn_comeBack.Text = "<--";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // PanelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.bnt_bedrooms);
            this.Name = "PanelScreen";
            this.Text = "Painel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt_bedrooms;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_comeBack;
    }
}