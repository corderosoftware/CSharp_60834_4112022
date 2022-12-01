using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Services
{
    public class Validaciones
    {
        public string NombreRequerido(string valor)
        {
            return valor.Length > 0 ? null : "El Nombre y el Apellido son requeridos";
        }

        public string PesoRequerido(string valor)
        {
            double peso;
            return double.TryParse(valor, out peso) == true ? null : "El Peso es requerido";
        }

    }
}
