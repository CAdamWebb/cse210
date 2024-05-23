class Entry
{
    public string _prompt;
    public string _response;
    public string _time;
    public Entry(string timeString = "", string promptString = "", string responseString = ""){
        _time = timeString;
        _prompt = promptString;
        _response = responseString;
    }
    public void makeEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        _prompt = promptGenerator.Prompt();
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
        _time = DateTime.Now.ToString();
    }
    public void display()
    {
        Console.WriteLine(_time);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
        Console.WriteLine();
    }
}