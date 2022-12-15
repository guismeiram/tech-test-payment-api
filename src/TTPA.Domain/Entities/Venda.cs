using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTPA.Core.DomainObjects;

namespace TTPA.Domain.Entities
{
    public class Venda : Entity
    {
        public int Quantidade { get; set; }
        public double Valor { get; set; }
    }
}
