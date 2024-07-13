class Board
{
    public List<char> _contents = new List<char>();
    public Board()
    {
        for (int i = 0; i < 100; i++)
        {
            _contents.Add('-');
        }
    }
    public void display()
    {
        Console.WriteLine("    0 1 2 3 4 5 6 7 8 9");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\n{i}   ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(_contents[10 * i + j] + " ");
            }
        }
        Console.WriteLine();
    }
}