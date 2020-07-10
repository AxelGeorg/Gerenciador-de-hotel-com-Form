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

        public List<Employees> retornaEmployees(int tipoOrdenacao)
        {
            return employeesDAO.BuscarFuncionarios(tipoOrdenacao);
        }

        public void cradastraEmployees(Employees emp)
        {
            employeesDAO.cadastrarEmployee(emp.emp_nome, emp.emp_sobrenome, emp.emp_cpf, emp.emp_titulo, emp.emp_email, emp.emp_password);
        }

        public void alteraEmployee(Employees emp)
        {
            employeesDAO.alterarEmployee(emp.emp_id,emp.emp_nome, emp.emp_sobrenome, emp.emp_cpf, emp.emp_titulo, emp.emp_email, emp.emp_password);
        }
        public void deletaEmployee(int emp_id)
        {
            employeesDAO.deletarEmployee(emp_id);
        }
    }
}
