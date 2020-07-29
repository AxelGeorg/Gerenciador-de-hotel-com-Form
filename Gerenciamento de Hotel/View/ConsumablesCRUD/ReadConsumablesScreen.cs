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

namespace Gerenciamento_de_Hotel.View
{
    public partial class ReadConsumablesScreen : Form
    {
        ConsumablesController controller = new ConsumablesController();

        public ReadConsumablesScreen()
        {
            InitializeComponent();
            listar(0);
        }
        public void listar(int tipoOrdenacao)
        {
            listView_consumables.Items.Clear();
            var listConsumables = new List<Consumables>();

            listConsumables = controller.retornaConsumables(tipoOrdenacao);

            for (int i = 0; i < listConsumables.Count; i++)
            {
                listView_consumables.Items.Add(listConsumables[i].con_id.ToString());
                listView_consumables.Items[i] .SubItems.Add(listConsumables[i].con_nome);
                listView_consumables.Items[i].SubItems.Add(listConsumables[i].con_tipoProduto);
                listView_consumables.Items[i].SubItems.Add(listConsumables[i].con_tipoSabor);
                listView_consumables.Items[i].SubItems.Add(listConsumables[i].con_descricao);
            }
        }
        private void ordenar(object sender, ColumnClickEventArgs e)
        {
            listView_consumables.Items.Clear();
            if (e.Column == 0)
            {
                listar(0);
            }
            else if (e.Column == 1)
            {
                listar(1);
            }
            else if (e.Column == 2)
            {
                listar(2);
            }
            else if (e.Column == 3)
            {
                listar(3);
            }
            else if (e.Column == 4)
            {
                //ver o que fazer nessa situação
                listar(0);
            }
        }
    }
}
