using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    class Alumno
    {
        private string idAlumno;
        private string idPadre;
        private string idPersona;
        private string idSeccion;
        private string carnet;

        public string IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string IdPadre { get => idPadre; set => idPadre = value; }
        public string IdPersona { get => idPersona; set => idPersona = value; }
        public string IdSeccion { get => idSeccion; set => idSeccion = value; }
        public string Carnet { get => carnet; set => carnet = value; }
    }
}
