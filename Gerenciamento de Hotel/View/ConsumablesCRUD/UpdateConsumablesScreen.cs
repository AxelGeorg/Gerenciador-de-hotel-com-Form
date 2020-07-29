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
    public partial class UpdateConsumablesScreen : Form
    {
        ConsumablesController controller = new ConsumablesController();
        Consumables consumables = new Consumables();

        public UpdateConsumablesScreen()
        {
            InitializeComponent();
            btn_alterar.Enabled = false;
            txtb_novoAlterar.Enabled = false;
            cbox_opcoes.Enabled = false;
            cbox_tipo.Visible = false;
            listaComboBox();
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            GerenciadorStripScreen tela = new GerenciadorStripScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            listView_consumables.Items.Clear();

            if (string.IsNullOrEmpty(txtb_consumablesAlterar.Text))
            {
                MessageBox.Show("A caixa de texto pesquisa esta vazia!! \nDigite novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                consumables = controller.retonaConsumablesNome(txtb_consumablesAlterar.Text);

                if (consumables.con_nome != null)
                {
                    ListViewItem itens = new ListViewItem(Convert.ToString(consumables.con_id));
                    itens.SubItems.Add(Convert.ToString(consumables.con_nome));
                    itens.SubItems.Add(Convert.ToString(consumables.con_tipoProduto));
                    itens.SubItems.Add(Convert.ToString(consumables.con_tipoSabor));
                    itens.SubItems.Add(Convert.ToString(consumables.con_descricao));
                    listView_consumables.Items.Add(itens);

                    cbox_opcoes.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Não há consumiveis com esse nome!! \nDigite novamente ou verifique no estoque!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void listaComboBox()
        {
            cbox_opcoes.Items.Add("Nome");
            cbox_opcoes.Items.Add("Tipo Produto");
            cbox_opcoes.Items.Add("Tipo Sabor");
            cbox_opcoes.Items.Add("Descrição");
        }
        private void listaComboBoxProduto()
        {
            cbox_tipo.Items.Add("Bebida");
            cbox_tipo.Items.Add("Comida");
        }
        private void listaComboBoxSabor()
        {
            cbox_tipo.Items.Add("Doce");
            cbox_tipo.Items.Add("Salgado");
            cbox_tipo.Items.Add("Amargo");
            cbox_tipo.Items.Add("Azedo");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;

            if (cbox_opcoes.SelectedIndex == 0)
            {
                consumables.con_nome = txtb_novoAlterar.Text;

                var consumablesRetornado = controller.retonaConsumablesNome(txtb_novoAlterar.Text);

                if (consumablesRetornado.con_nome != null)
                {
                    verificaSeRetornou = 1;
                }
            }
            else if (cbox_opcoes.SelectedIndex == 1)
            {
                consumables.con_tipoProduto = cbox_tipo.SelectedItem.ToString();
            }
            else if (cbox_opcoes.SelectedIndex == 2)
            {
                consumables.con_tipoSabor = cbox_tipo.SelectedItem.ToString();
            }
            else if (cbox_opcoes.SelectedIndex == 3)
            {
                consumables.con_descricao = txtb_novoAlterar.Text;
            }

            if (verificaSeRetornou == 0)
            {
                if (MessageBox.Show("Deseja alterar esse produto?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    controller.alteraConsumables(consumables);
                    MessageBox.Show("Produto alterado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampoForm();
                }
            }
            else
            {
                MessageBox.Show("Não é possível alterar esse produto, pois já há um produto com esse nome!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbox_opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbox_opcoes.SelectedIndex == 0) || (cbox_opcoes.SelectedIndex == 3))
            {
                btn_alterar.Enabled = false;
                txtb_novoAlterar.Visible = true;
                txtb_novoAlterar.Enabled = true;
                cbox_tipo.Enabled = false;
                cbox_tipo.Visible = false;
                cbox_tipo.SelectedIndex = -1;
            }
            else if (cbox_opcoes.SelectedIndex == 1)
            {
                btn_alterar.Enabled = false;
                txtb_novoAlterar.Visible = false;
                txtb_novoAlterar.Enabled = false;
                cbox_tipo.Enabled = true;
                cbox_tipo.Visible = true;
                cbox_tipo.Items.Clear();
                listaComboBoxProduto();
            }
            else if (cbox_opcoes.SelectedIndex == 2)
            {
                btn_alterar.Enabled = false;
                txtb_novoAlterar.Visible = false;
                txtb_novoAlterar.Enabled = false;
                cbox_tipo.Enabled = true;
                cbox_tipo.Visible = true;
                cbox_tipo.Items.Clear();
                listaComboBoxSabor();
            }
        }

        private void txtb_novoAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || (cbox_tipo.SelectedIndex != -1))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }
        private void cbox_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || (cbox_tipo.SelectedIndex != -1))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        private void txtb_consumablesAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtb_consumablesAlterar.Text)))
            {
                limpaCampoForm();
            }
        }

        private void limpaCampoForm()
        {
            listView_consumables.Items.Clear();
            btn_alterar.Enabled = false;
            txtb_novoAlterar.Text = "";
            txtb_novoAlterar.Enabled = false;
            txtb_novoAlterar.Visible = true;
            cbox_opcoes.Enabled = false;
            cbox_opcoes.SelectedIndex = -1;
            cbox_tipo.Enabled = false;
            cbox_tipo.Visible = false;
            cbox_tipo.SelectedIndex = -1;
        }
    }
}
