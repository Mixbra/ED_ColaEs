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
           
            l.enqueue("Hola ");
            l.enqueue("Profesor");
            l.enqueue("como esta");
            l.enqueue("Bienvenido");
            l.enqueue(" pipipi ");
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
