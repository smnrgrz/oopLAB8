using Lab8_PetShop;

Dog dog = new Dog("Karabaş", 3, "Kangal");
dog.Eat();
dog.Fetch();
Console.WriteLine($"{dog.Name} ({dog.Breed}), {dog.Age} years old");

Animal[] animals = new Animal[]
{
    dog,
    new Cat("Tekir", 2)
};

foreach (Animal animal in animals)
{
    animal.MakeSound();
}