using Gerenciamento_de_Hotel.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Controller
{
    public class loginController
    {
        EmployeesDAO employeesDAO = new EmployeesDAO();
        public bool validateUser(String email, String senha){

            try
            {
                return employeesDAO.ValidateUser(email, senha);
            }
            catch (Exception)
            {
                return false;
            }


            
        }

    }
}
