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
    public partial class UpdateEmployeeScreen : Form
    {
        EmployeeController controller = new EmployeeController();
        Employees employees = new Employees();
        EmployeeScreen tela = new EmployeeScreen();


        public UpdateEmployeeScreen()
        {
            InitializeComponent();

            listaComboBox();
            btn_alterar.Enabled = false;
            txtb_novoAlterar.Enabled = false;
            cbox_opcoes.Enabled = false;
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;

            listViewAlterar.Items.Clear();
            var emp = controller.retornaEmployees(0);

            for (int i = 0; i < emp.Count; i++)
            {
                if (txtb_empAlterar.Text.Trim() == emp[i].emp_cpf)
                {
                    ListViewItem itens = new ListViewItem(Convert.ToString(emp[i].emp_id));
                    itens.SubItems.Add(emp[i].emp_nome);
                    itens.SubItems.Add(emp[i].emp_sobrenome);
                    itens.SubItems.Add(emp[i].emp_cpf);
                    itens.SubItems.Add(emp[i].emp_titulo);
                    itens.SubItems.Add(emp[i].emp_email);
                    listViewAlterar.Items.Add(itens);

                    employees.emp_id = emp[i].emp_id;
                    employees.emp_nome = emp[i].emp_nome;
                    employees.emp_sobrenome = emp[i].emp_sobrenome;
                    employees.emp_cpf = emp[i].emp_cpf;
                    employees.emp_titulo = emp[i].emp_titulo;
                    employees.emp_email = emp[i].emp_email;
                    employees.emp_password = emp[i].emp_password;

                    txtb_novoAlterar.Enabled = true;
                    cbox_opcoes.Enabled = true;
                    verificaSeRetornou = 1;
                }
            }

            if (verificaSeRetornou == 0)
            {
                MessageBox.Show("Não foi possìvel encontrar nenhum funcionario com esse cpf!! \nDigite novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;

            if (cbox_opcoes.SelectedIndex == 0)
            {
                employees.emp_nome = txtb_novoAlterar.Text;
            }
            else if (cbox_opcoes.SelectedIndex == 1)
            {
                employees.emp_sobrenome = txtb_novoAlterar.Text;
            }
            else if (cbox_opcoes.SelectedIndex == 2)
            {
                employees.emp_cpf = txtb_novoAlterar.Text;

                var listEmp = controller.retornaEmployees(0);

                for (int i = 0; i < listEmp.Count; i++)
                {
                    if (employees.emp_cpf == listEmp[i].emp_cpf)
                    {
                        verificaSeRetornou = 1;
                    }
                }
            }
            else if (cbox_opcoes.SelectedIndex == 3)
            {
                employees.emp_titulo = txtb_novoAlterar.Text;
            }
            else if (cbox_opcoes.SelectedIndex == 4)
            {
                employees.emp_email = txtb_novoAlterar.Text;
            }
            else if (cbox_opcoes.SelectedIndex == 5)
            { 
                employees.emp_password = txtb_novoAlterar.Text;
            }

            if (verificaSeRetornou == 0)
            {
                if (MessageBox.Show("Deseja alterar esse funcionario?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    controller.alteraEmployee(employees);
                    MessageBox.Show("Funcionario alterado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    tela.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Não é possível alterar esse funcionário, pois já há um funcionário com esse CPF!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtb_novoAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_novoAlterar.Text)))
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        private void txtb_empAlterar_TextChanged(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtb_empAlterar.Text)))
            {
                listViewAlterar.Items.Clear();
                btn_alterar.Enabled = false;
                txtb_novoAlterar.Text = "";
                txtb_novoAlterar.Enabled = false;
                cbox_opcoes.Enabled = false;
            }
        }

        private void listaComboBox()
        {
            cbox_opcoes.Items.Add("Nome");
            cbox_opcoes.Items.Add("Sobrenome");
            cbox_opcoes.Items.Add("CPF");
            cbox_opcoes.Items.Add("Título");
            cbox_opcoes.Items.Add("Email");
            cbox_opcoes.Items.Add("Senha");
        }
    }
}
