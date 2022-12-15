using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTPA.Core.DomainObjects;

namespace TTPA.Domain.Entities
{
    public class Pessoa : Entity
    {
        // Vendedor: id, cpf, nome, e-mail e telefone;
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone{ get; set; }

    }
}
