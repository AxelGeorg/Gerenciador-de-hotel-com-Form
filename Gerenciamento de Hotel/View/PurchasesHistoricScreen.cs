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
    public partial class PurchasesHistoricScreen : Form
    {
        Guest guest = new Guest();
        public PurchasesHistoricScreen(Guest guestRecebido)
        {
            InitializeComponent();
            guest = guestRecebido;
            listarHistorico();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listarHistorico()
        {
            listView_historico.Items.Clear();
            string nome="", preco="";
            int i = 0, contador = 0, inicio = 0, fim, contLinhas = 0;
           
            
            while (i <= guest.gue_historico.Length){
                if(string.Equals(guest.gue_historico[i], '/'))
                {
                    fim = i;
                    if (contador == 0)
                    {
                        nome = guest.gue_historico.Substring(inicio, fim - inicio);
                        inicio = fim + 1;
                        contador = 1;
                    }
                    else if (contador == 1)
                    {
                        preco = guest.gue_historico.Substring(inicio, fim - inicio);
                        inicio = fim + 1;
                        contador = 0;

                        listView_historico.Items.Add(nome);
                        listView_historico.Items[contLinhas].SubItems.Add(preco);
                        contLinhas += 1;
                    }
                }
                i += 1;
            }   
        }
    }
}
