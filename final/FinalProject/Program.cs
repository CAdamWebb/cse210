class Program
{
    static void Main(string[] args)
    {
        Board playerBoard = new Board();
        Board cpuBoard = new Board();
        PlayerSetup playerSetup = new PlayerSetup();
        RandomSetup randomSetup = new RandomSetup();
        playerSetup.setup(playerBoard);
        randomSetup.setup(cpuBoard);
        HumanPlayer player1 = new HumanPlayer(playerBoard, cpuBoard);
        CpuPlayer player2 = new CpuPlayer(playerBoard);
        while (! playerBoard.isDead() && ! cpuBoard.isDead())
        {
            player1.play();
            player2.play();
        }
        if (cpuBoard.isDead())
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose.");
        }
    }
}