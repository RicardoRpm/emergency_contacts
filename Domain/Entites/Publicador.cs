using Domain.Common;
using Domain.Enums;

namespace Domain.Entites
{
    public class Publicador : BaseEntity
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public DateTime DataDeBatismo { get; set; }
        public EGenero Genero { get; set; }
    }
}
