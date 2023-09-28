using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Cliente: BaseEntity<int> 
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Documentento { get; set; }
        public string Bairro { get; set; }
        public Cidade idCidade { get; set; }

    }
}
