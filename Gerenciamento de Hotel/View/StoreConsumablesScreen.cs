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
    public partial class StoreConsumablesScreen : Form
    {
        ConsumablesController consumablesController = new ConsumablesController();
        GuestController guestController = new GuestController();
        Guest guest = new Guest();
        bool verificaSeHaProdutos;
        string tipoProdutoList = "";

        public StoreConsumablesScreen(Guest guestRetornado)
        {
            InitializeComponent();

            guest = guestRetornado;
            ListaComboBox();
            cbox_ordem.SelectedIndex = 0;
            verificaSeHaProdutos = VerificaProdutos();
            btn_comprarProduto.Enabled = false;

            if (verificaSeHaProdutos)
            {
                lbl_semProdutos.Visible = false;
                cbox_ordem.Enabled = true;
                listView_consumables.Visible = true;
                Listar(0, tipoProdutoList);
            }
            else
            {
                lbl_semProdutos.Visible = true;
                cbox_ordem.Enabled = false;
                listView_consumables.Visible = false;
            }
        }

        public bool VerificaProdutos()
        {
            var listConsumables = consumablesController.retornaConsumables(0);

            if (listConsumables.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        private void ListaComboBox()
        {
            cbox_ordem.Items.Add("Todos os Produtos");
            cbox_ordem.Items.Add("Todas as Bebidas");
            cbox_ordem.Items.Add("Todas as Comidas");
            cbox_ordem.Items.Add("Produtos com Descrição");
            cbox_ordem.Items.Add("Bebidas com Descrição");
            cbox_ordem.Items.Add("Comidas com Descrição");
        }
        public void Listar(int tipoOrdenacao, string tipoProdutoList)
        {
            listView_consumables.Items.Clear();
            var listConsumables = consumablesController.retornaConsumablesPorTipoProduto(tipoOrdenacao, tipoProdutoList);

            for (int i = 0; i < listConsumables.Count; i++)
            {
                listView_consumables.Items.Add(listConsumables[i].con_id.ToString());
                listView_consumables.Items[i].SubItems.Add(listConsumables[i].con_nome);
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
                Listar(0, tipoProdutoList);
            }
            else if (e.Column == 1)
            {
                Listar(1, tipoProdutoList);
            }
            else if (e.Column == 2)
            {
                Listar(2, tipoProdutoList);
            }
            else if (e.Column == 3)
            {
                Listar(3, tipoProdutoList);
            }
            else if (e.Column == 4)
            {
                //ver o que fazer nessa situação
                Listar(0, tipoProdutoList);
            }
        }

        private void cbox_ordem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_ordem.SelectedIndex == 0)
            {
                tipoProdutoList = "";
                Listar(0, tipoProdutoList);
            }
            else if (cbox_ordem.SelectedIndex == 1)
            {
                tipoProdutoList = "Bebida";
                Listar(0, tipoProdutoList);
            }
            else if (cbox_ordem.SelectedIndex == 2)
            {
                tipoProdutoList = "Comida";
                Listar(0, tipoProdutoList);
            }
            else if (cbox_ordem.SelectedIndex == 3)
            {

            }
            else if (cbox_ordem.SelectedIndex == 4)
            {

            }
            else if (cbox_ordem.SelectedIndex == 5)
            {

            }
        }

        private void listView_consumables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_consumables.SelectedItems.Count > 0)
            {
                btn_comprarProduto.Enabled = true;
            }
        }

        private void btn_comprarProduto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja comprar esse produto?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                //controller.alteraConsumables(consumables);
                //guest.gue_precoTotal += 
                //guestController.alteraGuestParaReserva(guest);

                if (Application.OpenForms.OfType<ReadGuestScreen>().Count() > 0)
                {
                    ReadGuestScreen form = Application.OpenForms["ReadGuestScreen"] as ReadGuestScreen;
                    form.listar(0);
                }

                btn_comprarProduto.Enabled = false;
                MessageBox.Show(listView_consumables.SelectedItems[0].SubItems[1].Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView_consumables.Items.Remove(listView_consumables.SelectedItems[0]);
            }





        }
    }
}
