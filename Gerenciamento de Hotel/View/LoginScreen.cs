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
            if (String.Equals(txt_email.Text, "") | String.Equals(txt_password.Text,"")){
                MessageBox.Show("Os campos login e senha precisam ser preenchidos");
            }
            else
            {
                if (loginController.validateUser(txt_email.Text, txt_password.Text) == true)
                {
                    CreateRoomScreen panel = new CreateRoomScreen();
                    this.Hide();
                    panel.ShowDialog();

                    //PanelScreen panel = new PanelScreen();
                    //this.Hide();
                    //panel.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erro ao tentar efetuar o login");
                }
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
