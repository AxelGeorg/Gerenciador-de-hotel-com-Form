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
            this.btn_comeBack = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_room = new System.Windows.Forms.Button();
            this.btn_guest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(1, 0);
            this.btn_comeBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(129, 34);
            this.btn_comeBack.TabIndex = 2;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_employees.Location = new System.Drawing.Point(264, 277);
            this.btn_employees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(313, 34);
            this.btn_employees.TabIndex = 3;
            this.btn_employees.Text = "Funcionários";
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // btn_room
            // 
            this.btn_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_room.Location = new System.Drawing.Point(264, 213);
            this.btn_room.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(313, 34);
            this.btn_room.TabIndex = 4;
            this.btn_room.Text = "Quartos";
            this.btn_room.UseVisualStyleBackColor = true;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_guest
            // 
            this.btn_guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guest.Location = new System.Drawing.Point(264, 155);
            this.btn_guest.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guest.Name = "btn_guest";
            this.btn_guest.Size = new System.Drawing.Size(313, 34);
            this.btn_guest.TabIndex = 5;
            this.btn_guest.Text = "Hóspedes";
            this.btn_guest.UseVisualStyleBackColor = true;
            this.btn_guest.Click += new System.EventHandler(this.btn_guest_Click);
            // 
            // PanelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.btn_guest);
            this.Controls.Add(this.btn_room);
            this.Controls.Add(this.btn_employees);
            this.Controls.Add(this.btn_comeBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PanelScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_room;
        private System.Windows.Forms.Button btn_guest;
    }
}