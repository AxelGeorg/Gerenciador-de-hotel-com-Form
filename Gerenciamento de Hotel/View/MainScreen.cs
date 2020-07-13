using Gerenciamento_de_Hotel.Controller;
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
    public partial class MainScreen : Form
    {
        InicializaController controller = new InicializaController();
        public MainScreen()
        {
            InitializeComponent();
            controller.criaDATABASE();
            controller.criaTabelas();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginScreen tela = new LoginScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
