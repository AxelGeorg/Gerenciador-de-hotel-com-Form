using Gerenciamento_de_Hotel.Controller;
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
    public partial class CloseRoomsScreen : Form
    {
        GuestController guestController = new GuestController();
        RoomController  roomController  = new RoomController();
        HotelService service = new HotelService();
        private string cpf;
        private int id_quarto;

        public CloseRoomsScreen()
        {
            InitializeComponent();
            txtb_cpf.Focus();
            txtb_cpf.Select();
        }

        private void txtb_cpf_Leave(object sender, EventArgs e)
        {
            string cpfSemMascara = service.preparaCPFparaBD(txtb_cpf.Text);
            var guest = guestController.retornaGuestCPF(cpfSemMascara);
            if (guest.gue_fk_room != null)
            {
                if (guest.gue_nome != null)
                {
                    cpf = guest.gue_cpf;
                    txtb_hospede.Text = guest.gue_nome;
                    txtb_precoTotal.Text = "R$"+Convert.ToString(guest.gue_precoTotal);

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
            string cpfSemMascara = service.preparaCPFparaBD(txtb_cpf.Text);

            if (e.KeyChar == (char)Keys.Return)
            {
                var guest = guestController.retornaGuestCPF(cpfSemMascara);
                if (guest.gue_fk_room != null)
                {
                    if (guest.gue_nome != null)
                    {
                        cpf = guest.gue_cpf;
                        txtb_hospede.Text = guest.gue_nome;
                        txtb_precoTotal.Text = "R$" + Convert.ToString(guest.gue_precoTotal);

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
                        MessageBox.Show("Hóspede não encontrado por não ter realizado um Check-In ou por não estar cadastrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hóspede não encontrado por não ter realizado um Check-In ou por não estar cadastrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
            }





            //mascara cpf
            char num;
            txtb_cpf.SelectionStart = txtb_cpf.Text.Length + 1;

            if (txtb_cpf.Text.Length == 3 || txtb_cpf.Text.Length == 7)
            {
                txtb_cpf.Text = txtb_cpf.Text + ".";
            }
            else if (txtb_cpf.Text.Length == 11)
            {
                txtb_cpf.Text = txtb_cpf.Text + "-";
            }
            txtb_cpf.SelectionStart = txtb_cpf.Text.Length + 1;

            if ((e.KeyChar == (char)Keys.Back) && (txtb_cpf.Text.Length > 0))
            {
                string s = txtb_cpf.Text.Substring(txtb_cpf.Text.Length - 1, 1);

                if (string.Equals(s, "-") || string.Equals(s, "."))
                {
                    num = txtb_cpf.Text[txtb_cpf.Text.Length - 2];

                    txtb_cpf.Text = txtb_cpf.Text.Remove(txtb_cpf.Text.Length - 1);

                    txtb_cpf.Text += num;
                    txtb_cpf.SelectionStart = txtb_cpf.Text.Length;

                    txtb_cpf.Text = txtb_cpf.Text.Remove(txtb_cpf.Text.Length - 1);
                    txtb_cpf.SelectionStart = txtb_cpf.Text.Length;
                }
                else if (txtb_cpf.Text.Length == 1)
                {
                    txtb_cpf.Text = txtb_cpf.Text.Remove(txtb_cpf.Text.Length - 1);
                    txtb_cpf.SelectionStart = txtb_cpf.Text.Length;
                }
                else if (service.verificaIntOrFloat(txtb_cpf.Text))
                {
                    num = txtb_cpf.Text[txtb_cpf.Text.Length - 2];

                    txtb_cpf.Text = txtb_cpf.Text.Remove(txtb_cpf.Text.Length - 1);

                    txtb_cpf.Text += num;
                    txtb_cpf.SelectionStart = txtb_cpf.Text.Length;
                }
            }
        }

        private void txtb_cpf_TextChanged(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtb_cpf.Text)))
            {
                limparCampos();
            }
            txtb_cpf.MaxLength = 14;
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
