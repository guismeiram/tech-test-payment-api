using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTPA.Core.DomainObjects;

namespace TTPA.Domain.Entities
{
    public class Item : Entity
    {
        public string VendasId { get; set; }
        public string PessoaId { get; set; }
        public string PedidoId { get; set; }
        public IEnumerable<Pedido> Pedido { get; set; }
        public IEnumerable<Venda> Vendas { get; set; }
        public IEnumerable<Pessoa> Pessoas { get; set; }

        public Status Status { get; set; }

    }
}
