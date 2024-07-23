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
        Console.Write("   0 1 2 3 4 5 6 7 8 9");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\n{i}  ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(_contents[10 * i + j] + " ");
            }
            Console.Write($" {i}");
        }
        Console.WriteLine("\n   0 1 2 3 4 5 6 7 8 9");
    }
    public void hiddenDisplay()
    {
        Console.Write("   0 1 2 3 4 5 6 7 8 9");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\n{i}  ");
            for (int j = 0; j < 10; j++)
            {
                if (! Char.IsLetter(_contents[10 * i + j]))
                {
                    Console.Write(_contents[10 * i + j] + " ");
                }
                else if (Char.IsUpper(_contents[10 * i + j]))
                {
                    Console.Write("- ");
                }
                else if (_contents.Contains(Char.ToUpper(_contents[10 * i + j])))
                {
                    Console.Write("! ");
                }
                else
                {
                    Console.Write(_contents[10 * i + j] + " ");
                }
            }
            Console.Write($" {i}");
        }
        Console.WriteLine("\n   0 1 2 3 4 5 6 7 8 9");
    }
    public bool isDead()
    {
        foreach (char i in _contents)
        {
            if (Char.IsUpper(i))
            {
                return false;
            }
        }
        return true;
    }
    public bool hit(int target)
    {
        if (_contents[target] == '-' || _contents[target] == '*')
        {
            _contents[target] = '*';
            return false;
        }
        _contents[target] = Char.ToLower(_contents[target]);
        return true;
    }
}