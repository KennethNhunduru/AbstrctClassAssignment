using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrctClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside the Main() method, instantiating an Employee object with firstName “Sample” and lastName “Student”.
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
           
            //Calling the SayName() method on the object.
            employee.SayName();
        }
    }
}
