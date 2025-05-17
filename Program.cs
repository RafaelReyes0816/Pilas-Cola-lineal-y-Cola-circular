using System;
using Tarea_2.Modelos;
using Tarea_2.Estructuras;

namespace Tarea_2
{
    class Program
    {
        static void Main()
        {
            int opcionPrincipal;
            do
            {
                Console.Clear();
                // Menú principal para elegir la estructura a gestionar
                Console.WriteLine("=== Menú Principal ===");
                Console.WriteLine("1. Gestionar Cola Lineal (Banco)");
                Console.WriteLine("2. Gestionar Pila (Stack)");
                Console.WriteLine("3. Gestionar Cola Circular");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string? entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out opcionPrincipal) || opcionPrincipal < 1 || opcionPrincipal > 4)
                {
                    Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                // Llama al submenú correspondiente según la opción elegida
                switch (opcionPrincipal)
                {
                    case 1:
                        MenuColaLineal();
                        break;
                    case 2:
                        MenuPila();
                        break;
                    case 3:
                        MenuColaCircular();
                        break;
                    case 4:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                }
            } while (opcionPrincipal != 4);
        }

        // Submenú para la Cola Lineal (FIFO)
        static void MenuColaLineal()
        {
            Cola<ReporteSoporte> colaSoporte = new Cola<ReporteSoporte>();
            int contadorReportes = 1;
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Gestión de Soporte Técnico (Cola Lineal) ===");
                Console.WriteLine("1. Reportar un problema");
                Console.WriteLine("2. Atender el siguiente reporte");
                Console.WriteLine("3. Ver el siguiente reporte");
                Console.WriteLine("4. Mostrar cantidad de reportes en espera");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Opción elegida (1-5): ");
                string? entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Por favor, ingrese un número válido entre 1 y 5.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del usuario: ");
                        string? usuario = Console.ReadLine();
                        Console.Write("Describa el problema: ");
                        string? problema = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(problema))
                        {
                            Console.WriteLine("El usuario y el problema no pueden estar vacíos.");
                        }
                        else
                        {
                            var nuevoReporte = new ReporteSoporte(usuario.Trim(), problema.Trim(), contadorReportes++);
                            colaSoporte.Encolar(nuevoReporte);
                            Console.WriteLine($"Reporte agregado: {nuevoReporte}");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:
                        if (!colaSoporte.EstaVacia())
                        {
                            var atendido = colaSoporte.Desencolar();
                            Console.WriteLine($"Atendiendo: {atendido}");
                        }
                        else
                        {
                            Console.WriteLine("No hay reportes en espera.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        if (!colaSoporte.EstaVacia())
                        {
                            var siguiente = colaSoporte.VerFrente();
                            Console.WriteLine($"Siguiente reporte: {siguiente}");
                        }
                        else
                        {
                            Console.WriteLine("No hay reportes en espera.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 4:
                        int cantidad = colaSoporte.Contar();
                        if (cantidad == 0)
                            Console.WriteLine("No hay reportes en espera.");
                        else if (cantidad == 1)
                            Console.WriteLine("Hay 1 reporte en espera.");
                        else
                            Console.WriteLine($"Hay {cantidad} reportes en espera.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 5);
        }

        // Submenú para la Pila (LIFO)
        static void MenuPila()
        {
            Pila<string> pila = new Pila<string>();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Gestión de Pila (Stack) ===");
                Console.WriteLine("1. Apilar (Push)");
                Console.WriteLine("2. Desapilar (Pop)");
                Console.WriteLine("3. Ver elemento en la cima (Peek)");
                Console.WriteLine("4. Mostrar cantidad de elementos");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Opción elegida (1-5): ");
                string? entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Por favor, ingrese un número válido entre 1 y 5.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        // Apila un elemento en la pila
                        Console.Write("Ingrese el elemento a apilar: ");
                        string? elemento = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(elemento))
                        {
                            Console.WriteLine("El elemento no puede estar vacío.");
                        }
                        else
                        {
                            pila.Push(elemento.Trim());
                            Console.WriteLine($"Elemento '{elemento.Trim()}' apilado.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        // Desapila el elemento en la cima
                        if (!pila.EstaVacia())
                        {
                            string desapilado = pila.Pop();
                            Console.WriteLine($"Elemento desapilado: {desapilado}");
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        // Muestra el elemento en la cima sin desapilarlo
                        if (!pila.EstaVacia())
                        {
                            string cima = pila.Peek();
                            Console.WriteLine($"Elemento en la cima: {cima}");
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        // Muestra la cantidad de elementos en la pila
                        Console.WriteLine($"Cantidad de elementos en la pila: {pila.Contar()}");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 5);
        }

        // Submenú para la Cola Circular (FIFO con capacidad fija)
        static void MenuColaCircular()
        {
            int capacidad = 5; // Capacidad máxima de la cola circular
            ColaCircular<string> colaCircular = new ColaCircular<string>(capacidad);
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Gestión de Cola Circular ===");
                Console.WriteLine("1. Encolar elemento");
                Console.WriteLine("2. Desencolar elemento");
                Console.WriteLine("3. Ver elemento al frente");
                Console.WriteLine("4. Mostrar cantidad de elementos");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Opción elegida (1-5): ");
                string? entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Por favor, ingrese un número válido entre 1 y 5.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        // Encola un elemento si la cola no está llena
                        if (colaCircular.EstaLlena())
                        {
                            Console.WriteLine("La cola circular está llena. No se pueden agregar más elementos.");
                        }
                        else
                        {
                            Console.Write("Ingrese el elemento a encolar: ");
                            string? elemento = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(elemento))
                            {
                                Console.WriteLine("El elemento no puede estar vacío.");
                            }
                            else
                            {
                                colaCircular.Encolar(elemento.Trim());
                                Console.WriteLine($"Elemento '{elemento.Trim()}' encolado.");
                            }
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        // Desencola un elemento si la cola no está vacía
                        if (!colaCircular.EstaVacia())
                        {
                            string desencolado = colaCircular.Desencolar();
                            Console.WriteLine($"Elemento desencolado: {desencolado}");
                        }
                        else
                        {
                            Console.WriteLine("La cola circular está vacía.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        // Muestra el elemento al frente sin desencolarlo
                        if (!colaCircular.EstaVacia())
                        {
                            string frente = colaCircular.VerFrente();
                            Console.WriteLine($"Elemento al frente: {frente}");
                        }
                        else
                        {
                            Console.WriteLine("La cola circular está vacía.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        // Muestra la cantidad de elementos en la cola circular
                        Console.WriteLine($"Cantidad de elementos en la cola circular: {colaCircular.Contar()}");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 5);
        }
    }
}