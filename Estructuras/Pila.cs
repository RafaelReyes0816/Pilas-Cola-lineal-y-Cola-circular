using System;
using System.Collections.Generic;

namespace Tarea_2.Estructuras
{
    // Pila genérica (LIFO)
    public class Pila<T>
    {
        private Stack<T> stack = new Stack<T>();

        public void Push(T item) => stack.Push(item);
        public T Pop() => stack.Pop();
        public T Peek() => stack.Peek();
        public bool EstaVacia() => stack.Count == 0;
        public int Contar() => stack.Count;
    }
}