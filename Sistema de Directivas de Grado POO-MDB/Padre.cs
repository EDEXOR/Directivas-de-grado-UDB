﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    class Padre
    {
        private string idPadre;
        private string idPersona;

        public string IdPadre { get => idPadre; set => idPadre = value; }
        public string IdPersona { get => idPersona; set => idPersona = value; }
    }
}
