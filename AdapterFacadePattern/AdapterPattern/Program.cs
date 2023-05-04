using AdapterFacadePattern.Adapters;
using AdapterFacadePattern.Ducks;

var duck = new MallardDuck();

var turkey = new WildTukey();
var turkeyAdapter = new TurkeyAdapter(turkey);

Console.WriteLine("The turkey says...");
turkey.Gobble();
turkey.Fly();

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("The duck says...");
TestDuck(duck);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("The TurkeyAdapter says...");
TestDuck(turkeyAdapter);

Console.WriteLine();
Console.WriteLine();

static void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}