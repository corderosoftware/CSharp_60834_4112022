namespace ConsoleIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NombrePaciente;
            char Genero;
            double Peso = 0;
            double Altura = 0;
            double IMC = 0;
            int Valor;
            //Una linea
            /*
             Le solicitamos los datos al paciente
             con la finalidad
             de calcular su IMC
            */

            System.Console.WriteLine("Indica tu nombre y apellido:");
            NombrePaciente = System.Console.ReadLine();

            System.Console.WriteLine("Indica tu peso:");
            //Peso = float.Parse(System.Console.ReadLine());
            Peso = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Indica tu Altura:");
            Altura = Convert.ToDouble(System.Console.ReadLine());

            //Aca se calcula el IMC
            IMC = Peso / (Altura * Altura);

            //Se muestra el resultado
            System.Console.WriteLine("Tu IMC es: " + IMC);

            //Le brindamos el diagnostico al Paciente
            if (IMC <= 18.5)
            {
                Console.WriteLine("Tienes Bajo peso");
            }else if (IMC > 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("Tienes un Peso saludable");
            }else if (IMC > 25 && IMC <= 29.9)
            {
                Console.WriteLine("Tienes Sobrepeso");
            }
            else
            {
                Console.WriteLine("Tienes Obesidad, ve corriendo al hospital");
            }

        }
    }
}