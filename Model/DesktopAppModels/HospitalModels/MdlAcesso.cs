namespace HospitalModels
{
    public class MdlAcesso
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }
    }
}
