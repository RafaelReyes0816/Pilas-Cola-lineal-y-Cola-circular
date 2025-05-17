using System.Collections.Generic;

namespace Tarea_2.Estructuras
{
    // Cola genérica (FIFO)
    public class Cola<T>
    {
        private Queue<T> queue = new Queue<T>();

        public void Encolar(T elemento) => queue.Enqueue(elemento); // Agrega al final
        public T Desencolar() => queue.Dequeue();                   // Quita del frente
        public T VerFrente() => queue.Peek();                       // Consulta el frente
        public bool EstaVacia() => queue.Count == 0;
        public int Contar() => queue.Count;
    }
}