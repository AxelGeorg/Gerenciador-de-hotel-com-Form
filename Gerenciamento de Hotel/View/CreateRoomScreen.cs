using Gerenciamento_de_Hotel.Controller;
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
    public partial class CreateRoomScreen : Form
    {
        public CreateRoomScreen()
        {
            InitializeComponent();
        }

     

        private void CreateRoomScreen_Tisk(object sender, EventArgs e)
        {
            //
        }

        private void CreateRoomScreen_Load(object sender, EventArgs e)
        {
            //a
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RoomScreen tela = new RoomScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void txt_identificacao_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
