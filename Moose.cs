namespace OOP_arv
{
    class Moose : Animal
    {   //Properties - set default values to the new properties
        protected bool Antlers { get; set; } = true;

        //Constructor
        public Moose(string name, int age, string color, string food, int weight, bool antlers)
            : base(name, age, color, food, weight)
        {

            Antlers = antlers;
        }

        //Constructor - set default values
        public Moose()
        {
            Name = "Helge"; Age = 8; Color = "Dark grey"; Food = "plants"; Weight = 250;
        }

        //METHODS
        //Moose have a new method, we override 4 methods from Animal

        public void LookForShelter()
        {
            Console.WriteLine("Moose is looking for shelter in the stormy weather.");
        }


        public override void MakeSound()
        {
            Console.WriteLine($"Moose says moooooaaaaaa");
        }

        public override void Running()
        {
            Console.WriteLine($"Moose is running in the woods");
        }

        public override void Eating()
        {
            Console.WriteLine($"Moose is eating {Food}");
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, {Age}, {Color}, Eats: {Food}, Kg: {Weight}, Have antlers: {Antlers}");
        }


    }
}
