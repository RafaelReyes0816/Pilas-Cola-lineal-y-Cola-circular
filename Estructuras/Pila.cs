using System;
using System.Collections.Generic;

namespace Tarea_2.Estructuras
{
    // Pila genérica (LIFO)
    public class Pila<T>
    {
        private Stack<T> stack = new Stack<T>();

        public void Push(T item) => stack.Push(item);   // Agrega a la cima
        public T Pop() => stack.Pop();                  // Quita de la cima
        public T Peek() => stack.Peek();                // Consulta la cima
        public bool EstaVacia() => stack.Count == 0;
        public int Contar() => stack.Count;
    }
}