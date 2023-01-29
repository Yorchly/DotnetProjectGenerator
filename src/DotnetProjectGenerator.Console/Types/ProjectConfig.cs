namespace DotnetProjectGenerator.Console.Types;

public class ProjectConfig
{
    public string ProjectName { get; set; } = "ConsoleProject";
    public string ProjectPath { get; set; } =
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "DotnetProjectGenerated",
            "ConsoleProject"
        );
    public ProjectType ProjectType { get; set; } = ProjectType.Console;
    public FrameworkType FrameworkType { get; set; } = FrameworkType.Net7;
}
