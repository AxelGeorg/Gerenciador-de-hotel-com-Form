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
        FrigoBarController FrigoBarController = new FrigoBarController();
        public CreateRoomScreen()
        {
            InitializeComponent();
            carregarComboBox();
        }

        private void carregarComboBox()
        {
            var frigoBares = FrigoBarController.listarFrigoBares();
            var listFrigoBares = new List<FrigoBar>();

            if (frigoBares.Count != 0)
            {
                for (int i = 0; i < frigoBares.Count; i++)
                {
                    cb_frigoBar.Items.Add(frigoBares[i].frig_identificacao);
                    listFrigoBares.Add(frigoBares[i]);
                }
            }
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
            PanelScreen tela = new PanelScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
