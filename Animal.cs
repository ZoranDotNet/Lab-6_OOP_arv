namespace OOP_arv
{
    abstract class Animal
    {   // Properties
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Color { get; set; }
        protected string Food { get; set; }
        protected int Weight { get; set; }

        public Animal(string name, int age, string color, string food, int weight)
        {
            Name = name;
            Age = age;
            Color = color;
            Food = food;
            Weight = weight;
        }

        public Animal()
        {

        }

        // METHODS
        public virtual void MakeSound()
        {
            Console.WriteLine();
        }

        public virtual void Running()
        {
            Console.WriteLine();
        }

        public virtual void Eating()
        {
            Console.WriteLine();
        }

        public virtual void Print()
        {
            Console.WriteLine();
        }


    }
}
