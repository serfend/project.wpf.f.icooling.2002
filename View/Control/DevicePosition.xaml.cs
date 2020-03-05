using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
	/// DevicePosition.xaml 的交互逻辑
	/// </summary>
	public partial class DevicePosition : UserControl
	{
		[Category("Behavior")]
		public static readonly RoutedEvent OnSelectionChangedEvent =
  EventManager.RegisterRoutedEvent(
  "OnSelectionChanged",
  RoutingStrategy.Bubble,
  typeof(RoutedEventHandler),
  typeof(DevicePosition));

		public event RoutedEventHandler OnSelectionChanged
		{
			add { AddHandler(OnSelectionChangedEvent, value); }
			remove { RemoveHandler(OnSelectionChangedEvent, value); }
		}

		public DevicePosition()
		{
			InitializeComponent();
		}

		private void SingleOption_OnChecked(object sender, RoutedEventArgs e)
		{
			//var result = MessageBoxX.Show(sender.ToString(), "Infomation", Application.Current.MainWindow, MessageBoxButton.YesNo);
			SingleOption source = sender as SingleOption;
			var option = source.DataContext as Model.Device.DevicePosition;
			var global = DataContext as Model.Device.DevicePositions;
			global.NowPosition = option;
			this.RaiseEvent(new RoutedEventArgs(OnSelectionChangedEvent, option));
		}
	}
}