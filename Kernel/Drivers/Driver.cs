using Devices;

namespace Kernel.Drivers
{
	/// <summary>
	/// 模拟设备驱动程序
	/// </summary>
	/// <typeparam name="T">设备类</typeparam>
	internal abstract class Driver<T> where T : Device
	{
		public abstract T Device { get; }
		public abstract void Initialize();
		public abstract void Shutdown();

	}
}
