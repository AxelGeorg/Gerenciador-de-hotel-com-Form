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


        public int quantPessoasGlobal;
        public int quantCamasCasalGlobal;
        public int quantCamasSolteiroGlobal;
        public float precoMinGlobal;
        public float precoMaxGlobal;
        public bool salvou;

        public string filtroSQL;

        public FiltroScreen()
        {
            InitializeComponent();

            //talvez funcione
            if (salvou == true)
            {
                txtb_quantPessoa.Text = Convert.ToString(quantPessoasGlobal);
                txtb_quantCamaCasal.Text = Convert.ToString(quantCamasCasalGlobal);
                txtb_quantCamaSolteiro.Text = Convert.ToString(quantCamasSolteiroGlobal);
                txtb_precoMin.Text = Convert.ToString(precoMinGlobal);
                txtb_precoMax.Text = Convert.ToString(precoMaxGlobal);
            }
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            ReserveRoomsScreen tela = new ReserveRoomsScreen();
            tela.Hide();
            tela.ShowDialog();
        }

        //salva filtro
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            int verificaSeValidou = 0;
            filtroSQL = "select * from room where room_disponibilidade = true ";
            //valida campos

            if ((!string.IsNullOrEmpty(txtb_precoMin.Text) && (service.verificaIntOrFloat(txtb_precoMin.Text))))
            {
                filtro.precoMin = float.Parse(txtb_precoMin.Text);
                filtroSQL = filtroSQL + " and room_precoDiaria >= " + filtro.precoMin + "";
            }
            else if ((!string.IsNullOrEmpty(txtb_precoMin.Text) && (!service.verificaIntOrFloat(txtb_precoMin.Text))))
            {
                verificaSeValidou = 1;
            }
            if ((!string.IsNullOrEmpty(txtb_precoMax.Text) && (service.verificaIntOrFloat(txtb_precoMax.Text))))
            {
                filtro.precoMax = float.Parse(txtb_precoMax.Text);
                filtroSQL = filtroSQL + " and room_precoDiaria <= " + filtro.precoMax + "";
            }
            else if ((!string.IsNullOrEmpty(txtb_precoMax.Text) && (!service.verificaIntOrFloat(txtb_precoMax.Text))))
            {
                verificaSeValidou = 1;
            }
            if ((!string.IsNullOrEmpty(txtb_quantCamaSolteiro.Text) && (service.verificaIntOrFloat(txtb_quantCamaSolteiro.Text))))
            {
                filtro.quantCamaSolteiro = Convert.ToInt32(txtb_quantCamaSolteiro.Text);
                filtroSQL = filtroSQL + " and room_quantSolteiro >= " + filtro.quantCamaSolteiro + "";
            }
            else if ((!string.IsNullOrEmpty(txtb_quantCamaSolteiro.Text) && (!service.verificaIntOrFloat(txtb_quantCamaSolteiro.Text))))
            {
                verificaSeValidou = 1;
            }
            if ((!string.IsNullOrEmpty(txtb_quantCamaCasal.Text) && (service.verificaIntOrFloat(txtb_quantCamaCasal.Text))))
            {
                filtro.quantCamaCasal = Convert.ToInt32(txtb_quantCamaCasal.Text);
                filtroSQL = filtroSQL + " and room_quantCasal >= " + filtro.quantCamaCasal + "";
            }
            else if ((!string.IsNullOrEmpty(txtb_quantCamaCasal.Text) && (!service.verificaIntOrFloat(txtb_quantCamaCasal.Text))))
            {
                verificaSeValidou = 1;
            }
            if ((!string.IsNullOrEmpty(txtb_quantPessoa.Text) && (service.verificaIntOrFloat(txtb_quantPessoa.Text))))
            {
                filtro.quantPessoas = Convert.ToInt32(txtb_quantPessoa.Text);
                filtroSQL = filtroSQL + " and room_quantPessoa >= " + filtro.quantPessoas + "";
            }
            else if ((!string.IsNullOrEmpty(txtb_quantPessoa.Text) && (!service.verificaIntOrFloat(txtb_quantPessoa.Text))))
            {
                verificaSeValidou = 1;
            }

            filtroSQL = filtroSQL + ";";

            //valida se retorna corretamente
            var listRoom = controller.retornaRoomComFiltro(filtroSQL);
            if (listRoom.Count==0)
            {
                verificaSeValidou = 1;
            }

            if (verificaSeValidou == 0)
            {
                if (MessageBox.Show("Deseja salvar esse filtro?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    filtro.filtrosql = filtroSQL;
                    filtro.filtroSalvo = true;
                    MessageBox.Show("Filtro salvo com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //salva os valores nas variaveis globais

                    quantPessoasGlobal = filtro.quantPessoas;
                    quantCamasCasalGlobal = filtro.quantCamaCasal;
                    quantCamasSolteiroGlobal = filtro.quantCamaSolteiro;
                    precoMinGlobal = filtro.precoMin;
                    precoMaxGlobal = filtro.precoMax;
                    salvou = true;

                    ReserveRoomsScreen tela = new ReserveRoomsScreen();
                    tela.Hide();
                    tela.Show();
                }
            }
            else
            {
                MessageBox.Show("O filtro não foi salvo pois algum campo está incorreto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
