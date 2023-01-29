namespace DotnetProjectGenerator.Console.Types.Enums;

public class FrameworkType
{
    public string Value { get; private set; }
    public static FrameworkType Net7 { get => new FrameworkType("net7.0"); }
    public static FrameworkType Net6 { get => new FrameworkType("net6.0"); }

    private FrameworkType(string value) =>
        Value = value;

    public override string ToString() => Value;
}
