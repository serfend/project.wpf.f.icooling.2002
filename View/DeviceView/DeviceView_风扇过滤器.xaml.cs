using Newtonsoft.Json;
using project.wpf.f.icooling._2002.Controller;
using project.wpf.f.icooling._2002.Model.Device;
using project.wpf.f.icooling._2002.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project.wpf.f.icooling._2002.View
{
	/// <summary>
	/// DeviceView.xaml 的交互逻辑
	/// </summary>
	public partial class DeviceView风扇过滤器 : UserControl
	{
		public DeviceView风扇过滤器()
		{
			InitializeComponent();

			var Positions = JsonConvert.DeserializeObject<ObservableCollection<DevicePosition>>(Encoding.UTF8.GetString(Properties.Resources.device_position));
			foreach (var i in Positions) i.Img = $"/Resources/{i.Img}";
			var InstallPositions = JsonConvert.DeserializeObject<ObservableCollection<DeviceInstallPosition>>(Encoding.UTF8.GetString(Properties.Resources.device_installPosition));
			var Material = JsonConvert.DeserializeObject<ObservableCollection<DeviceMaterial>>(Encoding.UTF8.GetString(Properties.Resources.device_material));
			DeviceViewModel viewModel = new DeviceViewModel()
			{
				Device = new Model.Device.Device()
				{
					Name = this.GetType().Name.Replace("View", ""),
					Size = new Model.Device.DeviceSize(),
					DevicePositions = new DevicePositions()
					{
						NowPosition = Positions[0],
						Positions = Positions
					},
					InstallPositions = InstallPositions,
					Material = Material,
					Power = new DevicePower(),
					TemperatureDifference = new DeviceTemperatureDifference()
				}
			};

			//初始化设备材料的ViewModel
			DeviceMaterial.DataContext = new DeviceMaterialViewModel()
			{
				Members = Material,
				NowSelect = new DeviceMaterial()
			};

			DataContext = viewModel;
			switch (Helper.Tier)
			{
				case 2:
					RectBackground.Fill = FindResource("GridBrush") as Brush;
					break;
			}
		}
	}
}