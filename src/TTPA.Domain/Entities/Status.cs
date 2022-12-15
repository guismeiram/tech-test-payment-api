using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTPA.Domain.Entities
{
    public enum Status
    {
        Aguardando = 1,
        Aprovado = 2,
        Cancelado = 3,
        Enviado = 4
    }

    /*De: Aguardando pagamento Para: Pagamento Aprovado
De: Aguardando pagamento Para: Cancelada
De: Pagamento Aprovado Para: Enviado para Transportadora
De: Pagamento Aprovado Para: Cancelada*/
}
