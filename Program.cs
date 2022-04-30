class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(@"Enter your Diet name:
ve = Vegan
vg = Vegetarian
o = Omnivore

q = quit the program
");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "q")
                break;
            else
            {
                DietFactory DF = new DietFactory();
                IBasicDiet diet = DF.GetMenu(input);
                if (diet != null)
                {
                    diet.ShowMenu();
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("No diet with this name!");
            }
        }
        Console.WriteLine("Thank you!");
    }
}