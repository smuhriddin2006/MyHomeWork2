namespace Computer;

public class Smarthphone : Computer
{
    public int NumberSelfies {get; set;}

    public void TakeSelfies()
    {
        
        System.Console.WriteLine(NumberSelfies++);
    }
}
