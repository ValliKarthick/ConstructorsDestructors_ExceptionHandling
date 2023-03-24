using System;
using System.CodeDom;

namespace ConstructorsDestructors_ExceptionHandling
{
    public class ExceptionHandler
    {
        public void DivideTwoNumbers(int NumberOne, int NumberTwo)
        {
            double result;
            try
            {
                //try
                //{

                //}
                //catch
                //{

                //}
                //finally
                //{

                //}
                result = NumberOne / NumberTwo;
                Console.WriteLine("Result - " + result);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Dont divide by 0");
            }
            //finally
            //{
            //    Console.WriteLine("Finally Block Here.");
            //}
        }

        public void CheckIfAmountCanBeWithdrawn(int withDrawAmount)
        {
            int balance = 5000;
            if (withDrawAmount > balance)
            {
                throw new ArithmeticException("Insufficient Balance");
            }
            else
            {
                Console.WriteLine("You have enough balance to withdraw..");
            }
        }
    }
}
