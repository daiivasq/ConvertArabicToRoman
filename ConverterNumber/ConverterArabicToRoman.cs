using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterNumber
{
    public class ConverterArabicToRoman
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA CONVERSOR DE NUMEROS ARABICOS O DECIMALES A NUMEROS ROMANOS. \n\n");
            Console.WriteLine("--------- CONVERSOR A NUMEROS ROMANOS--------");
            try
            {
                int converter;

                Console.WriteLine("Ingrese un numero:");
                converter = int.Parse(Console.ReadLine());
                if (converter == 0 || converter > 3999)
                {
                    Console.WriteLine("El numero que ha ingresado esta fuera de los parametros establecidos.");
                }
                Console.WriteLine($"\n ------ RESULTADO ------- \n\n Resultado de la conversion de {converter} a numero romano es: " + ConverterToRoman(converter));
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine($"NO SE PUEDE INGRESAR LETRAS. {e}");
                Console.ReadKey();
            }
        }

        public static string ConverterToRoman(int converter)
        {
            string roman = "";
            if (converter < 4) roman = "I" + ConverterToRoman(converter - 1);
            else if (converter == 4) roman = "IV";
            else if (converter < 9) roman = "V" + ConverterToRoman(converter - 5);
            else if (converter == 9) roman = "IX";
            else if (converter < 40) roman = "X" + ConverterToRoman(converter - 10);
            else if (converter < 50) roman = "XL" + ConverterToRoman(converter - 40);
            else if (converter < 90) roman = "L" + ConverterToRoman(converter - 50);
            else if (converter < 100) roman = "XC" + ConverterToRoman(converter - 90);
            else if (converter < 400) roman = "C" + ConverterToRoman(converter - 100);
            else if (converter < 500) roman = "CD" + ConverterToRoman(converter - 400);
            else if (converter < 900) roman = "D" + ConverterToRoman(converter - 500);
            else if (converter < 1000) roman = "CM" + ConverterToRoman(converter - 900);
            else if (converter < 4000) roman = "M" + ConverterToRoman(converter - 1000);

            return roman;

        }
    }
}
