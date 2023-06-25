using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
	/// <summary>
	/// 模拟IO设备
	/// </summary>
	public abstract class IODevice : Device
	{
		public bool EnableInput;
		public bool EnableOutput;
		public abstract void Operate();
		public abstract void Reset();
		public abstract void Input();
		public abstract void Output();
	}

}
