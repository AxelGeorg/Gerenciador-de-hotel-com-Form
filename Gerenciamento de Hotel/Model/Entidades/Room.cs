using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Model.Entidades
{
    public class Room
    {
        public int room_id { get; set; }
        public string room_numeroQUarto { get; set; }
        public int room_quantCasal { get; set; }
        public int room_quantSolteiro { get; set; }
        public bool room_disponibilidade { get; set; }
        public bool room_limpeza { get; set; }
        public float room_precoDiaria { get; set; }
        public float room_precoTotal { get; set; }
        public int fk_frigID { get; set; }

    }
}
