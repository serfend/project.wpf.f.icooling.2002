using Newtonsoft.Json;
using Panuon.UI.Silver;
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
	public partial class DeviceView冷暖水蒸发器 : UserControl
	{
		public DeviceViewModel viewModel;

		public DeviceView冷暖水蒸发器()
		{
			InitializeComponent();

			var Positions = JsonConvert.DeserializeObject<ObservableCollection<DevicePosition>>(Encoding.UTF8.GetString(Properties.Resources.device_position));
			foreach (var i in Positions) i.Img = $"/Resources/{i.Img}";
			var InstallPositions = JsonConvert.DeserializeObject<ObservableCollection<DeviceInstallPosition>>(Encoding.UTF8.GetString(Properties.Resources.device_installPosition));
			var Material = JsonConvert.DeserializeObject<ObservableCollection<DeviceMaterial>>(Encoding.UTF8.GetString(Properties.Resources.device_material));
			viewModel = new DeviceViewModel()
			{
				Device = new Model.Device.Device()
				{
					Name = this.GetType().Name.Replace("View", ""),
					Size = new Model.Device.DeviceSize(),
					DevicePositions = new DevicePositions()
					{
					},
					InstallPositions = InstallPositions,
					Material = Material,
					Power = new DevicePower(),
					TemperatureDifference = new DeviceTemperatureDifference(),
					ModuleSelect = new DeviceModuleSelect()
				}
			};
			DataContext = viewModel;
			switch (Helper.Tier)
			{
				case 2:
					RectBackground.Fill = FindResource("GridBrush") as Brush;
					break;
			}
		}

		private void image1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			var result = MessageBoxX.Show(sender.ToString(), "Infomation", Application.Current.MainWindow, MessageBoxButton.YesNo);
		}

		private void SelectInstallMethod(object sender, RoutedEventArgs e)
		{
			var result = MessageBoxX.Show(sender.ToString(), "Infomation", Application.Current.MainWindow, MessageBoxButton.YesNo);
		}

		private void SelectPower(object sender, RoutedEventArgs e)
		{
			var item = e.Source as RadioButton;
			switch (item.Tag)
			{
				case "1":
					viewModel.Device.ModuleSelect.MoudleName = "WL3003B";
					break;

				case "2":
					viewModel.Device.ModuleSelect.MoudleName = "WK3005B";

					break;

				case "3":
					viewModel.Device.ModuleSelect.MoudleName = "WL3008B";

					break;
			}
			var result = MessageBoxX.Show(sender.ToString(), "Infomation", Application.Current.MainWindow, MessageBoxButton.YesNo);
		}
	}
}