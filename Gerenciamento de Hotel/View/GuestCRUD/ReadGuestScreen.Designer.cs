﻿namespace Gerenciamento_de_Hotel.View
{
    partial class ReadGuestScreen
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
            this.listView_guest = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_guest
            // 
            this.listView_guest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_guest.GridLines = true;
            this.listView_guest.HideSelection = false;
            this.listView_guest.Location = new System.Drawing.Point(44, 31);
            this.listView_guest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_guest.Name = "listView_guest";
            this.listView_guest.Scrollable = false;
            this.listView_guest.Size = new System.Drawing.Size(804, 422);
            this.listView_guest.TabIndex = 23;
            this.listView_guest.UseCompatibleStateImageBehavior = false;
            this.listView_guest.View = System.Windows.Forms.View.Details;
            this.listView_guest.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ordenar);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPF";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data de Nascimento";
            this.columnHeader4.Width = 128;
            // 
            // ReadGuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.listView_guest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ReadGuestScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadGuestScreen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView_guest;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}