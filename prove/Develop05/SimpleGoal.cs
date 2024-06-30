class SimpleGoal : Goal
{
    public bool _complete = false;
    public SimpleGoal(string goalString)
    {
        string[] parts = goalString.Split("~");
        _name = parts[0];
        _pointValue = Convert.ToInt32(parts[1]);
        _complete = Convert.ToBoolean(parts[2]);
    }
    public SimpleGoal()
    {
        Console.WriteLine("\nName:");
        _name = Console.ReadLine();
        Console.WriteLine("points:");
        _pointValue = Convert.ToInt32(Console.ReadLine());
    }
    public override int complete()
    {
        if (_complete)
        {
            return 0;
        }
        _complete = true;
        Console.WriteLine($"Earned {_pointValue} points!");
        return _pointValue;
    }
    public override void display()
    {
        if (_complete)
        {
            Console.WriteLine($"{_name}: Complete!");
        }
        else
        {
            Console.WriteLine($"{_name}: {_pointValue} points");
        }
    }
    public override string saveString()
    {
        return $"simple|{_name}~{_pointValue}~{_complete}";
    }
}