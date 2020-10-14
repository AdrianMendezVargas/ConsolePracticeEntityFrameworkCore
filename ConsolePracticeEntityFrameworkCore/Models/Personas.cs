using System;
using System.Collections.Generic;

namespace ConsolePracticeEntityFrameworkCore.Models
{
    public partial class Personas
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
    }
}
