class Activity
{
    Random random = new Random();
    public string _title;
    public string _description;
    public int _duration;
    public int _interval;
    public List<string> _prompts;
    public Activity()
    {
        
    }
    public virtual void exercise()
    {
        Console.WriteLine("exercise");
    }
    public void start()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.Write("Duration: ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_prompts[random.Next(_prompts.Count())]);
        wait(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            exercise();
            wait(_interval);
        }
        Console.WriteLine($"You have completed the {_title} activity.");
    }
    public void wait(int time)
    {
        for (int i = 0; i < time; i++)
        {
            Console.Write("/\b");
            Thread.Sleep(250);
            Console.Write("-\b");
            Thread.Sleep(250);
            Console.Write("\\\b");
            Thread.Sleep(250);
            Console.Write("|\b");
            Thread.Sleep(250);
        }
    }
}