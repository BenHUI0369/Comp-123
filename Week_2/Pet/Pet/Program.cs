using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Pet
{
    class Pet
    {
        public string Name { get; }
        public string Owner { get; private set; }
        public int Age { get; }
        public string Description { get; }
        public bool IsHouseTrained { get; private set; }
        public Pet(string name, int age, string description)
        {
            Name = name;
            Owner = "no one";
            Age = age;
            Description = description;
            IsHouseTrained = false;
        }
        public override string ToString()
        {
            return $"Pet Detail:{Description}\nName: {Name}\nOwner: {Owner}\nAge: {Age}\nTrained?: {(IsHouseTrained ? "Yes" : "No")}";
        }
        public void SetOwner(string owner)
        {
            Owner = owner;
        }
        public void Train()
        {
            IsHouseTrained = true;
        }
        static void Main(string[] args)
        {
            Pet cat_baby = new Pet("Mew", 1, "Orange cats from Iceland");
            Pet dog_baby = new Pet("Doge", 2, "Husky from Siberia");
            Pet owl_baby = new Pet("lily", 1, "Bubo virginianus from Americas");
            Pet rabbit_baby = new Pet("jumpy", 1, "Holland Lop virginianus from Holland");
            List<Pet> pets = new List<Pet>();
            pets.Add(cat_baby);
            pets.Add(dog_baby);
            pets.Add(owl_baby);
            pets.Add(rabbit_baby);
            cat_baby.SetOwner("Peter");
            cat_baby.Train();
            dog_baby.SetOwner("Marry");
            dog_baby.Train();
            rabbit_baby.SetOwner("Peter");
            Console.WriteLine("------Display All Collection of the pets------");
            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet);
                Console.WriteLine();
            }
            Console.WriteLine("------End of The collection Display------");
            Console.WriteLine();
            Console.Write("Please enter the name of the Owner for searching:");
            string ownerName = Console.ReadLine();
            Console.WriteLine($"{ownerName} is now owning below pets:");
            foreach (Pet pet in pets)
            {
                if (pet.Owner.ToLower() == ownerName.ToLower())
                {
                    Console.WriteLine(pet);
                    Console.WriteLine();
                }
            }
        }
    }
}