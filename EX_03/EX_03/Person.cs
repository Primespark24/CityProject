using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    class Person : Speak.ISpeak
    {
        private string name;
        public Person()
        {
            name = "John Doe";
        }

        public Person(string nameInput)
        {
            name = nameInput;
        }

        public string GetName()
        {
            return name;
        }

        public void speak() { }
    }
}
