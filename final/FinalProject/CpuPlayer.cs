class CpuPlayer : Player
{
    Random random = new Random();
    public CpuPlayer(Board board)
    {
        _opponentBoard = board;
    }
    public override void play()
    {
        _opponentBoard.hit(random.Next(0,100));
    }
}