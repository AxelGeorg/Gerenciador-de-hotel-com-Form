using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Model.Entidades
{
    public class Filtro
    {
        public float precoMin { get; set; }
        public float precoMax { get; set; }
        public int quantCamaCasal { get; set; }
        public int quantCamaSolteiro { get; set; }
        public int quantPessoas { get; set; }
        public string filtrosql { get; set; }
        public bool filtroSalvo { get; set; }
    }
}
