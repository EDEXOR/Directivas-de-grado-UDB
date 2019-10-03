using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    class PadreDirectiva
    {
        private string idDirectiva;
        private string idPadre;
        private string idCargo;

        public string IdDirectiva { get => idDirectiva; set => idDirectiva = value; }
        public string IdPadre { get => idPadre; set => idPadre = value; }
        public string IdCargo { get => idCargo; set => idCargo = value; }
    }
}
