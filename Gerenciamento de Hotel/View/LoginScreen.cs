using Gerenciamento_de_Hotel.Controller;
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
        employeeController controller = new employeeController();
        hotelService service = new hotelService();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var verifica = 0;

            if (string.IsNullOrWhiteSpace(txtb_email.Text) || string.IsNullOrWhiteSpace(txtb_password.Text)){
                MessageBox.Show("Os campos login e senha precisam ser preenchidos");
            }
            else
            {
                var listEmp = controller.retornaEmployees(0);

                for (int i = 0; i < listEmp.Count; i++)
                {
                    if ((txtb_email.Text.Trim() == listEmp[i].emp_email) && (txtb_password.Text.Trim() == listEmp[i].emp_password))
                    {
                        verifica = 1;
                        PanelScreen tela = new PanelScreen();
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
            MainScreen tela = new MainScreen();
            this.Hide();
            tela.ShowDialog(); 
        }

        private void btn_esqueceuSenha_Click(object sender, EventArgs e)
        {
            var listEmp = controller.retornaEmployees(0);
            var emp = new Employees();
            var resposta = "";
            var validaEmail = 0;

            if (!string.IsNullOrWhiteSpace(txtb_email.Text))
            {
                for (int i = 0; i < listEmp.Count; i++)
                {
                    if ((txtb_email.Text.Trim() == listEmp[i].emp_email) && (service.ValidaEnderecoEmail(txtb_email.Text.Trim()) == true))
                    {
                        validaEmail = 1;
                        emp = listEmp[i];
                    }
                }
            }
            
            if (validaEmail == 1)
            {
                try
                {/*
                    //cria uma mensagem
                    MailMessage mail = new MailMessage();
                    //define os endereços
                    mail.From = new MailAddress("axelgeorg16@gmail.com");
                    //mail.To.Add("macoratti@ig.com.br"); // se eu quiser mandar para outro email ao msm tmp

                    //define o conteúdo
                    mail.Subject = "Este é um simples ,muito simples email";
                    mail.Body = "Este é o corpo do email";
                    //envia a mensagem
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com",);
                    smtp.Send(mail);
                    */
                    
                    resposta = service.EnviaEmail(emp);

                    /* smtp.Send(mensagemEmail);*/


                    /*
                    using (SmtpClient client = new SmtpClient())
                    {
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential("axelgeorg16@gmail.com", "991602113xp");

                        // envia a mensagem
                        client.Send(mensagemEmail);
                    }*/


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
    }
}
