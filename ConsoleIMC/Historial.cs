using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIMC
{
    public class Historial
    {
        public struct DiagnosticoPaciente
        {
            public Paciente Paciente { get; set; }
            public double IMC { get; set; }
            public string Diagnostico { get; set; }
        }

        public void AddDiagnostico(DiagnosticoPaciente diagnostico)
        {
            //Código para almacenar el diagnostico en el historial
        }

        public DiagnosticoPaciente[] ObtenerHistorial()
        {
            DiagnosticoPaciente[] diagnosticos = new DiagnosticoPaciente[10];
            return diagnosticos;
        }

    }
}
