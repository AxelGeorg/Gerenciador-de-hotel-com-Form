using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Model.Entidades
{
    class Employees
    {
        public int fun_id { get; set; }
        public string fun_nome { get; set; }
        public string fun_sobrenome { get; set; }
        public string fun_cpf { get; set; }
        public string fun_titulo { get; set; }

        public Employees(int id, string nome, string sobrenome, string cpf, string titulo)
        {
            this.fun_id = id;
            this.fun_nome = nome;
            this.fun_sobrenome = sobrenome;
            this.fun_cpf = cpf;
            this.fun_titulo = titulo;
        }

    }
}
