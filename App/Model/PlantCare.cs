namespace GreenThumb.Model;
public class Light : ICare
{
    public Levels Level {get; set;}
}

public class Water : ICare
{
    public Levels Level {get; set;}
}

public class Fertilize : ICare
{
    public Levels Level {get; set;}
}
public class Prune : ICare
{
    public Levels Level {get; set;}
}

public class Repot : ICare
{
    public Levels Level {get; set;}
}
