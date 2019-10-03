using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    class Persona
    {
        private string idPersona;
        private string primerNombre;
        private string segundoNombre;
        private string tercerNombre;
        private string primerApellido;
        private string segundoApellido;
        private string telefono;
        private string email;

        public string IdPersona { get => idPersona; set => idPersona = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string TercerNombre { get => tercerNombre; set => tercerNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
