using System;

namespace Tarea_2.Estructuras
{
    // Cola Circular genérica (FIFO con capacidad fija)
    public class ColaCircular<T>
    {
        private T[] elementos;
        private int frente, final, cantidad, capacidad;

        public ColaCircular(int capacidad)
        {
            this.capacidad = capacidad;
            elementos = new T[capacidad];
            frente = 0;
            final = -1;
            cantidad = 0;
        }

        public bool EstaVacia() => cantidad == 0;
        public bool EstaLlena() => cantidad == capacidad;

        public void Encolar(T item)
        {
            if (EstaLlena())
                throw new InvalidOperationException("La cola circular está llena.");
            final = (final + 1) % capacidad; // Movimiento circular
            elementos[final] = item;
            cantidad++;
        }

        public T Desencolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola circular está vacía.");
            T valor = elementos[frente];
            frente = (frente + 1) % capacidad; // Movimiento circular
            cantidad--;
            return valor;
        }

        public T VerFrente()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola circular está vacía.");
            return elementos[frente];
        }

        public int Contar() => cantidad;
    }
}