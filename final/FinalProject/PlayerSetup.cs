class PlayerSetup : Setup
{
    public override void getLocation(Boat boat)
    {
        _board.display();
        Console.Write($"{boat._name} ({boat._length}) Location: ");
        _location = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("(v) vertical or (h) horizontal?");
        string input = Console.ReadLine();
        if (input == "v")
        {
            _vertical = true;
        }
        else
        {
            _vertical = false;
        }
    }
}