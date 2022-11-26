namespace IMC.Services
{
    public class Metodos
    {
        //Método que calcula el IMC
        public double CalcularIMC(double Peso, double Altura)
        {
            double IMC;
            IMC = Peso / (Altura * Altura);
            return IMC;
        }

        public string ObtenerDiagnostico(double IMC)
        {
            string Diagnostico = string.Empty;

            string[,] DiagnosticosEval = ObtenerDiagnosticosBD(); //Obtenemos los diagnosticos de la BD

            for (int f = 0; f < DiagnosticosEval.GetLength(0); f++)//Recorre las filas
            {
                if (IMC >= double.Parse(DiagnosticosEval[f, 0]) && IMC <= double.Parse(DiagnosticosEval[f, 1]))
                {
                    Diagnostico = DiagnosticosEval[f, 2];
                    break;
                }
            }

            return Diagnostico;
        }

        private string[,] ObtenerDiagnosticosBD()
        {
            string[,] diagnosticos = new string[4, 3];

            diagnosticos[0, 0] = "0";
            diagnosticos[0, 1] = "18,5";
            diagnosticos[0, 2] = "Bajo peso";

            diagnosticos[1, 0] = "18,6";
            diagnosticos[1, 1] = "24,9";
            diagnosticos[1, 2] = "Peso saludable";

            diagnosticos[2, 0] = "25";
            diagnosticos[2, 1] = "29,9";
            diagnosticos[2, 2] = "Sobrepeso";

            diagnosticos[3, 0] = "30";
            diagnosticos[3, 1] = "39,9";
            diagnosticos[3, 2] = "Obesidad";

            return diagnosticos;
        }

    }
}