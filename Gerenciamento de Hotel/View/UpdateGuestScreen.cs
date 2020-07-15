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

namespace Gerenciamento_de_Hotel.View
{
    public partial class UpdateGuestScreen : Form
    {
        GuestController controller = new GuestController();
        Guest guest = new Guest();
        HotelService service = new HotelService();

        public UpdateGuestScreen()
        {
            InitializeComponent();

            listaComboBox();
            btn_alterar.Enabled = false;
            txtb_novoAlterar.Enabled = false;
            cbox_opcoes.Enabled = false;
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            GuestScreen tela = new GuestScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;

            listView_guest.Items.Clear();
            var listGuest = controller.retornaGuest(0);

            for (int i = 0; i < listGuest.Count; i++)
            {
                if (txtb_guestAlterar.Text.Trim() == listGuest[i].gue_cpf)
                {
                    ListViewItem itens = new ListViewItem(Convert.ToString(listGuest[i].gue_id));
                    itens.SubItems.Add(listGuest[i].gue_nome);
                    itens.SubItems.Add(listGuest[i].gue_cpf);
                    itens.SubItems.Add(listGuest[i].gue_dataNascimento);
                    listView_guest.Items.Add(itens);

                    guest.gue_id = listGuest[i].gue_id;
                    guest.gue_nome = listGuest[i].gue_nome;
                    guest.gue_cpf = listGuest[i].gue_cpf;
                    guest.gue_dataNascimento = listGuest[i].gue_dataNascimento;

                    cbox_opcoes.Enabled = true;
                    verificaSeRetornou = 1;
                }
            }

            if (verificaSeRetornou == 0)
            {
                MessageBox.Show("Não foi possìvel encontrar nenhum hóspede com esse cpf!! \nDigite novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaComboBox()
        {
            cbox_opcoes.Items.Add("Nome");
            cbox_opcoes.Items.Add("CPF");
            cbox_opcoes.Items.Add("Data de Nascimento");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;
            int tipoSelect = 0;

            if (cbox_opcoes.SelectedIndex == 0)
            {
                guest.gue_nome = txtb_novoAlterar.Text;
                tipoSelect = 0;
            }
            else if (cbox_opcoes.SelectedIndex == 1)
            {
                guest.gue_cpf = txtb_novoAlterar.Text;
                tipoSelect = 0;

                if (!service.verificaIntOrFloat(guest.gue_cpf))
                {
                    verificaSeRetornou = 1;
                }

                var listGuest = controller.retornaGuest(0);

                for (int i = 0; i < listGuest.Count; i++)
                {
                    if (guest.gue_cpf == listGuest[i].gue_cpf)
                    {
                        verificaSeRetornou = 1;
                    }
                }
            }
            else if (cbox_opcoes.SelectedIndex == 2)
            {
                guest.gue_dataNascimento = txtb_ano.Text + "/" + txtb_mes.Text + "/" + txtb_dia.Text;
                tipoSelect = 1;

                if ((!service.verificaIntOrFloat(txtb_dia.Text.Trim())) || (!service.verificaIntOrFloat(txtb_mes.Text.Trim())) || (!service.verificaIntOrFloat(txtb_ano.Text.Trim())))
                {
                    verificaSeRetornou = 1;
                }
            }
           
            if (verificaSeRetornou == 0)
            {
                if (MessageBox.Show("Deseja alterar esse funcionario?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    controller.alteraGuest(guest, tipoSelect);
                    MessageBox.Show("Funcionario alterado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampoForm();
                }
            }
            else
            {
                MessageBox.Show("Não é possível alterar esse hóspede, pois já há um funcionário com esse CPF ou o mesmo é inválido!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbox_opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_opcoes.SelectedIndex == 2)
            {
                txtb_novoAlterar.Visible = false;
                txtb_novoAlterar.Enabled = false;
                lbl_barra1.Visible = true;
                lbl_barra2.Visible = true;
                txtb_dia.Visible = true;
                txtb_dia.Enabled = true;
                txtb_mes.Visible = true;
                txtb_mes.Enabled = true;
                txtb_ano.Visible = true;
                txtb_ano.Enabled = true;
            }
            else
            {
                txtb_novoAlterar.Visible = true;
                txtb_novoAlterar.Enabled = true;
                lbl_barra1.Visible = false;
                lbl_barra2.Visible = false;
                txtb_dia.Visible = false;
                txtb_dia.Enabled = false;
                txtb_mes.Visible = false;
                txtb_mes.Enabled = false;
                txtb_ano.Visible = false;
                txtb_ano.Enabled = false;
            }
        }
        private void txtb_guestAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtb_guestAlterar.Text)))
            {
                limpaCampoForm();
            }
        }

        private void limpaCampoForm()
        {
            listView_guest.Items.Clear();
            btn_alterar.Enabled = false;
            txtb_dia.Text = "";
            txtb_dia.Enabled = false;
            txtb_mes.Text = "";
            txtb_mes.Enabled = false;
            txtb_ano.Text = "";
            txtb_ano.Enabled = false;
            txtb_novoAlterar.Text = "";
            txtb_novoAlterar.Enabled = false;
            cbox_opcoes.Enabled = false;
            cbox_opcoes.SelectedIndex = -1;
        }

        private void txtb_novoAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || ((!string.IsNullOrWhiteSpace(txtb_dia.Text)) && (!string.IsNullOrWhiteSpace(txtb_mes.Text)) && (!string.IsNullOrWhiteSpace(txtb_ano.Text))))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        private void txtb_dia_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || ((!string.IsNullOrWhiteSpace(txtb_dia.Text)) && (!string.IsNullOrWhiteSpace(txtb_mes.Text)) && (!string.IsNullOrWhiteSpace(txtb_ano.Text))))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        private void txtb_mes_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || ((!string.IsNullOrWhiteSpace(txtb_dia.Text)) && (!string.IsNullOrWhiteSpace(txtb_mes.Text)) && (!string.IsNullOrWhiteSpace(txtb_ano.Text))))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        private void txtb_ano_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)) || ((!string.IsNullOrWhiteSpace(txtb_dia.Text)) && (!string.IsNullOrWhiteSpace(txtb_mes.Text)) && (!string.IsNullOrWhiteSpace(txtb_ano.Text))))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }
    }
}
