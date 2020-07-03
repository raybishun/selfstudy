using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Dog : Animal
    {
        public override void Speak_Abstract()
        {
            Console.WriteLine("grr");
        }

        public override void Speak_TheChoiceIsYours()
        {
            Console.WriteLine("Dog's implementation of Speak_TheChoiceIsYours()");
        }
    }
}
