using System;
using System.Collections.Generic;
using System.Diagnostics;
using IL.SolutionBuilder.Business.Abstract;

namespace IL.SolutionBuilder.Business.Concrete
{
    public class CommandManager : ICommandService
    {
        public void Run(List<string> commands)
        {
            var cmd = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                }
            };

            cmd.Start();
            cmd.StandardInput.WriteLine(@"cd\");
            cmd.StandardInput.WriteLine(@"cd .\SolutionBuilder");

            foreach (var command in commands)
            {
                cmd.StandardInput.WriteLine(command);
            }

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            cmd.StandardOutput.ReadToEnd();

        }
    }
}
