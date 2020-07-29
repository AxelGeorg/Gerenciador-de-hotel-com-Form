using Gerenciamento_de_Hotel.Controller;
using Gerenciamento_de_Hotel.Model.Entidades;
using Gerenciamento_de_Hotel.Services;
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
    public partial class DeleteRoomScreen : Form
    {
        RoomController controller = new RoomController();
        Room room = new Room();

        public DeleteRoomScreen()
        {
            InitializeComponent();
            btn_deletar.Enabled = false;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            listView_room.Items.Clear();
            var roomRetornado = controller.retornaRoom(0);

            for (int i = 0; i < roomRetornado.Count; i++)
            {
                if (txtb_roomDeletar.Text.Trim() == roomRetornado[i].room_numeroQuarto)
                {
                    ListViewItem itens = new ListViewItem(Convert.ToString(roomRetornado[i].room_id));
                    room.room_id = roomRetornado[i].room_id;
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_numeroQuarto));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_quantCasal));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_quantSolteiro));

                    if (roomRetornado[i].room_disponibilidade == true)
                    {
                        itens.SubItems.Add("Disponível");
                    }
                    else if (roomRetornado[i].room_disponibilidade == false)
                    {
                        itens.SubItems.Add("Ocupado");
                    }

                    if (roomRetornado[i].room_limpeza == true)
                    {
                        itens.SubItems.Add("Limpo");
                    }
                    else if (roomRetornado[i].room_limpeza == false)
                    {
                        itens.SubItems.Add("Sujo");
                    }

                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_precoDiaria));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_quantPessoa));
                    listView_room.Items.Add(itens);

                    btn_deletar.Enabled = true;
                }
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar esse funcionario?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (controller.deletaRoom(room.room_id))
                {
                    if (Application.OpenForms.OfType<ReadRoomScreen>().Count() > 0)
                    {
                        ReadRoomScreen form = Application.OpenForms["ReadRoomScreen"] as ReadRoomScreen;
                        form.listar(0);
                    }

                    txtb_roomDeletar.Text = "";
                    MessageBox.Show("Quarto deletado com sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o quarto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void txtb_roomDeletar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_roomDeletar.Text))
            {
                listView_room.Items.Clear();
                btn_deletar.Enabled = false;
            }
        }
    }
}
