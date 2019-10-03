using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    class Cargo
    {
        private string idCargo;
        private string cargo;

        public string IdCargo { get => idCargo; set => idCargo = value; }
        public string NombreCargo { get => cargo; set => cargo = value; }
    }
}
