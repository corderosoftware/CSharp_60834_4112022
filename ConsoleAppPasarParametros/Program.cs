using System.Drawing;

namespace ConsoleAppPasarParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int valorActual = 10;
            //int[] arrayValorActual = { 2, 4, 6 };
            //UpdateRef(valorActual); //pasar argumento por referencia
            //UpdateArrayRef(arrayValorActual); //pasar argumento por referencia
            //Console.WriteLine($"el valor es: {valorActual}"); // muestra 12
            //Console.WriteLine($"el valor es: {arrayValorActual[1]}"); // muestra 12
            //Console.ReadKey();

            //int currentValue=8;
            //updateOut(out currentValue);
            //Console.WriteLine($"el valor es: {currentValue}"); // Muestra 21
            //Console.ReadKey();

            //int currentValue = 21;
            ////updateIn(currentValue);
            ////updateIn(in currentValue);
            //Console.WriteLine($"el valor es: {currentValue}"); // Muestra 21
            //Console.ReadKey();

            string valueTodec1 = "abcd";
            string valueToDec2 = "211";
            decimal dec1;
            decimal dec2;

            if (Decimal.TryParse(valueTodec1, out dec1))
                Console.WriteLine("Se pudo convertir " + valueTodec1 + " en " + dec1);
            else
                Console.WriteLine(valueTodec1 + " no se puede convertir a decimal");

            if (Decimal.TryParse(valueToDec2, out dec2))
                Console.WriteLine("Se pudo convertir " + valueToDec2 + " en " + dec2);
            else
                Console.WriteLine(valueToDec2 + " no se puede convertir a decimal");
        }

        //Método utilizando in
        public static void updateIn(int valorIn)
        {
            valorIn += 21; //Da error
            Console.WriteLine($"Valor dentro del método: { valorIn }"); // Muestra 21
        }


        //Método utilizando out
        public static void updateOut(out int valorIn)
        {
            valorIn = 21;
        }


        //Método para actualizar por referencia
        public static void UpdateRef(int valor)
        {
            valor += 2;
        }

        //Método para actualizar por referencia
        public static void UpdateArrayRef(int[] valor)
        {
            valor[1] += 2;
        }

    }
}