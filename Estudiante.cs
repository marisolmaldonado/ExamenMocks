using RhinoMocks;
using System;

namespace PruebaRinoMarisol
{
    internal class Estudiante: IEstudiante
    {
        public Estudiante()
        {
        }

    public double notaIni { get; internal set; }
    public double promedio { get; private set; }

        
        public void Aprobar(IEstudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public double PorcentajeNota()
        {
            return notaIni / promedio;
        }
    }
}
