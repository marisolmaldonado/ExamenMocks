using System;

namespace RhinoMocks
{
    internal class Nota
    {
        public Nota()
        {
        }

        public bool Aprobo { get; internal set; }
        public bool Reprobo { get; internal set; }
        public bool Remedial { get; internal set; }


        internal void Aprobar(IEstudiante estudiante)
        {
            if (estudiante.PorcentajeNota() >= 0.7)
            {
                this.Aprobo = true;
            }
            if (estudiante.PorcentajeNota() == 0.6)
            {
                this.Remedial = true;
            }

            else
            {
                this.Reprobo = true;
            }
        }
    }
}


