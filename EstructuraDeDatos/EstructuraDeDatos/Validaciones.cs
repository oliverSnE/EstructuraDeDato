using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EstructuraDeDatos
{
    public class Validaciones
    {
        static Regex regex;

        public static bool entero (string entero)
        {
            regex = new Regex(@"^[0-9]{1,15}$");
            return regex.IsMatch(entero);
        }
        public static bool doble (string doble)
        {
            regex = new Regex(@"[0-9].[0-9]{1,15}$");
            return regex.IsMatch(doble);
        }
        public static bool decima(string decima)
        {
            regex = new Regex(@"[0-9].[0-9]{1,28}$");
            return regex.IsMatch(decima);
        }
        public static bool cha (string cha)
        {
            regex = new Regex(@"[A-Za-z0-9]{1}$");
            return regex.IsMatch(cha);
        }
    }
}
