using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModels
{
    public class MdlFuncionario
    {
        public int Id { get; set; }
        public decimal Salario { get; set; }
        public bool Terceirizado { get; set; }
        public int CargoId { get; set; }
        public MdlCargo Cargo{ get; set; }
        public MdlPessoa Pessoa { get; set; }
    }
}
