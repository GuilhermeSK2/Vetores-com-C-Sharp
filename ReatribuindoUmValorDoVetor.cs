using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresCS
{
    internal class ReatribuindoUmValorDoVetor
    {
        public static void Main(string[] args)
        {
            string[] carros = { "Volvo", "BMW", "Ford", "Mazda" };
            carros[0] = "Opel"; //Reatibuição do valor do elemento da posição "0".
            Console.WriteLine(carros[0]); //Esta linha diz para o programa imprimir o elemento da posição "0", antes seu valor era "Volvo", agora é "Opel".
        }
    }
}
