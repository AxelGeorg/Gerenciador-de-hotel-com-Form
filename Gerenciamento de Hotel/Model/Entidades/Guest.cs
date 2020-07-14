using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Model.Entidades
{
    public class Guest
    {
        public int gue_id { get; set; }
        public string gue_nome { get; set; }
        public string gue_cpf { get; set; }
        public string gue_dataNascimento { get; set; }
        public int gue_diasReservados { get; set; }
        public float gue_precoTotal { get; set; }
        public int gue_fk_room { get; set; }
    }
}
