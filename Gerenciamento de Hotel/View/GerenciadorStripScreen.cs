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
            this.Hide();
            tela.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRoomScreen tela = new UpdateRoomScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadRoomScreen tela = new ReadRoomScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRoomScreen tela = new DeleteRoomScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateEmployeeScreen tela = new CreateEmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateEmployeeScreen tela = new UpdateEmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void verificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReadEmployeeScreen tela = new ReadEmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteEmployeeScreen tela = new DeleteEmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateGuestScreen tela = new CreateGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateGuestScreen tela = new UpdateGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void verificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReadGuestScreen tela = new ReadGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void deletarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteGuestScreen tela = new DeleteGuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveRoomsScreen tela = new ReserveRoomsScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void quartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseRoomsScreen tela = new CloseRoomsScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void verificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ReadConsumablesScreen tela = new ReadConsumablesScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CreateConsumablesScreen tela = new CreateConsumablesScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void deletarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteConsumablesScreen tela = new DeleteConsumablesScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UpdateConsumablesScreen tela = new UpdateConsumablesScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
