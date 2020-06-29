using Gerenciamento_de_Hotel.Model.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Model.DAO
{
    public class FrigoBarDAO
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;

        public List<FrigoBar> listarFrigoBares()
        {
            try
            {
                var frigoBar = new List<FrigoBar>();
                //int qntd = qntdBanco();

                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand("select frig_id, frig_nomeProduto, frig_preco, frig_quant  from frigoBar;", connection))
                    {
                        connection.Open(); // abre a conexão
                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                FrigoBar frigo = new FrigoBar();
                                frigo.frig_id = Convert.ToInt32(dataReader["frig_id"].ToString());
                                frigo.frig_identificacao = dataReader["frig_identificacao"].ToString();
                                frigo.fk_frigPID = Convert.ToInt32(dataReader["frig_id"].ToString());

                                frigoBar.Add(frigo);
                            }
                        }
                        return frigoBar;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar a lista dos FrigoBares" + ex.Message);
            }
        }

    }
}
