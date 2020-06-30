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
    public partial class EmployeeScreen : Form
    {
        public EmployeeScreen()
        {
            InitializeComponent();
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            PanelScreen tela = new PanelScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_cadastrarEmp_Click(object sender, EventArgs e)
        {
            CreateEmployeeScreen tela = new CreateEmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_listarEmp_Click(object sender, EventArgs e)
        {
            ReadEmployeeScreen tela = new ReadEmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
