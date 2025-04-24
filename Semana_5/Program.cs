using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semana_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ERJERCICIOS l = new ERJERCICIOS();
           
            l.enqueue(1);
            l.enqueue(35);
            l.enqueue(69);
            l.enqueue(3432);
            l.enqueue(23);
            Console.WriteLine(l.ToString());
            Console.WriteLine();

            l.dequeue();
            Console.WriteLine(l.ToString());
            Console.WriteLine();

            l.front();
            Console.WriteLine();

            Console.WriteLine(l.ToString());
            l.size();
            Console.WriteLine();

            l.isEmpty();
            Console.WriteLine();
           

        }
    }
}
