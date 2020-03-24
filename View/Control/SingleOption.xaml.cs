using System;
using System.Collections.Generic;
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
	/// SingleOption.xaml 的交互逻辑
	/// </summary>
	public partial class SingleOption : UserControl
	{
		[Category("Behavior")]
		public static readonly RoutedEvent OnCheckedEvent =
  EventManager.RegisterRoutedEvent(
  "SingleOptionOnChecked",
  RoutingStrategy.Bubble,
  typeof(RoutedEventHandler),
  typeof(SingleOption));

		public event RoutedEventHandler SingleOptionOnChecked
		{
			add { AddHandler(OnCheckedEvent, value); }
			remove { RemoveHandler(OnCheckedEvent, value); }
		}

		public SingleOption()
		{
			InitializeComponent();
		}

		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			this.RaiseEvent(new RoutedEventArgs(OnCheckedEvent));
		}
	}
}