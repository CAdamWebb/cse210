class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        PlayerSetup playerSetup = new PlayerSetup();
        RandomSetup randomSetup = new RandomSetup();
        board.display();
        randomSetup.setup(board);
        board.display();
    }
}