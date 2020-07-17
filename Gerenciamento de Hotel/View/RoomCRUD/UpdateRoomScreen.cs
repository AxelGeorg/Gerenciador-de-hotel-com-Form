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
    public partial class UpdateRoomScreen : Form
    {
        RoomController controller = new RoomController();
        Room room = new Room();
        HotelService service = new HotelService();

        public UpdateRoomScreen()
        {
            InitializeComponent();

            listaComboBox();
            btn_alterar.Enabled = false;
            txtb_novoAlterar.Enabled = false;
            cbox_opcoes.Enabled = false;
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            GerenciadorStripScreen tela = new GerenciadorStripScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;

            listView_room.Items.Clear();
            var roomRetornado = controller.retornaRoom(0);

            for (int i = 0; i < roomRetornado.Count; i++)
            {
                if (txtb_roomAlterar.Text.Trim() == roomRetornado[i].room_numeroQuarto)
                {
                    ListViewItem itens = new ListViewItem(Convert.ToString(roomRetornado[i].room_id));
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

                    room.room_id = roomRetornado[i].room_id;
                    room.room_numeroQuarto = roomRetornado[i].room_numeroQuarto;
                    room.room_quantCasal = roomRetornado[i].room_quantCasal;
                    room.room_quantSolteiro = roomRetornado[i].room_quantSolteiro;
                    room.room_disponibilidade = roomRetornado[i].room_disponibilidade;
                    room.room_limpeza = roomRetornado[i].room_limpeza;
                    room.room_precoDiaria = roomRetornado[i].room_precoDiaria;
                    room.room_quantPessoa = roomRetornado[i].room_quantPessoa;

                    cbox_opcoes.Enabled = true;
                    verificaSeRetornou = 1;
                }
            }

            if (verificaSeRetornou == 0)
            {
                MessageBox.Show("Não foi possìvel encontrar nenhum quarto com esse número de quarto!! \nDigite novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;
            string retorno = "Quarto alterado com sucesso!!!";

            if (cbox_opcoes.SelectedIndex == 0)
            {
                room.room_numeroQuarto = txtb_novoAlterar.Text;

                var listRoom = controller.retornaRoom(0);

                for (int i = 0; i < listRoom.Count; i++)
                {
                    if (room.room_numeroQuarto == listRoom[i].room_numeroQuarto)
                    {
                        verificaSeRetornou = 1;
                        retorno = "pois já há um quarto com esse número!!";
                    }
                }
            }
            else if (cbox_opcoes.SelectedIndex == 1)
            {
                //verifica se é inteiro
                if (!service.verificaIntOrFloat(txtb_novoAlterar.Text))
                {
                    verificaSeRetornou = 1;
                    retorno = "pois a quantidade de camas de casal não está me formato inteiro, verifique a forma o qual foi digitada!!";
                }
                else
                {
                    room.room_quantCasal = Convert.ToInt32(txtb_novoAlterar.Text);
                    room.room_quantPessoa = room.room_quantSolteiro + room.room_quantCasal * 2;
                }
            }
            else if (cbox_opcoes.SelectedIndex == 2)
            {
                //verifica se é inteiro
                if (!service.verificaIntOrFloat(txtb_novoAlterar.Text))
                {
                    verificaSeRetornou = 1;
                    retorno = "pois a quantidade de camas de solteiro não está me formato inteiro, verifique a forma o qual foi digitada!!";
                }
                else
                {
                    room.room_quantSolteiro = Convert.ToInt32(txtb_novoAlterar.Text);
                    room.room_quantPessoa = room.room_quantSolteiro + room.room_quantCasal * 2;
                }
            }
            else if (cbox_opcoes.SelectedIndex == 3)
            {
                if (rbtn_disponivel.Checked)
                {
                    room.room_disponibilidade = true;
                }
                else if (rbtn_ocupado.Checked)
                {
                    room.room_disponibilidade = false;
                }
            }
            else if (cbox_opcoes.SelectedIndex == 4)
            {
                if (rbtn_limpo.Checked)
                {
                    room.room_limpeza = true;
                }
                else if (rbtn_sujo.Checked)
                {
                    room.room_limpeza = false;
                }
            }
            else if (cbox_opcoes.SelectedIndex == 5)
            {
                //verifica se é um float
                if (!service.verificaIntOrFloat(txtb_novoAlterar.Text))
                {
                    verificaSeRetornou = 1;
                    retorno = "pois o valor do preço não está no formato desejado, verifique a forma o qual foi digitada!!!!";
                }
                else
                {
                    room.room_precoDiaria = float.Parse(txtb_novoAlterar.Text);
                }
            }

            if (verificaSeRetornou == 0)
            {
                if (MessageBox.Show("Deseja alterar esse quarto?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    controller.alteraRoom(room);
                    MessageBox.Show(retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampoForm();
                }
            }
            else
            {
                MessageBox.Show("Não é possível alterar esse quarto, "+retorno+"", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtb_roomAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtb_roomAlterar.Text)))
            {
                limpaCampoForm();
            }
        }

        private void limpaCampoForm()
        {
            listView_room.Items.Clear();
            btn_alterar.Enabled = false;
            txtb_novoAlterar.Text = "";
            txtb_novoAlterar.Enabled = false;
            cbox_opcoes.Enabled = false;
            cbox_opcoes.SelectedIndex = -1;
            rbtn_disponivel.Enabled = false;
            rbtn_ocupado.Enabled = false;
            rbtn_limpo.Enabled = false;
            rbtn_sujo.Enabled = false;
        }

        private void cbox_opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbox_opcoes.SelectedIndex == 0) || (cbox_opcoes.SelectedIndex == 1) || (cbox_opcoes.SelectedIndex == 2) || (cbox_opcoes.SelectedIndex == 5))
            {
                txtb_novoAlterar.Enabled = true;
                txtb_novoAlterar.Visible = true;
                rbtn_disponivel.Enabled = false;
                rbtn_disponivel.Visible = false;
                rbtn_ocupado.Enabled = false;
                rbtn_ocupado.Visible = false;
                rbtn_limpo.Enabled = false;
                rbtn_limpo.Visible = false;
                rbtn_sujo.Enabled = false;
                rbtn_sujo.Visible = false;
            }
            else if (cbox_opcoes.SelectedIndex == 3)
            {
                txtb_novoAlterar.Text = "";
                txtb_novoAlterar.Enabled = false;
                txtb_novoAlterar.Visible = false;
                rbtn_disponivel.Enabled = true;
                rbtn_disponivel.Visible = true;
                rbtn_ocupado.Enabled = true;
                rbtn_ocupado.Visible = true;
                rbtn_limpo.Enabled = false;
                rbtn_limpo.Visible = false;
                rbtn_sujo.Enabled = false;
                rbtn_sujo.Visible = false;

                if (room.room_disponibilidade)
                {
                    rbtn_disponivel.Checked = true;
                    rbtn_ocupado.Checked = false;
                }
                else if (!room.room_disponibilidade)
                {
                    rbtn_disponivel.Checked = false;
                    rbtn_ocupado.Checked = true;
                }
            }
            else if (cbox_opcoes.SelectedIndex == 4)
            {
                txtb_novoAlterar.Text = "";
                txtb_novoAlterar.Enabled = false;
                txtb_novoAlterar.Visible = false;
                rbtn_disponivel.Enabled = false;
                rbtn_disponivel.Visible = false;
                rbtn_ocupado.Enabled = false;
                rbtn_ocupado.Visible = false;
                rbtn_limpo.Enabled = true;
                rbtn_limpo.Visible = true;
                rbtn_sujo.Enabled = true;
                rbtn_sujo.Visible = true;

                if (room.room_limpeza)
                {
                    rbtn_limpo.Checked = true;
                    rbtn_sujo.Checked = false;
                }
                else if (!room.room_limpeza)
                {
                    rbtn_limpo.Checked = false;
                    rbtn_sujo.Checked = true;
                }
            }
        }
        private void listaComboBox()
        {
            cbox_opcoes.Items.Add("Numero do Quarto");
            cbox_opcoes.Items.Add("Quant. Camas casal");
            cbox_opcoes.Items.Add("Quant. Camas solteiro");
            cbox_opcoes.Items.Add("Disponibilidade");
            cbox_opcoes.Items.Add("Limpeza");
            cbox_opcoes.Items.Add("Preço da Diária");
        }

        private void txtb_novoAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || (((rbtn_disponivel.Checked && rbtn_disponivel.Enabled) || (rbtn_ocupado.Checked && rbtn_ocupado.Enabled)) || ((rbtn_limpo.Checked && rbtn_limpo.Enabled) || (rbtn_sujo.Checked && rbtn_sujo.Enabled))))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        private void rbtn_limpo_CheckedChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || (((rbtn_disponivel.Checked && rbtn_disponivel.Enabled) || (rbtn_ocupado.Checked && rbtn_ocupado.Enabled)) || ((rbtn_limpo.Checked && rbtn_limpo.Enabled) || (rbtn_sujo.Checked && rbtn_sujo.Enabled))))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        private void rbtn_sujo_CheckedChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || (((rbtn_disponivel.Checked && rbtn_disponivel.Enabled) || (rbtn_ocupado.Checked && rbtn_ocupado.Enabled)) || ((rbtn_limpo.Checked && rbtn_limpo.Enabled) || (rbtn_sujo.Checked && rbtn_sujo.Enabled))))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        private void rbtn_ocupado_CheckedChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || (((rbtn_disponivel.Checked && rbtn_disponivel.Enabled) || (rbtn_ocupado.Checked && rbtn_ocupado.Enabled)) || ((rbtn_limpo.Checked && rbtn_limpo.Enabled) || (rbtn_sujo.Checked && rbtn_sujo.Enabled))))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        private void rbtn_disponivel_CheckedChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || (((rbtn_disponivel.Checked && rbtn_disponivel.Enabled) || (rbtn_ocupado.Checked && rbtn_ocupado.Enabled)) || ((rbtn_limpo.Checked && rbtn_limpo.Enabled) || (rbtn_sujo.Checked && rbtn_sujo.Enabled))))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }
    }
}
