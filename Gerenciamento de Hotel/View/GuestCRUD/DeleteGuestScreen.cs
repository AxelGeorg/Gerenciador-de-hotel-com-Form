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

namespace Gerenciamento_de_Hotel.View.GuestCRUD
{
    public partial class DeleteGuestScreen : Form
    {
        GuestController controller = new GuestController();
        Guest guest = new Guest();
        HotelService service = new HotelService();

        public DeleteGuestScreen()
        {
            InitializeComponent();
            btn_deletar.Enabled = false;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;
            string cpfRetornado = service.preparaCPFparaBD(txtb_guestDeletar.Text);

            listView_guest.Items.Clear();
            var guestRetornado = controller.retornaGuest(0);
            var guestParaValidacao = controller.retornaGuestParaDelete();


            for (int i = 0; i < guestRetornado.Count; i++)
            {
                if ((cpfRetornado == guestRetornado[i].gue_cpf) && ((string.IsNullOrEmpty(guestParaValidacao[i].gue_fk_room.ToString()) || (guestParaValidacao[i].gue_fk_room == 0))))
                {
                    ListViewItem itens = new ListViewItem(Convert.ToString(guestRetornado[i].gue_id));
                    itens.SubItems.Add(Convert.ToString(guestRetornado[i].gue_nome));
                    itens.SubItems.Add(Convert.ToString(guestRetornado[i].gue_cpf));
                    itens.SubItems.Add(Convert.ToString(guestRetornado[i].gue_dataNascimento));
                    listView_guest.Items.Add(itens);

                    guest.gue_id = guestRetornado[i].gue_id;
                    btn_deletar.Enabled = true;

                    verificaSeRetornou = 1;
                }
            }
            if (verificaSeRetornou == 0)
            {
                MessageBox.Show("Não foi possìvel encontrar nenhum hóspede com esse cpf ou esse hóspede possui vinculo a um quarto, desse modo, não pode ser deletado!! \nDigite novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar esse hóspede?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (controller.deletaGuest(guest.gue_id))
                {
                    if (Application.OpenForms.OfType<ReadGuestScreen>().Count() > 0)
                    {
                        ReadGuestScreen form = Application.OpenForms["ReadGuestScreen"] as ReadGuestScreen;
                        form.listar(0);
                    }

                    listView_guest.Items.Clear();
                    btn_deletar.Enabled = false;
                    txtb_guestDeletar.Text = "";
                    MessageBox.Show("Hóspede deletado com sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o hóspede!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtb_guestDeletar.MaxLength = 14;
        }

        private void mascara_cpf(object sender, KeyPressEventArgs e)
        {
            char num;
            txtb_guestDeletar.SelectionStart = txtb_guestDeletar.Text.Length + 1;

            if (txtb_guestDeletar.Text.Length == 3 || txtb_guestDeletar.Text.Length == 7)
            {
                txtb_guestDeletar.Text = txtb_guestDeletar.Text + ".";
            }
            else if (txtb_guestDeletar.Text.Length == 11)
            {
                txtb_guestDeletar.Text = txtb_guestDeletar.Text + "-";
            }
            txtb_guestDeletar.SelectionStart = txtb_guestDeletar.Text.Length + 1;

            if ((e.KeyChar == (char)Keys.Back) && (txtb_guestDeletar.Text.Length > 0))
            {
                string s = txtb_guestDeletar.Text.Substring(txtb_guestDeletar.Text.Length - 1, 1);

                if (string.Equals(s, "-") || string.Equals(s, "."))
                {
                    num = txtb_guestDeletar.Text[txtb_guestDeletar.Text.Length - 2];

                    txtb_guestDeletar.Text = txtb_guestDeletar.Text.Remove(txtb_guestDeletar.Text.Length - 1);

                    txtb_guestDeletar.Text += num;
                    txtb_guestDeletar.SelectionStart = txtb_guestDeletar.Text.Length;

                    txtb_guestDeletar.Text = txtb_guestDeletar.Text.Remove(txtb_guestDeletar.Text.Length - 1);
                    txtb_guestDeletar.SelectionStart = txtb_guestDeletar.Text.Length;
                }
                else if (txtb_guestDeletar.Text.Length == 1)
                {
                    txtb_guestDeletar.Text = txtb_guestDeletar.Text.Remove(txtb_guestDeletar.Text.Length - 1);
                    txtb_guestDeletar.SelectionStart = txtb_guestDeletar.Text.Length;
                }
                else if (service.verificaIntOrFloat(txtb_guestDeletar.Text))
                {
                    num = txtb_guestDeletar.Text[txtb_guestDeletar.Text.Length - 2];

                    txtb_guestDeletar.Text = txtb_guestDeletar.Text.Remove(txtb_guestDeletar.Text.Length - 1);

                    txtb_guestDeletar.Text += num;
                    txtb_guestDeletar.SelectionStart = txtb_guestDeletar.Text.Length;
                }
            }
        }
    }
}
