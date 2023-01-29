namespace DotnetProjectGenerator.Console.Types.Enums;

public class ProjectType
{
    public string Value { get; private set; }
    public static ProjectType Console { get => new ProjectType("console"); }
    public static ProjectType ClassLib { get => new ProjectType("classlib"); }
    public static ProjectType Xunit { get => new ProjectType("xunit"); }

    private ProjectType(string value) =>
        Value = value;

    public override string ToString() => Value;
}
