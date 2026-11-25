namespace Lab8_PetShop
{
    public class Dog : Animal
    {
        public string Breed;

        public Dog(string dogName, int dogAge, string dogBreed) : base(dogName, dogAge)
        {
            Breed = dogBreed;
            Console.WriteLine("Dog constructor");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} brings the ball back!");
        }

        public  override void MakeSound()
        {
            Console.WriteLine($"{Name}: Woof!");
        }









































































    }
}