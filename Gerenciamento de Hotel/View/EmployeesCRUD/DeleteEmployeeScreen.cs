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
    public partial class DeleteEmployeeScreen : Form
    {
        EmployeeController controller = new EmployeeController();
        Employees employees = new Employees();
        HotelService service = new HotelService();

        public DeleteEmployeeScreen()
        {
            InitializeComponent();
            btn_deletar.Enabled = false;
        }
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;
            string cpfDigitado = service.preparaCPFparaBD(txtb_empDeletar.Text);

            listViewDeletar.Items.Clear();
            var emp = controller.retornaEmployees(0);

            for (int i = 0; i < emp.Count; i++)
            {
                if (cpfDigitado == emp[i].emp_cpf)
                {
                    ListViewItem itens = new ListViewItem(Convert.ToString(emp[i].emp_id));
                    itens.SubItems.Add(emp[i].emp_nome);
                    itens.SubItems.Add(emp[i].emp_sobrenome);
                    itens.SubItems.Add(emp[i].emp_cpf);
                    itens.SubItems.Add(emp[i].emp_titulo);
                    itens.SubItems.Add(emp[i].emp_email);
                    listViewDeletar.Items.Add(itens);

                    employees.emp_id = emp[i].emp_id;
                    btn_deletar.Enabled = true;

                    verificaSeRetornou = 1;
                }
            }

            if (verificaSeRetornou == 0)
            {
                MessageBox.Show("Não foi possìvel encontrar nenhum funcionario com esse cpf!! \nDigite novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar esse funcionario?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                controller.deletaEmployee(employees.emp_id);

                //verifica se ha um form ReadEmployeeScreen aberto, para desse modo após criar um novo funcionário já atualizar no outro form.
                if (Application.OpenForms.OfType<ReadEmployeeScreen>().Count() > 0)
                {
                    ReadEmployeeScreen form = Application.OpenForms["ReadEmployeeScreen"] as ReadEmployeeScreen;
                    form.listar(0);
                }

                txtb_empDeletar.Text = "";
                MessageBox.Show("Funcionario deletado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtb_empDeletar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_empDeletar.Text))
            { 
                listViewDeletar.Items.Clear();
                btn_deletar.Enabled = false;
            }

            txtb_empDeletar.MaxLength = 14;
        }
        //mascara cpf
        private void txt_cpf(object sender, KeyPressEventArgs e)
        {
            char num;
            txtb_empDeletar.SelectionStart = txtb_empDeletar.Text.Length + 1;

            if (txtb_empDeletar.Text.Length == 3 || txtb_empDeletar.Text.Length == 7)
            {
                txtb_empDeletar.Text = txtb_empDeletar.Text + ".";
            }
            else if (txtb_empDeletar.Text.Length == 11)
            {
                txtb_empDeletar.Text = txtb_empDeletar.Text + "-";
            }
            txtb_empDeletar.SelectionStart = txtb_empDeletar.Text.Length + 1;

            if ((e.KeyChar == (char)Keys.Back) && (txtb_empDeletar.Text.Length > 0))
            {
                string s = txtb_empDeletar.Text.Substring(txtb_empDeletar.Text.Length - 1, 1);

                if (string.Equals(s, "-") || string.Equals(s, "."))
                {
                    num = txtb_empDeletar.Text[txtb_empDeletar.Text.Length - 2];

                    txtb_empDeletar.Text = txtb_empDeletar.Text.Remove(txtb_empDeletar.Text.Length - 1);

                    txtb_empDeletar.Text += num;
                    txtb_empDeletar.SelectionStart = txtb_empDeletar.Text.Length;

                    txtb_empDeletar.Text = txtb_empDeletar.Text.Remove(txtb_empDeletar.Text.Length - 1);
                    txtb_empDeletar.SelectionStart = txtb_empDeletar.Text.Length;
                }
                else if (txtb_empDeletar.Text.Length == 1)
                {
                    txtb_empDeletar.Text = txtb_empDeletar.Text.Remove(txtb_empDeletar.Text.Length - 1);
                    txtb_empDeletar.SelectionStart = txtb_empDeletar.Text.Length;
                }
                else if (service.verificaIntOrFloat(txtb_empDeletar.Text))
                {
                    num = txtb_empDeletar.Text[txtb_empDeletar.Text.Length - 2];

                    txtb_empDeletar.Text = txtb_empDeletar.Text.Remove(txtb_empDeletar.Text.Length - 1);

                    txtb_empDeletar.Text += num;
                    txtb_empDeletar.SelectionStart = txtb_empDeletar.Text.Length;
                }
            }
        }
    }
}
