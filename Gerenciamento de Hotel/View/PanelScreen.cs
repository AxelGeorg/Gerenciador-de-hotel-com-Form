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
    public partial class PanelScreen : Form
    {
        public PanelScreen()
        {
            InitializeComponent();
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            LoginScreen tela = new LoginScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            EmployeeScreen tela = new EmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            RoomScreen tela = new RoomScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            GuestScreen tela = new GuestScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
