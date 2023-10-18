namespace OOP_arv
{
    class Labrador : Dog
    {   //Properties - set default values to the new properties
        protected string Breed { get; set; } = "Labrador";
        protected string SpecialSkill { get; set; } = "Retrieve ducks";

        //Constructor - set default values
        public Labrador()
        {
            Name = "Charlie"; Age = 6;
            Color = "Black"; Food = "treats";
            Weight = 42; Wild = false;
            LikesToDo = "chase the ball";
            Sound = "Grrrrrrr"; PlaceToSleep = "blanket";

        }

        public Labrador(string name, int age, string color, string food, int weight, bool wild, string likesToDo, string sound, string placeToSleep)
        {
            Name = name; Age = age;
            Color = color; Food = food;
            Weight = weight; Wild = wild;
            LikesToDo = likesToDo; Sound = sound;
            PlaceToSleep = placeToSleep;
        }

        //METHODS
        //We override Animal and Dog methods and have a new method


        public void Swimming()
        {
            Console.WriteLine($"{Name} is swimming. {Breed}s love water");
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, {Breed}, {Age}, {Color}, Eats: {Food}, likes to {LikesToDo}, Kg: {Weight}, special skill: {SpecialSkill}");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Breed} says {Sound}");
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
            Console.WriteLine($"{Breed} is running fast");
        }

        public override void Eating()
        {
            Console.WriteLine($"{Breed} is eating {Food}");
        }

    }


}
