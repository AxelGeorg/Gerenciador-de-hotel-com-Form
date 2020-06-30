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
    public partial class CreateEmployeeScreen : Form
    {
        employeeController controller = new employeeController();

        public CreateEmployeeScreen()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            int verificaSeRetornou = 0;

            //valida se há outra empresa com msm nome
            var listEmp = controller.retornaEmployees();

            for (int i = 0; i < listEmp.Count; i++)
            {
                if (txtb_cpf.Text.Trim() == listEmp[i].emp_cpf)
                {
                    verificaSeRetornou = 1;
                    MessageBox.Show("Não é possível cadastrar essa funcionários, pois já há uma funcionário com esse nome!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (verificaSeRetornou == 0)
            {
                emp.emp_nome = txtb_nome.Text;
                emp.emp_sobrenome = txtb_sobrenome.Text;
                emp.emp_cpf = txtb_cpf.Text;
                emp.emp_titulo = txtb_titulo.Text;
                emp.emp_email = txtb_email.Text;
                emp.emp_password = txtb_senha.Text;

                if (MessageBox.Show("Deseja cadastrar esse Funcionário?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    controller.cradastraEmployees(emp);

                    MessageBox.Show("Funcionário cadastrado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //this.Hide();
                    //tela.ShowDialog();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EmployeeScreen tela = new EmployeeScreen();
            this.Hide();
            tela.ShowDialog();
        }
    }
}
