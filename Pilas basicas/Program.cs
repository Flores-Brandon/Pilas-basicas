using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_basicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Stack para representar una pila
            Stack<int> pila = new Stack<int>();

            // Apilar elementos en la pila
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);

            // Mostrar el contenido de la pila
            Console.WriteLine("Elementos en la pila:");
            foreach (int elemento in pila)
            {
                Console.WriteLine(elemento); // Debe imprimir 5, 4, 3, 2, 1 en ese orden
            }

            // Desapilar un elemento de la pila
            int elementoDesapilado = pila.Pop();
            Console.WriteLine("\nElemento desapilado: " + elementoDesapilado); // Debe imprimir 5

            // Mostrar el elemento superior de la pila sin desapilarlo
            int elementoSuperior = pila.Peek();
            Console.WriteLine("Elemento superior de la pila: " + elementoSuperior); // Debe imprimir 4
        }
    }
}
