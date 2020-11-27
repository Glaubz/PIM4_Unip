using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModels
{
    public class MdlMedicoConsulta
    {
        public int Id { get; set; }
        public int ConsultaId { get; set; }
        public int MedicoId { get; set; }
        public string Tratamento { get; set; }
    }
}
