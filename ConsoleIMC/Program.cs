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
                Console.WriteLine("1 - Diagnostico Presencial");
                Console.WriteLine("2 - Diagnostico Multiple");
                Console.WriteLine("3 - Salir");
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

                        ShowDiagnostic(paciente);

                        System.Console.WriteLine("Presione <Enter> para continuar");
                        System.Console.ReadKey();
                        System.Console.Clear();

                        break;

                    case 2: //Procesar multiples pacientes

                        Paciente[] ListaPacientesMultiples = ObtenerPacientes();
                        System.Console.Clear();
                        foreach (Paciente pacienteM in ListaPacientesMultiples)
                        {
                            ShowDiagnostic(pacienteM);
                        }
                        System.Console.WriteLine("Presione <Enter> para continuar");
                        System.Console.ReadKey();
                        System.Console.Clear();
                        break;
                }

            } while (opcion != 3);

            Console.WriteLine($"Hasta luego { GetTitulo(paciente.Genero) } { paciente.NombreApellido } , cuidese.");

        }


        static void ShowDiagnostic(Paciente pacienteShow)
        {
            double IMC;
            //Aca se calcula el IMC
            IMC = CalcularIMC(pacienteShow.Peso, pacienteShow.Altura);

            //Muestra los datos del Paciente
            System.Console.WriteLine(pacienteShow.ShowData());

            //Se muestra el resultado
            System.Console.WriteLine("Tu IMC es: " + IMC);

            //Le brindamos el diagnostico al Paciente
            System.Console.WriteLine($"El diagnóstico es: {ObtenerDiagnostico(IMC)} ");
           
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

        //Devolver un listado de pacientes
        static Paciente[] ObtenerPacientes()
        {
            Paciente[] ListaPacientes = new Paciente[4];

            //Crear los pacientes y almacenarlos en el Array
            //Paciente paciente1 = new Paciente();
            //paciente1.NroDoc = "bvxcbvzbv";
            //paciente1.NombreApellido = "hhjjhhjg";
            //paciente1.Peso = 80;

            //Paciente paciente2 = new Paciente();
            //paciente1.NroDoc = "bvxcbvzbv";
            //paciente1.NombreApellido = "hhjjhhjg";
            //paciente1.Peso = 80;


            ListaPacientes[0] = new Paciente() { NroDoc = "44343443", NombreApellido = "Victor Cordero", Genero = 'M', Peso = 80, Altura = 1.65 };
            ListaPacientes[1] = new Paciente() { NroDoc = "21228788", NombreApellido = "Alejo", Genero = 'M', Peso = 60, Altura = 1.40 };
            ListaPacientes[2] = new Paciente() { NroDoc = "21887878", NombreApellido = "Francisco", Genero= 'M', Peso = 50, Altura = 1.35 };
            ListaPacientes[3] = new Paciente() { NroDoc = "21888765", NombreApellido = "Pedro", Genero = 'M', Peso = 70, Altura = 1.75 };


            return ListaPacientes;
        }

        //static Paciente[] ObtenerPacientesFor()
        //{
        //    Paciente[] ListaPacientes = new Paciente[4];

        //    for (int i = 0; i < ListaPacientes.Length; i++)
        //    {
        //        ListaPacientes[i] = new Paciente() { NroDoc = "999999" +i , 
        //            NombreApellido= "Paciente " + i,
        //            Peso = 
        //        };
        //    }

        //    //Crear los pacientes y almacenarlos en el Array
        //    Paciente paciente1 = new Paciente();
        //    paciente1.NroDoc = "bvxcbvzbv";
        //    paciente1.NombreApellido = "hhjjhhjg";
        //    paciente1.Peso = 80;

        //    Paciente paciente2 = new Paciente();
        //    paciente1.NroDoc = "bvxcbvzbv";
        //    paciente1.NombreApellido = "hhjjhhjg";
        //    paciente1.Peso = 80;


        //    ListaPacientes[0] = paciente1; //new Paciente() { NroDoc = "44343443", NombreApellido = "Victor Cordero", Peso = 80, Altura = 1.65 };
        //    ListaPacientes[1] = paciente2; //new Paciente() { NroDoc = "21228788", NombreApellido = "Alejo", Peso = 60, Altura = 1.40 };
        //    ListaPacientes[2] = new Paciente() { NroDoc = "21887878", NombreApellido = "Francisco", Peso = 50, Altura = 1.35 };
        //    ListaPacientes[3] = new Paciente() { NroDoc = "21888765", NombreApellido = "Pedro", Peso = 70, Altura = 1.75 };


        //    return ListaPacientes;
        //}

    }
}