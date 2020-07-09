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
            txt_qunatPessoas.Enabled = false;
            txt_qunatPessoas.Text = "0";
        }

     

        private void CreateRoomScreen_Tisk(object sender, EventArgs e)
        {
            //txt_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txt_qunatCamaSolteiro.Text) + Convert.ToInt32(txtb_quantCamaCasal.Text));
        }

        private void CreateRoomScreen_Load(object sender, EventArgs e)
        {
           // 
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RoomScreen tela = new RoomScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void txt_identificacao_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Daniel 09/07/2020 - passa como parametro o objeto room para o método cadastrarRoom para salvar os dados do quarto no banco.
            Room room = new Room();
            room.room_numeroQUarto = txt_identificacao.Text;
            room.room_disponibilidade = true;
            room.room_quantCasal = Convert.ToInt32(txtb_quantCamaCasal.Text);
            room.room_quantSolteiro = Convert.ToInt32(txt_qunatCamaSolteiro.Text);
            room.room_precoDiaria = float.Parse(txt_precoDiaria.Text);
            room.room_limpeza = false;
            room.quantPessoas = Convert.ToInt32(txt_qunatPessoas.Text);
            
            controller.cadastrarRoom(room);
            if (controller.cadastrarRoom(room))
            {
                MessageBox.Show("Quarto cadastrado com sucesso!!!");
                txt_identificacao.Text = "";
                txtb_quantCamaCasal.Text = "";
                txt_identificacao.Text = "";
                txt_precoDiaria.Text = "";
                txt_qunatCamaSolteiro.Text = "";
            }
            
        }

        
        private void txtb_quantCamaCasal_TextChanged(object sender, EventArgs e)
        { 
            //Daniel 09/07/2020 - Faz a verificação dos campos camaCasal e camaSolteiro para setar o valor correto na quantidade de pessoas.
            if (txtb_quantCamaCasal.Text != "")
            {
                if (txt_qunatCamaSolteiro.Text == "")
                {
                    txt_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2);
                }
                else if (txt_qunatCamaSolteiro.Text != "")
                {
                    txt_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2 + Convert.ToInt32(txt_qunatCamaSolteiro.Text));
                }
            }
            else if (txt_qunatCamaSolteiro.Text != "")
            {
                txt_qunatPessoas.Text = txt_qunatCamaSolteiro.Text;
            }
            else if (txtb_quantCamaCasal.Text == "" && txt_qunatCamaSolteiro.Text == "")
            {
                txt_qunatPessoas.Text = "0" ;
            }
        }

        private void txt_qunatCamaSolteiro_TextChanged(object sender, EventArgs e)
        {
            //Daniel 09/07/2020 - Faz a verificação dos campos camaCasal e camaSolteiro para setar o valor correto na quantidade de pessoas.
            if (txt_qunatCamaSolteiro.Text != "")
            {
                if(txtb_quantCamaCasal.Text != "")
                {
                    txt_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2 + Convert.ToInt32(txt_qunatCamaSolteiro.Text));
                }
                else
                {
                    txt_qunatPessoas.Text = txt_qunatCamaSolteiro.Text;
                }
            }else if(txtb_quantCamaCasal.Text != "")
            {
                txt_qunatPessoas.Text = Convert.ToString(Convert.ToInt32(txtb_quantCamaCasal.Text) * 2);
            }else if (txtb_quantCamaCasal.Text == "" && txt_qunatCamaSolteiro.Text == "")
            {
                txt_qunatPessoas.Text = "0";
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
    }
}
