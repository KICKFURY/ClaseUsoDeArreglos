using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseUsoDeArreglos
{
    internal class Asignatura
    {
        private string[] nombreA;
        private double[] nota;
        private double notaasig;

        public string[] NombreA { get; set; }
        public double[] Nota { get; set; }

        public Asignatura() { }

        public Asignatura(int n)
        {
            NombreA = new string[n];
            Nota = new double[n];
        }

        public void AgregarDatos(string nombreAsig, int i)
        {
            NombreA[i] = nombreAsig;
            Nota[i] = notaasig;
        }

        public void CalcularNota(int acumulado, int examen)
        {
            notaasig = acumulado + examen;
        }
    }
}
