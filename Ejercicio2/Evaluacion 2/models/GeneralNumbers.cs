using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Evaluacion_2.models
{
    internal class GeneralNumbers
    {
        private int[] numbers = new int [25]; // Arreglo de numeros

        public void AddNumbers(int number, int pos)
        {
            numbers[pos] = number; // Se busca en la posicion que se indique 
        }

        public int[] GetNumbers() 
        {
            return numbers; // Retorna el arreglo de numeros
        }
    }
}
