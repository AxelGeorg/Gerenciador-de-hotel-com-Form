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
    public partial class CreateEmployeeScreen : Form
    {
        EmployeeController controller = new EmployeeController();
        HotelService service = new HotelService();

        public CreateEmployeeScreen()
        {
            InitializeComponent();
            btn_cadastrar.Enabled = false;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            int verificaSeRetornou = 0;
            string cpfSemMascara = service.preparaCPFparaBD(txtb_cpf.Text);

            //valida se há outra empresa com msm nome
            var listEmp = controller.retornaEmployees(0);

            for (int i = 0; i < listEmp.Count; i++)
            {
                if ((cpfSemMascara == listEmp[i].emp_cpf) && (txtb_email.Text.Trim() == listEmp[i].emp_email))
                {
                    MessageBox.Show("Não é possível cadastrar essa funcionários, pois já há uma funcionário com esse CPF e com esse Email!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificaSeRetornou = 1;
                }
                else if (cpfSemMascara == listEmp[i].emp_cpf)
                {
                    MessageBox.Show("Não é possível cadastrar essa funcionários, pois já há uma funcionário com esse CPF!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificaSeRetornou = 1;
                }
                else if (txtb_email.Text.Trim() == listEmp[i].emp_email)
                {
                    MessageBox.Show("Não é possível cadastrar essa funcionários, pois já há uma funcionário com esse Email!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificaSeRetornou = 1;
                }else if (service.ValidaEnderecoEmail(txtb_email.Text.Trim()) == false)
                {
                    MessageBox.Show("Não é possível cadastrar essa funcionários, pois o email não é válido!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificaSeRetornou = 1;
                }
            }

            if (verificaSeRetornou == 0)
            {
                emp.emp_nome = txtb_nome.Text;
                emp.emp_sobrenome = txtb_sobrenome.Text;
                emp.emp_cpf = cpfSemMascara;
                emp.emp_titulo = txtb_titulo.Text;
                emp.emp_email = txtb_email.Text;
                emp.emp_password = txtb_senha.Text;

                if (MessageBox.Show("Deseja cadastrar esse Funcionário?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    controller.cradastraEmployees(emp);

                    txtb_nome.Clear();  
                    txtb_sobrenome.Clear();
                    txtb_cpf.Clear();
                    txtb_titulo.Clear();
                    txtb_email.Clear();
                    txtb_senha.Clear();

                    //verifica se ha um form ReadEmployeeScreen aberto, para desse modo após criar um novo funcionário já atualizar no outro form.
                    if (Application.OpenForms.OfType<ReadEmployeeScreen>().Count() > 0)
                    {
                        ReadEmployeeScreen form = Application.OpenForms["ReadEmployeeScreen"] as ReadEmployeeScreen;
                        form.listar(0);
                    }

                    MessageBox.Show("Funcionário cadastrado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtb_nome_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_sobrenome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_titulo.Text)) && (!string.IsNullOrWhiteSpace(txtb_email.Text)) && (!string.IsNullOrWhiteSpace(txtb_senha.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void txtb_sobrenome_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_sobrenome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_titulo.Text)) && (!string.IsNullOrWhiteSpace(txtb_email.Text)) && (!string.IsNullOrWhiteSpace(txtb_senha.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void txtb_cpf_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_sobrenome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_titulo.Text)) && (!string.IsNullOrWhiteSpace(txtb_email.Text)) && (!string.IsNullOrWhiteSpace(txtb_senha.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
            
            txtb_cpf.MaxLength = 14;
        }

        private void txtb_titulo_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_sobrenome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_titulo.Text)) && (!string.IsNullOrWhiteSpace(txtb_email.Text)) && (!string.IsNullOrWhiteSpace(txtb_senha.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void txtb_email_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_sobrenome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_titulo.Text)) && (!string.IsNullOrWhiteSpace(txtb_email.Text)) && (!string.IsNullOrWhiteSpace(txtb_senha.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }

            txtb_email.MaxLength = 30;
        }

        private void txtb_senha_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_sobrenome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_titulo.Text)) && (!string.IsNullOrWhiteSpace(txtb_email.Text)) && (!string.IsNullOrWhiteSpace(txtb_senha.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }

            txtb_senha.MaxLength = 15;
        }

        private void txt_cpf(object sender, KeyPressEventArgs e)
        {
            char num;
            txtb_cpf.SelectionStart = txtb_cpf.Text.Length + 1;

            if (txtb_cpf.Text.Length == 3 || txtb_cpf.Text.Length == 7)
            {
                txtb_cpf.Text = txtb_cpf.Text + ".";
            }
            else if (txtb_cpf.Text.Length == 11)
            {
                txtb_cpf.Text = txtb_cpf.Text + "-";
            }
            txtb_cpf.SelectionStart = txtb_cpf.Text.Length + 1;
            
            if ((e.KeyChar == (char)Keys.Back) && (txtb_cpf.Text.Length > 0))
            {
                string s = txtb_cpf.Text.Substring(txtb_cpf.Text.Length-1, 1);

                if (string.Equals(s, "-") || string.Equals(s, "."))
                {
                    num = txtb_cpf.Text[txtb_cpf.Text.Length - 2];

                    txtb_cpf.Text = txtb_cpf.Text.Remove(txtb_cpf.Text.Length - 1);

                    txtb_cpf.Text += num;
                    txtb_cpf.SelectionStart = txtb_cpf.Text.Length;

                    txtb_cpf.Text = txtb_cpf.Text.Remove(txtb_cpf.Text.Length - 1);
                    txtb_cpf.SelectionStart = txtb_cpf.Text.Length;
                }
                else if (txtb_cpf.Text.Length == 1)
                {
                    txtb_cpf.Text = txtb_cpf.Text.Remove(txtb_cpf.Text.Length - 1);
                    txtb_cpf.SelectionStart = txtb_cpf.Text.Length;
                }
                else if (service.verificaIntOrFloat(txtb_cpf.Text))
                {
                    num = txtb_cpf.Text[txtb_cpf.Text.Length - 2];

                    txtb_cpf.Text = txtb_cpf.Text.Remove(txtb_cpf.Text.Length - 1);

                    txtb_cpf.Text += num;
                    txtb_cpf.SelectionStart = txtb_cpf.Text.Length;
                }
            }
        }
    }
}
