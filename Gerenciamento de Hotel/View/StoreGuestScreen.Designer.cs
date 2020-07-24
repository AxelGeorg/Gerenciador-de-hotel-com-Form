namespace Gerenciamento_de_Hotel.View
{
    partial class StoreGuestScreen
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
            this.btn_teste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_comeBack
            // 
            this.btn_comeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comeBack.Location = new System.Drawing.Point(2, 2);
            this.btn_comeBack.Name = "btn_comeBack";
            this.btn_comeBack.Size = new System.Drawing.Size(97, 28);
            this.btn_comeBack.TabIndex = 31;
            this.btn_comeBack.Text = "←";
            this.btn_comeBack.UseVisualStyleBackColor = true;
            this.btn_comeBack.Click += new System.EventHandler(this.btn_comeBack_Click);
            // 
            // btn_teste
            // 
            this.btn_teste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teste.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_teste.Location = new System.Drawing.Point(220, 331);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(243, 27);
            this.btn_teste.TabIndex = 36;
            this.btn_teste.Text = "teste";
            this.btn_teste.UseVisualStyleBackColor = true;
            this.btn_teste.Click += new System.EventHandler(this.btn_teste_Click);
            // 
            // StoreGuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.btn_teste);
            this.Controls.Add(this.btn_comeBack);
            this.Name = "StoreGuestScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreGuestScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_comeBack;
        private System.Windows.Forms.Button btn_teste;
    }
}