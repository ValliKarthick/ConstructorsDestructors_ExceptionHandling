using System;

namespace ConstructorsDestructors_ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter Number 1:");
            //int numberOne = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Number 2:");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());

            //ExceptionHandler exceptionHandler = new ExceptionHandler();
            //exceptionHandler.DivideTwoNumbers(numberOne,numberTwo);

            //Console.WriteLine("Enter amount to withdraw:");
            //int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            //exceptionHandler.CheckIfAmountCanBeWithdrawn(withdrawAmount);

            Employee employee = new Employee();
            Employee firstEmployee = new Employee("abc", 1, "Chennai");
            Employee secondEmployee = new Employee("xyz", 1, "Chennai");

            //firstEmployee.EmployeeName = "Abc";
            //firstEmployee.EmployeeId = 123;
            //firstEmployee.EmployeeLocation = "Chennai";

            //Employee secondEmployee = new Employee();
            //secondEmployee.EmployeeName = "Xyz";
            //secondEmployee.EmployeeId = 456;
            //secondEmployee.EmployeeLocation = "Banglore";

            Console.WriteLine("Name - " + firstEmployee.EmployeeName);
            Console.WriteLine("Name - " + secondEmployee.EmployeeName);

            //ExceptionHandler exceptionHandler = new ExceptionHandler();
            //exceptionHandler.DivideTwoNumbers(4, 0);
            //exceptionHandler.CheckIfAmountCanBeWithdrawn(12000);

            //StatusAlert statusAlert = new StatusAlert();
            //statusAlert.ShowCurrentStatus();

            Console.ReadLine();
        }
    }
}
