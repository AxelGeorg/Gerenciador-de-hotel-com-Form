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
    public partial class RoomScreen : Form
    {
        public RoomScreen()
        {
            InitializeComponent();
        }

        private void btn_criarQuarto_Click(object sender, EventArgs e)
        {
            CreateRoomScreen tela = new CreateRoomScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            PanelScreen tela = new PanelScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
