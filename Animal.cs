namespace OOP_arv
{
    class Animal
    {   // Properties
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Color { get; set; }
        protected string Food { get; set; }
        protected bool Wild { get; set; }

        //Constructor
        public Animal(string name, int age, string color, string food, bool wild)
        {
            Name = name;
            Age = age;
            Color = color;
            Food = food;
            Wild = wild;

        }
        //Constructor where we set default values
        public Animal()
        {
            Name = "Lisa";
            Age = 9; Color = "Black/white";
            Food = "food";
            Wild = false;
        }

        // METHODS
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public virtual void Running()
        {
            Console.WriteLine("Animal is running");
        }

        public virtual void Eating()
        {
            Console.WriteLine($"Animal is eating {Food}");
        }

        public virtual void Print()
        {
            Console.WriteLine($"Animals name: {Name}, Age: {Age}, Color: {Color}, Food: {Food}, Is wild: {Wild}");
        }


    }
}
