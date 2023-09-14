namespace OOP_arv
{
    class Chihuahua : Dog
    {
        //Properties - set default values to the new properties
        protected string Breed { get; set; } = "Chihuahua";
        protected string BadHabit { get; set; } = "chase mailman";
        protected string Sound2 { get; set; } = "Yap yap yap";

        //Constructor
        public Chihuahua(string name, int age, string color, string food, int weight, string likesToDo, string sound, string placeToSleep, string breed, string badHabit, string sound2)
            : base(name, age, color, food, weight, likesToDo, sound, placeToSleep)
        {
            Breed = breed;
            BadHabit = badHabit;
            Sound2 = sound2;
        }
        //Constructor - set default values
        public Chihuahua()
        {
            Name = "Carlos"; Age = 2; Color = "light brown"; Food = "can food"; Weight = 2; LikesToDo = "bark at strangers"; PlaceToSleep = "the couch";
        }

        //METHODS
        //We override Animal and Dog methods and have a new method

        public void TakeNap()
        {
            Console.WriteLine($"{Name} is taking a nap in the sun");
        }

        public override void Print()
        {
            Console.WriteLine($"{Name}, {Breed}, {Age}, {Color}, {Food}, likes to {LikesToDo}, " +
                $"Kg: {Weight}, Badhabit: {BadHabit}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Breed} says {Sound} & {Sound2}");
        }

        public override void Jumping()
        {
            Console.WriteLine($"{Breed} is jumping low");
        }
        public override void Sleeping()
        {
            Console.WriteLine($"{Breed} is sleeping on {PlaceToSleep}");
        }

        public override void Running()
        {
            Console.WriteLine($"{Breed} is running slow");
        }

        public override void Eating()
        {
            Console.WriteLine($"{Breed} is eating {Food}");
        }

    }
}
