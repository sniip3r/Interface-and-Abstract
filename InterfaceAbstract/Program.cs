using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    class Program
    {
        public interface iAnimal
        {
            void speak();
        }

        class Dog : iAnimal
        {
            public Dog() { }

            public void speak()
            {
                Console.WriteLine("Woof");
            }

            public void hunt()
            {
                Console.WriteLine("Hunt");
            }

        }

        class Cat : iAnimal
        {
            public Cat() { }

            public void speak()
            {
                Console.WriteLine("Meow");
            }

        }

        static void Main(string[] args)
        {
            iAnimal dog = new Dog();
            dog.speak();

            Dog woof = new Dog();
            woof.hunt();

            Cat cat = new Cat();
            cat.speak();

            Console.ReadLine();
        }
    }
}
