namespace OOP_arv
{
    class Chihuahua : Dog
    {
        //Properties - set default values to the new properties
        protected string Breed { get; set; } = "Chihuahua";
        protected string BadHabit { get; set; } = "chase mailman";


        //Constructor - set default values
        public Chihuahua()
        {
            Name = "Carlos"; Age = 2;
            Color = "light brown"; Food = "can food";
            Weight = 2; LikesToDo = "bark at strangers";
            Sound = "Yap yap yap"; PlaceToSleep = "the couch";
        }

        //METHODS
        //We override Animal and Dog methods and have a new method

        public void SneakPeak()
        {
            Console.WriteLine($"This is {Name} and he is a {Breed}");
        }


        public void TakeNap()
        {
            Console.WriteLine($"{Name} is taking a nap in the sun");
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, {Breed}, {Age}, {Color}, Eats: {Food}, likes to {LikesToDo}, " +
                $"Kg: {Weight}, Badhabit: {BadHabit}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Breed} says {Sound}");
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
