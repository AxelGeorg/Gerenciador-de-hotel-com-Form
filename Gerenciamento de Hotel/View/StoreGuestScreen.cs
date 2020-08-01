using Gerenciamento_de_Hotel.Model.Entidades;
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
    public partial class StoreGuestScreen : Form
    {
        Guest guest = new Guest();

        public StoreGuestScreen()
        {
            InitializeComponent();
        }
        public StoreGuestScreen(Guest guestRetornado)
        {
            InitializeComponent();
            guest = guestRetornado;
        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStripScreen tela = new MenuStripScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_teste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrou com o hóspede "+ guest.gue_nome + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void produtosDisponíveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<StoreConsumablesScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StoreConsumablesScreen tela = new StoreConsumablesScreen(guest);
                tela.Show();
            }
        }
    }
}
