using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace RhinoMocks
{
    [TestClass]
    public class TransporteTest
    {
        [TestMethod]
        public void SiLaNotaEsMasDeCeroPuntoSieteAprueba()
        {
            var estudiante = MockRepository.GenerateStub<IEstudiante>();
            estudiante.Stub(e => e.PorcentajeNota()).Return(0.7);

            var nota = new Nota();
            nota.Aprobar(estudiante);

            Assert.IsTrue(nota.Aprobo);
            estudiante.AssertWasCalled(t => t.PorcentajeNota());
        }

        public void SiLaNotaEsmenorDeCeroPuntoSieteAprueba()
        {
            {
                var estudiante = MockRepository.GenerateStub<IEstudiante>();
                estudiante.Stub(e => e.PorcentajeNota()).Return(0.5);

                var nota = new Nota();
                nota.Aprobar(estudiante);

                Assert.IsTrue(nota.Reprobo);
                estudiante.AssertWasCalled(t => t.PorcentajeNota());
            }

        }

        public void SiLaNotaEsIgualASeisRemedial()
        {
            {
                var estudiante = MockRepository.GenerateStub<IEstudiante>();
                estudiante.Stub(e => e.PorcentajeNota()).Return(0.6);

                var nota = new Nota();
                nota.Aprobar(estudiante);

                Assert.IsTrue(nota.Remedial);
                estudiante.AssertWasCalled(t => t.PorcentajeNota());
            }

            

        }
    }
}
