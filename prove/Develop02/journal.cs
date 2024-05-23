class Journal
{
    public List<Entry> _contents = new List<Entry>();
    public void display()
    {
        Console.WriteLine();
        foreach (Entry i in _contents)
        {
            i.display();
        }
    }
    public void addEntry()
    {
        Entry entry = new Entry();
        entry.makeEntry();
        _contents.Add(entry);
    }
    public void save()
    {
        Console.WriteLine("Filename: ");
        string filename = Console.ReadLine();
        string file_contents = "";
        foreach (Entry i in _contents)
        {
            file_contents = file_contents + $"{i._time}~{i._prompt}~{i._response}\n";
        }
        File.WriteAllText(filename, file_contents);
    }
    public void load()
    {
        Console.WriteLine("Filename: ");
        string filename = Console.ReadLine();
        _contents = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            _contents.Add(new Entry(parts[0], parts[1], parts[2]));
        }
    }
}