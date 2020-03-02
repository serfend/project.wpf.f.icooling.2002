using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.Model.Device
{
	public class DeviceTemperatureDifference : ViewModelBase
	{
		private double maxTemperature;
		private double fitTemperature;

		public double FitTemperature
		{
			get { return fitTemperature; }
			set { this.Set(ref fitTemperature, value); }
		}

		public double MaxTemperature
		{
			get { return maxTemperature; }
			set { this.Set(ref maxTemperature, value); }
		}
	}
}