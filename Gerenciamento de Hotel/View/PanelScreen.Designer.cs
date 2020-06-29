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
            this.bnt_bedrooms.Location = new System.Drawing.Point(54, 64);
            this.bnt_bedrooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_bedrooms.Name = "bnt_bedrooms";
            this.bnt_bedrooms.Size = new System.Drawing.Size(255, 34);
            this.bnt_bedrooms.TabIndex = 0;
            this.bnt_bedrooms.Text = "Quartos";
            this.bnt_bedrooms.UseVisualStyleBackColor = true;
            this.bnt_bedrooms.Click += new System.EventHandler(this.bnt_bedrooms_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(54, 116);
            this.btn_employee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(255, 34);
            this.btn_employee.TabIndex = 1;
            this.btn_employee.Text = "Funcionários";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Location = new System.Drawing.Point(1, 0);
            this.btn_comeBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(72, 23);
            this.btn_comeBack.TabIndex = 2;
            this.btn_comeBack.Text = "<--";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // PanelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 223);
            this.Controls.Add(this.btn_comeBack);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.bnt_bedrooms);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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