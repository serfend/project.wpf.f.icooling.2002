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
	public class DeviceViewModel : ViewModelBase
	{
		public DeviceViewModel()
		{
			device = new Device();
		}

		private Device device;

		public Device Device
		{
			get { return device; }
			set { this.Set(ref device, value); }
		}
	}
}