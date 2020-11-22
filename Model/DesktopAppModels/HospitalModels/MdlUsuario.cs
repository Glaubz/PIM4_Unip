using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModels
{
    public class MdlUsuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int PerfilId { get; set; }
        public MdlPerfil Perfil { get; set; }
    }
}
