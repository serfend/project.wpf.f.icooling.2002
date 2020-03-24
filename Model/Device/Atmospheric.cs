using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.Model.Device
{
	public class Atmospheric : ViewModelBase
	{
		public ObservableCollection<AtmosphericOption> Atmospherics { get; set; }
		private AtmosphericOption nowSelect;

		public AtmosphericOption NowSelect
		{
			get { return nowSelect; }
			set { this.Set(ref nowSelect, value); }
		}
	}

	public class AtmosphericOption
	{
		public string Height { get; set; }
		public double Presure { get; set; }
	}
}