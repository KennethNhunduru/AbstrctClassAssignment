using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrctClassAssignment
{
    //Creating an ABSTRACT/BASE class called Person with two properties: string firstName and string lastName.
    //Abstract classes can only be INHERITED FROM but can NEVER BE INSTANTIATED.
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Giving it the method SayName().
        /*Since the SayName method is only implemented in the Employee class, this method has to have the 
          keyword "virtual" which means the method gets inherited by the inheriting class, but the inheriting class
          will have the ability to override the virtual method.*/
        public virtual void SayName()
        {            
        }
    }
}
