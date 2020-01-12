using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EX_03
{
    class Police : Person, Speak.ISpeak
    {
        //delegate instantiation
        delegate void Del(string str);

        //private anonymous method instantiation
        private Del Del1 = delegate(string message) { Console.WriteLine("Police! Open up!"); };

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
