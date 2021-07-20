using System;
using PetStore.Pets;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var benny = new Dog();
            benny.Name = "benny";
            benny.Size = "Large";
            benny.Weight = 110;
            benny.Eat("healthy food");

            var gatsby = new Dog();
            gatsby.Name = "gatsby";
            gatsby.Size = "large";
            gatsby.Weight = 90;
            gatsby.Bark();

        }
    }
}
