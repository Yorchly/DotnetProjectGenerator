namespace DotnetProjectGenerator.Console.Utils;

public static class DotnetCommandUtils
{
    /// <summary>
    /// Returns command to add solution to specified path.
    /// </summary>
    /// <param name="solutionName"></param>
    /// <param name="solutionPath"></param>
    /// <returns></returns>
    public static string GetAddSolutionCommand(string solutionName, string solutionPath) =>
        $"dotnet new sln --name {solutionName} --output {solutionPath} --force";


    /// <summary>
    /// Returns command to add new project to specified path.
    /// </summary>
    /// <param name="projectConfig"></param>
    /// <returns></returns>
    public static string GetAddNewProjectCommand(ProjectConfig projectConfig) =>
        $"dotnet new {projectConfig.ProjectType.Value} --name {projectConfig.ProjectName} " +
        $"--output {projectConfig.ProjectPath} --language" +
        $" \"C#\" --framework {projectConfig.FrameworkType.Value} --force";

    /// <summary>
    /// Returns command to add project to solution.
    /// </summary>
    /// <param name="solutionFullPath">The solution full path must include the solution filename</param>
    /// <param name="projectPath"></param>
    /// <returns></returns>
    public static string GetAddProjectToSolutionCommand(string solutionFullPath, string projectPath) =>
        $"dotnet sln {solutionFullPath} add {projectPath}";

    /// <summary>
    /// Returns the command to add in project 1 a reference to project 2.
    /// </summary>
    /// <param name="projectCsprojFullPath1">full path must include name of project with csproj extension.</param>
    /// <param name="projectCsprojFullPath2"></param>
    /// <returns></returns>
    public static string GetAddReferenceProjectToProject(
        string projectCsprojFullPath1,
        string projectCsprojFullPath2
    ) => $"dotnet add {projectCsprojFullPath1} reference {projectCsprojFullPath2}";

}
