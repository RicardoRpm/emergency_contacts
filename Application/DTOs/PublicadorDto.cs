using Application.DTOs.Commons;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class PublicadorDto : BaseDTO
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public DateTime DataDeBatismo { get; set; }
        public EGenero Genero { get; set; }

        // new fields 
        public bool OutraOvelha { get; set; }
        public bool Ungido { get; set; }
        public bool Anciao { get; set; }
        public bool ServoMinisterial { get; set; }
        public bool PioneiroRegular { get; set; }
        public bool PioneiroEspecial { get; set; }
        public bool Missionario { get; set; }
    }
}
