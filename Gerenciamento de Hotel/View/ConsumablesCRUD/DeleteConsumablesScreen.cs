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
    public partial class DeleteConsumablesScreen : Form
    {
        ConsumablesController controller = new ConsumablesController();
        Consumables consumables = new Consumables();

        public DeleteConsumablesScreen()
        {
            InitializeComponent();
            btn_deletar.Enabled = false;
            txtb_nome.Focus();
            txtb_nome.Select();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtb_nome.Text))
            {
                MessageBox.Show("A caixa de texto pesquisa esta vazia!! \nDigite novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                consumables = controller.retonaConsumablesNome(txtb_nome.Text);

                if (consumables.con_nome != null)
                {
                    ListViewItem itens = new ListViewItem(Convert.ToString(consumables.con_id));
                    itens.SubItems.Add(Convert.ToString(consumables.con_nome));
                    itens.SubItems.Add(Convert.ToString(consumables.con_tipoProduto));
                    itens.SubItems.Add(Convert.ToString(consumables.con_tipoSabor));
                    itens.SubItems.Add(Convert.ToString("R$"+consumables.con_preco));
                    itens.SubItems.Add(Convert.ToString(consumables.con_descricao));
                    listView_consumables.Items.Add(itens);
                    btn_deletar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Não há consumiveis com esse nome!! \nDigite novamente ou verifique no estoque!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar esse produto?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (controller.deletarConsumable(consumables.con_id))
                {
                    listView_consumables.Items.Clear();

                    if (Application.OpenForms.OfType<ReadConsumablesScreen>().Count() > 0)
                    {
                        ReadConsumablesScreen form = Application.OpenForms["ReadConsumablesScreen"] as ReadConsumablesScreen;
                        form.listar(0);
                    }

                    txtb_nome.Text = "";
                    MessageBox.Show("Produto deletado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o hóspede", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtb_nome_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_nome.Text))
            {
                listView_consumables.Items.Clear();
                btn_deletar.Enabled = false;
            }
        }
    }
}
