using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Programs
{
	public abstract class Program : IExecutable
	{
		public abstract void Start();
		public abstract void Stop();
		public abstract void Terminate();
	}
}
