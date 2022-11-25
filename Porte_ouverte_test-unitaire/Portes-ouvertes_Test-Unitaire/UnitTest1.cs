using Methods;

namespace Portes_ouvertes_Test_Unitaire
{
    [TestClass]
    public class Test
    {
        int a = 10;
        int b = 2;
        Method x = new Method();

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(12, x.Addition(a, b));
        }

        [TestMethod]
        public void TestSubstraction()
        {
            
            Assert.AreEqual(8, x.Substraction(a, b));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(20, x.Multiplication(a, b));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(5, x.Division(a, b));
        }

        [TestMethod]
        public void TestAverage()
        {
            List<int> numbers = new List<int>();

            for(int i = 0; i < a; i++)
            {
                numbers.Add(i);
            }
            Assert.AreEqual(4,5, x.Average(numbers));
        }
    }
}