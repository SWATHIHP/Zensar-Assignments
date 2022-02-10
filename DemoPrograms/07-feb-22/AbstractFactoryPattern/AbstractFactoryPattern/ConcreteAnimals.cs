using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Cat : Animal
    {
        public string Speak()
        {
            return "Meow Meow";
        }
    }
    public class Dog : Animal
    {
        public string Speak()
        {
            return "Bow Bow";
        }
    }
    public class Lion : Animal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
    public class Octopus : Animal
    {
        public string Speak()
        {
            return "Sweesh";
        }
    }
    public class Shark : Animal
    {
        public string Speak()
        {
            return "Shark can't speak";
        }
    }
    class ConcreteAnimals
    {
    }
}
