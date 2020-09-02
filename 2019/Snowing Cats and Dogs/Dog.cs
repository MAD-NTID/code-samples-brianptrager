namespace Snowing_Cats_and_Dogs
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Owner { get; set; }

        public Dog(string name, string breed, int age, string owner)
        {
            this.Name = name;
            this.Breed = breed;
            this.Age = age;
            this.Owner = owner;
        }

        public Dog()
        {
            this.Name = "Unknown";
            this.Breed = "N/A";
            this.Age = 0;
            this.Owner = "Unknown";
        }
    }
}