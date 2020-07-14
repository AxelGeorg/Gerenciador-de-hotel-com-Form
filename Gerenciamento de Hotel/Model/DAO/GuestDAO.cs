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
