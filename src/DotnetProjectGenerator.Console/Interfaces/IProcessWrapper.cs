namespace DotnetProjectGenerator.Console.Interfaces;

public interface IProcessWrapper
{
    /// <summary>
    /// Start a dotnet process with the arguments specified in command paremeter.
    /// DotnetCommandUtils.cs contains a few helper methods to get this commands.
    /// </summary>
    /// <param name="command">Dotnet command to be executed.</param>
    /// <returns></returns>
    public bool Start(string command);
}
