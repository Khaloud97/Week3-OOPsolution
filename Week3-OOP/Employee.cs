

using System.Xml.Linq;

namespace Week3_OOP
{
     class Employee
    {
        
        public string FName;
        public string LName;
        public int age;
        public decimal Salary;


        //constacter ==> is have same name of my class it can be empty || or have variable
        public Employee()
        {
            //empty constacter
        }
        // ctor + tab ==> اختصار 


        public Employee(string _FName, string _LName, int age )
        {
            // constacter with vairable
            FName = _FName;
            LName = _LName;
          
            this.age = age;
            // we use this before it to now wich ne is from class and other one from constacter


        }

    }

}
