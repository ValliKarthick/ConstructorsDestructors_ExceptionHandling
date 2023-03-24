namespace ConstructorsDestructors_ExceptionHandling
{
    public class Employee
    {
        int value = 10;
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeLocation { get; set; }

        public Employee()
        {
             value = 1000;
        }
        public Employee(string name, int id, string location)
        {
            EmployeeName = name;
            EmployeeId = id;
            EmployeeLocation = location;
        }

        ~Employee()
        {
            value = 0;
        }
    }
}
