namespace Hackaton.Domain
{
    public class AgendaEntity : BaseEntity
    {
        public int MedicoId { get; set; }
        public UsuarioEntity Medico { get; set; } = null!;

        public int PacienteId { get; set; }
        public UsuarioEntity? Paciente { get; set; }

        public DateOnly Data { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFim { get; set; }

    }
}
