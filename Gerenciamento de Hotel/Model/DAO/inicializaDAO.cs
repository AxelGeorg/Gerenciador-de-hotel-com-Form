﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Model.DAO
{
    public class InicializaDAO
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        string cs = @"Server=localhost;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;

        /// <summary>
        /// Cria a base de dados no MySQL.
        /// </summary>
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

        /// <summary>
        /// Cria um funcionário teste na tabela de funcionários.
        /// </summary>
        public void criaEmployeePadrao()
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "insert ignore into employees (emp_id,emp_nome,emp_sobrenome,emp_cpf,emp_titulo,emp_email,emp_password) " +
                                                 "values (1,'axel', 'erwer', '12341234','ceo','axelgeorg16@gmail.com','123');";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        }

        /// <summary>
        /// Cria toda a tabela de funcionário na base de dados.
        /// </summary>
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
                                                                        "emp_email varchar(30) not null," +
                                                                        "emp_password varchar(15) not null);";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        }

        /// <summary>
        /// Cria toda a tabela quarto na base de dados.
        /// </summary>
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
                                                                        "room_precoDiaria float not null);";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        }

        /// <summary>
        /// Cria toda a tabela de bebida na base de dados.
        /// </summary>
        public void criaTabelaConsumables()
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "create table if not exists consumables (con_id int primary key auto_increment," +
                                                                          "con_nome varchar(20) not null," +
                                                                          "con_tipoProduto varchar(10) not null," +
                                                                          "con_tipoSabor varchar(10) not null," +
                                                                          "con_preco float not null," +
                                                                          "con_descricao varchar(45));";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        }

        /// <summary>
        /// Cria toda a tabela de hóspede na base de dados.
        /// </summary>
        public void criaTabelaGuest()
        {
            connection = new MySqlConnection(conexaoString);
            connection.Open(); // abre a conexão
            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
            command.CommandText = "create table if not exists guest (gue_id int primary key auto_increment," +
                                                                        "gue_nome varchar(30) not null," +
                                                                        "gue_cpf varchar(15) not null," +
                                                                        "gue_dataNascimento date not null," +
                                                                        "gue_diasReservado int," +
                                                                        "gue_precoTotal float," +
                                                                        "gue_historico varchar(10000)," +
                                                                        "gue_fk_room int," +
                                                                        "CONSTRAINT fk_room FOREIGN KEY(gue_fk_room) REFERENCES room(room_id));";

            command.ExecuteNonQuery();
            command.Connection.Close(); //fecha conexão
        }
    }
}
