namespace Week3_OOP
{
    class Program
    {

        static decimal NetSalary(int tWorking ,decimal Wege)
        {
            decimal toSal = (tWorking * Wege);
             decimal texSal= toSal * 0.3m;
            

           // int reSalary = int.Parse(netSal);
                return toSal - texSal;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello,To our system!");


            Employee emp = new Employee();
            Employee emp1 = new Employee("Khaloud","Hamed",26);
            Employee emp2 = new Employee("Ali","Mohammed",21);

            Employee[] employees = { emp,emp1,emp2 };
            foreach(Employee emps in employees)
            {
                Console.WriteLine($"I am {emps.FName} , {emps.LName} ,my age is {emps.age}");

            }



            Console.WriteLine("---------------------------------------");
            Console.Write("Enter Your first Name: ");
            emp.FName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            emp.LName = Console.ReadLine();

            Console.Write("Enter Your age: ");
            emp.age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your time of Working: ");
            int tWorking = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Salary of one time: ");
            decimal Wege = int.Parse(Console.ReadLine());
            emp.Salary = NetSalary(tWorking, Wege);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Employee System");
            Console.WriteLine($"Hi {emp.FName} , your Salary is {emp.Salary}");




        }
    }
}