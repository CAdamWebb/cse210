class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an activity\n1: Breathing\n2: Reflection\n3: Listing");
        string response = Console.ReadLine();
        if (response == "1")
        {
            Breathing breathing = new Breathing();
        }
        else if (response == "2")
        {
            new Reflection();
        }
        else if (response == "3")
        {
            new Listing();
        }
    }
}