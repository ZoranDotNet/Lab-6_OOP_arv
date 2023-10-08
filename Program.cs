namespace OOP_arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make a List of Animal so we can loop thrue all methods
            List<Animal> myAnimals = new List<Animal>();


            //creates objects
            Dog dog1 = new Dog();
            Labrador dog2 = new Labrador();
            Chihuahua dog3 = new Chihuahua();
            Moose moose = new Moose();
            Lion lion = new Lion();

            //add objects to List myAnimals
            myAnimals.Add(dog1);
            myAnimals.Add(dog2);
            myAnimals.Add(dog3);
            myAnimals.Add(moose);
            myAnimals.Add(lion);

            /* In our loop we call our methods from base class. 
             - we then see if object is a Dog, then we call 2 more methods. 
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
                        Console.WriteLine();
                    }
                    else if (x is Chihuahua dc)
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