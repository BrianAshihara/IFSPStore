using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Produto: BaseEntity<int>
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public DateTime DataCompra { get; set; }
        public string UnidadeVenda { get; set; }

        public Grupo idGrupo { get; set; }

    }
}
