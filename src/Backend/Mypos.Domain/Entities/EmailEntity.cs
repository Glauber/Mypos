using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypos.Domain.Entities
{
    public class EmailEntity : BaseEntity
    {
        public int Id { get; set; }
        public string EnderecoEmail { get; set; }
        public bool Principal { get; set; }

        // Referência ao cliente dono do email
        public ClienteEntity Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
