abstract class Goal
{
    public string _name;
    public int _pointValue;
    public abstract int complete();
    public abstract void display();
    public abstract string saveString();
}