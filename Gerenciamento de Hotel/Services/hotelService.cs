using Gerenciamento_de_Hotel.Controller;
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
        public string EnviaEmail(string enderecoEmail, int posicao)
        {
            try
            {
                var listEmp = controller.retornaEmployees(0);

                //define a expressão regulara para validar o email
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

                return "Email enviado com sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
