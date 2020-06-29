using Gerenciamento_de_Hotel.Model.DAO;
using Gerenciamento_de_Hotel.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Controller
{
    public class FrigoBarController
    {
        FrigoBarDAO frigoBarDAO = new FrigoBarDAO();



        public List<FrigoBar> listarFrigoBares()
        {
            var frigobar = new List<FrigoBar>();
            frigobar = frigoBarDAO.listarFrigoBares();
            return frigobar;
        }
    }
}
