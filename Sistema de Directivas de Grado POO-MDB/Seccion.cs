using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    class Seccion
    {
        private string idSeccion;
        private string idGrado;
        private string idProfesor;
        private string seccion;

        public string IdSeccion { get => idSeccion; set => idSeccion = value; }
        public string IdGrado { get => idGrado; set => idGrado = value; }
        public string IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string NombreSeccion { get => seccion; set => seccion = value; }
    }
}
