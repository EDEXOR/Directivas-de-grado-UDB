using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Directivas_de_Grado_POO_MDB
{
    public class Validaciones
    {
        public void ValidarLetras(KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //tecla espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "Validación de Letras",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void ValidarPass(KeyPressEventArgs e, TextBox txt)
        {
            //condicion para solo números
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //tecla espacio
            else if ((char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if ((e.KeyChar == '.') && (!txt.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Contraseña mal digitada", "Validación de Pass", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ValidarNumeros(KeyPressEventArgs e, TextBox txt)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txt.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Validación de Números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static bool ValidarEmail(string email)
        {
            //cadena o expresion regular que verifica a un formato de correo electrónico
            string expresion = @"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$";
                //verifica que el email ingresado corresponda con la expresion válida
            if (Regex.IsMatch(email, expresion))
            {//verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarTelefono(string telefono)
        {
            //cadena o expresion regular que verifica a un formato de correo electrónico
            string expresion = @"[0-9]{4}-[0-9]{4}";
            //verifica que el email ingresado corresponda con la expresion válida
            if (Regex.IsMatch(telefono, expresion))
            {//verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
                if (Regex.Replace(telefono, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarCarnet(string carnet)
        {
            //cadena o expresion regular que verifica a un formato de correo electrónico
            string expresion = @"[a-zA-Z]{2}[0-9]{6}";
            //verifica que el email ingresado corresponda con la expresion válida
            if (Regex.IsMatch(carnet, expresion))
            {//verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
                if (Regex.Replace(carnet, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
