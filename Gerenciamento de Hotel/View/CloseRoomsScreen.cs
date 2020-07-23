using Gerenciamento_de_Hotel.Controller;
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
    public partial class CloseRoomsScreen : Form
    {
        GuestController guestController = new GuestController();
        RoomController  roomController  = new RoomController();
        private string cpf;
        private int id_quarto;

        public CloseRoomsScreen()
        {
            InitializeComponent();
        }

        private void txtb_cpf_Leave(object sender, EventArgs e)
        {
            var guest = guestController.retornaGuestCPF(txtb_cpf.Text);
            if (guest.gue_fk_room != null)
            {
                if (guest.gue_nome != null)
                {
                    cpf = guest.gue_cpf;
                    txtb_hospede.Text = guest.gue_nome;
                    txtb_precoTotal.Text = Convert.ToString(guest.gue_precoTotal);

                    var room = roomController.retornaRoomID(guest.gue_fk_room);
                    id_quarto = room.room_id;
                    txtb_quarto.Text = room.room_numeroQuarto;
                    rbtn_efetuado.Enabled = true;
                    rbtn_pendente.Enabled = true;
                }
                else
                {
                    rbtn_efetuado.Enabled = false;
                    rbtn_pendente.Enabled = false;
                    MessageBox.Show("Hóspede não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Hóspede não encontrado");
            }
            
        }

        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            var room = roomController.retornaRoomID(id_quarto);
            room.room_disponibilidade = true;
            roomController.alteraRoom(room);

            var guest = guestController.retornaGuestCPF(cpf);
            if (MessageBox.Show("Deseja realizar o CHeck-Out do hóspede?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (guestController.alteraGuestCheckOut(guest.gue_id))
                {
                    limparCampos();
                    MessageBox.Show("Check-Out realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não possivel realizar o Check-Out", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtb_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                var guest = guestController.retornaGuestCPF(txtb_cpf.Text);
                if (guest.gue_fk_room != null)
                {
                    if (guest.gue_nome != null)
                    {
                        cpf = guest.gue_cpf;
                        txtb_hospede.Text = guest.gue_nome;
                        txtb_precoTotal.Text = Convert.ToString(guest.gue_precoTotal);

                        var room = roomController.retornaRoomID(guest.gue_fk_room);
                        id_quarto = room.room_id;
                        txtb_quarto.Text = room.room_numeroQuarto;
                        rbtn_efetuado.Enabled = true;
                        rbtn_pendente.Enabled = true;
                    }
                    else
                    {
                        rbtn_efetuado.Enabled = false;
                        rbtn_pendente.Enabled = false;
                        MessageBox.Show("Hóspede não encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Hóspede não encontrado");
                }

                e.Handled = true;
            }
        }

        private void txtb_cpf_TextChanged(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtb_cpf.Text)))
            {
                limparCampos();
            }
        }

        private void rbtn_efetuado_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_efetuado.Checked == true)
            {
                btn_checkOut.Enabled = true;
            }
        }

        private void rbtn_pendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_pendente.Checked == true)
            {
                btn_checkOut.Enabled = false;
            }
        }

        private void limparCampos()
        {
            txtb_hospede.Text     = "";
            txtb_precoTotal.Text  = "";
            txtb_quarto.Text      = "";
            btn_checkOut.Enabled  = false;
            rbtn_efetuado.Enabled = false;
            rbtn_pendente.Enabled = false;
        }
    }
}
