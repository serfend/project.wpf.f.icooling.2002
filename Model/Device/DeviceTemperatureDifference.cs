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
		public Device Parent { get; set; }
		private double maxTemperature;
		private double fitTemperature;

		public double FitTemperature
		{
			get { return fitTemperature; }
			set { this.Set(nameof(FitTemperature), ref fitTemperature, value); Parent?.CaculateThePower(); }
		}

		public double MaxTemperature
		{
			get { return maxTemperature; }
			set { this.Set(nameof(MaxTemperature), ref maxTemperature, value); Parent?.CaculateThePower(); }
		}
	}
}