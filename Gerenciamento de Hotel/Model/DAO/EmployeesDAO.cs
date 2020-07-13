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
        const string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;
        bool clickID = true;
        bool clickNome = true;
        bool clickSobrenome = true;
        bool clickCPF = true;
        bool clickTitulo = true;
        bool clickEmail = true;

        public List<Employees> BuscarFuncionarios(int tipoOrdenacao)
        {
            try
            {
                var listEmp = new List<Employees>();
                string query = "select emp_id,emp_nome,emp_sobrenome,emp_cpf,emp_titulo,emp_email,emp_password from employees";

                if (tipoOrdenacao == 0)
                {
                    if (clickID == true)
                    {
                        query  = query + " order by emp_id asc;";
                        clickID = false;
                    }
                    else
                    {
                        query = query + " order by emp_id desc;";
                        clickID = true;
                    }

                }

                if (tipoOrdenacao == 1)
                {
                    if (clickNome == true)
                    {
                        query = query + " order by emp_nome asc;";
                        clickNome = false;
                    }
                    else
                    {
                        query = query + " order by emp_nome desc;";
                        clickNome = true;
                    }
                    
                }

                if (tipoOrdenacao == 2)
                {
                    if (clickSobrenome == true)
                    {
                        query = query + " order by emp_sobrenome asc;";
                        clickSobrenome = false;
                    }
                    else
                    {
                        query = query + " order by emp_sobrenome desc;";
                        clickSobrenome = true;
                    }

                }

                if (tipoOrdenacao == 3)
                {
                    if (clickCPF == true)
                    {
                        query = query + " order by emp_cpf asc;";
                        clickCPF = false;
                    }
                    else
                    {
                        query = query + " order by emp_cpf desc;";
                        clickCPF = true;
                    }

                }

                if (tipoOrdenacao == 4)
                {
                    if (clickTitulo == true)
                    {
                        query = query + " order by emp_titulo asc;";
                        clickTitulo = false;
                    }
                    else
                    {
                        query = query + " order by emp_titulo desc;";
                        clickTitulo = true;
                    }

                }

                if (tipoOrdenacao == 5)
                {
                    if (clickEmail == true)
                    {
                        query = query + " order by emp_email asc;";
                        clickEmail = false;
                    }
                    else
                    {
                        query = query + " order by emp_email desc;";
                        clickEmail = true;
                    }
                }


                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand(query, connection))
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

        public bool alterarEmployee(int emp_id,string emp_nome, string emp_sobrenome, string emp_cpf, string emp_titulo, string emp_email, string emp_password)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "update employees set emp_nome = '" + emp_nome + "',emp_sobrenome = '" + emp_sobrenome + "',emp_cpf = '" + emp_cpf + "',emp_titulo = '" + emp_titulo + "',emp_email = '" + emp_email + "',emp_password = '" + emp_password + "' where emp_id = " + emp_id + ";";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletarEmployee(int emp_id)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "delete from employees where emp_id = " + emp_id + ";";

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
