using Gerenciamento_de_Hotel.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Controller
{
    public class inicializaController
    {
        inicializaDAO inicializaDAO = new inicializaDAO();
        public void criaDATABASE()
        {
            inicializaDAO.criaDataBase();
        }
        public void criaTabelas()
        {
            inicializaDAO.criaTabelaEmployees();
            inicializaDAO.criaTabelaRoom();
            inicializaDAO.criaTabelaDrink();
            inicializaDAO.criaTabelaFood();

            inicializaDAO.criaEmployeeTeste();
        }
    }
}
