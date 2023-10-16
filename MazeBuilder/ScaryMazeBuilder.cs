namespace MazeBuilder;

public class ScaryMazeBuilder : MazeBuilder<ScaryMazeBuilder>
{
    // Хотим добавить новые возможности к MazeBuilder-у
    public ScaryMazeBuilder AddGhost(int x, int y)
    {
        //...
        return this;
    }

    // ещё много методов добавления страшилок в лабиринт.
}