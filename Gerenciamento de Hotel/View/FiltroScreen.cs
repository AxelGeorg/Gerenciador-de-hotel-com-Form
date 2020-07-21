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
    public partial class FiltroScreen : Form
    {
        Filtro filtro = new Filtro();
        HotelService service = new HotelService();
        RoomController controller = new RoomController();

        ReserveRoomsScreen telaReserve = new ReserveRoomsScreen();

        public int quantPessoasGlobal = 0;
        public int quantCamasCasalGlobal = 0;
        public int quantCamasSolteiroGlobal = 0;
        public float precoMinGlobal = 0;
        public float precoMaxGlobal = 0;
        public bool salvou;

        public string filtroSQL;

        public FiltroScreen()
        {
            InitializeComponent();
            preencherCampos();
        } 

        public FiltroScreen(ReserveRoomsScreen formReserve, int quantPessoas, int quantCamasCasal, int quantCamasSolteiro, float precoMin, float precoMax)
        {
            InitializeComponent();

            quantPessoasGlobal = quantPessoas;
            quantCamasCasalGlobal = quantCamasCasal;
            quantCamasSolteiroGlobal = quantCamasSolteiro;
            precoMinGlobal = precoMin;
            precoMaxGlobal = precoMax;
            btn_removerFiltro.Enabled = false;

            if ((quantPessoasGlobal != 0) || (quantCamasCasalGlobal != 0) || (quantCamasSolteiroGlobal != 0) || (precoMinGlobal != 0) || (precoMaxGlobal != 0))
            {
                btn_removerFiltro.Enabled = true;
            }

            telaReserve = formReserve;
            preencherCampos();
        } 

        private void preencherCampos()
        {
            if (quantPessoasGlobal != 0)
            {
                txtb_quantPessoa.Text = Convert.ToString(quantPessoasGlobal);
            }

            if (quantCamasCasalGlobal != 0)
            {
                txtb_quantCamaCasal.Text = Convert.ToString(quantCamasCasalGlobal);
            }

            if (quantCamasSolteiroGlobal != 0)
            {
                txtb_quantCamaSolteiro.Text = Convert.ToString(quantCamasSolteiroGlobal);
            }

            if (precoMinGlobal != 0)
            {
                txtb_precoMin.Text = Convert.ToString(precoMinGlobal);
            }

            if (precoMaxGlobal != 0)
            {
                txtb_precoMax.Text = Convert.ToString(precoMaxGlobal);
            }
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //salva filtro
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            filtroSQL = "select * from room where room_disponibilidade = true";

            if ((!string.IsNullOrEmpty(txtb_precoMax.Text) && (service.verificaIntOrFloat(txtb_precoMax.Text))))
            {
                filtroSQL = filtroSQL + " and room_precoDiaria <= " + txtb_precoMax.Text;
                precoMaxGlobal = float.Parse(txtb_precoMax.Text);
            }

            if ((!string.IsNullOrEmpty(txtb_precoMin.Text) && (service.verificaIntOrFloat(txtb_precoMin.Text))))
            {
                precoMinGlobal = float.Parse(txtb_precoMin.Text);
                filtroSQL = filtroSQL + " and room_precoDiaria >= " + txtb_precoMin.Text;
            }

            if ((!string.IsNullOrEmpty(txtb_quantCamaCasal.Text) && (!service.verificaIntOrFloat(txtb_quantCamaCasal.Text))))
            {
                quantCamasCasalGlobal = Convert.ToInt32(txtb_quantCamaCasal.Text);
                filtroSQL = filtroSQL + " and room_quantCasal >= " + txtb_quantCamaCasal.Text;
            }

            if ((!string.IsNullOrEmpty(txtb_quantCamaSolteiro.Text) && (service.verificaIntOrFloat(txtb_quantCamaSolteiro.Text))))
            {
                quantCamasSolteiroGlobal = Convert.ToInt32(txtb_quantCamaSolteiro.Text);
                filtroSQL = filtroSQL + " and room_quantSolteiro >= " + txtb_quantCamaSolteiro.Text;
            }

            if ((!string.IsNullOrEmpty(txtb_quantPessoa.Text) && (service.verificaIntOrFloat(txtb_quantPessoa.Text))))
            {
                quantPessoasGlobal = Convert.ToInt32(txtb_quantPessoa.Text);
                filtroSQL = filtroSQL + " and room_quantPessoa >= " + txtb_quantPessoa.Text;
            }
            
            //ve se o retorno é possivel ou não
            var listRoom = controller.retornaRoomComFiltro(filtroSQL);
            if (listRoom.Count == 0)
            {
                MessageBox.Show("O filtro não foi salvo pois algum campo está incorreto ou o filtro não retornou nada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                filtroSQL = filtroSQL + ";";
                MessageBox.Show("Filtro salvo com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                telaReserve.Hide();
                ReserveRoomsScreen reserveRoomsScreen = new ReserveRoomsScreen(filtroSQL, quantPessoasGlobal, quantCamasCasalGlobal, quantCamasSolteiroGlobal, precoMinGlobal, precoMaxGlobal);
                reserveRoomsScreen.Show();
            }
        }

        private void btn_removerFiltro_Click(object sender, EventArgs e)
        {
            string sqlPadrao = "select * from room where room_disponibilidade = true;";

            MessageBox.Show("Filtro removido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            telaReserve.Hide();
            ReserveRoomsScreen reserveRoomsScreen = new ReserveRoomsScreen(sqlPadrao);
            reserveRoomsScreen.Show();
        }
    }
}
