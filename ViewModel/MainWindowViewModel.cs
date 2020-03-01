using Panuon.UI.Silver.Core;
using project.wpf.f.icooling._2002.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.ViewModel
{
	public class MainWindowViewModel : PropertyChangedBase
	{
		public MainWindowViewModel(ObservableCollection<TabControllViewItemModel> MenuItems)
		{
			this.MenuItems = MenuItems;
		}

		public ObservableCollection<TabControllViewItemModel> MenuItems { get; } = new ObservableCollection<TabControllViewItemModel>();
	}
}