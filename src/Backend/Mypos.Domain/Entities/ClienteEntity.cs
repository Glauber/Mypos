using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypos.Domain.Entities
{
    public class ClienteEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        // Lista de emails do cliente
        public ICollection<EmailEntity> Emails { get; set; } = new List<EmailEntity>();

        // Lista de telefones do cliente
        public ICollection<TelefoneEntity> Telefones { get; set; } = new List<TelefoneEntity>();

        // Lista de endereços do cliente
        public ICollection<EnderecoEntity> Enderecos { get; set; } = new List<EnderecoEntity>();
    }
}
