namespace DotnetProjectGenerator.Console.Wrappers;

public class ProcessWrapper : IProcessWrapper
{
    public bool Start(string command)
    {
        try
        {
            using var process = new Process();
            process.StartInfo.FileName = "dotnet";
            process.StartInfo.Arguments = command;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            process.WaitForExit();

            return true;
        }
        catch(Exception ex)
        {
            System.Console.Error.WriteLine(ex.Message);

            return false;
        }
    }
}
