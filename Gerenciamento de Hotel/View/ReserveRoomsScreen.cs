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
        List<Room> listRoom = new List<Room>();
        FiltroScreen tela;
        string filtroSQL = "select * from room where room_disponibilidade = true;";

        public int quantPessoas = 0;
        public int quantCamasCasal = 0;
        public int quantCamasSolteiro = 0;
        public float precoMin = 0;
        public float precoMax = 0;

        public ReserveRoomsScreen()
        {
            InitializeComponent();

            listaComboBox(filtroSQL);

            lbl_numeroQuartoA.Visible = false;
            lbl_quantCamasCasalA.Visible = false;
            lbl_camasSolteiroA.Visible = false;
            lbl_quantMaxPessoasA.Visible = false;
            lbl_precoDiariaA.Visible = false;
            lbl_precpTotalA.Visible = false;
        }

        public ReserveRoomsScreen(string sqlstring)
        {
            InitializeComponent();

            filtroSQL = sqlstring;

            listaComboBox(filtroSQL);

            lbl_numeroQuartoA.Visible = false;
            lbl_quantCamasCasalA.Visible = false;
            lbl_camasSolteiroA.Visible = false;
            lbl_quantMaxPessoasA.Visible = false;
            lbl_precoDiariaA.Visible = false;
            lbl_precpTotalA.Visible = false;
        }

        public ReserveRoomsScreen(string sqlstring, int quantPessoasGlobal, int quantCamasCasalGlobal, int quantCamasSolteiroGlobal, float precoMinGlobal, float precoMaxGlobal)
        {
            InitializeComponent();

            quantPessoas = quantPessoasGlobal;
            quantCamasCasal = quantCamasCasalGlobal;
            quantCamasSolteiro = quantCamasSolteiroGlobal;
            precoMin = precoMinGlobal;
            precoMax = precoMaxGlobal;
            filtroSQL = sqlstring;

            listaComboBox(filtroSQL);

            lbl_numeroQuartoA.Visible = false;
            lbl_quantCamasCasalA.Visible = false;
            lbl_camasSolteiroA.Visible = false;
            lbl_quantMaxPessoasA.Visible = false;
            lbl_precoDiariaA.Visible = false;
            lbl_precpTotalA.Visible = false;
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            tela = new FiltroScreen(this, quantPessoas, quantCamasCasal, quantCamasSolteiro, precoMin, precoMax);
            tela.Show();
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            GerenciadorStripScreen tela = new GerenciadorStripScreen();
            tela.Hide();
            tela.ShowDialog();
        }
        public void listaComboBox(string sql)
        {
            cbox_quarto.Items.Clear();
            listRoom = controllerRoom.retornaRoomComFiltro(sql);

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
            else if ((string.IsNullOrEmpty(txtb_quantDias.Text)) && (lbl_precpTotalA.Visible))
            {
                lbl_precpTotalA.Text = lbl_precoDiariaA.Text;
            }
        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;

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
