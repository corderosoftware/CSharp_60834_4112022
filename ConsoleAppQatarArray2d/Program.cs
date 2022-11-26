namespace ConsoleAppQatarArray2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] GruposQatar2022 = new string[4, 6];

            GruposQatar2022[0, 0] = "A Saudita";
            GruposQatar2022[0, 1] = "1"; 
            GruposQatar2022[0, 2] = "1";
            GruposQatar2022[0, 3] = "0";
            GruposQatar2022[0, 4] = "0";
            GruposQatar2022[0, 5] = "0";
            //
            GruposQatar2022[1, 0] = "Polonia";
            GruposQatar2022[1, 1] = "1";
            GruposQatar2022[1, 2] = "0";
            GruposQatar2022[1, 3] = "1";
            GruposQatar2022[1, 4] = "0";
            GruposQatar2022[1, 5] = "0";
            //
            GruposQatar2022[2, 0] = "Mexico";
            GruposQatar2022[2, 1] = "1";
            GruposQatar2022[2, 2] = "0";
            GruposQatar2022[2, 3] = "1";
            GruposQatar2022[2, 4] = "0";
            GruposQatar2022[2, 5] = "0";
            //
            GruposQatar2022[3, 0] = "Argentina";
            GruposQatar2022[3, 1] = "1";
            GruposQatar2022[3, 2] = "0";
            GruposQatar2022[3, 3] = "0";
            GruposQatar2022[3, 4] = "1";
            GruposQatar2022[3, 5] = "0";
            //
            Console.WriteLine($"Equipo \t\t\tPJ\tPG\tPE\tPP\tPTS.");
            for (int f = 0; f < GruposQatar2022.GetLength(0); f++)
            {
                var Eq = GruposQatar2022[f, 0];
                var PJ = GruposQatar2022[f, 1];
                var PG = GruposQatar2022[f, 2];
                var PE = GruposQatar2022[f, 3];
                var PP = GruposQatar2022[f, 4];
                //var PTS = CalcularPuntos(GruposQatar2022);

                Console.WriteLine("Valor antes: " + GruposQatar2022[f, 4]);//Antes

                CalcularPuntos(GruposQatar2022,f);

                Console.WriteLine("Valor despues: " + GruposQatar2022[f, 4]); //Antes

                //Console.WriteLine($" {(f + 1)} {Eq} \t\t{PJ}\t{PG}\t{PE}\t{PP}\t{PTS}");
            }

        }

        static void CalcularPuntos(string[,] valores, int fc)
        {
            valores[fc, 4] = "Cambio";
        }

    }
}