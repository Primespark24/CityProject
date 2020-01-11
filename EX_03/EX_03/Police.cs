using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    class Police : Person, Speak.ISpeak
    {
        // base constuctor for police inherited from Person
        public Police() : base() { }

        // constuctor for police inherited from Person
        public Police(string nameInput) : base(nameInput) { }

        //Police message using speak function
        public void speak()
        {
            Console.WriteLine("Its the sound of the Police Woop Woop");
        }
    }
}
