namespace OOP_arv
{
    abstract class Animal
    {   // Properties
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Color { get; set; }
        public string? Food { get; set; }
        public int Weight { get; set; }
        public bool Wild { get; set; }



        // METHODS - We implement them in subclasses
        public abstract void MakeSound();

        public abstract void Running();

        public abstract void Eating();

        public abstract void Print();

    }
}
