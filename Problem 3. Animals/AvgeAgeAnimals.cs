using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animals
{
    class AvgeAgeAnimals
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog("sharo", 3, "male"),
                new Dog("baro", 5, "male"),
                new Dog("PEPI", 2, "female"),
                new Dog("Keti", 5, "male"),
                new Dog("Sherry", 5, "female"),
                new Dog("Varo", 5, "male")
            };
            List<Cat> cats = new List<Cat>
            {
                new Tomcat("Garfield", 7),
                new Kitten("Amanda", 1),
                new Tomcat("Penio", 5),
                new Kitten("Merry", 2),
                new Tomcat("Ceci", 4),
                new Tomcat("Strashimir", 6),
                new Kitten("Pungerica", 3),
                new Kitten("Sola", 8),
            };
            List<Frog> frogs = new List<Frog>
            {
                new Frog("Maq", 13, "female"),
                new Frog("Genka", 13, "female"),
                new Frog("Ismeralda", 13, "female"),
                new Frog("Raq", 13, "female"),
                new Frog("Grimaldin", 13, "male"),
                new Frog("Petq", 13, "female"),
                new Frog("Donio", 13, "male"),
                new Frog("mario", 13, "male")
            };
            var dogsAverage = dogs.Average(d => d.Age);
            Console.WriteLine("The average age of the dogs is: " + dogsAverage);
            var catsAverage = cats.Average(c => c.Age);
            Console.WriteLine("Cats' average age: " + catsAverage);
            var frogsAverage = frogs.Average(f => f.Age);
            Console.WriteLine(frogsAverage + " is the frogs' average age");
        }
    }
}
