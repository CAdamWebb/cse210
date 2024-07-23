class HumanPlayer : Player
{
    private int input;
    public HumanPlayer(Board a, Board b)
    {
        _myBoard = a;
        _opponentBoard = b;
    }
    public override void play()
    {
        _opponentBoard.hiddenDisplay();
        Console.WriteLine("\n");
        _myBoard.display();
        input = -1;
        while (input > 99 || input < 0)
        {
            input = int.Parse(Console.ReadLine());
        }
        if (_opponentBoard.hit(input))
        {
            Console.WriteLine("Hit!");
        }
        else
        {
            Console.WriteLine("Miss!");
        }
    }
}