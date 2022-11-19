namespace ConsoleAppArray1d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arrayEnteros = new int[6];//Declaración y creación
            //int[] arrayEnteros = new int[] { 15, 24, 36, 7, -80, 1 };
            //int[] arrayEnteros = { 15, 24, 36, 7, -80, 1 };

            string[] arrayDiasSemana; //Declaración del array
            arrayDiasSemana = new string[7]; //instancia del array

            arrayDiasSemana[0] = "Domingo";
            arrayDiasSemana[1] = "Lunes";
            arrayDiasSemana[2] = "Martes";
            arrayDiasSemana[3] = "Miercoles";
            arrayDiasSemana[4] = "Jueves";
            arrayDiasSemana[5] = "Viernes";
            arrayDiasSemana[6] = "Sabado";

            //Snipet
            for (int i = 0; i < arrayDiasSemana.Length; i++)
            {
                if (i % 2 == 0) //Es par la posición
                {
                    arrayDiasSemana[i] = arrayDiasSemana[i].ToUpper();
                    Console.WriteLine(arrayDiasSemana[i]);
                }
            }

            //string DiaMayuscula;
            //foreach (string dia in arrayDiasSemana)
            //{
            //    DiaMayuscula = dia.ToUpper();
            //    System.Console.WriteLine(DiaMayuscula);
            //}






        }
    }
}