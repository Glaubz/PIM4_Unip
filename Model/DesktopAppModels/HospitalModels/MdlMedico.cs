using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModels
{
    public class MdlMedico
    {
        public int Id { get; set; }
        public string CRM { get; set; }
        public int PessoaId { get; set; }
        public int EspecialidadeId { get; set; }
        public MdlPessoa Pessoa { get; set; }
        public MdlEspecialidade Especialidade { get; set; }
    }

}
