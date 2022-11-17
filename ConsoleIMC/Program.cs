using System.Diagnostics;

namespace ConsoleIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creación de un objeto Persona (Instancia de una clase)
            Paciente paciente = new Paciente(); //Darle vida a la clase
                       
            double IMC = 0;
            int Valor;
            //Una linea
            /*
             Le solicitamos los datos al paciente
             con la finalidad
             de calcular su IMC
            */

            //Genero un Menu
            byte opcion;
            do
            {
                Console.WriteLine("Bienvenido IMC V beta 1.0");
                Console.WriteLine("=========================");
                Console.WriteLine("1 - Nuevo Diagnostico");
                Console.WriteLine("2 - Salir");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        System.Console.WriteLine("Indica tu Nro de Documento:");
                        paciente.NroDoc = System.Console.ReadLine();

                        System.Console.WriteLine("Indica tu nombre y apellido:");
                        paciente.NombreApellido = System.Console.ReadLine();

                        System.Console.WriteLine("Indica tu Genero (F/M):");
                        paciente.Genero = char.Parse(System.Console.ReadLine());

                        System.Console.WriteLine("Indica tu peso:");
                        //Peso = float.Parse(System.Console.ReadLine());
                        paciente.Peso = Convert.ToDouble(System.Console.ReadLine());

                        System.Console.WriteLine("Indica tu Altura:");
                        paciente.Altura = Convert.ToDouble(System.Console.ReadLine());

                        //Aca se calcula el IMC
                        IMC = CalcularIMC(paciente.Peso,paciente.Altura);

                        //Muestra los datos del Paciente
                        System.Console.WriteLine(paciente.ShowData());

                        //Se muestra el resultado
                        System.Console.WriteLine("Tu IMC es: " + IMC);

                        //Le brindamos el diagnostico al Paciente
                        System.Console.WriteLine($"El diagnóstico es: { ObtenerDiagnostico(IMC) } ");
                        //System.Console.WriteLine("El diagnótico es: " + ObtenerDiagnostico(IMC)); //Concatenación
                        break;
                }

            } while (opcion != 2);

            Console.WriteLine($"Hasta luego { GetTitulo(paciente.Genero) } { paciente.NombreApellido } , cuidese.");

        }

        //Implementar el método que calcula el IMC
        static double CalcularIMC(double Peso, double Altura)
        {
            double IMC;
            IMC = Peso / (Altura * Altura);
            return IMC;
        }

        //Devolver si es Sr o Sra
        static string GetTitulo (char Genero)
        {
            string Titulo;
            switch (Genero)
            {
                case 'F':
                    Titulo = "Sra.";
                    break;
                case 'M':
                    Titulo = "Sr";
                    break;
                default:
                    Titulo = "X";
                    break;
            }
            return Titulo;
        }


        //Implementar el método para retornar el diagnóstico
        static string ObtenerDiagnostico(double IMC)
        {
            string Diagnostico;
            if (IMC <= 18.5)
            {
                Diagnostico = "Tienes Bajo peso";
            }
            else if (IMC > 18.5 && IMC <= 24.9)
            {
                Diagnostico = "Tienes un Peso saludable";
            }
            else if (IMC > 25 && IMC <= 29.9)
            {
                Diagnostico = "Tienes Sobrepeso";
            }
            else
            {
                Diagnostico = "Tienes Obesidad, ve corriendo al hospital";
            }

            return Diagnostico;
        }

    }
}