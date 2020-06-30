using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using Gerenciamento_de_Hotel.Model.Entidades;

namespace Gerenciamento_de_Hotel.Model.DAO
{
    class EmployeesDAO
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;

        public bool ValidateUser(String email, String senha)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                
                connection.Open(); // abre a conexão
               
                command = new MySqlCommand("select emp_email, emp_password from employees;", connection);
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

        public List<Employees> BuscarFuncionarios()
        {
            try
            {
                var listEmp = new List<Employees>();
                //int qntd = qntdBanco();

                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand("select emp_id,emp_nome,emp_sobrenome,emp_cpf,emp_titulo,emp_email,emp_password from employees;", connection))
                    {
                        connection.Open(); // abre a conexão
                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Employees emp = new Employees();
                                emp.emp_id = Convert.ToInt32(dataReader["emp_id"].ToString());
                                emp.emp_nome = dataReader["emp_nome"].ToString();
                                emp.emp_sobrenome = dataReader["emp_sobrenome"].ToString();
                                emp.emp_cpf = dataReader["emp_cpf"].ToString();
                                emp.emp_titulo = dataReader["emp_titulo"].ToString();
                                emp.emp_email = dataReader["emp_email"].ToString();
                                emp.emp_password = dataReader["emp_password"].ToString();
                                listEmp.Add(emp);
                            }
                        }
                        return listEmp;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar a lista de funcionarios" + ex.Message);
            }
        }

        public bool cadastrarEmployee(string emp_nome, string emp_sobrenome, string emp_cpf, string emp_titulo, string emp_email, string emp_password)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into employees (emp_nome,emp_sobrenome,emp_cpf,emp_titulo,emp_email,emp_password) values ('" + emp_nome + "','" + emp_sobrenome + "','" + emp_cpf + "','" + emp_titulo + "','" + emp_email + "','" + emp_password + "');";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
