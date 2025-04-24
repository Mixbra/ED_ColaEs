using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semana_5
{
    internal class ERJERCICIOS
    {
        Cola primero { get; set; }
        public void enqueue(string dato)
        {
            Cola nuevo = new Cola(dato);
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Cola temp = primero;
                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevo;
            }
        }
        public void dequeue()
        {
            if (primero != null)
            {
                primero = primero.siguiente;
            }
            else
            {
                Console.WriteLine("La cola está vacía");
            }
        }
        public void front()
        {
            Cola temp = primero;
            if (temp == null)
            {
                Console.WriteLine("La cola está vacía");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.dato);// imprime el dato
                    break; // sale del bucle después de imprimir el primer elemento
                }

            }
        }
        public void size()
        {
            Cola temp = primero;
            int contador = 0;
            if (temp == null)
            {
                Console.WriteLine("La cola está vacía");
            }
            else
            {
                while (temp != null)
                {
                    contador++;
                    temp = temp.siguiente;
                }
                Console.WriteLine("El tamaño de la cola es: " + contador);
            }
        }
        public Boolean isEmpty()
        {
            if (primero == null)
            { 
                
                Console.WriteLine("La cola está vacía");
                return true;
              
            }
            else
            {
                Console.WriteLine("La cola no está vacía");
                return false;

               
            }
        }
        public override string ToString()
        {
            Cola temp = primero;
            string resultado = "";
            while (temp != null)
            {
                resultado += temp.dato + " ";
                temp = temp.siguiente;
            }


            return resultado.Trim(); 
        }



    }
}
