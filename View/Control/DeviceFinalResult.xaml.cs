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
	/// DeviceFinalResult.xaml 的交互逻辑
	/// </summary>
	public partial class DeviceFinalResult : UserControl
	{
		public DeviceFinalResult()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("计算");
		}
	}
}