using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gerenciamento_de_Hotel.Model.DAO
{
    class RoomDAO
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;


        public bool cadastrarRoom(string room_numeroQuarto, int room_quantPessoa, int room_quantCasal, int room_quantSolteiro, bool room_disponibilidade, bool room_limpeza, float room_precoDIaria)
        {
            //Daniel 09/07/2020 Conexão com o banco e a inserção dos dados do quarto para o banco.
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into room (room_numeroQuarto, room_quantPessoa, room_quantCasal, room_quantSolteiro, room_disponibilidade, room_limpeza, room_precoDiaria) values ('" + room_numeroQuarto + "','" + room_quantPessoa + "','" + room_quantCasal + "','" + room_quantSolteiro + "','" + room_disponibilidade + "','" + room_limpeza + "','" + room_precoDIaria + "');";

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
