var dotnetCommandArgs = new DotnetCommandArgs
{
    BasePath = "C:\\Users\\jorge\\source\\repos\\Test",
    SolutionName = "TestSolution"
};
var processWrapper = new ProcessWrapper();
bool result = processWrapper.Start(
    DotnetCommandUtils.GetAddSolutionCommand(dotnetCommandArgs.SolutionName, dotnetCommandArgs.BasePath)
);

if (result)
    Console.WriteLine($"Solution created successfully in {dotnetCommandArgs.BasePath}");

var projectConfig1 = new ProjectConfig
{
    ProjectName = "ConsoleTestProject",
    ProjectPath = Path.Combine(dotnetCommandArgs.BasePath, "ConsoleTestProject"),
    ProjectType = ProjectType.Console,
    FrameworkType = FrameworkType.Net7
};

var projectConfig2 = new ProjectConfig
{
    ProjectName = "ConsoleTestProject2",
    ProjectPath = Path.Combine(dotnetCommandArgs.BasePath, "ConsoleTestProject2"),
    ProjectType = ProjectType.ClassLib,
    FrameworkType = FrameworkType.Net6
};

dotnetCommandArgs.ProjectConfigs.Add(projectConfig1);
dotnetCommandArgs.ProjectConfigs.Add(projectConfig2);

foreach(ProjectConfig config in dotnetCommandArgs.ProjectConfigs)
{
    string addNewProjectCommand =
        DotnetCommandUtils.GetAddNewProjectCommand(config);

    result = processWrapper.Start(addNewProjectCommand);

    if (result)
        Console.WriteLine($"Project '{config.ProjectName}' added successfully in {dotnetCommandArgs.BasePath}");

    result = processWrapper.Start(
        DotnetCommandUtils.GetAddProjectToSolutionCommand(
            Path.Combine(dotnetCommandArgs.BasePath, dotnetCommandArgs.SolutionNameWithExtension),
            config.ProjectPath
        )
    );

    if (result)
        Console.WriteLine($"Project '{config.ProjectName}' added successfully to solution");
}

result = processWrapper.Start(
    DotnetCommandUtils.GetAddReferenceProjectToProject(
        Path.Combine(projectConfig1.ProjectPath, projectConfig1.ProjectName + ".csproj"),
        Path.Combine(projectConfig2.ProjectPath, projectConfig2.ProjectName + ".csproj")
    )
);

if (result)
    Console.WriteLine(
        $"Added reference to project '{projectConfig2.ProjectName}' in project '{projectConfig1.ProjectName}'"
    );
