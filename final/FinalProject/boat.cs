abstract class Boat
{
    public string _name;
    public int _length;
    public char _symbol;
}

class Carrier : Boat
{
    public Carrier()
    {
        _name = "Carrier";
        _length = 5;
        _symbol = 'C';
    }
}
class Battleship : Boat
{
    public Battleship()
    {
        _name = "Battleship";
        _length = 4;
        _symbol = 'B';
    }
}
class Destroyer : Boat
{
    public Destroyer()
    {
        _name = "Destroyer";
        _length = 3;
        _symbol = 'D';
    }
}
class Submarine : Boat
{
    public Submarine()
    {
        _name = "Submarine";
        _length = 3;
        _symbol = 'S';
    }
}
class PatrolBoat : Boat
{
    public PatrolBoat()
    {
        _name = "Patrol Boat";
        _length = 2;
        _symbol = 'P';
    }
}