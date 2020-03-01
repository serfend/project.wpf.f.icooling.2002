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
	public partial class DeviceView : UserControl
	{
		public DeviceView()
		{
			var f = Encoding.UTF8.GetString(Properties.Resources.device_position);
			var list = JsonConvert.DeserializeObject<ObservableCollection<DevicePosition>>(f);
			foreach (var i in list) i.Img = $"/Resources/{i.Img}";
			DeviceViewModel viewModel = new DeviceViewModel()
			{
				Device = new Model.Device.Device()
				{
					Name = this.GetType().Name.Replace("View", ""),
					Size = new Model.Device.DeviceSize(),
					Positions = list
				}
			};
			DataContext = viewModel;
			InitializeComponent();
			switch (Helper.Tier)
			{
				case 2:
					RectBackground.Fill = FindResource("GridBrush") as Brush;
					break;
			}
		}
	}
}