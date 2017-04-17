using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            //var firstCat = new Cat();
            //var secondCat = new Cat();
            //var thirdCat = new Cat()
            //{
            //    Name = "Goshe",
            //    Age = 4,
            //    Color = "Red",
            //    Gender = "Male"         
            //};

            //firstCat.Name = "Ivan";
            //firstCat.Age = 12;
            //firstCat.Color = "Black";
            //firstCat.Gender = "Famale";
            //secondCat.Name = "Pesho";
            //secondCat.Age = 15;
            //secondCat.Color = "Grey";
            //secondCat.Gender = "Male";

            //Console.WriteLine(secondCat.Name);
            //Console.WriteLine(secondCat.Age);
            //Console.WriteLine(secondCat.Color);
            //Console.WriteLine(secondCat.Gender);

            //Console.WriteLine(secondCat.SaySomething("Zdr kopr") + "my name is " + secondCat.Name);

            //Console.WriteLine(firstCat.SayHello());


            //Console.WriteLine(thirdCat.SayHello());



            //var dog = new Dog()
            //{
            //    Name = "Goshe",
            //    Breed = "Male",
            //    IsAsleep = false,
            //    HasEatern = false
            //};

            //var cat = new Cat
            //{
            //    Name = "Maria",
            //    Age = 4
            //};
            ////dog.Eat(cat);
            //dog.GoToSleep();
            //Console.WriteLine(dog.IsAsleep);


            var newDog = new Dog();

            newDog.Birthday = new DateTime(1990, 1, 1);
            Console.WriteLine(newDog.Age);

        }

    }
}
