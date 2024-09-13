using System;
using System.Windows.Forms;
using Evaluacion_2.models;
using System.Linq;

namespace Evaluacion_2
{
    public partial class Form1 : Form
    {
        // Crea un programa que pida numeros al usuario, los almacene en un arreglo y sume todos los numeros ingresados hasta que el usuario introduzca un numero negativo. Al igual debe mostrar el mayor y el menor de los numeros ingresados.

        GeneralNumbers numbers = new GeneralNumbers(); // Instancia de la clase
        int index = 0; // Indice para el arreglo
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void AddNumbers()
        {
            try
            {
                int number = int.Parse(tbNumbers.Text);

                if (number < 0)
                {
                    throw new Exception("No se permiten números negativos");
                }

                numbers.AddNumbers(number, index); // Agrega los numeros al arreglo

                index++; // Aumenta el indice
                showNumbers(); // Llama a la funcion
                tbNumbers.Clear(); // Limpia el textbox
                tbNumbers.Focus(); // Se enfoca en el textbox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", // Muestra un mensaje de error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showNumbers()
        {
            try
            {
                lbNumbers.Items.Clear(); // Limpia el listbox
                for (int i = 0; i < index; i++)
                {
                    lbNumbers.Items.Add(numbers.GetNumbers()[(int)i]); 
                }
                int sum = numbers.GetNumbers().Sum(); 
                lblSuma.Text = "Suma: " + sum; 
                // Operacion de suma 
            }
            catch
            {
                MessageBox.Show("No hay numeros", "Error", // Mensaje de error   
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNumbers(); // Llama a la funcion 
        }
    }
}
