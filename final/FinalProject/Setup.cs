abstract class Setup
{
    Boat[] boats = {new Carrier(), new Battleship(), new Destroyer(), new Submarine(), new PatrolBoat()};
    public Board _board;
    public int _location;
    public bool _vertical;
    public abstract void getLocation(Boat boat);
    public void setup(Board board)
    {
        _board = board;
        foreach (Boat i in boats)
        {
            _location = -1;
            while (! isValid(i))
            {
                getLocation(i);
            }
            placeBoat(i);
        }
    }
    void placeBoat(Boat boat)
    {
        for (int i = 0; i < boat._length; i++)
        {
            if (_vertical)
            {
                _board._contents[_location + 10 * i] = boat._symbol;
            }
            else
            {
                _board._contents[_location + i] = boat._symbol;
            }
        }
    }
    bool isValid(Boat boat)
    {
        int step = 1;
        if (_vertical)
        {
            step = 10;
        }
        if (_location < 0 || _location + step * (boat._length - 1) > 99)
        {
            return false;
        }
        if ((_location + step * (boat._length - 1)) % 10 < _location % 10)
        {
            return false;
        }
        for (int i = 0; i < boat._length; i++)
        {
            if (_board._contents[_location + step * i] != '-')
            {
                return false;
            }
        }
        return true;
    }
}