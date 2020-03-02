using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.Model.Device
{
	public class DevicePower : ViewModelBase
	{
		private double power;

		public double Power
		{
			get { return power; }
			set { this.Set(ref power, value); }
		}
	}
}