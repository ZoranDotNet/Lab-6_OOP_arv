namespace OOP_arv
{
    class Moose : Animal
    {   //Properties - set default values to the new properties
        protected bool Antlers { get; set; } = true;

        //Constructor
        public Moose(string name, int age, string color, string food, bool wild, bool antlers)
            : base(name, age, color, food, wild)
        {
            Antlers = antlers;
        }

        //Constructor - set default values
        public Moose()
        {
            Name = "Helge"; Age = 8; Color = "Dark grey"; Food = "plants"; Wild = true;
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
            Console.WriteLine($"Moose is running");
        }

        public override void Eating()
        {
            Console.WriteLine($"Moose is eating {Food}");
        }
        public override void Print()
        {
            Console.WriteLine($"{Name}, {Age}, {Color}, {Food}, Is wild: {Wild}, Have antlers: {Antlers}");
        }

    }
}
