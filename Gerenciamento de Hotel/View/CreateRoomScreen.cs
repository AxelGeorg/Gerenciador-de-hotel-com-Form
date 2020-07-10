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
    public partial class CreateRoomScreen : Form
    {
        RoomController controller = new RoomController();
        
        public CreateRoomScreen()
        {
            InitializeComponent();
            btn_cadastrar.Enabled = true;
            txtb_qunatPessoas.Enabled = false;
            txtb_qunatPessoas.Text = "0";
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            RoomScreen tela = new RoomScreen();
            this.Hide();
            tela.ShowDialog();
        }
        private void CreateRoomScreen_Load(object sender, EventArgs e)
        {
            // 
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            int verificaSeRetornou = 0;

            var listRoom = controller.retornaRoom(0);

            for (int i = 0; i < listRoom.Count; i++)
            {
                if ((txtb_identificacao.Text.Trim() == listRoom[i].room_numeroQuarto))
                {
                    MessageBox.Show("Não é possível cadastrar essa funcionários, pois já há uma funcionário com esse CPF e com esse Email!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificaSeRetornou = 1;
                }
            }

            if (verificaSeRetornou == 0)
            {
                //Daniel 09/07/2020 - passa como parametro o objeto room para o método cadastrarRoom para salvar os dados do quarto no banco.
                room.room_numeroQuarto = txtb_identificacao.Text;
                room.room_disponibilidade = true;
                room.room_quantCasal = Convert.ToInt32(txtb_quantCamaCasal.Text);
                room.room_quantSolteiro = Convert.ToInt32(txtb_qunatCamaSolteiro.Text);
                room.room_precoDiaria = float.Parse(txtb_precoDiaria.Text);
                room.room_limpeza = false;
                room.room_quantPessoa = Convert.ToInt32(txtb_qunatPessoas.Text);

                if (MessageBox.Show("Deseja cadastrar esse Quarto?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    controller.cadastrarRoom(room);

                    txtb_identificacao.Clear();
                    txtb_quantCamaCasal.Clear();
                    txtb_identificacao.Clear();
                    txtb_precoDiaria.Clear();
                    txtb_qunatCamaSolteiro.Clear();
                    MessageBox.Show("Quarto cadastrado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void txtb_quantCamaCasal_TextChanged(object sender, EventArgs e)
        { 
            //Daniel 09/07/2020 - Faz a verificação dos campos camaCasal e camaSolteiro para setar o valor correto na quantidade de pessoas.
            if (txtb_quantCamaCasal.Text != "")
            {
                if (txtb_qunatCamaSolteiro.Text == "")
                {
                    txtb_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2);
                }
                else if (txtb_qunatCamaSolteiro.Text != "")
                {
                    txtb_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2 + Convert.ToInt32(txtb_qunatCamaSolteiro.Text));
                }
            }
            else if (txtb_qunatCamaSolteiro.Text != "")
            {
                txtb_qunatPessoas.Text = txtb_qunatCamaSolteiro.Text;
            }
            else if (txtb_quantCamaCasal.Text == "" && txtb_qunatCamaSolteiro.Text == "")
            {
                txtb_qunatPessoas.Text = "0" ;
            }
        }

        private void txtb_quantCamaCasal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Daniel 09/07/2020 permite apenas números
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txt_qunatCamaSolteiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Daniel 09/07/2020 permite apenas números
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txt_precoDiaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Daniel 09/07/2020 permite apenas números
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtb_identificacao_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_identificacao.Text)) && (!string.IsNullOrWhiteSpace(txtb_qunatCamaSolteiro.Text)) && (!string.IsNullOrWhiteSpace(txtb_quantCamaCasal.Text)) && (!string.IsNullOrWhiteSpace(txtb_precoDiaria.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }
        private void txtb_qunatCamaSolteiro_TextChanged(object sender, EventArgs e)
        {
            //Daniel 09/07/2020 - Faz a verificação dos campos camaCasal e camaSolteiro para setar o valor correto na quantidade de pessoas.
            if (txtb_qunatCamaSolteiro.Text != "")
            {
                if (txtb_quantCamaCasal.Text != "")
                {
                    txtb_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2 + Convert.ToInt32(txtb_qunatCamaSolteiro.Text));
                }
                else
                {
                    txtb_qunatPessoas.Text = txtb_qunatCamaSolteiro.Text;
                }
            }
            else if (txtb_quantCamaCasal.Text != "")
            {
                txtb_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2);
            }
            else if (txtb_quantCamaCasal.Text == "" && txtb_qunatCamaSolteiro.Text == "")
            {
                txtb_qunatPessoas.Text = "0";
            }

            if ((!string.IsNullOrWhiteSpace(txtb_identificacao.Text)) && (!string.IsNullOrWhiteSpace(txtb_qunatCamaSolteiro.Text)) && (!string.IsNullOrWhiteSpace(txtb_quantCamaCasal.Text)) && (!string.IsNullOrWhiteSpace(txtb_precoDiaria.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }
        private void txt_qunatCamaSolteiro_TextChanged(object sender, EventArgs e)
        {
            //Daniel 09/07/2020 - Faz a verificação dos campos camaCasal e camaSolteiro para setar o valor correto na quantidade de pessoas.
            if (txtb_qunatCamaSolteiro.Text != "")
            {
                if (txtb_quantCamaCasal.Text != "")
                {
                    txtb_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2 + Convert.ToInt32(txtb_qunatCamaSolteiro.Text));
                }
                else
                {
                    txtb_qunatPessoas.Text = txtb_qunatCamaSolteiro.Text;
                }
            }
            else if (txtb_quantCamaCasal.Text != "")
            {
                txtb_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2);
            }
            else if (txtb_quantCamaCasal.Text == "" && txtb_qunatCamaSolteiro.Text == "")
            {
                txtb_qunatPessoas.Text = "0";
            }

            if ((!string.IsNullOrWhiteSpace(txtb_identificacao.Text)) && (!string.IsNullOrWhiteSpace(txtb_qunatCamaSolteiro.Text)) && (!string.IsNullOrWhiteSpace(txtb_quantCamaCasal.Text)) && (!string.IsNullOrWhiteSpace(txtb_precoDiaria.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void txtb_precoDiaria_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_identificacao.Text)) && (!string.IsNullOrWhiteSpace(txtb_qunatCamaSolteiro.Text)) && (!string.IsNullOrWhiteSpace(txtb_quantCamaCasal.Text)) && (!string.IsNullOrWhiteSpace(txtb_precoDiaria.Text)))
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
