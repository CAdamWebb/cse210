abstract class Setup
{
    Boat[] boats = {new Carrier(), new Battleship(), new Destroyer(), new Submarine(), new PatrolBoat()};
    public int location;
    public abstract void getLocation();
    public void setup(Board board)
    {
        foreach (Boat i in boats)
        {
            getLocation();
            placeBoat(board, i, true);
        }
    }
    void placeBoat(Board board, Boat boat, bool vertical)
    {
        for (int i = 0; i < boat._length; i++)
        {
            if (vertical)
            {
                board._contents[location + 10 * i] = boat._symbol;
            }
            else
            {
                board._contents[location + i] = boat._symbol;
            }
        }
    }
}