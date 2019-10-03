using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    class Grado
    {
        private string idGrado;
        private int grado;

        public string IdGrado { get => idGrado; set => idGrado = value; }
        public int NombreGrado { get => grado; set => grado = value; }
    }
}
