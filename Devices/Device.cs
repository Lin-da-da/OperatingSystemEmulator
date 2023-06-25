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
		public string? Name { get; set; }
		public int Id { get; set; }
		/// <summary>
		/// 是否启用
		/// </summary>
		public bool IsEnabled { get; set; }
		/// <summary>
		/// 是否就绪
		/// </summary>
		public bool IsOnlined { get; set; }
	}
}
