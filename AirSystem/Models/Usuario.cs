using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Models
{
    class Usuario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        public string numeroEnd { get; set; }
        public DateTime nascimento { get; set; }

        public string usuario { get; set; }
        public string senha { get; set; }
        //public string confirmasenha { get; set; }

        public string tipousuario { get; set; }

    }
}
