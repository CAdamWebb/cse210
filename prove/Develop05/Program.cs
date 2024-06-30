class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();
        string input = "";
        while (input != "5")
        {
            Console.Clear();
            goalTracker.display();
            Console.WriteLine("\n1: Create goal\n2: Complete goal\n3: Save\n4: Load\n5: Quit");
            input = Console.ReadLine();
            if (input == "1")
            {
                goalTracker.createGoal();
            }
            else if (input == "2")
            {
                goalTracker.complete();
            }
            else if (input == "3")
            {
                goalTracker.save();
            }
            else if (input == "4")
            {
                goalTracker.load();
            }
        }
    }
}