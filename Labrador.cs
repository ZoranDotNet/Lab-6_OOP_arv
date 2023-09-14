namespace OOP_arv
{
    class Labrador : Dog
    {   //Properties - set default values to the new properties
        protected string Breed { get; set; } = "Labrador";
        protected string SpecialSkill { get; set; } = "Retrieve ducks";
        protected string Sound2 { get; set; } = "Grrrrrrr";

        //Constructor
        public Labrador(string name, int age, string color, string food, bool wild, string likesToDo, string sound, string placeToSleep, string breed, string specialSkill, string sound2)
            : base(name, age, color, food, wild, likesToDo, sound, placeToSleep)
        {
            Breed = breed;
            SpecialSkill = specialSkill;
            Sound2 = sound2;
        }

        //Constructor - set default values
        public Labrador()
        {
            Name = "Charlie"; Age = 6; Color = "Black"; Food = "treats"; Wild = false; LikesToDo = "chase the ball"; PlaceToSleep = "blanket";
        }

        //METHODS
        //We override Animal and Dog methods and have a new method

        public void Swimming()
        {
            Console.WriteLine($"{Name} is swimming. {Breed}s love water");
        }

        public override void Print()
        {
            Console.WriteLine($"{Name}, {Breed}, {Age}, {Color}, {Food}, likes to {LikesToDo}, Is wild: {Wild}, special skill: {SpecialSkill}");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Breed} says {Sound} & {Sound2}");
        }

        public override void Jumping()
        {
            Console.WriteLine($"{Breed} is jumping high");
        }
        public override void Sleeping()
        {
            Console.WriteLine($"{Breed} is sleeping on a {PlaceToSleep}");
        }

        public override void Running()
        {
            Console.WriteLine($"{Breed} is running");
        }

        public override void Eating()
        {
            Console.WriteLine($"{Breed} is eating {Food}");
        }

    }


}
