namespace OOP_arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make a List of Animal so we can loop thrue all methods
            List<Animal> myAnimals = new List<Animal>();


            //creates objects
            Animal animal = new();
            Dog dog1 = new();
            Labrador dog2 = new();
            Chihuahua dog3 = new();
            Moose moose = new();
            Lion lion = new();

            //add objects to List myAnimal
            myAnimals.Add(animal);
            myAnimals.Add(dog1);
            myAnimals.Add(dog2);
            myAnimals.Add(dog3);
            myAnimals.Add(moose);
            myAnimals.Add(lion);

            /* In our loop we call our methods. 
             - Object animal call the base methods, 
             - we then see if object is a Dog then we call 2 more methods. 
             - if Dog is Labrador we call one more method 
             - if Dog is Chihuahua we call another method.
             - Moose and Lion has their own methods also.  */

            foreach (Animal x in myAnimals)
            {
                x.MakeSound();
                x.Running();
                x.Eating();
                x.Print();


                if (x is Dog d)
                {
                    d.Sleeping();
                    d.Jumping();

                    if (x is Labrador dl)
                    {
                        dl.Swimming();
                    }
                    if (x is Chihuahua dc)
                    {
                        dc.TakeNap();
                        Console.WriteLine();
                    }
                    else Console.WriteLine();

                }
                else if (x is Moose m)
                {
                    m.LookForShelter();
                    Console.WriteLine();
                }

                else if (x is Lion l)
                {
                    l.GetFacts();

                }
                else Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}