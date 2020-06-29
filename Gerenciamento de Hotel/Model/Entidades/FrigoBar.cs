using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Model.Entidades
{
    public class FrigoBar
    {
        public int frig_id { get; set; }
        public string frig_identificacao { get; set; }
        public int fk_frigPID { get; set; }
    }
}
