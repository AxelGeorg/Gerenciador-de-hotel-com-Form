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
    public partial class UpdateEmployeeScreen : Form
    {
        EmployeeController controller = new EmployeeController();
        Employees employees = new Employees();
        HotelService service = new HotelService();

        public UpdateEmployeeScreen()
        {
            InitializeComponent();
            txtb_empAlterar.Focus();
            txtb_empAlterar.Select();

            listaComboBox();
            btn_alterar.Enabled = false;
            txtb_novoAlterar.Enabled = false;
            cbox_opcoes.Enabled = false;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;
            string cpfRetornado = service.preparaCPFparaBD(txtb_empAlterar.Text);

            listViewAlterar.Items.Clear();
            var emp = controller.retornaEmployees(0);

            for (int i = 0; i < emp.Count; i++)
            {
                if (cpfRetornado == emp[i].emp_cpf)
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

                if (!service.verificaIntOrFloat(employees.emp_cpf))
                {
                    verificaSeRetornou = 1;
                }

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

                    //verifica se ha um form ReadEmployeeScreen aberto, para desse modo após criar um novo funcionário já atualizar no outro form.
                    if (Application.OpenForms.OfType<ReadEmployeeScreen>().Count() > 0)
                    {
                        ReadEmployeeScreen form = Application.OpenForms["ReadEmployeeScreen"] as ReadEmployeeScreen;
                        form.listar(0);
                    }

                    limpaCampoForm();
                    MessageBox.Show("Funcionario alterado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                limpaCampoForm();
            }

            txtb_empAlterar.MaxLength = 14;
        }

        private void limpaCampoForm()
        {
            listViewAlterar.Items.Clear();
            btn_alterar.Enabled = false;
            txtb_novoAlterar.Text = "";
            txtb_novoAlterar.Enabled = false;
            cbox_opcoes.Enabled = false;
            cbox_opcoes.SelectedIndex = -1;
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

        //mascara cpf
        private void txtb_cpf(object sender, KeyPressEventArgs e)
        {
            char num;
            txtb_empAlterar.SelectionStart = txtb_empAlterar.Text.Length + 1;

            if (txtb_empAlterar.Text.Length == 3 || txtb_empAlterar.Text.Length == 7)
            {
                txtb_empAlterar.Text = txtb_empAlterar.Text + ".";
            }
            else if (txtb_empAlterar.Text.Length == 11)
            {
                txtb_empAlterar.Text = txtb_empAlterar.Text + "-";
            }
            txtb_empAlterar.SelectionStart = txtb_empAlterar.Text.Length + 1;

            if ((e.KeyChar == (char)Keys.Back) && (txtb_empAlterar.Text.Length > 0))
            {
                string s = txtb_empAlterar.Text.Substring(txtb_empAlterar.Text.Length - 1, 1);

                if (string.Equals(s, "-") || string.Equals(s, "."))
                {
                    num = txtb_empAlterar.Text[txtb_empAlterar.Text.Length - 2];

                    txtb_empAlterar.Text = txtb_empAlterar.Text.Remove(txtb_empAlterar.Text.Length - 1);

                    txtb_empAlterar.Text += num;
                    txtb_empAlterar.SelectionStart = txtb_empAlterar.Text.Length;

                    txtb_empAlterar.Text = txtb_empAlterar.Text.Remove(txtb_empAlterar.Text.Length - 1);
                    txtb_empAlterar.SelectionStart = txtb_empAlterar.Text.Length;
                }
                else if (txtb_empAlterar.Text.Length == 1)
                {
                    txtb_empAlterar.Text = txtb_empAlterar.Text.Remove(txtb_empAlterar.Text.Length - 1);
                    txtb_empAlterar.SelectionStart = txtb_empAlterar.Text.Length;
                }
                else if (service.verificaIntOrFloat(txtb_empAlterar.Text))
                {
                    num = txtb_empAlterar.Text[txtb_empAlterar.Text.Length - 2];

                    txtb_empAlterar.Text = txtb_empAlterar.Text.Remove(txtb_empAlterar.Text.Length - 1);

                    txtb_empAlterar.Text += num;
                    txtb_empAlterar.SelectionStart = txtb_empAlterar.Text.Length;
                }
            }
        }
    }
}
