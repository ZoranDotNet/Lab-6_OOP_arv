namespace OOP_arv
{
    abstract class Animal
    {   // Properties
        protected string? Name { get; set; }
        protected int Age { get; set; }
        protected string? Color { get; set; }
        protected string? Food { get; set; }
        protected int Weight { get; set; }



        // METHODS - We implement them in subclasses
        public abstract void MakeSound();

        public abstract void Running();

        public abstract void Eating();

        public abstract void Print();

    }
}
