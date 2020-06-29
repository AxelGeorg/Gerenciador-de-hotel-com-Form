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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            LoginScreen telaLogin = new LoginScreen();
            this.Hide();
            telaLogin.ShowDialog();
        }

        private void bnt_bedrooms_Click(object sender, EventArgs e)
        {
            RoomScreen tela = new RoomScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
