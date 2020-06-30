using Gerenciamento_de_Hotel.Model.DAO;
using Gerenciamento_de_Hotel.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Controller
{
    public class employeeController
    {
        EmployeesDAO employeesDAO = new EmployeesDAO();
        public bool validateUser(String email, String senha)
        {
            try
            {
                return employeesDAO.ValidateUser(email, senha);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Employees> retornaEmployees()
        {
            return employeesDAO.BuscarFuncionarios();
        }
        public void cradastraEmployees(Employees emp)
        {
            employeesDAO.cadastrarEmployee(emp.emp_nome, emp.emp_sobrenome, emp.emp_cpf, emp.emp_titulo, emp.emp_email, emp.emp_password);
        }
    }
}
