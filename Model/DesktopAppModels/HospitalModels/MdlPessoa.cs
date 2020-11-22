using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModels
{
    public class MdlPessoa
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Genero { get; set; }
        public int UsuarioId { get; set; }
        public MdlUsuario Usuario { get; set; }
    }
}
