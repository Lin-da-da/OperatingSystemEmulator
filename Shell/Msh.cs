using CommandLine;

using static System.Console;
using static Shell.MshStaticResource;


namespace Shell
{
	public class Msh
	{
		public void Start()
		{
			WriteLine($"{MshName}@{MshVersion}\n");
			while(true)
			{
                Write(GenPromptWithDirectory(System.Environment.CurrentDirectory));
				var input = ReadLine();
				WriteLine(input);
            }
		}
	}
}