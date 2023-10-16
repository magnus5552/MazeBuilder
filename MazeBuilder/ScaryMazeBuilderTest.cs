using NUnit.Framework;

namespace MazeBuilder;

public class ScaryMazeBuilderTest
{
    [Test]
    public void TestBuilder_Ok()
    {
        var builder = new ScaryMazeBuilder();
        var maze = builder
                   .AddGhost(5, 5)
                   .AddGhost(15, 5)
                   .AddRock(5, 6)
                   .AddRock(5, 4)
                   .AddRock(4, 5)
                   .Build();
    }
    
    [Test]
    public void TestBuilder_ShouldBeOk()
    {
        var builder = new ScaryMazeBuilder();
        var maze = builder
                   .AddRock(5, 6)
                   .AddRock(5, 4)
                   .AddRock(4, 5)
                   // .AddGhost(5, 5) // не работает :(
                   // .AddGhost(15, 5)  // не работает :(
                   .Build();
    }
}