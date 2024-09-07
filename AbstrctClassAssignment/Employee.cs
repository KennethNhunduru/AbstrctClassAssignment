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
        //Virtual methods may have implementation, but CAN be overriden by the inheriting class.
        /*Since our virtual method in the BASE CLASS Person has no implementation, 
          this method has to have the "override" keyword to be able to override the virtual method.*/
        public override void SayName()
        {
            Console.WriteLine("Your name is " + firstName + " " + lastName);
            Console.ReadLine();
        }
        
    }
}
