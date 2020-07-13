﻿using Gerenciamento_de_Hotel.Controller;
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
    public partial class UpdateRoomScreen : Form
    {
        RoomController controller = new RoomController();
        Room room = new Room();
        RoomScreen tela = new RoomScreen();

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
            RoomScreen tela = new RoomScreen();
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
                    ListViewItem itens = new ListViewItem(Convert.ToString(roomRetornado[i].room_numeroQuarto));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_quantCasal));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_quantSolteiro));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_disponibilidade));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_limpeza));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_precoDiaria));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_precoTotal));
                    itens.SubItems.Add(Convert.ToString(roomRetornado[i].room_quantPessoa));
                    listView_room.Items.Add(itens);

                    room.room_id = roomRetornado[i].room_id;
                    room.room_numeroQuarto = roomRetornado[i].room_numeroQuarto;
                    room.room_quantCasal = roomRetornado[i].room_quantCasal;
                    room.room_quantSolteiro = roomRetornado[i].room_quantSolteiro;
                    room.room_disponibilidade = roomRetornado[i].room_disponibilidade;
                    room.room_limpeza = roomRetornado[i].room_limpeza;
                    room.room_precoDiaria = roomRetornado[i].room_precoDiaria;
                    room.room_precoTotal = roomRetornado[i].room_precoTotal;
                    room.room_quantPessoa = roomRetornado[i].room_quantPessoa;

                    txtb_novoAlterar.Enabled = true;
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

            if (cbox_opcoes.SelectedIndex == 0)
            {
                room.room_numeroQuarto = txtb_novoAlterar.Text;

                var listRoom = controller.retornaRoom(0);

                for (int i = 0; i < listRoom.Count; i++)
                {
                    if (room.room_numeroQuarto == listRoom[i].room_numeroQuarto)
                    {
                        verificaSeRetornou = 1;
                    }
                }
            }
            else if (cbox_opcoes.SelectedIndex == 1)
            {
                //verificar se é número...
                room.room_numeroQuarto = txtb_novoAlterar.Text;
            }
            else if (cbox_opcoes.SelectedIndex == 2)
            {
                //verificar se é número...
                room.room_numeroQuarto = txtb_novoAlterar.Text;
            }
            else if (cbox_opcoes.SelectedIndex == 3)
            {
                //txtb_novoAlterar.Text = "Disponível ou Ocupado";
            }
            else if (cbox_opcoes.SelectedIndex == 4)
            {
                // txtb_novoAlterar.Text = "Limpo ou Sujo";
            }
            else if (cbox_opcoes.SelectedIndex == 5)
            {
                //verificar se é número...
                room.room_numeroQuarto = txtb_novoAlterar.Text;
            }

            if (verificaSeRetornou == 0)
            {
                if (MessageBox.Show("Deseja alterar esse quarto?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    controller.alteraRoom(room);
                    MessageBox.Show("Quarto alterado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    tela.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Não é possível alterar esse quarto, pois já há um quarto com esse número!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtb_roomAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtb_roomAlterar.Text)))
            {
                listView_room.Items.Clear();
                btn_alterar.Enabled = false;
                txtb_novoAlterar.Text = "";
                txtb_novoAlterar.Enabled = false;
                cbox_opcoes.Enabled = false;
            }  
        }
        private void txtb_novoAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
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
    }
}
