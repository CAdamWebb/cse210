class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Board board = new Board();
        PlayerSetup playerSetup = new PlayerSetup();
        board.display();
        playerSetup.setup(board);
        board.display();
    }
}