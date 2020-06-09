using Gerenciamento_de_Hotel.Controller;
using Gerenciamento_de_Hotel.Model.DAO;
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
        loginController loginController = new loginController();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (loginController.validateUser(txt_email.Text, txt_password.Text)==true){
                PanelScreen panel = new PanelScreen();
                this.Hide();
                panel.ShowDialog();
            }else{
                MessageBox.Show("Erro ao tentar efetuar o login");
            }
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            MainScreen telaPrincipal = new MainScreen();
            this.Hide();
            telaPrincipal.ShowDialog();  
        }
    }
}
