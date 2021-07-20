using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Dog
    {
        //Properties
        public string Size { get; set; } //auto-property
        public short Weight { get; set; }
        public string Name { get; set; }

        //Method Signature
        public void Bark()
        {
            Console.WriteLine($"{Name} barks noisily.");
        }

        public void Eat(string typeOfFood)
        {
            if (typeOfFood.ToLower() == "healthy food")
            {
                Weight -= 1;
            }

            Console.WriteLine($"{Name} just ate {typeOfFood}. {Name} weighs {Weight}.");
        }
    }
}
