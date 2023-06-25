using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Programs
{
	/// <summary>
	/// 可执行应用程序接口，只有实现该接口的类才可以在系统中作为可执行程序运行
	/// </summary>
	public interface IExecutable
	{
		/// <summary>
		/// 启动
		/// </summary>
		public void Start();
		/// <summary>
		/// 暂停
		/// </summary>
		public void Stop();
		/// <summary>
		/// 终止，被终止的程序会被自动清理
		/// </summary>
		public void Terminate();
	}
}
