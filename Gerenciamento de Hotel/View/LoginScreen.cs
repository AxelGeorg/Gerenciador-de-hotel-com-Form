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

namespace Gerenciamento_de_Hotel
{
    public partial class LoginScreen : Form
    {
        employeeController controller = new employeeController();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var verifica = 0;

            if (String.Equals(txtb_email.Text, "") || String.Equals(txtb_password.Text,"")){
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
            int validaEmail = 0;
            int posicao = 0;


            var listEmp = controller.retornaEmployees(0);

            for (int i = 0; i < listEmp.Count; i++)
            {
                if ((txtb_email.Text.Trim() == listEmp[i].emp_email) && (ValidaEnderecoEmail(txtb_email.Text.Trim()) == true))
                {
                    validaEmail = 1;
                    posicao = i;

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


                    // cria uma mensagem - MailMessage(Remetente, Destinatario, Assunto, enviaMensagem);
                    MailMessage mensagemEmail = new MailMessage("vilson.daniel@hotmail.com", "vilson.daniel17@gmail.com", "testeAssunto", "testeCorpo");
                    mensagemEmail.To.Add(new MailAddress("vilson.daniel@hotmail.com"));//remetente
                    mensagemEmail.From = new MailAddress("gerenciadorHotel@hotmail.com");//Destinatario
                    mensagemEmail.Subject = "Recuperação da senha";
                    mensagemEmail.Body = "Este email é automático, por favor não responda-o\n \n Caro(a) " + listEmp[posicao].emp_nome + " " + listEmp[posicao].emp_sobrenome + " a senha referente ao seu email " + listEmp[posicao].emp_email + " é: " + listEmp[posicao].emp_password + ".\n\n Atenciosamente Gerenciador de Hoteis.";

                    SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                    using (smtp)
                    {
                        smtp.Credentials = new NetworkCredential("gerenciadorHotel@hotmail.com", "hotel123");//email e senha do remetente
                        smtp.EnableSsl = true;
                        smtp.Send(mensagemEmail);
                    }
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


                     MessageBox.Show("Email enviado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar o email, verifique se o email realmente existe!\n" + ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Esse email não esta registrado ou não é valido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                //define a expressão regulara para validar o email
                string texto_Validar = enderecoEmail;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                // testa o email com a expressão
                if (expressaoRegex.IsMatch(texto_Validar))
                {
                    // o email é valido
                    return true;
                }
                else
                {
                    // o email é inválido
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
