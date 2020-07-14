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

       public bool cadastrarGuest (Guest guest)
        {
            return guestDAO.cadastrarGuest(guest);
        }
    }
}
