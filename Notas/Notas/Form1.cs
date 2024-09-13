using Notas.calcular;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        // Arreglo para almacenar hasta 1000
        private Estudiante[] estudiantes;
        private int contadorEstudiantes;
        public Form1()
        {
            InitializeComponent();
            estudiantes = new Estudiante[1000];
            contadorEstudiantes = 0; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text.Trim();
            double nota;

            // Validamos el nombre.
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            // Aqui se valida la nota 
            if (!double.TryParse(txtGrade.Text, out nota) || nota < 0 || nota > 100)
            {
                MessageBox.Show("Ingrese una nota válida (0 - 100).");
                return;
            }

            // Verificamos que no se exceda el límite de 1000 estudiantes.
            if (contadorEstudiantes >= 1000)
            {
                MessageBox.Show("Se ha alcanzado el número máximo de estudiantes (1000).");
                return;
            }

            // Agregamos el estudiante al arreglo.
            estudiantes[contadorEstudiantes] = new Estudiante(nombre, nota);
            contadorEstudiantes++;

            // Funcion para limpiar los cuadros de texto
            txtName.Clear();
            txtGrade.Clear();

            // Funcion para calcular los primeros lugares
            MostrarEstadisticas();
        }
        private void MostrarEstadisticas()
        {
            if (contadorEstudiantes == 0)
            {
                MessageBox.Show("No hay estudiantes registrados.");
                return;
            }

            // Promedio
            double suma = 0;
            for (int i = 0; i < contadorEstudiantes; i++)
            {
                suma += estudiantes[i].Nota;
            }

            double promedio = suma / contadorEstudiantes;
            lblGrade.Text = "Promedio: " + promedio.ToString("F2");

            // Estudiantes en su respectivo orden 
            Estudiante[] estudiantesOrdenados = new Estudiante[contadorEstudiantes];
            Array.Copy(estudiantes, estudiantesOrdenados, contadorEstudiantes);
            Array.Sort(estudiantesOrdenados, (a, b) => b.Nota.CompareTo(a.Nota));

           
            lblFirstPlace.Text = "1er Lugar: " + estudiantesOrdenados[0].Nombre + " - Nota: " + estudiantesOrdenados[0].Nota;
            lblSecondPlace.Text = (contadorEstudiantes > 1) ? "2do Lugar: " + estudiantesOrdenados[1].Nombre + " - Nota: " + estudiantesOrdenados[1].Nota : "2do Lugar: N/A";
            lblThirdPlace.Text = (contadorEstudiantes > 2) ? "3er Lugar: " + estudiantesOrdenados[2].Nombre + " - Nota: " + estudiantesOrdenados[2].Nota : "3er Lugar: N/A"; //Se muestran los primeros lugares
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
