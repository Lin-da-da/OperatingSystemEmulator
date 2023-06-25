using CommandLine;

using Shell.InternalCommands;
using Kernel.Programs;

using static System.Console;
using static Shell.MshStaticResource;


namespace Shell
{
	public class MshLauncher : Program
	{
		public override void Start()
		{
			WriteLine($"{MshName}@{MshVersion}\n");
			Msh msh = new Msh();
			while(true)
			{
                Write(GenPromptWithDirectory(System.Environment.CurrentDirectory));
				var input = ReadLine();
				
            }
		}

		public override void Stop()
		{
			throw new NotImplementedException();
		}

		public override void Terminate()
		{
			throw new NotImplementedException();
		}
	}
}