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
    public partial class ReserveRoomsScreen : Form
    {
        RoomController controllerRoom = new RoomController();
        GuestController controllerGuest = new GuestController();
        HotelService service = new HotelService();
        FiltroScreen telaFiltro = new FiltroScreen();
        string filtroSQL = "select * from room where room_disponibilidade = true;";
        List<Room> listRoom = new List<Room>();
        List<Guest> listGuest = new List<Guest>();
        

        public ReserveRoomsScreen()
        {
            InitializeComponent();
            listaComboBox();

            lbl_numeroQuartoA.Visible = false;
            lbl_quantCamasCasalA.Visible = false;
            lbl_camasSolteiroA.Visible = false;
            lbl_quantMaxPessoasA.Visible = false;
            lbl_precoDiariaA.Visible = false;
            lbl_precpTotalA.Visible = false;
        }

        //se não foi filtrado nada ou seja filtrosalvo == false, o select retorna os quartos disponiveis como retorno padrao

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            FiltroScreen tela = new FiltroScreen();
            tela.Show();
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            GerenciadorStripScreen tela = new GerenciadorStripScreen();
            tela.Hide();
            tela.ShowDialog();
        }
        private void listaComboBox()
        {
            //era pra pegar o filtrosql da tela filtro mas não estaaakkk
            if (!string.IsNullOrEmpty(telaFiltro.filtroSQL))
            {
                filtroSQL = telaFiltro.filtroSQL;
            }

            listRoom = controllerRoom.retornaRoomComFiltro(filtroSQL);

            for (int i = 0; i < listRoom.Count; i++)
            {
                cbox_quarto.Items.Add(listRoom[i].room_numeroQuarto);
            }
        }

        private void cbox_quarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listRoom.Count; i++)
            {
                if (cbox_quarto.SelectedIndex == i)
                {

                    lbl_numeroQuartoA.Text = listRoom[i].room_numeroQuarto;
                    lbl_quantCamasCasalA.Text = Convert.ToString(listRoom[i].room_quantCasal);
                    lbl_camasSolteiroA.Text = Convert.ToString(listRoom[i].room_quantSolteiro);
                    lbl_quantMaxPessoasA.Text = Convert.ToString(listRoom[i].room_quantPessoa);
                    lbl_precoDiariaA.Text = Convert.ToString(listRoom[i].room_precoDiaria);

                    lbl_numeroQuartoA.Visible = true;
                    lbl_quantCamasCasalA.Visible = true;
                    lbl_camasSolteiroA.Visible = true;
                    lbl_quantMaxPessoasA.Visible = true;
                    lbl_precoDiariaA.Visible = true;

                    if (!string.IsNullOrEmpty(txtb_quantDias.Text))
                    {
                        lbl_precpTotalA.Text = Convert.ToString(listRoom[i].room_precoDiaria * Convert.ToInt32(txtb_quantDias.Text));
                    }
                    else
                    {
                        lbl_precpTotalA.Text = Convert.ToString(listRoom[i].room_precoDiaria);
                    }
                    lbl_precpTotalA.Visible = true;
                }
            }
        }

        private void txtb_quantDias_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtb_quantDias.Text)) && (lbl_precpTotalA.Visible) && (service.verificaIntOrFloat(txtb_quantDias.Text)))
            {
                lbl_precpTotalA.Text = Convert.ToString(Convert.ToInt32(lbl_precoDiariaA.Text) * Convert.ToInt32(txtb_quantDias.Text));
            }
        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;

            //valida se as textbox estão preenchidas corretamente, ou seja,
            if ((!string.IsNullOrEmpty(txtb_quantDias.Text)) && (service.verificaIntOrFloat(txtb_quantDias.Text)) && (!string.IsNullOrEmpty(txtb_cpf.Text)))
            {
                var listGuest = controllerGuest.retornaGuest(0);

                for (int i = 0; i < listGuest.Count; i++)
                {
                    if (txtb_cpf.Text.Trim() == listGuest[i].gue_cpf)
                    {                       
                        verificaSeRetornou = 1;
                    }
                }

                if (verificaSeRetornou == 1)
                {
                    // add o preço total ao funcionário
                    // botar o quarto como ocupado
                    // add a fk do guest no room

                    //limpar todos os campos
                }
                else
                {
                    //dar opção para cadastra hóspede com esse cpf
                }
            }
        }
    }
}
