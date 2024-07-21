class RandomSetup : Setup
{
    public override void getLocation(Boat boat)
    {
        Random random = new Random();
        _location = random.Next(0, 100);
        _vertical = random.Next(2) == 0;
    }
}