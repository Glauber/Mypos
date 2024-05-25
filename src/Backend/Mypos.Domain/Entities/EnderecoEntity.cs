using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypos.Domain.Entities
{
    public class EnderecoEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        // Referência ao cliente dono do endereço
        public ClienteEntity Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
