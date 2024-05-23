using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string choice = "1";
        while (choice != "5")
        {
            Console.WriteLine("-Journal-\n1: New entry\n2: View entries\n3: Save journal\n4: Load journal\n5: Quit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.addEntry();
            }
            else if (choice == "2")
            {
                journal.display();
            }
            else if (choice == "3")
            {
                journal.save();
            }
            else if (choice == "4")
            {
                journal.load();
            }
        }
    }
}