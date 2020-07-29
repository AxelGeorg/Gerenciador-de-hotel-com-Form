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
    public partial class ReadRoomScreen : Form
    {
       RoomController controller = new RoomController();

        public ReadRoomScreen()
        {
            InitializeComponent();
            listar(0);
        }

        public void listar(int tipoOrdenacao)
        {
            listView_room.Items.Clear();
            var listRoom = new List<Room>();

            listRoom = controller.retornaRoom(tipoOrdenacao);

            for (int i = 0; i < listRoom.Count; i++)
            {
                listView_room.Items.Add(listRoom[i].room_id.ToString());
                listView_room.Items[i].SubItems.Add(listRoom[i].room_numeroQuarto);
                listView_room.Items[i].SubItems.Add(listRoom[i].room_quantCasal.ToString());
                listView_room.Items[i].SubItems.Add(listRoom[i].room_quantSolteiro.ToString());

                if (listRoom[i].room_disponibilidade == true)
                {
                    listView_room.Items[i].SubItems.Add("Disponível");
                }
                else if (listRoom[i].room_disponibilidade == false)
                {
                    listView_room.Items[i].SubItems.Add("Ocupado");
                }

                if (listRoom[i].room_limpeza == true)
                {
                    listView_room.Items[i].SubItems.Add("Limpo");
                }
                else if (listRoom[i].room_limpeza == false)
                {
                    listView_room.Items[i].SubItems.Add("Sujo");
                }

                listView_room.Items[i].SubItems.Add("R$"+listRoom[i].room_precoDiaria.ToString());
                listView_room.Items[i].SubItems.Add(listRoom[i].room_quantPessoa.ToString());
            }
        }

        private void ordenar(object sender, ColumnClickEventArgs e)
        {
            listView_room.Items.Clear();
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
            else if (e.Column == 4)
            {
                listar(4);
            }
            else if (e.Column == 5)
            {
                listar(5);
            }
            else if (e.Column == 6)
            {
                listar(6);
            }
            else if (e.Column == 7)
            {
                listar(7);
            }
            else if (e.Column == 8)
            {
                listar(8);
            }
        }
    }
}
