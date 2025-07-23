namespace DiceRoller;

public class Dice
{
    private readonly Random _roll = new(); // using field to denote internal helper

    public int Faces { get; private set; }

    public void SetFaces(int faces)
    {
        if (faces < 2)
        {
            throw new ArgumentException("Dice need at least 2 sides in this plane of existnce.");
        }
        else if (faces > 25)
        {
            throw new ArgumentException("Are you trying to roll dice or golf balls?");
        }
        else
        {
            Faces = faces;
        }
    }

    public int Roll()
    {
        return _roll.Next(1, Faces + 1);
    }
}

