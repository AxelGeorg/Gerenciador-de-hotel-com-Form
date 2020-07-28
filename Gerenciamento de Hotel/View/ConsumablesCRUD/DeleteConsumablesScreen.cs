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
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            listView_consumables.Clear();
            if(string.IsNullOrEmpty(txtb_nome.Text))
            {
                MessageBox.Show("Digite o nome do produto");
            }
            else
            {
                consumables = controller.retonaConsumablesNome(txtb_nome.Text);
                ListViewItem itens = new ListViewItem(Convert.ToString(consumables.con_id));
                itens.SubItems.Add(Convert.ToString(consumables.con_nome));
                itens.SubItems.Add(Convert.ToString(consumables.con_tipoProduto));
                itens.SubItems.Add(Convert.ToString(consumables.con_tipoSabor));
                itens.SubItems.Add(Convert.ToString(consumables.con_descricao));
                listView_consumables.Items.Add(itens);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar o produto?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (controller.deletarConsumable(consumables.con_id))
                {
                    MessageBox.Show("Produto deletado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o hóspede");
                }
            }
        }
    }
}
