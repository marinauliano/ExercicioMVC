using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMVC.LojaVirtual.Dominio.Entidades
{
    class Produto
    {
        public int ProdutoId {get; set;}

        public String Type { get; set; }

        public String Descricao { get; set; }

        public decimal Preco { get; set; }

        public String categoria { get; set; }

    }
}
