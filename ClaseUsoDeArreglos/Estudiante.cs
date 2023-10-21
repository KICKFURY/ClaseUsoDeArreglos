using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseUsoDeArreglos
{
    internal class Estudiante
    {
        private string[] nombreE;
        private string[] carreraE;

        private static double promedio;

        public string[] NombreE { get; set; }
        public string[] CarreraE { get; set; }

        public Estudiante() { }

        public Estudiante(int i)
        {
            NombreE = new string[i];
            CarreraE = new string[i];
        }

        public void AgregarDatos(string nombre, string carrera, int i)
        {
            NombreE[i] = nombre;
            CarreraE[i] = carrera;
        }

        public static double CalcularPromedio(double sumaNota, int n)
        {
            return Math.Round(promedio = sumaNota / n, 2);
        }
    }
}
