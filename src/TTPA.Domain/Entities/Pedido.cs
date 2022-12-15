using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTPA.Core.DomainObjects;

namespace TTPA.Domain.Entities
{
    public class Pedido : Entity
    {
        public string Nome { get; set; }
        public DateTime HorarioPedido { get; set; }
        public string ProtocoloPedido { get; set; }

    }
}
