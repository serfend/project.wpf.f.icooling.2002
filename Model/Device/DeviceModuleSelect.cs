using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.Model.Device
{
	public class DeviceModuleSelect : ViewModelBase
	{
		private string moduleName;

		public string MoudleName
		{
			get { return moduleName; }
			set { this.Set(ref moduleName, value); }
		}
	}
}