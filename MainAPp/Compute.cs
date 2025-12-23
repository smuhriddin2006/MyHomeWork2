namespace MainAPp;

public class Compute
{


    public int Ram {get; set;}
    public int Storage {get; set;}
    public string Keyboard {get; set;} = "";

    public void AddRam(int ram)
    {
        Ram = ram;
    }
        public void AddStorage(int storage)
    {
        Storage = storage;
    }
    public Compute(){}
    public void Print()
    {
        System.Console.WriteLine($"{Ram}, {Storage}");
    }
}

