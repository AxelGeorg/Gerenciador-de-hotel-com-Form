﻿using Gerenciamento_de_Hotel.Controller;
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
    public partial class CreateGuestScreen : Form
    {
        GuestController controller = new GuestController();
        HotelService service = new HotelService();

        public CreateGuestScreen()
        {
            InitializeComponent();
            btn_cadastrar.Enabled = false;
            txtb_nome.Focus();
            txtb_nome.Select();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            string dataNascimento;
            int verificaSeRetornou = 0;
            string cpfParaCadastrar = service.preparaCPFparaBD(txtb_cpf.Text);

            var listGuest = controller.retornaGuest(0);

            for (int i = 0; i < listGuest.Count; i++)
            {
                if (cpfParaCadastrar == listGuest[i].gue_cpf)
                {
                    MessageBox.Show("Não é possível cadastrar esse hóspede, pois já há uma hóspede com esse CPF!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificaSeRetornou = 1;
                }
                else if ((!service.verificaIntOrFloat(txtb_dia.Text.Trim())) || (!service.verificaIntOrFloat(txtb_mes.Text.Trim())) || (!service.verificaIntOrFloat(txtb_ano.Text.Trim())))
                {
                    MessageBox.Show("Não é possível cadastrar esse hóspede, pois a sua data de nascimento não está no formato correto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificaSeRetornou = 1;
                }
            }

            if (verificaSeRetornou == 0)
            {
                dataNascimento = txtb_ano.Text + "/" + txtb_mes.Text + "/" + txtb_dia.Text;
                guest.gue_nome = txtb_nome.Text;
                guest.gue_cpf = cpfParaCadastrar;
                guest.gue_dataNascimento = dataNascimento;

                if (MessageBox.Show("Deseja cadastrar esse Hóspede?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (controller.cadastrarGuest(guest))
                    {
                        txtb_nome.Clear();
                        txtb_cpf.Clear();
                        txtb_dia.Clear();
                        txtb_mes.Clear();
                        txtb_ano.Clear();

                        if (Application.OpenForms.OfType<ReadGuestScreen>().Count() > 0)
                        {
                            ReadGuestScreen form = Application.OpenForms["ReadGuestScreen"] as ReadGuestScreen;
                            form.listar(0);
                        }

                        MessageBox.Show("Hóspede cadastrado com sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o hóspede!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtb_nome_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_dia.Text)) && (!string.IsNullOrWhiteSpace(txtb_mes.Text)) && (!string.IsNullOrWhiteSpace(txtb_ano.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
            txtb_nome.MaxLength = 30;
        }

        private void txtb_cpf_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_dia.Text)) && (!string.IsNullOrWhiteSpace(txtb_mes.Text)) && (!string.IsNullOrWhiteSpace(txtb_ano.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
            txtb_cpf.MaxLength = 14;
        }

        private void txtb_dia_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_dia.Text)) && (!string.IsNullOrWhiteSpace(txtb_mes.Text)) && (!string.IsNullOrWhiteSpace(txtb_ano.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
            txtb_dia.MaxLength = 2;
        }

        private void txtb_mes_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_dia.Text)) && (!string.IsNullOrWhiteSpace(txtb_mes.Text)) && (!string.IsNullOrWhiteSpace(txtb_ano.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
            txtb_mes.MaxLength = 2;
        }

        private void txtb_ano_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtb_nome.Text)) && (!string.IsNullOrWhiteSpace(txtb_cpf.Text)) && (!string.IsNullOrWhiteSpace(txtb_dia.Text)) && (!string.IsNullOrWhiteSpace(txtb_mes.Text)) && (!string.IsNullOrWhiteSpace(txtb_ano.Text)))
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
            txtb_ano.MaxLength = 4;
        }
          
        private void mascara_cpf(object sender, KeyPressEventArgs e)
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
                string s = txtb_cpf.Text.Substring(txtb_cpf.Text.Length - 1, 1);

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
