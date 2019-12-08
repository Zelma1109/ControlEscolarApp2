using System;

namespace Entidades.ControlEscolarApp
{
    public class NoControl
    {
        public string Generate(string año, int longitud, string extension)
        {
            string Short = "";
            string cadena = "";
            Random r = new Random();

            for (int i = 0; i < año.Length; i++)
            {
                if (i > 1)
                {
                    Short += año[i];
                }
            }

            for (int i = 0; i < longitud; i++)
            {

                int numero = r.Next(1, 36);
                switch (numero)
                {
                    case 1:
                        cadena += "A";
                        break;
                    case 2:
                        cadena += "B";
                        break;
                    case 3:
                        cadena += "C";
                        break;
                    case 4:
                        cadena += "D";
                        break;
                    case 5:
                        cadena += "E";
                        break;
                    case 6:
                        cadena += "F";
                        break;
                    case 7:
                        cadena += "G";
                        break;
                    case 8:
                        cadena += "H";
                        break;
                    case 9:
                        cadena += "I";
                        break;
                    case 10:
                        cadena += "J";
                        break;
                    case 11:
                        cadena += "K";
                        break;
                    case 12:
                        cadena += "L";
                        break;
                    case 13:
                        cadena += "M";
                        break;
                    case 14:
                        cadena += "N";
                        break;
                    case 15:
                        cadena += "O";
                        break;
                    case 16:
                        cadena += "P";
                        break;
                    case 17:
                        cadena += "Q";
                        break;
                    case 18:
                        cadena += "R";
                        break;
                    case 19:
                        cadena += "S";
                        break;
                    case 20:
                        cadena += "T";
                        break;
                    case 21:
                        cadena += "U";
                        break;
                    case 22:
                        cadena += "V";
                        break;
                    case 23:
                        cadena += "W";
                        break;
                    case 24:
                        cadena += "X";
                        break;
                    case 25:
                        cadena += "Y";
                        break;
                    case 26:
                        cadena += "Z";
                        break;
                    case 27:
                        cadena += "1";
                        break;
                    case 28:
                        cadena += "2";
                        break;
                    case 29:
                        cadena += "3";
                        break;
                    case 30:
                        cadena += "4";
                        break;
                    case 31:
                        cadena += "5";
                        break;
                    case 32:
                        cadena += "6";
                        break;
                    case 33:
                        cadena += "7";
                        break;
                    case 34:
                        cadena += "8";
                        break;
                    case 35:
                        cadena += "9";
                        break;
                    case 36:
                        cadena += "0";
                        break;
                    default:
                        break;
                }
            }

            return extension + Short + cadena;
        }
    }
}
