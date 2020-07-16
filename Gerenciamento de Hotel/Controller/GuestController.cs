using Gerenciamento_de_Hotel.Model.DAO;
using Gerenciamento_de_Hotel.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Controller
{
    public class GuestController
    {
        GuestDAO guestDAO = new GuestDAO();

        public List<Guest> retornaGuest(int tipoOrdenacao)
        {
            return guestDAO.BuscarGuest(tipoOrdenacao);
        }

        public bool cadastrarGuest(Guest guest)
        {
            return guestDAO.cadastrarGuest(guest);
        }

        public bool alteraGuest(Guest guest, int tipoSelect)
        {
            return guestDAO.alterarGuest(guest, tipoSelect);
        }

        public bool deletaGuest(int id)
        {
            return guestDAO.deletarGuest(id);
        }
    }
}
