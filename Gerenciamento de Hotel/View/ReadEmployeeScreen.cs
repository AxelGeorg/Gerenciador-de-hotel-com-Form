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
        employeeController controller = new employeeController();

        public ReadEmployeeScreen()
        {
            InitializeComponent();
            listar();
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            EmployeeScreen tela = new EmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }

        public void listar()
        {
            listView_employees.Items.Clear();
            var emp = new List<Employees>();

            emp = controller.retornaEmployees();

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
    }
}
