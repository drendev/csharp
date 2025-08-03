namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human aldren = new Human("Aldren", "Mendoza", "Brown", 26);
            aldren.IntroduceMyself();
            List<int> age1 = new List<int> { 1, 2, 3, 4, 5 };

            foreach (int item in age1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
