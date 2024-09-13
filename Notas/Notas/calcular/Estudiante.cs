using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas.calcular
{
    internal class Estudiante
    {
        //Almacenar estudiantes
        public string Nombre { get; set; }

        //Almacena nota del estudiante
        public double Nota { get; set; }

        // Constructor de nombre y nota
        public Estudiante(string nombre, double nota)
        {
            Nombre = nombre;
            Nota = nota;
        }
    }
}
