namespace ConsoleAppArray2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arregloEnteros = {{15,24,36,7,-80},
                          {23,67, 9,7, -8},
                          {58,67, 9,7, 90}};

            //Obtener un valor del arreglo
            int valor = arregloEnteros[0, 4];

            Console.WriteLine($"El valor de arregloEnteros[0, 4] es: {valor} ");

            //Recorriendo el arreglo
            for (int fil = 0; fil < 3; fil++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.WriteLine(arregloEnteros[fil, col]);
                }
            }

        }
    }
}