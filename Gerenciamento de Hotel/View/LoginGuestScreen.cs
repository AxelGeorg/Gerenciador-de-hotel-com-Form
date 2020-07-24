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

namespace Gerenciamento_de_Hotel.View
{
    public partial class LoginGuestScreen : Form
    {
        GuestController controller = new GuestController();

        public LoginGuestScreen()
        {
            InitializeComponent();
            btn_entrar.Enabled = false;
        }

        private void LoginGuestScreen_Load(object sender, EventArgs e)
        {

        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            MenuStripScreen tela = new MenuStripScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            var guestRetornado = controller.retornaGuestCPF(txtb_cpfGuest.Text);

            if (!string.IsNullOrEmpty(guestRetornado.gue_nome))
            {
                StoreGuestScreen tela = new StoreGuestScreen(guestRetornado);
                this.Hide();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("CPF não identificado ou inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtb_cpfGuest_TextChanged(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtb_cpfGuest.Text)))
            {
                btn_entrar.Enabled = false;
            }
            else
            {
                btn_entrar.Enabled = true;
            }
        }
    }
}
