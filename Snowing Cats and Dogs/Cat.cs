namespace Snowing_Cats_and_Dogs
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Owner { get; set; }
        public string Color { get; set; }
        public bool Declawed { get; set; }

        public Cat(string name, string breed, int age, string color, string owner, bool declawed)
        {
            this.Name = name;
            this.Breed = breed;
            this.Age = age;
            this.Color = color;
            this.Owner = owner;
            this.Declawed = declawed;
        }
        
        public Cat()
        {
            this.Breed = "N/A";
            this.Age = 0;
            this.Owner = "Unknown";
            this.Declawed = false;
            this.Name = "Unknown";
            this.Color = "N/A";
        }
    }
}