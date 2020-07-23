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

        /// <summary>
        /// Retorna uma lista de funcionários de acordo com a ordenação desejada.
        /// </summary>
        /// <param name="tipoOrdenacao"></param>
        /// <returns></returns>
        public List<Guest> BuscarGuest(int tipoOrdenacao)
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
                                guest.gue_dataNascimento = dataReader["gue_dataNascimento"].ToString().Remove(dataReader["gue_dataNascimento"].ToString().Length - 8);
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

        public Guest retornaGuestCPF(string cpf)
        {
            Guest guest = new Guest();
            try
            {
                string query = "select gue_id, gue_cpf, gue_nome, gue_precoTotal, gue_fk_room from guest where gue_cpf = '" + cpf + "';";
                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand(query, connection))
                    {
                        connection.Open(); // abre a conexão
                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                guest.gue_id = Convert.ToInt32(dataReader["gue_id"].ToString());
                                guest.gue_nome = dataReader["gue_nome"].ToString();
                                guest.gue_fk_room = Convert.ToInt32(dataReader["gue_fk_room"].ToString());
                                guest.gue_precoTotal = float.Parse(dataReader["gue_precoTotal"].ToString());
                                guest.gue_cpf = dataReader["gue_cpf"].ToString();
                                
                            }
                        }

                    }
                }
                return guest;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar o hóspede através do CPF" + ex.Message);
            }
        }

        /// <summary>
        /// Cadastra o hóspede desejado.
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Altera o hóspede desejado.
        /// </summary>
        /// <param name="guest"></param>
        /// <param name="tipoSelect"></param>
        /// <returns></returns>
        public bool alterarGuest(Guest guest, int tipoSelect)
        {
            try
            {
                string query = "update guest set gue_nome = '" + guest.gue_nome + "',gue_cpf = '" + guest.gue_cpf + "'";

                if(tipoSelect == 1)
                    query = query + ",gue_dataNascimento = '" + guest.gue_dataNascimento + "'";

                query = query + " where gue_id = " + guest.gue_id + ";";

                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = query;

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Altera o hóspede desejado após a reserva do quarto.
        /// </summary>
        /// <param name="guest"></param>
        /// <param name="tipoSelect"></param>
        /// <returns></returns>
        public bool alterarGuestReserva(Guest guest)
        {
            try
            {
                string query = "update guest set gue_diasReservado = "+guest.gue_diasReservados+ ", gue_precoTotal = "+guest.gue_precoTotal+ ", gue_fk_room = "+guest.gue_fk_room+" where gue_id = " + guest.gue_id + ";";

                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = query;

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool alterarGuestCheckOut(int id)
        {
            try
            {
                string query = "update guest set gue_fk_room = null, gue_precoTotal = 0, gue_diasReservado = 0 where gue_id = " + id + "; ";

                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = query;

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        /// <summary>
        ///  Deleta o hóspede desejado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool deletarGuest(int id)
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "delete from guest where gue_id = " + id + ";";
            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão

            return true;
        }


    }
}
