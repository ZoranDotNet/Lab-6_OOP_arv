namespace OOP_arv
{
    class Dog : Animal
    {   //Properties - set default values to new properties
        protected string LikesToDo { get; set; } = "play";
        protected string Sound { get; set; } = "wow wow";
        protected string PlaceToSleep { get; set; } = "dog house";

        //Constructor - get properties from base class - and 3 new Dog properties
        public Dog(string name, int age, string color, string food, bool wild, string likesToDo, string sound, string placeToSleep)
            : base(name, age, color, food, wild)
        {
            LikesToDo = likesToDo;
            Sound = sound;
            PlaceToSleep = placeToSleep;
        }

        // Constructor - set default values
        public Dog()
        {
            Name = "Fido"; Age = 3; Color = "brown/white"; Food = "dog-food"; Wild = false;
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
            Console.WriteLine($"{Name}, {Age}, {Color}, {Food}, likes to {LikesToDo}, Is wild: {Wild}, ");
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
