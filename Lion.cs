namespace OOP_arv
{
    class Lion : Animal
    {   //Properties
        protected bool IsPredator { get; set; }

        //Constructor
        public Lion(string name, int age, string color, string food, bool wild, bool isPredator)
            : base(name, age, color, food, wild)
        {
            IsPredator = isPredator;
        }

        //Constructor - set default values
        public Lion()

        {
            Name = "Akita"; Age = 6; Color = "yellow"; Food = "meat"; Wild = true; IsPredator = true;
        }

        //METHODS
        //Lion have a new method, we override 4 methods from Animal

        public void GetFacts()
        {
            Console.WriteLine("The lion is a fierce predator and hunts in packs.");
            Console.WriteLine("Often reffered to as king of the djungle.");
        }


        public override void MakeSound()
        {
            Console.WriteLine("Lion says rrrroooaaaaarrr");
        }

        public override void Running()
        {
            Console.WriteLine("Lion is running");
        }

        public override void Eating()
        {
            Console.WriteLine($"Lion is eating {Food}");

        }

        public override void Print()
        {
            Console.WriteLine($"{Name}, Age: {Age}, Color: {Color}, Eats: {Food}, Is a wild animal: {Wild}, Is a predator: {IsPredator}");
        }



    }
}
