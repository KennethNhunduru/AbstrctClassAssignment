using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrctClassAssignment
{
    //Creating another class called Employee that inherits from the Person class.
    public class Employee : Person
    {
        //Implementing the SayName() method inside of the Employee class.
        //In order to satisfy the requirement of the abstract SayName() method in the BASE CLASS (Person class),
        //we will define the SayName() method in the Employee class with the "override" keyword.

        public override void SayName()
        {
            Console.WriteLine("Your name is " + firstName + " " + lastName);
            Console.ReadLine();
        }
        
    }
}
