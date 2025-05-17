# Tarea 2 - Tipos Abstractos de Datos en C#

## Objetivo

El objetivo de esta actividad es que los estudiantes apliquen los conocimientos aprendidos en clase sobre tipos abstractos de datos, estructuras TAD como Pilas, Cola lineal y Cola circular mediante la creación de una aplicación sencilla en C#. Se debe identificar un problema simple y proponer su solución programada, promoviendo el análisis lógico, la estructuración del código y la solución efectiva de problemas mediante la programación.

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