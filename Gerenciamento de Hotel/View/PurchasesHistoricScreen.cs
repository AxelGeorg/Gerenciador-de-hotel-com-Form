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
            int i = 1, contador = 0, inicio = 0, fim, contLinhas = 0;

            if (!string.IsNullOrEmpty(guest.gue_historico))
            {
                while (i <= guest.gue_historico.Length - 1)
                {
                    if (string.Equals(guest.gue_historico[i], '/'))
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

                            ListViewItem item = new ListViewItem(nome);
                            item.SubItems.Add(preco);
                            listView_historico.Items.Add(item);
                        }
                    }
                    i += 1;
                }
            } 
        }
    }
}
