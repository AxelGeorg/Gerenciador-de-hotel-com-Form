using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gerenciamento_de_Hotel.Model.Entidades;

namespace Gerenciamento_de_Hotel.Model.DAO
{
    class RoomDAO
    {
        const string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;
        bool clickID = true;
        bool clickNumeroQuarto = true;
        bool clickQuantCasal = true;
        bool clickQuantSolteiro = true;
        bool clickDisponibilidade = true;
        bool clickLimpeza = true;
        bool clickPrecoDiaria = true;
        bool clickPrecoTotal = true;
        bool clickQuantPessoa = true;

        public bool cadastrarRoom(string room_numeroQuarto, int room_quantPessoa, int room_quantCasal, int room_quantSolteiro, bool room_disponibilidade, bool room_limpeza, float room_precoDiaria, float room_precoTotal)
        {
            //Daniel 09/07/2020 Conexão com o banco e a inserção dos dados do quarto para o banco.
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into room (room_numeroQuarto, room_quantPessoa, room_quantCasal, room_quantSolteiro, room_disponibilidade, room_limpeza, room_precoDiaria, room_precoTotal) values ('" + room_numeroQuarto + "'," + room_quantPessoa + "," + room_quantCasal + "," + room_quantSolteiro + "," + room_disponibilidade + "," + room_limpeza + "," + room_precoDiaria + "," + room_precoTotal + ");";
                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool alteraRoom(int room_id, string room_numeroQuarto, int room_quantPessoa, int room_quantCasal, int room_quantSolteiro, bool room_disponibilidade, bool room_limpeza, float room_precoDiaria, float room_precoTotal)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "update room set room_numeroQuarto = '" + room_numeroQuarto + "',room_quantPessoa = " + room_quantPessoa + ",room_quantCasal = " + room_quantCasal + ",room_quantSolteiro = " + room_quantSolteiro + ",room_disponibilidade = " + room_disponibilidade + ",room_limpeza = " + room_limpeza + ",room_precoDiaria = " + room_precoDiaria + ",room_precoTotal = " + room_precoTotal + " where room_id = " + room_id + ";";
                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Room> BuscarQuartos(int tipoOrdenacao)
        {
            try
            {
                var listRoom = new List<Room>();
                string query = "select room_id,room_numeroQuarto,room_quantCasal,room_quantSolteiro,room_disponibilidade,room_limpeza,room_precoDiaria,room_precoTotal,room_quantPessoa from room ";

                if (tipoOrdenacao == 0)
                {
                    if (clickID == true)
                    {
                        query = query + " order by room_id asc;";
                        clickID = false;
                    }
                    else
                    {
                        query = query + " order by room_id desc;";
                        clickID = true;
                    }
                }

                if (tipoOrdenacao == 1)
                {
                    if (clickNumeroQuarto == true)
                    {
                        query = query + " order by room_numeroQuarto asc;";
                        clickNumeroQuarto = false;
                    }
                    else
                    {
                        query = query + " order by room_numeroQuarto desc;";
                        clickNumeroQuarto = true;
                    }
                }

                if (tipoOrdenacao == 2)
                {
                    if (clickQuantCasal == true)
                    {
                        query = query + " order by room_quantCasal asc;";
                        clickQuantCasal = false;
                    }
                    else
                    {
                        query = query + " order by room_quantCasal desc;";
                        clickQuantCasal = true;
                    }
                }

                if (tipoOrdenacao == 3)
                {
                    if (clickQuantSolteiro == true)
                    {
                        query = query + " order by room_quantSolteiro asc;";
                        clickQuantSolteiro = false;
                    }
                    else
                    {
                        query = query + " order by room_quantSolteiro desc;";
                        clickQuantSolteiro = true;
                    }
                }

                if (tipoOrdenacao == 4)
                {
                    if (clickDisponibilidade == true)
                    {
                        query = query + " order by room_disponibilidade asc;";
                        clickDisponibilidade = false;
                    }
                    else
                    {
                        query = query + " order by room_disponibilidade desc;";
                        clickDisponibilidade = true;
                    }
                }

                if (tipoOrdenacao == 5)
                {
                    if (clickLimpeza == true)
                    {
                        query = query + " order by room_limpeza asc;";
                        clickLimpeza = false;
                    }
                    else
                    {
                        query = query + " order by room_limpeza desc;";
                        clickLimpeza = true;
                    }
                }
                
                if (tipoOrdenacao == 6)
                {
                    if (clickPrecoDiaria == true)
                    {
                        query = query + " order by room_precoDiaria asc;";
                        clickPrecoDiaria = false;
                    }
                    else
                    {
                        query = query + " order by room_precoDiaria desc;";
                        clickPrecoDiaria = true;
                    }
                }
                
                if (tipoOrdenacao == 7)
                {
                    if (clickPrecoTotal == true)
                    {
                        query = query + " order by room_precoTotal asc;";
                        clickPrecoTotal = false;
                    }
                    else
                    {
                        query = query + " order by room_precoTotal desc;";
                        clickPrecoTotal = true;
                    }
                }
                
                if (tipoOrdenacao == 8)
                {
                    if (clickQuantPessoa == true)
                    {
                        query = query + " order by room_quantPessoa asc;";
                        clickQuantPessoa = false;
                    }
                    else
                    {
                        query = query + " order by room_quantPessoa desc;";
                        clickQuantPessoa = true;
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
                                Room room = new Room();
                                room.room_id = Convert.ToInt32(dataReader["room_id"].ToString());
                                room.room_numeroQuarto = dataReader["room_numeroQuarto"].ToString();
                                room.room_quantCasal = Convert.ToInt32(dataReader["room_quantCasal"].ToString());
                                room.room_quantSolteiro = Convert.ToInt32(dataReader["room_quantSolteiro"].ToString());
                                room.room_disponibilidade = Convert.ToBoolean(dataReader["room_disponibilidade"].ToString());
                                room.room_limpeza = Convert.ToBoolean(dataReader["room_limpeza"].ToString());
                                room.room_precoDiaria = float.Parse(dataReader["room_precoDiaria"].ToString());
                           //     room.room_precoTotal = float.Parse(dataReader["room_precoTotal"].ToString());
                                room.room_quantPessoa = Convert.ToInt32(dataReader["room_quantPessoa"].ToString());
                                listRoom.Add(room);
                            }
                        }
                        return listRoom;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar a lista de quartos" + ex.Message);
            }
        }
        public bool deletaRoom(int id)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "delete from room where room_id = " + id + ";";
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
