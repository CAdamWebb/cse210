abstract class Boat
{
    public int _length;
    public char _symbol;
}

class Carrier : Boat
{
    public Carrier()
    {
        _length = 5;
        _symbol = 'C';
    }
}
class Battleship : Boat
{
    public Battleship()
    {
        _length = 4;
        _symbol = 'B';
    }
}
class Destroyer : Boat
{
    public Destroyer()
    {
        _length = 3;
        _symbol = 'D';
    }
}
class Submarine : Boat
{
    public Submarine()
    {
        _length = 3;
        _symbol = 'S';
    }
}
class PatrolBoat : Boat
{
    public PatrolBoat()
    {
        _length = 2;
        _symbol = 'P';
    }
}