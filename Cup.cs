
using DiceRoller;

public class Cup
{
    public List<Die> Dice { get; private set; } = [];

    public void AddDie()
    {
        Console.Write("Would you like to add a die? [N/y]: ");

        if (string.Equals(Console.ReadLine(), "y"))
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int faceCount))
                {
                    try
                    {
                        Die die = new();
                        die.SetFaces(faceCount);
                        Dice.Add(die);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }

    public void RemoveDie()
    {
        Console.Write("Would you like to remove a die? [N/y]: ");
        if (string.Equals(Console.ReadLine(), "y"))
        {
            return;
        }
    }


}

