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
            if (Application.OpenForms.OfType<CreateRoomScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CreateRoomScreen tela = new CreateRoomScreen();
                tela.Show();
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UpdateRoomScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateRoomScreen tela = new UpdateRoomScreen();
                tela.Show();
            }
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ReadRoomScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReadRoomScreen tela = new ReadRoomScreen();
                tela.Show();
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DeleteRoomScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DeleteRoomScreen tela = new DeleteRoomScreen();
                tela.Show();
            }
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CreateEmployeeScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CreateEmployeeScreen tela = new CreateEmployeeScreen();
                tela.Show();
            }
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UpdateEmployeeScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateEmployeeScreen tela = new UpdateEmployeeScreen();
                tela.Show();
            }
        }

        private void verificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ReadEmployeeScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReadEmployeeScreen tela = new ReadEmployeeScreen();
                tela.Show();
            }
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DeleteEmployeeScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DeleteEmployeeScreen tela = new DeleteEmployeeScreen();
                tela.Show();
            }
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CreateGuestScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CreateGuestScreen tela = new CreateGuestScreen();
                tela.Show();
            }
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UpdateGuestScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateGuestScreen tela = new UpdateGuestScreen();
                tela.Show();
            }
        }

        private void verificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ReadGuestScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReadGuestScreen tela = new ReadGuestScreen();
                tela.Show();
            }
        }

        private void deletarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DeleteGuestScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DeleteGuestScreen tela = new DeleteGuestScreen();
                tela.Show();
            }
        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ReserveRoomsScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReserveRoomsScreen tela = new ReserveRoomsScreen();
                tela.Show();
            }
        }

        private void quartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CloseRoomsScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CloseRoomsScreen tela = new CloseRoomsScreen();
                tela.Show();
            }
        }

        private void verificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ReadConsumablesScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReadConsumablesScreen tela = new ReadConsumablesScreen();
                tela.Show();
            }
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CreateConsumablesScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CreateConsumablesScreen tela = new CreateConsumablesScreen();
                tela.Show();
            }
        }

        private void deletarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DeleteConsumablesScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DeleteConsumablesScreen tela = new DeleteConsumablesScreen();
                tela.Show();
            }
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UpdateConsumablesScreen>().Count() > 0)
            {
                MessageBox.Show("Está tela já está aberta, não é possível abrir mais uma tela desta!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateConsumablesScreen tela = new UpdateConsumablesScreen();
                tela.Show();
            }
        }
    }
}
