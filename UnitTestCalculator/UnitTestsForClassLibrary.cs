using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCalculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestsForClassLibrary
    {

        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod1()
        {
            double additionresult;
            additionresult = CalculatorTasks.AdditionTask(0,20);
            Assert.AreEqual(20, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod2()
        {
            double additionresult;
            additionresult = CalculatorTasks.AdditionTask(20, 0);
            Assert.AreEqual(20, additionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveAdditionChallengeTestMethod3()
        {
            double additionresult;
            additionresult = CalculatorTasks.AdditionTask(20, 20);
            Assert.AreEqual(40, additionresult);
        }

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
        public void CheckClassLibrarySolveAdditionChallengeDataTestMethod(double number1, double number2, double desiredresult)
        {
            double additionresult;
            additionresult = CalculatorTasks.AdditionTask(number1, number2);
            Assert.AreEqual(desiredresult, additionresult);
        }

        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod1()
        {
            double subtractionresult;
            subtractionresult = CalculatorTasks.SubtractionTask(0, 30);
            Assert.AreEqual(-30, subtractionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod2()
        {
            double subtractionresult;
            subtractionresult = CalculatorTasks.SubtractionTask(30, 0);
            Assert.AreEqual(30, subtractionresult);
        }

        [TestMethod]
        public void CheckClassLibrarySolveSubtractionChallengeTestMethod3()
        {
            double subtractionresult;
            subtractionresult = CalculatorTasks.SubtractionTask(30, 30);
            Assert.AreEqual(0, subtractionresult);
        }


        [DataTestMethod]
        [DataRow(5, 5, 0)]
        [DataRow(7, 5, 2)]
        [DataRow(1, 9, -8)]
        [DataRow(8, 8, 0)]
        [DataRow(3, 3, 0)]
        [DataRow(6, 30, -24)]
        [DataRow(17, 17, 0)]
        [DataRow(11, 11, 0)]
        [DataRow(65, 12, 53)]
        [DataRow(45, 5, 40)]
        [DataRow(99, 1, 98)]
        public void CheckClassLibrarySolveSubtractionChallengeDataTestMethod(double number1, double number2, double desiredresult)
        {
            double subtractionresult;
            subtractionresult = CalculatorTasks.SubtractionTask(number1, number2);
            Assert.AreEqual(desiredresult, subtractionresult);
        }

        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod1()
        {
            double multiplicationresult;
            multiplicationresult = CalculatorTasks.MultiplicationTask(0, 40);
            Assert.AreEqual(0, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod2()
        {
            double multiplicationresult;
            multiplicationresult = CalculatorTasks.MultiplicationTask(40, 0);
            Assert.AreEqual(0, multiplicationresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveMultiplicationChallengeTestMethod3()
        {
            double multiplicationresult;
            multiplicationresult = CalculatorTasks.MultiplicationTask(40, 40);
            Assert.AreEqual(1600, multiplicationresult);
        }

        [DataTestMethod]
        [DataRow(5, 5, 25)]
        [DataRow(7, 5, 35)]
        [DataRow(1, 9, 9)]
        [DataRow(8, 8, 64)]
        [DataRow(3, 3, 9)]
        [DataRow(6, 30, 180)]
        [DataRow(17, 17, 289)]
        [DataRow(11, 11, 121)]
        [DataRow(65, 12, 780)]
        [DataRow(45, 5, 225)]
        [DataRow(99, 1, 99)]
        public void CheckClassLibrarySolveMultiplicationChallengeDataTestMethod(double number1, double number2, double desiredresult)
        {
            double multiplicationresult;
            multiplicationresult = CalculatorTasks.MultiplicationTask(number1, number2);
            Assert.AreEqual(desiredresult, multiplicationresult);
        }

        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod1()
        {
            double divisionresult;
            divisionresult = CalculatorTasks.DivisionTask(0, 50);
            Assert.AreEqual(0, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod2()
        {
            double divisionresult;
            divisionresult = CalculatorTasks.DivisionTask(50, 0);
            Assert.AreEqual(-1, divisionresult);
        }
        [TestMethod]
        public void CheckClassLibrarySolveDivisionChallengeTestMethod3()
        {
            double divisionresult;
            divisionresult = CalculatorTasks.DivisionTask(50, 50);
            Assert.AreEqual(1, divisionresult);
        }

        [DataTestMethod]
        [DataRow(5, 5, 1)]
        [DataRow(7, 5, 1.4)]
       [DataRow(40, 4, 10)]
        [DataRow(121, 11, 11)]
        [DataRow(336, 12, 28)]
       [DataRow(6, 30, 0.2)]
        [DataRow(225, 15, 15)]
        [DataRow(220, 4, 55)]
        [DataRow(60, 12, 5)]
        [DataRow(45, 5, 9)]
        [DataRow(99, 1, 99)]
        public void CheckClassLibrarySolveDivisionChallengeDataTestMethod(double number1, double number2, double desiredresult)
        {
            double divisionresult;
            divisionresult = CalculatorTasks.DivisionTask(number1, number2);
            Assert.AreEqual(desiredresult, divisionresult);
        }
    }
}
