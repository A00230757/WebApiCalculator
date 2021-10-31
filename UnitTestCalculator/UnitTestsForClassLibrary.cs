using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCalculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestsForClassLibrary
    {
        [DataTestMethod]
        [DataRow(5, 5, 10)]
        [DataRow(7, 5, 12)]
        [DataRow(1, 9, 10)]
        [DataRow(8, 8, 16)]
        [DataRow(3, 3, 6)]
        [DataRow(6, 30, 36)]
        [DataRow(17, 17, 34)]
        [DataRow(11, 11, 22)]
        [DataRow(65, 12, 77)]
        [DataRow(45, 5, 50)]
        [DataRow(99, 1, 100)]
        public void CheckClassLibrarySolveAdditionChallenge(double number1, double number2, double desiredresult)
        {
            double additionresult;
            additionresult = CalculatorTasks.AdditionTask(number1, number2);
            Assert.AreEqual(desiredresult, additionresult);
        }

        [DataTestMethod]
        [DataRow(5, 5, 0)]
        [DataRow(7, 5, 2)]
        [DataRow(1, 9, 8)]
        [DataRow(8, 8, 0)]
        [DataRow(3, 3, 0)]
        [DataRow(6, 30, 24)]
        [DataRow(17, 17, 0)]
        [DataRow(11, 11, 0)]
        [DataRow(65, 12, 53)]
        [DataRow(45, 5, 40)]
        [DataRow(99, 1, 98)]
        public void CheckClassLibrarySolveSubtractionChallenge(double number1, double number2, double desiredresult)
        {
            double subtractionresult;
            subtractionresult = CalculatorTasks.SubtractionTask(number1, number2);
            Assert.AreEqual(desiredresult, subtractionresult);
        }
    }
}
