namespace DiceRoller.Menu.Menu;

public class Menu
{
    private readonly List<MenuItem> _menuItems;
}


public abstract class MenuItem
{
    public string Title { get; private set; }

    protected MenuItem(string title)
    {
        Title = title;
    }

    protected abstract void Open();
}


public class SubMenuItem : MenuItem
{
    private readonly List<MenuItem> _subItems;

    protected SubMenuItem(string title, List<MenuItem> subItems) : base(title)
    {
        _subItems = subItems;
    }

    protected override void Open() { }
}

public class ExecMenuItem : MenuItem
{
    private readonly Action _action; // delegate 

    protected ExecMenuItem(string title) : base(title) { }

    protected override void Open() => _action();
}
