using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Venda: BaseEntity<int>
    {
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }

        public Usuario idUsuario { get; set; }

        public Cliente idCliente { get; set; }
    }
}
