namespace DotnetProjectGenerator.Console.Models;

public class DotnetAddCommandArgs
{
    public string ProjectName { get; set; } = "New project";
    public string ProjectPath { get; set; } = 
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    public ProjectType ProjectType { get; set; } = ProjectType.Console;
    public FrameworkType FrameworkType { get; set; } = FrameworkType.Net7;
}
