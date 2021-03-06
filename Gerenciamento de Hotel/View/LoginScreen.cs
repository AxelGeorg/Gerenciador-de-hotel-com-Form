﻿using Gerenciamento_de_Hotel.Controller;
using Gerenciamento_de_Hotel.Model.DAO;
using Gerenciamento_de_Hotel.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Gerenciamento_de_Hotel.Services;
using Gerenciamento_de_Hotel.Model.Entidades;

namespace Gerenciamento_de_Hotel
{
    public partial class LoginScreen : Form
    {
        EmployeeController controller = new EmployeeController();
        HotelService service = new HotelService();

        public LoginScreen()
        {
            InitializeComponent();
            txtb_email.Focus();
            txtb_email.Select();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txtb_email.Text.Trim();
            string senha = txtb_password.Text.Trim();

            var verifica = 0;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha)){
                MessageBox.Show("Os campos login e senha precisam ser preenchidos");
            }
            else
            {
                var listEmp = controller.retornaEmployees(0);

                for (int i = 0; i < listEmp.Count; i++)
                {
                    if ((email == listEmp[i].emp_email) && (senha == listEmp[i].emp_password))
                    {
                        verifica = 1;
                        GerenciadorStripScreen tela = new GerenciadorStripScreen();
                        this.Hide();
                        tela.ShowDialog();
                    }
                }
                if (verifica == 0)
                {
                    MessageBox.Show("Email ou senha incorretos, digite novamente!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }  
        }
        private void btn_comeBack_Click(object sender, EventArgs e)
        {
            MenuStripScreen tela = new MenuStripScreen();
            this.Hide();
            tela.ShowDialog(); 
        }

        private void btn_esqueceuSenha_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var resposta = "";
            string assunto = "Recuperação da senha";
            string emailTexto = "";
            string remetente = "";
            var verificaSeValidouEmail = 0;
            var listEmp = controller.retornaEmployees(0);
            var emp = new Employees();

            if (!string.IsNullOrWhiteSpace(txtb_email.Text))
            {
                for (int i = 0; i < listEmp.Count; i++)
                {
                    if ((txtb_email.Text.Trim() == listEmp[i].emp_email) && (service.ValidaEnderecoEmail(txtb_email.Text.Trim()) == true))
                    {
                        verificaSeValidouEmail = 1;
                        remetente = txtb_email.Text.Trim();
                        emp = listEmp[i];
                    }
                }
            }
            this.Cursor = Cursors.Hand;

            if (verificaSeValidouEmail == 1)
            {
                try
                {
                    emailTexto = "Este email é automático, por favor não responda-o.\n \n Caro(a) " + emp.emp_nome + " " + emp.emp_sobrenome + " a senha referente ao seu email " + emp.emp_email + " é " + emp.emp_password + ".\n\n Atenciosamente Gerenciador de Hoteis.";

                    resposta = service.EnviaEmail(assunto, emailTexto, remetente);

                    MessageBox.Show(resposta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao enviar o email, verifique se o email realmente existe!\n" + resposta.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erro!\n\nEsse email não esta registrado, não é valido ou a caixa de texto email está vazia!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtb_email_TextChanged(object sender, EventArgs e)
        {
            txtb_email.MaxLength = 30;
        }

        private void txtb_password_TextChanged(object sender, EventArgs e)
        {
            txtb_password.MaxLength = 15;
        }
    }
}
