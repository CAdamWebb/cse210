class GoalTracker
{
    public List<Goal> goals = new List<Goal>();
    public int pointTotal = 0;
    public void createGoal()
    {
        Console.WriteLine("\n1: Simple goal\n2: Eternal goal\n3: Checklist goal");
        string input = Console.ReadLine();
        if (input == "1")
        {
            goals.Add(new SimpleGoal());
        }
        else if (input == "2")
        {
            goals.Add(new EternalGoal());
        }
        else if (input == "3")
        {
            goals.Add(new ChecklistGoal());
        }
    }
    public void complete()
    {
        Console.WriteLine("Complete which goal?");
        pointTotal += goals[Convert.ToInt32(Console.ReadLine())].complete();
        Thread.Sleep(1000);
    }
    public void display()
    {
        Console.WriteLine($"\nPoints: {pointTotal}");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i}: ");
            goals[i].display();
        }
    }
    public void save()
    {
        Console.WriteLine("Filename: ");
        string filename = Console.ReadLine();
        string file_contents = $"points|{pointTotal}\n";
        foreach (Goal goal in goals)
        {
            file_contents = file_contents + goal.saveString() + "\n";
        }
        File.WriteAllText(filename, file_contents);
        Console.WriteLine("Saved!");
        Thread.Sleep(1000);
    }
    public void load()
    {
        Console.WriteLine("Filename: ");
        string filename = Console.ReadLine();
        goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts[0] == "points")
            {
                pointTotal = Convert.ToInt32(parts[1]);
            }
            if (parts[0] == "simple")
            {
                goals.Add(new SimpleGoal(parts[1]));
            }
            if (parts[0] == "eternal")
            {
                goals.Add(new EternalGoal(parts[1]));
            }
            if (parts[0] == "checklist")
            {
                goals.Add(new ChecklistGoal(parts[1]));
            }
        }
    }
}