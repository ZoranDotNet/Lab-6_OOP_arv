namespace OOP_arv
{
    class Lion : Animal
    {   //Properties
        protected bool IsPredator { get; set; }



        //Constructor - set default values
        public Lion()

        {
            Name = "Akita"; Age = 6; Color = "yellow"; Food = "meat"; Weight = 180; Wild = true; IsPredator = true;
        }

        //METHODS
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
            Console.WriteLine("Lion is running on the savannah");
        }

        public override void Eating()
        {
            Console.WriteLine($"Lion is eating {Food}");

        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, {Age}, {Color}, Eats: {Food}, Kg: {Weight}, Is predator: {IsPredator}");
        }



    }
}
