using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.Model.Device
{
	public class DevicePositions : ViewModelBase
	{
		private DevicePosition nowPosition;
		private ObservableCollection<DevicePosition> positions;
		public Device Parent { get; set; }

		public ObservableCollection<DevicePosition> Positions
		{
			get { return positions; }
			set { this.Set(nameof(Positions), ref positions, value); }
		}

		public DevicePosition NowPosition
		{
			get { return nowPosition; }
			set { this.Set(nameof(NowPosition), ref nowPosition, value); ResetSurfaceArea(); }
		}

		private void ResetSurfaceArea()
		{
			if (Parent != null)
			{
				Parent.Size.ResetSurfaceArea();
			}
		}
	}

	/// <summary>
	/// 设备的放置位置
	/// </summary>
	public class DevicePosition : DescriptionItem
	{
		private const string res = "/Resources/";
		private string img;
		private string hugeImg;
		public string SurfaceCaculateMethod { get; set; }

		/// <summary>
		/// 图标路径，需要使用资源文件
		/// </summary>
		public string Img { get => img.Contains(res) ? img : $"{res}{img}"; set => img = value; }

		public string HugeImg { get => hugeImg.Contains(res) ? hugeImg : $"{res}{hugeImg}"; set => hugeImg = value; }
	}

	/// <summary>
	/// 包含说明的项
	/// </summary>
	public class DescriptionItem
	{
		public string Id { get; set; }
		public string Description { get; set; }
	}

	/// <summary>
	/// 设备安装位置
	/// </summary>
	public class DeviceInstallPosition : DescriptionItem
	{
	}
}