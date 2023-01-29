string newProjectBasePath = "C:\\Users\\jorge\\source\\repos\\Test";
var processWrapper = new ProcessWrapper();
bool result = processWrapper.Start(
    DotnetCommandUtils.GetAddSolutionCommand("Test", newProjectBasePath)
);

if (result)
    Console.WriteLine($"Solution created successfully in {newProjectBasePath}");

var commandArgs = new DotnetAddCommandArgs
{
    ProjectName = "ConsoleTestProject",
    ProjectPath = Path.Combine(newProjectBasePath, "ConsoleTestProject"),
    ProjectType = ProjectType.Console,
    FrameworkType = FrameworkType.Net7
};

string addNewProjectCommand = 
    DotnetCommandUtils.GetAddNewProjectCommand(commandArgs);

result = processWrapper.Start(addNewProjectCommand);

if (result)
    Console.WriteLine($"Project added successfully in {newProjectBasePath}");

result = processWrapper.Start(
    DotnetCommandUtils.GetAddProjectToSolutionCommand(
        Path.Combine(newProjectBasePath, "Test.sln"),
        Path.Combine(newProjectBasePath, commandArgs.ProjectName)
    )
);

if (result)
    Console.WriteLine($"Project added successfully to solution");
