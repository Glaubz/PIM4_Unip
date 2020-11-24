using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModels
{
    public class MdlPaciente
    {
        public int Id { get; set; }
        public string NumeroConvenio { get; set; }
        public int PessoaId { get; set; }
        public MdlPessoa Pessoa { get; set; }
    }
}
