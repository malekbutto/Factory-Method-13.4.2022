public class Omnivore : IBasicDiet
{
    public void ShowMenu()
    {
        string [] menu = {"Fruits","Vegetables","Grains","Nuts","Dairy","Eggs","Meat","Fish"};
        Console.WriteLine("The Menu for this Diet is:");
        foreach (string item in menu)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }
}