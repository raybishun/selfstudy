using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cannot create an instance of an abstract class or interfae
            // Animal animal = new Animal();

            Animal animal = new Dog();
            animal.Speak_Abstract();

            Dog dog = new Dog();
            dog.Speak_Abstract();
            dog.Speak_TheChoiceIsYours();
        }
    }
}
