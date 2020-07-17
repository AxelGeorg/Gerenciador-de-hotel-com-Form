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
    public partial class ReadGuestScreen : Form
    {
        GuestController controller = new GuestController();

        public ReadGuestScreen()
        {
            InitializeComponent();
            listar(0);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            GerenciadorStripScreen tela = new GerenciadorStripScreen();
            this.Hide();
            tela.ShowDialog();
        }

        public void listar(int tipoOrdenacao)
        {
            listView_guest.Items.Clear();
            var listGuest = new List<Guest>();

            listGuest = controller.retornaGuest(tipoOrdenacao);

            for (int i = 0; i < listGuest.Count; i++)
            {
                listView_guest.Items.Add(listGuest[i].gue_id.ToString());
                listView_guest.Items[i].SubItems.Add(listGuest[i].gue_nome);
                listView_guest.Items[i].SubItems.Add(listGuest[i].gue_cpf);
                listView_guest.Items[i].SubItems.Add(listGuest[i].gue_dataNascimento);
            }
        }

        private void ordenar(object sender, ColumnClickEventArgs e)
        {
            listView_guest.Items.Clear();
            if (e.Column == 0)
            {
                listar(0);
            }
            else if (e.Column == 1)
            {
                listar(1);
            }
            else if (e.Column == 2)
            {
                listar(2);
            }
            else if (e.Column == 3)
            {
                listar(3);
            }
        }
    }
}
