using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Gerenciamento_de_Hotel.Model.DAO
{
    class EmployeesDAO
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;

        

        //FbCommand cmd;
        //FbDataAdapter dataAdapter;


        public bool ValidateUser(String email, String senha)
        {
            try
            {
                //Passa a string de conexao  root@127.0.0.1:3306      jdbc:mysql://127.0.0.1:3306/?user=root
                connection = new MySqlConnection(conexaoString);
                
                connection.Open(); // abre a conexão
               
                command = new MySqlCommand("select emp_email, emp_password from Employees;", connection);
                command.CommandType = CommandType.Text;

                //Atribui os dados coletados para o dr
                MySqlDataReader dr = command.ExecuteReader();
                dr.Read();

                int d = 0;
                bool valida = false;


                while(d <= 2)
                {
                    if (String.Equals(email, dr.GetString(0)) && (String.Equals(senha, dr.GetString(1)))){
                        valida = true;
                        break;
                    }
                    else
                    {
                        valida = false;
                    }
                    //dr.NextResultAsync();
                    dr.NextResult();
                    d += 1;
                }


                command.Connection.Close(); 

                return valida;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
