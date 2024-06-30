class EternalGoal : Goal
{
    public EternalGoal(string goalString)
    {
        string[] parts = goalString.Split("~");
        _name = parts[0];
        _pointValue = Convert.ToInt32(parts[1]);
    }
    public EternalGoal()
    {
        Console.WriteLine("\nName:");
        _name = Console.ReadLine();
        Console.WriteLine("points:");
        _pointValue = Convert.ToInt32(Console.ReadLine());
    }
    public override int complete()
    {
        Console.WriteLine($"Earned {_pointValue} points!");
        return _pointValue;
    }
    public override void display()
    {
        Console.WriteLine($"{_name}: {_pointValue} points");
    }
    public override string saveString()
    {
        return $"eternal|{_name}~{_pointValue}";
    }
}