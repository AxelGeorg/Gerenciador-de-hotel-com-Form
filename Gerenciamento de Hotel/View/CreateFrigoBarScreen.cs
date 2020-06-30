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
    public partial class CreateFrigoBarScreen : Form
    {
        public CreateFrigoBarScreen()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FrigoBarScreen tela = new FrigoBarScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
