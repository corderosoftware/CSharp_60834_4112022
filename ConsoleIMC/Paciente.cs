using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIMC
{
    //Creando un nuevo tipo de Dato
    public class Paciente
    {

        //Contiene miembros
        /*
         * Campos (fields) (variables, atributos)
         * Constantes
         * Propiedades
         * Métodos (definen el comportamiento que tendra la clase)
         * 
        */

        //Campos (Encapsulación)
        private string _nroDoc;
        //private string _nombreApellido;
        //private string _Direccion;
        //private char _Genero;
        //private double _Peso = 0;
        //private double _Altura = 0;

        //Propiedad (Estilo C#)
        public string NroDoc
        {
            get
            {
                return _nroDoc;
            }

            set
            {
                //Validación
                _nroDoc = value;
            }
        }
        //public string NroDoc { get; set; } //Propiedad automaticamenteimplementada
        public string NombreApellido { get; set; }
        //public string NombreApellido { get => _nombreApellido; set => _nombreApellido = value; }
        public string Direccion { get; set; }
        public char Genero { get; set; } = 'F';
        public double Peso { get; set; }
        public double Altura { get; set; }


        //Estilo Java (Getters y Setters)
        //public string GetNroDoc()
        //{
        //    return NroDoc;
        //}

        //public void SetNroDoc(string nroDoc)
        //{
        //    this.NroDoc = nroDoc;
        //}

        public string ShowData()
        {
            return "Paciente" + Environment.NewLine + "--------" +
                Environment.NewLine + NombreApellido + 
                Environment.NewLine + _nroDoc + Environment.NewLine+
                "Genero: " + Genero;

        }
    }
}
