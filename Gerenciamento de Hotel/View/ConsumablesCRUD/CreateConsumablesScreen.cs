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

namespace Gerenciamento_de_Hotel.View.ConsumablesCRUD
{
    public partial class CreateConsumablesScreen : Form
    {
        ConsumablesController controller = new ConsumablesController();
        HotelService service = new HotelService();

        public CreateConsumablesScreen()
        {
            InitializeComponent();
            listaComboBoxs();
            btn_cadastrar.Enabled = false;
            txtb_nome.Focus();
            txtb_nome.Select();
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

            if (!service.verificaIntOrFloat(txtb_preco.Text))
            {
                verificaSeRetornou = 1;
            }

            if (verificaSeRetornou == 0)
            {
                consumables.con_nome = txtb_nome.Text;
                consumables.con_tipoProduto = cbox_tipo.SelectedItem.ToString();
                consumables.con_tipoSabor = cbox_sabor.SelectedItem.ToString();

                var precoCerto = txtb_preco.Text.Replace(",", ".");
                consumables.con_preco = float.Parse(precoCerto)/100;
                consumables.con_descricao = txtb_descricao.Text;

                if (MessageBox.Show("Deseja cadastrar esse Consumível?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (controller.cadastrarConsumables(consumables))
                    {
                        if (Application.OpenForms.OfType<ReadConsumablesScreen>().Count() > 0)
                        {
                            ReadConsumablesScreen form = Application.OpenForms["ReadConsumablesScreen"] as ReadConsumablesScreen;
                            form.listar(0);
                        }

                        txtb_nome.Clear();
                        cbox_tipo.SelectedIndex = -1;
                        cbox_sabor.SelectedIndex = -1;
                        txtb_preco.Clear();
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
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_descricao.Text)) && (!string.IsNullOrWhiteSpace(txtb_preco.Text)) && (cbox_tipo.SelectedIndex != -1) && (cbox_sabor.SelectedIndex != -1))
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
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_descricao.Text)) && (!string.IsNullOrWhiteSpace(txtb_preco.Text)) && (cbox_tipo.SelectedIndex != -1) && (cbox_sabor.SelectedIndex != -1))
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
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_descricao.Text)) && (!string.IsNullOrWhiteSpace(txtb_preco.Text)) && (cbox_tipo.SelectedIndex != -1) && (cbox_sabor.SelectedIndex != -1))
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
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_descricao.Text)) && (!string.IsNullOrWhiteSpace(txtb_preco.Text)) && (cbox_tipo.SelectedIndex != -1) && (cbox_sabor.SelectedIndex != -1))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void txtb_preco_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_descricao.Text)) && (!string.IsNullOrWhiteSpace(txtb_preco.Text)) && (cbox_tipo.SelectedIndex != -1) && (cbox_sabor.SelectedIndex != -1))
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
