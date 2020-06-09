using System;

namespace AbstractClasses
{
    abstract class Animal
    {
        public int MyProperty { get; set; }

        public Animal()
        {
            
        }

        void Speak_Private() 
        { 
            // Implementation here... 
        }

        public void Speak_Public()
        {
            // Implementation here... 
        }

        // Methods marked as abstract:
        // - cannot declare a body
        // - must explicitly use the public keyword
        // - and must be implemented in derived classes (using the override keyword)
        public abstract void Speak_Abstract();

        public virtual void Speak_TheChoiceIsYours()
        {
            Console.WriteLine("Optionally replace this implementation...");
        }
    }
}
