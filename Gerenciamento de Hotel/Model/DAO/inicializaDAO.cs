using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Model.DAO
{
    public class inicializaDAO
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        string cs = @"Server=localhost;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;

        public void criaDataBase()
        { 
            connection = new MySqlConnection(cs);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "create database if not exists hotel;";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão

        }

        public void criaEmployeeTeste()
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "insert into employees (emp_nome,emp_sobrenome,emp_cpf,emp_titulo,emp_email,emp_password) values ('axel', 'erwer', '12341234','ceo','teste','123');";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        }

        public void criaTabelaEmployees()
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "create table if not exists employees (emp_id int primary key auto_increment," +
                                                                        "emp_nome varchar(20) not null," +
                                                                        "emp_sobrenome varchar(35) not null," +
                                                                        "emp_cpf varchar(15) not null," +
                                                                        "emp_titulo varchar(15) not null," +
                                                                        "emp_email varchar(55) not null," +
                                                                        "emp_password varchar(15) not null);";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        }
        
        public void criaTabelaRoom()
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "create table if not exists room (room_id int primary key auto_increment," +
                                                                        "room_numeroQuarto varchar(20) not null," +
                                                                        "room_quantPessoa int not null," +
                                                                        "room_quantCasal int not null," +
                                                                        "room_quantSolteiro int not null," +
                                                                        "room_disponibilidade bool not null," +
                                                                        "room_limpeza bool not null," +
                                                                        "room_precoDiaria float not null," +
                                                                        "room_precoTotal float);";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        } 
        
        public void criaTabelaDrink()
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "create table if not exists drinks (dri_id int primary key auto_increment," +
                                                                        "dri_nome varchar(20) not null," +
                                                                        "dri_preco float not null," +
                                                                        "dri_tipo varchar(15) not null);";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        }   

        public void criaTabelaFood()
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "create table if not exists foods (food_id int primary key auto_increment," +
                                                                        "food_nome varchar(20) not null," +
                                                                        "food_preco float not null," +
                                                                        "food_tipo varchar(15) not null);";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        }
    }
}
