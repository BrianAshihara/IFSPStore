using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class VendaItem:BaseEntity<int>
    {
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }

        public Venda Venda { get; set; }

        public Produto Produto { get; set; }

        public VendaItem(int qtd, double vu, double vt, Venda vd, Produto pd) { 
            Quantidade= qtd;
            ValorUnitario= vu;
            ValorTotal= vt;
            Venda= vd;
            Produto= pd;
        }  

        public VendaItem()
        {

        }

    }
}
