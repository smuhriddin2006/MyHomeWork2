
namespace MainAPp;
public class Smartphone : Compute
{
    public int NumberSelfies {get; set;}

    public void TakeSelfies()
    {
        
        System.Console.WriteLine(NumberSelfies++);
    }
}

