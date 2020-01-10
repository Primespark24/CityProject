using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    class Police : Person, Speak.ISpeak
    {
        public Police() : base() { }
        public Police(string nameInput) : base(nameInput) { }

        public void speak()
        {
            Console.WriteLine("Its the sound of the Police Woop Woop");
        }
    }
}
