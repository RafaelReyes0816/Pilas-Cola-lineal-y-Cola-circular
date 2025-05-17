namespace Tarea_2.Modelos
{
    public class ReporteSoporte
    {
        public string Usuario { get; set; }
        public string Problema { get; set; }
        public int NumeroReporte { get; set; }

        public ReporteSoporte(string usuario, string problema, int numeroReporte)
        {
            Usuario = usuario;
            Problema = problema;
            NumeroReporte = numeroReporte;
        }

        public override string ToString()
        {
            return $"Reporte {NumeroReporte}: {Usuario} - {Problema}";
        }
    }
}