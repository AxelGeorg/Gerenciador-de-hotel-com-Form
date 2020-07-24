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

namespace Gerenciamento_de_Hotel.View.ConsumablesCRUD
{
    public partial class CreateConsumablesScreen : Form
    {
        ConsumablesController controller = new ConsumablesController();

        public CreateConsumablesScreen()
        {
            InitializeComponent();
            listaComboBoxs();
            btn_cadastrar.Enabled = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            GerenciadorStripScreen tela = new GerenciadorStripScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Consumables consumables = new Consumables();
            int verificaSeRetornou = 0;

            var listConsumables = controller.retornaConsumables(0);

            for (int i = 0; i < listConsumables.Count; i++)
            {
                if ((txtb_nome.Text.Trim() == listConsumables[i].con_nome))
                {
                    MessageBox.Show("Não é possível cadastrar esse consumível, pois já há uma consumível com esse nome!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificaSeRetornou = 1;
                }
            }

            if (verificaSeRetornou == 0)
            {
                consumables.con_nome = txtb_nome.Text;
                consumables.con_tipoProduto = cbox_tipo.SelectedItem.ToString();
                consumables.con_tipoSabor = cbox_sabor.SelectedItem.ToString();
                consumables.con_descricao = txtb_descricao.Text;

                if (MessageBox.Show("Deseja cadastrar esse Consumível?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (controller.cadastrarConsumables(consumables))
                    {
                        txtb_nome.Clear();
                        cbox_tipo.SelectedIndex = -1;
                        cbox_sabor.SelectedIndex = -1;
                        txtb_descricao.Clear();
                        MessageBox.Show("Consumível cadastrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o Consumível!");
                    }
                }
            }
        }

        private void listaComboBoxs()
        {
            cbox_tipo.Items.Add("Comida");
            cbox_tipo.Items.Add("Bebida");

            cbox_sabor.Items.Add("Doce");
            cbox_sabor.Items.Add("Salgado");
            cbox_sabor.Items.Add("Azedo");
            cbox_sabor.Items.Add("Amargo");
        }

        private void txtb_nome_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_descricao.Text)) && (cbox_tipo.SelectedIndex != -1) && (cbox_sabor.SelectedIndex != -1))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void cbox_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_descricao.Text)) && (cbox_tipo.SelectedIndex != -1) && (cbox_sabor.SelectedIndex != -1))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void cbox_sabor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_descricao.Text)) && (cbox_tipo.SelectedIndex != -1) && (cbox_sabor.SelectedIndex != -1))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void txtb_descricao_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_descricao.Text)) && (cbox_tipo.SelectedIndex != -1) && (cbox_sabor.SelectedIndex != -1))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }
    }
}
