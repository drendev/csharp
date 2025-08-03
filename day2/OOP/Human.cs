
namespace OOP
{
    public class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            Console.WriteLine("Hello, I'm {0} {1}. The color of my eyes is {2}, and I'm {3} years old", 
                firstName, lastName, eyeColor, age);
        }
    }
}
