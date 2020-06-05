using Gerenciamento_de_Hotel.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_Hotel
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 telaPrincipal = new Form1();
            this.Hide();
            telaPrincipal.ShowDialog();
           
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            PanelScreen panel = new PanelScreen();
            this.Hide();
            panel.ShowDialog();
        }
    }
}
