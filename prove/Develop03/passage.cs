class Passage
{
    List<Word> _words = new List<Word>();
    string _reference;
    public Passage(string reference, string content)
    {
        _reference = reference;
        string[] wordlist = content.Split(" ");
        foreach (string i in wordlist)
        {
            _words.Add(new Word(i));
        }
    }
    public void hide(int n)
    {
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            _words[random.Next(_words.Count())].hide();
        }
    }
    public void display()
    {
        Console.WriteLine(_reference);
        foreach (Word i in _words)
        {
            i.display();
        }
        Console.WriteLine();
    }
}