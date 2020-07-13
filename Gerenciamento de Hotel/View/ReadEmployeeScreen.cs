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
    public partial class ReadEmployeeScreen : Form
    {
        EmployeeController controller = new EmployeeController();

        public ReadEmployeeScreen()
        {
            InitializeComponent();
            listar(0);
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            EmployeeScreen tela = new EmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }

        public void listar(int tipoOrdenacao)
        {
            listView_employees.Items.Clear();
            var emp = new List<Employees>();

            emp = controller.retornaEmployees(tipoOrdenacao);

            for (int i = 0; i < emp.Count; i++)
            {
                listView_employees.Items.Add(emp[i].emp_id.ToString());
                listView_employees.Items[i].SubItems.Add(emp[i].emp_nome);
                listView_employees.Items[i].SubItems.Add(emp[i].emp_sobrenome);
                listView_employees.Items[i].SubItems.Add(emp[i].emp_cpf);
                listView_employees.Items[i].SubItems.Add(emp[i].emp_titulo);
                listView_employees.Items[i].SubItems.Add(emp[i].emp_email);
            }
        }

        private void ordenar(object sender, ColumnClickEventArgs e)
        {
            listView_employees.Items.Clear();
            if (e.Column == 0)
            {
                listar(0);
            }
            else if(e.Column == 1){
                listar(1);
            }
            else if (e.Column == 2)
            {
                listar(2);
            }
            else if (e.Column == 3)
            {
                listar(3);
            }
            else if (e.Column == 4)
            {
                listar(4);
            }
            else if (e.Column == 5)
            {
                listar(5);
            }
        }
    }
}
