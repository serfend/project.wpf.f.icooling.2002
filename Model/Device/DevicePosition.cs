using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.Model.Device
{
	/// <summary>
	/// 设备的放置位置
	/// </summary>
	public class DevicePosition
	{
		public string Id { get; set; }
		public string Description { get; set; }

		/// <summary>
		/// 图标路径，需要使用资源文件
		/// </summary>
		public string Img { get; set; }
	}
}