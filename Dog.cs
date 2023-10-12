namespace OOP_arv
{
    class Dog : Animal
    {   //Properties - set default values to our new properties
        protected string LikesToDo { get; set; } = "play";
        protected string Sound { get; set; } = "wow wow";
        protected string PlaceToSleep { get; set; } = "dog house";


        // Constructor - set default values
        public Dog()
        {
            Name = "Fido"; Age = 3; Color = "brown/white"; Food = "dog-food"; Weight = 12;
        }

        //METHODS
        //Dog has 2 new methods, we override 4 methods from Animal
        public virtual void Sleeping()
        {
            Console.WriteLine($"Dog is sleeping in {PlaceToSleep}");
        }

        public virtual void Jumping()
        {
            Console.WriteLine("Dog is jumping");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Dog say {Sound}");
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, {Age}, {Color}, Eats: {Food}, likes to {LikesToDo}, Kg: {Weight}, ");
        }

        public override void Running()
        {
            Console.WriteLine("Dog is running");
        }

        public override void Eating()
        {
            Console.WriteLine($"Dog is eating {Food}");
        }

    }
}
