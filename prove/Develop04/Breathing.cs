class Breathing : Activity
{
    public Breathing()
    {
        _title = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _interval = 8;
        _prompts = new List<string>{""};
        start();
    }
    public override void exercise()
    {
        Console.WriteLine("Breathe in...");
        wait(5);
        Console.WriteLine("Breathe out...");
    }
}