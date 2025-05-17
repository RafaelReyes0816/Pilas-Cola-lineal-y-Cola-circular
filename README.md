# Tarea 2 - Tipos Abstractos de Datos en C#

Este proyecto es una aplicación de consola en C# que ejemplifica el uso de **estructuras de datos abstractas** (TAD) como **Cola Lineal**, **Pila** y **Cola Circular**. Cada estructura está encapsulada en su propia clase y se integra en un menú interactivo para demostrar su funcionamiento.

---

## Estructuras implementadas

- **Cola Lineal (FIFO):**  
  Simula la gestión de reportes de soporte técnico, donde los problemas se atienden en orden de llegada.

- **Pila (LIFO):**  
  Permite apilar y desapilar elementos, mostrando el comportamiento típico de una pila.

- **Cola Circular (FIFO con capacidad fija):**  
  Permite encolar y desencolar elementos reutilizando el espacio, ideal para buffers o recursos limitados.

---

## Estructura del proyecto

```
Tarea-2/
│
├── Program.cs
├── Modelos/
│   ├── Cliente.cs
│   └── ReporteSoporte.cs
└── Estructuras/
    ├── Cola.cs
    ├── Pila.cs
    └── ColaCircular.cs
```

---

## ¿Cómo usar?

1. **Compilar y ejecutar:**
   ```bash
   dotnet run
   ```

2. **Menú principal:**
   - Gestionar Cola Lineal (Soporte Técnico)
   - Gestionar Pila (Stack)
   - Gestionar Cola Circular
   - Salir

3. **Cada estructura tiene su propio submenú** para realizar operaciones como agregar, quitar, consultar elementos y ver la cantidad de elementos.

---

## Validaciones y buenas prácticas

- El programa valida entradas incorrectas y muestra mensajes claros al usuario.
- No permite quitar elementos de estructuras vacías ni agregar en la cola circular si está llena.
- El código está organizado, comentado y utiliza nombres descriptivos.

---

## Créditos

Desarrollado por Juan Rafael Reyes Burgos para la materia de Estructuras de Datos.

---

**¡Explora el código y experimenta con las estructuras!**