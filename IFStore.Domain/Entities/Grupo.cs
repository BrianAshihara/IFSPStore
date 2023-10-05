using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Grupo: BaseEntity<int>
    {
        public string Nome { get; set; }

        public static implicit operator Grupo(Produto v)
        {
            throw new NotImplementedException();
        }
    }
}
