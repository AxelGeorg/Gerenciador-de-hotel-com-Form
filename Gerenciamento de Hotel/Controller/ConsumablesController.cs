using Gerenciamento_de_Hotel.Model.DAO;
using Gerenciamento_de_Hotel.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Controller
{
    public class ConsumablesController
    {
        ConsumablesDAO consumablesDAO = new ConsumablesDAO();

        public List<Consumables> retornaConsumables(int tipoOrdenacao)
        {
            return consumablesDAO.BuscarConsumables(tipoOrdenacao);
        }
        public bool cadastrarConsumables(Consumables consumables)
        {
            return consumablesDAO.cadastrarConsumables(consumables);
        }
        public bool alteraConsumables(Consumables consumables)
        {
            return consumablesDAO.alteraConsumables(consumables);
        }
        public Consumables retonaConsumablesNome(string nome)
        {
            return consumablesDAO.buscarConsumablesNome(nome);
        }
        public bool deletarConsumable (int id)
        {
            return consumablesDAO.deletarConsumables(id);
        }
    }
}
