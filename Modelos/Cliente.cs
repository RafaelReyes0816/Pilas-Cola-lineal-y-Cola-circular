namespace Tarea_2.Modelos
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int NumeroTurno { get; set; }

        // Constructor: asigna nombre y turno al cliente
        public Cliente(string nombre, int numeroTurno)
        {
            Nombre = nombre;
            NumeroTurno = numeroTurno;
        }

        // Muestra el cliente en formato "Turno X: Nombre"
        public override string ToString()
        {
            return $"Turno {NumeroTurno}: {Nombre}";
        }
    }
}