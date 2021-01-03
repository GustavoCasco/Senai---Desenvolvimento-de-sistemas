using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Models
{
    class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public DateTime nascimento { get; set; }
        public string user { get; set; }
        public string senha { get; set; }
        public string confirmacaosenha { get; set; }

    }
}
