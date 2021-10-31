using System;

namespace ClassLibraryCalculator
{
    public class CalculatorTasks
    {
        public static double AdditionTask(double number1, double number2)//this task of class library accept
                                                                         //two numbers of double data type and return their sum
        {
            return number1 + number2;
        }
        public static double SubtractionTask(double number1, double number2)//this task of class library accept
                                                                         //two numbers of double data type and check which number is greater
                                                                         //amd then subtract them and return the result
        {
            double answer=0;
            if( number1>number2)
            {
               answer = number1-number2;
            }
            else
            {
                answer = number2-number1;
            }
            return answer;
        }
        public static double MultiplicationTask(double number1, double number2)//this task of class library accept
                                                                         //two numbers of double data type and return their product
        {
            return number1 * number2;
        }
    }
}
