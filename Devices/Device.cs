using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
	/// <summary>
	/// 代表设备的抽象类
	/// </summary>
	public abstract class Device
	{
		public abstract string Name { get; set; }
		public abstract bool IsEnabled { get; set; }
		public abstract bool IsOnline { get; set; }
	}
}
