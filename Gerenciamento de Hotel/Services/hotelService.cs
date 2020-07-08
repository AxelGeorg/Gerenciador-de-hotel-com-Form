using Gerenciamento_de_Hotel.Controller;
using Gerenciamento_de_Hotel.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Services
{
    public class hotelService
    {
        employeeController controller = new employeeController();

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
        public string EnviaEmail(Employees emp)
        {
            try
            {
                const string emailRemetente = "gerenciadorHotel@hotmail.com";
                const string nomeUsuario = "Gerenciador de Hotel";
                //const string senha = "hotel123";
                const string senha = "senha123";
                const string servidorSMTP = "smtp.office365.com";
                const string assunto = "Recuperação da senha";
                const string mensagemRetorno = "Email enviado com sucesso!";
                string emailTexto = "Este email é automático, por favor não responda-o\n \n Caro(a) " + emp.emp_nome + " " + emp.emp_sobrenome + " a senha referente ao seu email " + emp.emp_email + " é: " + emp.emp_password + ".\n\n Atenciosamente Gerenciador de Hoteis.";

                using (SmtpClient smtpClient = new SmtpClient()
                {
                    Host = servidorSMTP,
                    Port = 587, 
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailRemetente, senha)
                })
                {
                    //cria uma mensagem - MailMessage(Remetente, Destinatario, Assunto, enviaMensagem);
                    MailMessage mensagemEmail = new MailMessage();
                    mensagemEmail.From = new MailAddress(emailRemetente, nomeUsuario, Encoding.UTF8);
                    mensagemEmail.To.Add(new MailAddress("vilson.daniel@hotmail.com"));
                    //mensagemEmail.To.Add(new MailAddress(emp.emp_email));
                    mensagemEmail.Bcc.Add("axelgeorg16@gmail.com");
                    mensagemEmail.Subject = assunto;
                    mensagemEmail.Body = emailTexto;
                    mensagemEmail.BodyEncoding = Encoding.UTF8;
                    mensagemEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
                    mensagemEmail.Priority = MailPriority.High;

                    smtpClient.Send(mensagemEmail);
                }

                return mensagemRetorno;
            }
            catch (SmtpFailedRecipientException ex)
            {
                return  "Mensagem : {0} " + ex.Message;
            }
            catch (SmtpException ex)
            {
                return "Mensagem SMPT Fail : {0} " + ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
