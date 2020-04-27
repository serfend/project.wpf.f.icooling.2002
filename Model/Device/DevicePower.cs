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
		public Device Parent { get; set; }
		private double power;
		private string powerInputLabelText = "连续的杂项功率";

		public string PowerInputLabelText
		{
			get { return powerInputLabelText; }
			set { this.Set(nameof(PowerInputLabelText), ref powerInputLabelText, value); }
		}

		public double Power
		{
			get { return power; }
			set { this.Set(nameof(Power), ref power, value); Parent.CaculateThePower(); }
		}
	}
}