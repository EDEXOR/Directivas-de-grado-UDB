using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    class Usuario
    {
        private string idUsuario;
        private string idProfesor;
        private string tipoUsuario;
        private string correo;
        private string clave;

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
