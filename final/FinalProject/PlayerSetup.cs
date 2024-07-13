class PlayerSetup : Setup
{
    public override void getLocation()
    {
        Console.Write("Location: ");
        location = Convert.ToInt32(Console.ReadLine());
    }
}