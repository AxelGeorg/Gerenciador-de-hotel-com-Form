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
    public partial class DeleteEmployeeScreen : Form
    {
        EmployeeController controller = new EmployeeController();
        Employees employees = new Employees();
        GerenciadorStripScreen tela = new GerenciadorStripScreen();

        public DeleteEmployeeScreen()
        {
            InitializeComponent();
            btn_deletar.Enabled = false;
        }

        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int verificaSeRetornou = 0;

            listViewDeletar.Items.Clear();
            var emp = controller.retornaEmployees(0);

            for (int i = 0; i < emp.Count; i++)
            {
                if (txtb_empDeletar.Text.Trim() == emp[i].emp_cpf)
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
                MessageBox.Show("Funcionario deletado com sucesso!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                tela.ShowDialog();
            }
        }

        private void txtb_empDeletar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_empDeletar.Text))
            { 
                listViewDeletar.Items.Clear();
                btn_deletar.Enabled = false;
            }
        }
    }
}
