using Gerenciamento_de_Hotel.View.ConsumablesCRUD;
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
    public partial class GerenciadorStripScreen : Form
    {
        public GerenciadorStripScreen()
        {
            InitializeComponent();
        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStripScreen tela = new MenuStripScreen(); 
            this.Hide();
            tela.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRoomScreen tela = new CreateRoomScreen();
            tela.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRoomScreen tela = new UpdateRoomScreen();
            tela.Show();
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadRoomScreen tela = new ReadRoomScreen();
            tela.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRoomScreen tela = new DeleteRoomScreen();
            tela.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateEmployeeScreen tela = new CreateEmployeeScreen();
            tela.Show();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateEmployeeScreen tela = new UpdateEmployeeScreen();
            tela.Show();
        }

        private void verificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReadEmployeeScreen tela = new ReadEmployeeScreen();
            tela.Show();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteEmployeeScreen tela = new DeleteEmployeeScreen();
            tela.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateGuestScreen tela = new CreateGuestScreen();
            tela.Show();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateGuestScreen tela = new UpdateGuestScreen();
            tela.Show();
        }

        private void verificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReadGuestScreen tela = new ReadGuestScreen();
            tela.Show();
        }

        private void deletarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteGuestScreen tela = new DeleteGuestScreen();
            tela.Show();
        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveRoomsScreen tela = new ReserveRoomsScreen();
            tela.Show();
        }

        private void quartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseRoomsScreen tela = new CloseRoomsScreen();
            tela.Show();
        }

        private void verificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ReadConsumablesScreen tela = new ReadConsumablesScreen();
            tela.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CreateConsumablesScreen tela = new CreateConsumablesScreen();
            tela.Show();
        }

        private void deletarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteConsumablesScreen tela = new DeleteConsumablesScreen();
            tela.Show();
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UpdateConsumablesScreen tela = new UpdateConsumablesScreen();
            tela.Show();
        }
    }
}
