namespace AdapterFacadePattern.Adapters;

public class TurkeyAdapter : IDuck
{
    public ITurkey Turkey { get; set; }

    public TurkeyAdapter(ITurkey turkey)
    {
        Turkey = turkey;
    }

    public void Quack()
    {
        Turkey.Gobble();
    }

    public void Fly()
    {
        for (var i = 0; i < 5; i++) Turkey.Fly();
    }
}