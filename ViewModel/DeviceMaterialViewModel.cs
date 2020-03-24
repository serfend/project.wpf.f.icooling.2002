using GalaSoft.MvvmLight;
using project.wpf.f.icooling._2002.Model.Device;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.ViewModel
{
	public class DeviceMaterialViewModel : ViewModelBase
	{
		public Device Parent { get; set; }
		public ObservableCollection<DeviceMaterial> Members { get; set; }
		private DeviceMaterial nowSelect;

		public DeviceMaterial NowSelect
		{
			get { return nowSelect; }
			set { this.Set(ref nowSelect, value); Parent?.CaculateThePower(); }
		}
	}
}