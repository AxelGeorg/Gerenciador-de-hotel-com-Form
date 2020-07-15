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
    public partial class GuestScreen : Form
    {
        public GuestScreen()
        {
            InitializeComponent();
        }

        private void btn_criarQuarto_Click(object sender, EventArgs e)
        {
            CreateGuestScreen tela = new CreateGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            ReadGuestScreen tela = new ReadGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            UpdateGuestScreen tela = new UpdateGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
