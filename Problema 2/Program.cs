using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutos,minuto1,horas;
            Console.WriteLine("Ingrese la cantidad de minutos: ");
            minutos = int.Parse(Console.ReadLine());
            horas = minutos / 60;
            minuto1 =horas % 60;
            Console.WriteLine("A continuacion mostraremos las horas y minutos que quedaron");
            Console.WriteLine($"{minutos} minutos son {horas} horas y {minuto1} minutos.");
            Console.ReadKey();
        }
    }
}
