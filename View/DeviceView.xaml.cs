using project.wpf.f.icooling._2002.Controller;
using project.wpf.f.icooling._2002.ViewModel;
using System;
using System.Collections.Generic;
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
			DeviceViewModel viewModel = new DeviceViewModel() { Device = new Model.Device.Device() { Name = this.GetType().Name.Replace("View", ""), Size = new Model.Device.DeviceSize() } };
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