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
    public class HotelService
    {
        EmployeeController controller = new EmployeeController();

        public bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                string texto_Validar = enderecoEmail;

                //define a expressão regulara para validar o email
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

        /// <summary>
        /// Envia email.
        /// </summary>
        /// <param name="assuntoEmail"></param>
        /// <param name="corpoEmail"></param>
        /// <returns></returns>
        public string EnviaEmail(string assuntoEmail, string corpoEmail)
        {
            try
            {
                const string emailRemetente = "gerenciadorHotel@hotmail.com";
                //const string emailRemetente = "vilson.daniel@hotmail.com";
                const string nomeUsuario = "Gerenciador de Hotel";
                //const string senha = "hotel123";
                const string senha = "senha123";
                //const string senha = "qwerty.bnu123";
                const string servidorSMTP = "smtp.office365.com";
                const string mensagemRetorno = "Email enviado com sucesso!";
                string assunto = assuntoEmail;
                string emailTexto = corpoEmail;

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

        /// <summary>
        /// Serviço que verifica se a variável string passada como parametro pode ser considerada uma variável do tipo int ou float. 
        /// </summary>
        /// <param name="textInt"></param>
        /// <returns></returns>
        public bool verificaIntOrFloat(string textInt)
        {
            int verificaInt;
            float verificaFloat;

            if ((int.TryParse(textInt, out verificaInt)) || (float.TryParse(textInt, out verificaFloat)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Serviço que verifica se a variável string passada como parametro pode ser considerado um cpf. 
        /// </summary>
        /// <param name="textInt"></param>
        /// <returns></returns>
        public bool verificaCPF(string textCPF)
        {



            return true;
        }

        /// <summary>
        /// Serviço que tira pontos e traços cpf, arrumando-o se necessário. 
        /// </summary>
        /// <param name="textInt"></param>
        /// <returns></returns>
        public string preparaCPFparaBD(string textCPF)
        {
            string cpfCerto = textCPF.Replace(".", "");
            cpfCerto = cpfCerto.Replace("-", "");

            return cpfCerto;
        }
    }
}
