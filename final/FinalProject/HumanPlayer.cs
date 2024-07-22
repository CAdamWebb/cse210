class HumanPlayer : Player
{
    public HumanPlayer(Board a, Board b)
    {
        _myBoard = a;
        _opponentBoard = b;
    }
    public override void play()
    {
        _opponentBoard.display();
        _myBoard.display();
        _opponentBoard.hit(int.Parse(Console.ReadLine()));
    }
}