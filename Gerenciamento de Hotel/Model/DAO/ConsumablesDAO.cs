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
    class ConsumablesDAO
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;
        bool clickID = true;
        bool clickNome = true;
        bool clickProduto = true;
        bool clickSabor = true;
        bool clickDescrição = true;

        /// <summary>
        /// Retorna uma lista de consumíveis de acordo com a ordenação desejada.
        /// </summary>
        /// <param name="tipoOrdenacao"></param>
        /// <returns></returns>
        public List<Consumables> BuscarConsumables(int tipoOrdenacao)
        {
            try
            {
                var listConsumables = new List<Consumables>();
                string query = "select con_id,con_nome,con_tipoProduto,con_tipoSabor,con_descricao from consumables";

                if (tipoOrdenacao == 0)
                {
                    if (clickID == true)
                    {
                        query = query + " order by con_id asc;";
                        clickID = false;
                    }
                    else
                    {
                        query = query + " order by con_id desc;";
                        clickID = true;
                    }
                }

                if (tipoOrdenacao == 1)
                {
                    if (clickNome == true)
                    {
                        query = query + " order by con_nome asc;";
                        clickNome = false;
                    }
                    else
                    {
                        query = query + " order by con_nome desc;";
                        clickNome = true;
                    }
                }

                if (tipoOrdenacao == 2)
                {
                    if (clickProduto == true)
                    {
                        query = query + " order by con_tipoProduto asc;";
                        clickProduto = false;
                    }
                    else
                    {
                        query = query + " order by con_tipoProduto desc;";
                        clickProduto = true;
                    }
                }

                if (tipoOrdenacao == 3)
                {
                    if (clickSabor == true)
                    {
                        query = query + " order by con_tipoSabor asc;";
                        clickSabor = false;
                    }
                    else
                    {
                        query = query + " order by con_tipoSabor desc;";
                        clickSabor = true;
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
                                Consumables consumables = new Consumables();
                                consumables.con_id = Convert.ToInt32(dataReader["con_id"].ToString());
                                consumables.con_nome = dataReader["con_nome"].ToString();
                                consumables.con_tipoProduto = dataReader["con_tipoProduto"].ToString();
                                consumables.con_tipoSabor = dataReader["con_tipoSabor"].ToString();
                                consumables.con_descricao = dataReader["con_descricao"].ToString();
                                listConsumables.Add(consumables);
                            }
                        }
                        return listConsumables; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar a lista de consumíveis" + ex.Message);
            }
        }

        /// <summary>
        /// Cadastra o consumível desejado.
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public bool cadastrarConsumables(Consumables consumables)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into consumables (con_nome, con_tipoProduto, con_tipoSabor, con_descricao) values ('" + consumables.con_nome + "', '" + consumables.con_tipoProduto + "', '" + consumables.con_tipoSabor + "', '" + consumables.con_descricao + "');";
                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Consumables buscarConsumablesNome(string nome)
        {
            Consumables consumables = new Consumables();

            try
            {
                string query = "select con_id,con_nome,con_tipoProduto,con_tipoSabor,con_descricao from consumables where con_nome = '" + nome + "';";
                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand(query, connection))
                    {
                        connection.Open(); // abre a conexão
                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                consumables.con_id = Convert.ToInt32(dataReader["con_id"].ToString());
                                consumables.con_nome = dataReader["con_nome"].ToString();
                                consumables.con_tipoProduto = dataReader["con_tipoProduto"].ToString();
                                consumables.con_tipoSabor = dataReader["con_tipoSabor"].ToString();
                                consumables.con_descricao = dataReader["con_descricao"].ToString();
                            }
                        }
                        return consumables;
                    }
                }
            }
            catch (Exception ex)
            {

                 throw new Exception("Erro ao acessar o produto" + ex.Message);
            }
        }

        public bool deletarConsumables(int id)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "delete from consumables where con_id = " + id + ";";
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
