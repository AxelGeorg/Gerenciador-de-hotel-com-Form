using Gerenciamento_de_Hotel.Model.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Model.DAO
{
    public class GuestDAO
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;
        bool clickID = true;
        bool clickNome = true;
        bool clickCPF = true;
        bool clickDataNascimento = true;

        public List<Guest> BuscarFuncionarios(int tipoOrdenacao)
        {
            try
            {
                var listGuest = new List<Guest>();
                string query = "select gue_id,gue_nome,gue_cpf,gue_dataNascimento from guest";

                if (tipoOrdenacao == 0)
                {
                    if (clickID == true)
                    {
                        query = query + " order by gue_id asc;";
                        clickID = false;
                    }
                    else
                    {
                        query = query + " order by gue_id desc;";
                        clickID = true;
                    }

                }

                if (tipoOrdenacao == 1)
                {
                    if (clickNome == true)
                    {
                        query = query + " order by gue_nome asc;";
                        clickNome = false;
                    }
                    else
                    {
                        query = query + " order by gue_nome desc;";
                        clickNome = true;
                    }

                }

                if (tipoOrdenacao == 2)
                {
                    if (clickCPF == true)
                    {
                        query = query + " order by gue_cpf asc;";
                        clickCPF = false;
                    }
                    else
                    {
                        query = query + " order by gue_cpf desc;";
                        clickCPF = true;
                    }

                }

                if (tipoOrdenacao == 3)
                {
                    if (clickDataNascimento == true)
                    {
                        query = query + " order by gue_dataNascimento asc;";
                        clickDataNascimento = false;
                    }
                    else
                    {
                        query = query + " order by gue_dataNascimento desc;";
                        clickDataNascimento = true;
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
                                Guest guest = new Guest();
                                guest.gue_id = Convert.ToInt32(dataReader["gue_id"].ToString());
                                guest.gue_nome = dataReader["gue_nome"].ToString();
                                guest.gue_cpf = dataReader["gue_cpf"].ToString();
                                guest.gue_dataNascimento = dataReader["gue_dataNascimento"].ToString();
                                listGuest.Add(guest);
                            }
                        }
                        return listGuest;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar a lista de funcionarios" + ex.Message);
            }
        }










        public bool cadastrarGuest(Guest guest)
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "insert into guest (gue_nome, gue_cpf, gue_dataNascimento, gue_diasReservado, gue_precoTotal) values ('"+ guest.gue_nome + "', '" + guest.gue_cpf + "', '" + guest.gue_dataNascimento + "', " + guest.gue_diasReservados + ", " + guest.gue_precoTotal + ");";
            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
            return true;
        }

        public bool deletarGuest(int id)
        {
            return true;
        }


    }
}
