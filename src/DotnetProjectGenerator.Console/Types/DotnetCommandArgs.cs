namespace DotnetProjectGenerator.Console.Types;

public class DotnetCommandArgs
{
    public string BasePath { get; set; } =
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
            "DotnetProjectGenerated"
        );
    public string SolutionName 
    { 
        get => _solutionName; 
        set
        {
            _solutionName = value;
            _solutionNameWithExtension = value + ".sln";
        }
    }
    public string SolutionNameWithExtension 
    { 
        get => _solutionNameWithExtension; 
        private set
        {
            _solutionNameWithExtension = value;
            _solutionName = value.Split('.')[0];
        }
    }
    public List<ProjectConfig> ProjectConfigs { get; set; } = new();

    private string _solutionName = "DotnetProjectSolution";
    private string _solutionNameWithExtension = "DotnetProjectSolution.sln";
}
