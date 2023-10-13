namespace OOP_arv
{//Zoran Matovic NET23
    internal class Program
    {
        static void Main(string[] args)
        {

            //Make a List of Animal so we can loop through all methods
            List<Animal> myAnimals = new List<Animal>();


            //creates objects
            Dog dog1 = new Dog();
            Labrador dog2 = new Labrador();
            Chihuahua dog3 = new Chihuahua();
            Moose moose1 = new Moose();
            Lion lion1 = new Lion();

            //add objects to List myAnimals
            myAnimals.Add(dog1);
            myAnimals.Add(dog2);
            myAnimals.Add(dog3);
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



            Console.ReadKey();
        }
    }
}