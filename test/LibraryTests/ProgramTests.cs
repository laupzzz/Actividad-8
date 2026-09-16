using NUnit.Framework;
using Ucu.Poo.Exercise;

namespace Ucu.Poo.Exercise
{
    [TestFixture]
    public class CircuitoTests
    {
        [TestCase(false, false, false, ExpectedResult = false)]
        [TestCase(false, false, true,  ExpectedResult = true)]  
        [TestCase(false, true,  false, ExpectedResult = false)]
        [TestCase(false, true,  true,  ExpectedResult = false)]
        [TestCase(true,  false, false, ExpectedResult = false)]
        [TestCase(true,  false, true,  ExpectedResult = false)]
        [TestCase(true,  true,  false, ExpectedResult = false)]
        [TestCase(true,  true,  true,  ExpectedResult = true)]
        public bool ProbarCircuito(bool a, bool b, bool c)
        {
            return Circuito.Calcular(a, b, c);
        }
    }
}