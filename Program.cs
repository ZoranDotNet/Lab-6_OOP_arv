using System.Data;

namespace OOP_arv
{//Zoran Matovic NET23
    internal class Program
    {
        static void Main(string[] args)
        {

            //Make a List of Animal so we can loop and call all methods
            List<Animal> myAnimals = new List<Animal>();


            //create objects
            Dog dog1 = new Dog();
            Chihuahua dog2 = new Chihuahua();
            Labrador dog3 = new Labrador();
            Labrador dog4 = new Labrador("Enzo", 3, "brown", "chicken", 35, false, "go on walks", "Grrrrrrr", "blanket");
            Moose moose1 = new Moose();
            Lion lion1 = new Lion();

            //add objects to List myAnimals
            myAnimals.Add(dog1);
            myAnimals.Add(dog2);
            myAnimals.Add(dog3);
            myAnimals.Add(dog4);
            myAnimals.Add(moose1);
            myAnimals.Add(lion1);

            /* In our loop we first call our methods from base class. 
            - we then see if object is a Dog, then we call 2 more methods. 
            - if Dog is Labrador we call one more method 
            - if Dog is Chihuahua we call another method.
            - Moose and Lion has their own methods also.  */


            foreach (Animal animal in myAnimals)
            {
                animal.MakeSound();
                animal.Running();
                animal.Eating();
                animal.Print();


                if (animal is Dog dog)
                {
                    dog.Sleeping();
                    dog.Jumping();

                    if (animal is Labrador lab)
                    {
                        lab.Swimming();
                        Console.WriteLine();
                    }
                    else if (animal is Chihuahua chi)
                    {
                        chi.TakeNap();
                        Console.WriteLine();
                    }
                    else Console.WriteLine();

                }
                else if (animal is Moose moose)
                {
                    moose.LookForShelter();
                    Console.WriteLine();
                }

                else if (animal is Lion lion)
                {
                    lion.GetFacts();

                }
                else Console.WriteLine();

            }

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Wild animals making sound:");

            //separate all wild animals to call MakeSound method
            var filteredList = myAnimals.Where(x => x.Wild == true).ToList();

            foreach (var item in filteredList)
            {
                item.MakeSound();
            }

            Console.WriteLine("\n------------------------------------");

            Console.WriteLine("The dogs want to say goodbye before you leave.");
            Console.WriteLine("Press enter...");
            Console.ReadLine();
            // filter out all dogs and put them in a new list
            List<Dog> dogList = myAnimals.OfType<Dog>().ToList();

            //Loop our new doglist and call method
            foreach (var item in dogList)
            {
                item.SayGoodbye();
            }



        }
    }
}