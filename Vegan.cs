public class Vegan : IBasicDiet
{
    public void ShowMenu()
    {
        string [] menu = {"Fruits","Vegetables","Grains","Nuts"};
        Console.WriteLine("The Menu for this Diet is:");
        foreach (string item in menu)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }
}