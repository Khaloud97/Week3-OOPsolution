

using System.Xml.Linq;

namespace Week3_OOP
{
     class Employee
    {
        
        public string FName;
        public string LName;
        public int age;
        public decimal Salary;

        //constacter ==> is have same name of my class 
        public Employee()
        {

        }

        public Employee(string _FName, string _LName, int _age)
        {
          FName = _FName;
          LName = _LName;
          age = _age;

        } 

    }

}
