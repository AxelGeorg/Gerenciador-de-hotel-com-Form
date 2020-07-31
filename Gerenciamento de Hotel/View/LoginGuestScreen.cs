using Gerenciamento_de_Hotel.Controller;
using Gerenciamento_de_Hotel.Services;
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
        HotelService service = new HotelService();

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
            string cpfSemMascara = service.preparaCPFparaBD(txtb_cpfGuest.Text);
            var guestRetornado = controller.retornaGuestCPF(cpfSemMascara);

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
            txtb_cpfGuest.MaxLength = 14;
        }

        private void mascara_cpf(object sender, KeyPressEventArgs e)
        {
            char num;
            txtb_cpfGuest.SelectionStart = txtb_cpfGuest.Text.Length + 1;

            if (txtb_cpfGuest.Text.Length == 3 || txtb_cpfGuest.Text.Length == 7)
            {
                txtb_cpfGuest.Text = txtb_cpfGuest.Text + ".";
            }
            else if (txtb_cpfGuest.Text.Length == 11)
            {
                txtb_cpfGuest.Text = txtb_cpfGuest.Text + "-";
            }
            txtb_cpfGuest.SelectionStart = txtb_cpfGuest.Text.Length + 1;

            if ((e.KeyChar == (char)Keys.Back) && (txtb_cpfGuest.Text.Length > 0))
            {
                string s = txtb_cpfGuest.Text.Substring(txtb_cpfGuest.Text.Length - 1, 1);

                if (string.Equals(s, "-") || string.Equals(s, "."))
                {
                    num = txtb_cpfGuest.Text[txtb_cpfGuest.Text.Length - 2];

                    txtb_cpfGuest.Text = txtb_cpfGuest.Text.Remove(txtb_cpfGuest.Text.Length - 1);

                    txtb_cpfGuest.Text += num;
                    txtb_cpfGuest.SelectionStart = txtb_cpfGuest.Text.Length;

                    txtb_cpfGuest.Text = txtb_cpfGuest.Text.Remove(txtb_cpfGuest.Text.Length - 1);
                    txtb_cpfGuest.SelectionStart = txtb_cpfGuest.Text.Length;
                }
                else if (txtb_cpfGuest.Text.Length == 1)
                {
                    txtb_cpfGuest.Text = txtb_cpfGuest.Text.Remove(txtb_cpfGuest.Text.Length - 1);
                    txtb_cpfGuest.SelectionStart = txtb_cpfGuest.Text.Length;
                }
                else if (service.verificaIntOrFloat(txtb_cpfGuest.Text))
                {
                    num = txtb_cpfGuest.Text[txtb_cpfGuest.Text.Length - 2];

                    txtb_cpfGuest.Text = txtb_cpfGuest.Text.Remove(txtb_cpfGuest.Text.Length - 1);

                    txtb_cpfGuest.Text += num;
                    txtb_cpfGuest.SelectionStart = txtb_cpfGuest.Text.Length;
                }
            }
        }
    }
}
