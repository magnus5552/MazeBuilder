namespace MazeBuilder;

public class MazeBuilder<T> where T : MazeBuilder<T>
{
    protected Maze maze = new Maze();
    
    public MazeBuilder<T> AddRock(int x, int y)
    {
        // добавляем камень
        return (T)this;
    }

    public MazeBuilder<T> AddWater(int x, int y)
    {
        // добавляем воду
        return (T)this;
    }

    // ещё много подобных методов AddXXX для добавления всего в maze.
    
    // Метод, который создает финальный лабиринт и возвращает его.
    public Maze Build()
    {
        // ...
        return maze;
    }
}

public class Maze
{
    
}