using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModels
{
    public class MdlConsulta
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataConsulta { get; set; }
        public string DescricaoEnfermidade { get; set; }
        public bool Retorno { get; set; }
        public DateTime? DataRetorno { get; set; }
        public int PacienteId { get; set; }
        public string NomePaciente { get; set; }
        public MdlMedicoConsulta MedicoConsulta { get; set; }
        public string NomeMedico { get; set; }
    }
}
