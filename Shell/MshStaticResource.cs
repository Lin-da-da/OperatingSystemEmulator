using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell
{
	internal static class MshStaticResource
	{
		public const string MshVersion = "0.0.1";
		public const string MshName = "Msh";
		public const string DefaultPrompt = "Msh> ";

		public static string GenPromptWithDirectory(string dir)
		{
			return $"{dir} > ";
		}
	}
}
