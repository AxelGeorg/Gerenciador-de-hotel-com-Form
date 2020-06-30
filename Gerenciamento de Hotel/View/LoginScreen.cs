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
        employeeController Controller = new employeeController();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var verifica = 0;

            if (String.Equals(txtb_email.Text, "") || String.Equals(txtb_password.Text,"")){
                MessageBox.Show("Os campos login e senha precisam ser preenchidos");
            }
            else
            {
                var listEmp = Controller.retornaEmployees();

                for (int i = 0; i < listEmp.Count; i++)
                {
                    if ((txtb_email.Text.Trim() == listEmp[i].emp_email) && (txtb_password.Text.Trim() == listEmp[i].emp_password))
                    {
                        verifica = 1;
                        PanelScreen tela = new PanelScreen();
                        this.Hide();
                        tela.ShowDialog();
                    }
                }
                if (verifica == 0)
                {
                    MessageBox.Show("Email ou senha incorretos, digite novamente!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }  
        }
        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            MainScreen tela = new MainScreen();
            this.Hide();
            tela.ShowDialog();  
        }
    }
}
