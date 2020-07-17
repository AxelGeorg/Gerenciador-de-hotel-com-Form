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

namespace Gerenciamento_de_Hotel.View.GuestCRUD
{
    public partial class DeleteGuestScreen : Form
    {
        GuestController controller = new GuestController();
        Guest guest = new Guest();
        public DeleteGuestScreen()
        {
            InitializeComponent();
            btn_deletar.Enabled = false;
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

            listView_guest.Items.Clear();
            var guestRetornado = controller.retornaGuest(0);

            for (int i = 0; i < guestRetornado.Count; i++)
            {
                if (txtb_guestDeletar.Text.Trim() == guestRetornado[i].gue_cpf)
                {
                    ListViewItem itens = new ListViewItem(Convert.ToString(guestRetornado[i].gue_id));
                    itens.SubItems.Add(Convert.ToString(guestRetornado[i].gue_nome));
                    itens.SubItems.Add(Convert.ToString(guestRetornado[i].gue_dataNascimento));
                    listView_guest.Items.Add(itens);

                    guest.gue_id = guestRetornado[i].gue_id;
                    btn_deletar.Enabled = true;

                    verificaSeRetornou = 1;
                }
            }
            if (verificaSeRetornou == 0)
            {
                MessageBox.Show("Não foi possìvel encontrar nenhum hóspede com esse cpf!! \nDigite novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar esse hóspede?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (controller.deletaGuest(guest.gue_id))
                {
                    MessageBox.Show("Hóspede deletado com sucesso");
                    GuestScreen tela = new GuestScreen();
                    this.Hide();
                    tela.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o hóspede");
                }
            }
        }

        private void txtb_guestDeletar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_guestDeletar.Text))
            {
                listView_guest.Items.Clear();
                btn_deletar.Enabled = false;
            }
        }
    }
}
