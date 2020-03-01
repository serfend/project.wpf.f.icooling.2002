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

namespace project.wpf.f.icooling._2002.View.Control
{
	/// <summary>
	/// DeviceMaterial.xaml 的交互逻辑
	/// </summary>
	public partial class DeviceMaterial : UserControl
	{
		public DeviceMaterial()
		{
			InitializeComponent();
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var i = ComboBox.SelectedItem as Model.Device.DeviceMaterial;
			var viewModel = DataContext as DeviceMaterialViewModel;
			viewModel.NowSelect = i;
		}
	}
}