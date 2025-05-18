using System.Collections.Generic;

namespace Tarea_2.Estructuras
{
    // Cola genérica (FIFO)
    public class Cola<T>
    {
        private Queue<T> queue = new Queue<T>();

        public void Encolar(T elemento) => queue.Enqueue(elemento);
        public T Desencolar() => queue.Dequeue();
        public T VerFrente() => queue.Peek();
        public bool EstaVacia() => queue.Count == 0;
        public int Contar() => queue.Count;
    }
}