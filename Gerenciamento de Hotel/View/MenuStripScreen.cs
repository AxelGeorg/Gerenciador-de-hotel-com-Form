using Gerenciamento_de_Hotel.Controller;
using Gerenciamento_de_Hotel.View.GuestCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_Hotel.View
{
    public partial class MenuStripScreen : Form
    {
        InicializaController controller = new InicializaController();

        public MenuStripScreen()
        {
            InitializeComponent();
            controller.criaDATABASE();
            controller.criaTabelas();
        }

        private void informaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginScreen tela = new LoginScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGuestScreen tela = new CreateGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadGuestScreen tela = new ReadGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateGuestScreen tela = new UpdateGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGuestScreen tela = new DeleteGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
