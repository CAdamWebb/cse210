class Listing : Activity
{
    public Listing()
    {
        _title = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _interval = 0;
        _prompts = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};
        start();
    }
    public override void exercise()
    {
        Console.ReadLine();
    }
}