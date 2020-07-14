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
    public partial class CreateGuestScreen : Form
    {
        GuestController controller = new GuestController();
        Guest guest = new Guest();
        string dataNascimento;
        public CreateGuestScreen()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cadastrar esse Hóspede?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                dataNascimento = txtb_ano.Text + "/" + txtb_mes.Text + "/" + txtb_dia.Text;
                guest.gue_nome = txtb_nome.Text;
                guest.gue_cpf = txtb_cpf.Text;
                guest.gue_dataNascimento = dataNascimento;

                if (controller.cadastrarGuest(guest))
                {
                    MessageBox.Show("Hóspede cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o hóspede");
                }
            }

        }
    }
}
