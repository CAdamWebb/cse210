class ChecklistGoal : Goal
{
    public int _progress = 0;
    public int _maxProgress;
    public int _completionPoints;
    public ChecklistGoal(string goalString)
    {
        string[] parts = goalString.Split("~");
        _name = parts[0];
        _pointValue = Convert.ToInt32(parts[1]);
        _completionPoints = Convert.ToInt32(parts[2]);
        _progress = Convert.ToInt32(parts[3]);
        _maxProgress = Convert.ToInt32(parts[4]);
    }
    public ChecklistGoal()
    {
        Console.WriteLine("\nName:");
        _name = Console.ReadLine();
        Console.WriteLine("points for completion:");
        _pointValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Points for final completion:");
        _completionPoints = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many times do you want to complete this?");
        _maxProgress = Convert.ToInt32(Console.ReadLine());
    }
    public override int complete()
    {
        if (_progress == _maxProgress)
        {
            return 0;
        }
        _progress ++;
        if (_progress == _maxProgress)
        {
            Console.WriteLine($"Earned {_pointValue} points!");
            Console.WriteLine($"Earned {_completionPoints} points!");
            return _pointValue + _completionPoints;
        }
        Console.WriteLine($"Earned {_pointValue} points!");
        return _pointValue;
    }
    public override void display()
    {
        if (_progress == _maxProgress)
        {
            Console.WriteLine($"{_name}: Complete!");
        }
        else
        {
            Console.WriteLine($"{_name} [{_progress}/{_maxProgress}]: {_pointValue} points");
        }
    }
    public override string saveString()
    {
        return $"checklist|{_name}~{_pointValue}~{_completionPoints}~{_progress}~{_maxProgress}";
    }
}