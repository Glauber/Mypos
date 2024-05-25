using Mypos.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypos.Domain.Entities
{
    public class TelefoneEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public TipoTelefone Tipo { get; set; }

        // Referência ao cliente dono do telefone
        public ClienteEntity Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
