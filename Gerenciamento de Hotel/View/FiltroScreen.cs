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
        ReserveRoomsScreen reserveRoomsScreen = new ReserveRoomsScreen();


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
            preencherCampos();

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
            int verificaSeValidou = 0;
            filtroSQL = "select * from room where room_disponibilidade = true ";

            /* --------------------------Daniel Inicio----------------------*/

            if (txtb_precoMax.Text != "")
            {
                filtroSQL = filtroSQL + " and room_precoDiaria <= " + txtb_precoMax.Text;
                precoMaxGlobal = Convert.ToInt32(txtb_precoMax.Text);
            }

            if (txtb_precoMin.Text != "")
            {
                filtroSQL = filtroSQL + " and room_precoDiaria >= " + txtb_precoMin.Text;
            }

            if (txtb_quantCamaCasal.Text != "")
            {
                filtroSQL = filtroSQL + " and room_quantCasal >= " + txtb_quantCamaCasal.Text;
            }

            if (txtb_quantCamaSolteiro.Text != "")
            {
                filtroSQL = filtroSQL + " and room_quantSolteiro >= " + txtb_quantCamaSolteiro.Text;
            }

            if (txtb_quantPessoa.Text != "")
            {
                filtroSQL = filtroSQL + " and room_quantPessoa >= " + txtb_quantPessoa.Text;
            }

            /* ----------------------------Daniel Fim-----------------------*/
            //valida campos

            /*if ((!string.IsNullOrEmpty(txtb_precoMin.Text) && (service.verificaIntOrFloat(txtb_precoMin.Text))))
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

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("O filtro não foi salvo pois algum campo está incorreto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            filtroSQL = filtroSQL + ";";
            reserveRoomsScreen.sql = filtroSQL;
            preencheVariavel();//Preenche as variaveis da classe FiltroScreen a partir dos textBox
            reserveRoomsScreen.retornaDados(quantPessoasGlobal, quantCamasCasalGlobal, quantCamasSolteiroGlobal, precoMinGlobal, precoMaxGlobal);// Chama o método para preencher as variaveis da tela Reserve
            reserveRoomsScreen.listaComboBox(filtroSQL);//Chama o método para realizar o select
            this.Hide();// Fechar a tela FiltroScreen
        }

        private void preencheVariavel()
        {
            if (txtb_quantPessoa.Text != "")
            {
                quantPessoasGlobal = Convert.ToInt32(txtb_quantPessoa.Text);
            }

            if (txtb_quantCamaCasal.Text != "")
            {
                quantCamasCasalGlobal = Convert.ToInt32(txtb_quantCamaCasal.Text);
            }

            if (txtb_quantCamaSolteiro.Text != "")
            {
                quantCamasSolteiroGlobal = Convert.ToInt32(txtb_quantCamaSolteiro.Text);
            }

            if (txtb_precoMax.Text != "")
            {
                precoMaxGlobal = float.Parse(txtb_precoMax.Text);
            }

            if (txtb_precoMin.Text != "")
            {
                precoMinGlobal = float.Parse(txtb_precoMin.Text);
            }
        }

        public void retornaDados(int quantPessoas, int quantCamasCasal, int quantCamasSolteiro, float precoMin, float precoMax)
        {
            quantPessoasGlobal       = quantPessoas;
            quantCamasCasalGlobal    = quantCamasCasal;
            quantCamasSolteiroGlobal = quantCamasSolteiro;
            precoMinGlobal           = precoMin;
            precoMaxGlobal           = precoMax;
        }
    }
}
