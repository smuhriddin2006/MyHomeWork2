namespace MainAPp;

public class Laptop : Compute
{
    public int Weight {get; set;}
    public int WeightCheck(int weight)
    {
        Weight = weight;
        if (weight < 5)
        {
            System.Console.WriteLine($"This cant be real");
        }
        else
        {
            System.Console.WriteLine("This is real");
        }
        return weight;
    }
}
