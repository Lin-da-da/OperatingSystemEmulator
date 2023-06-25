namespace Devices
{
	/// <summary>
	/// 模拟磁盘
	/// </summary>
	public class Disk : Device
	{
		private byte[] data;
		public Disk()
		{
            data = new byte[1024 * 1024 * 1024];
        }
	}
}