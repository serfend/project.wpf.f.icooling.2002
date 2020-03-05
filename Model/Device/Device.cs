using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.Model.Device
{
	public class Device : ViewModelBase
	{
		private DeviceSize size;
		private string name;
		private DevicePositions devicePositions;

		public DevicePositions DevicePositions
		{
			get { return devicePositions; }
			set { this.Set(ref devicePositions, value); }
		}

		public ObservableCollection<DeviceInstallPosition> InstallPositions { get; set; }
		public ObservableCollection<DeviceMaterial> Material { get; set; }
		private double caculateResult;
		private DevicePower power;
		private DeviceTemperatureDifference temperatureDifference;
		private DeviceModuleSelect moduleSelect;

		public DeviceModuleSelect ModuleSelect
		{
			get { return moduleSelect; }
			set { this.Set(ref moduleSelect, value); }
		}

		public DeviceTemperatureDifference TemperatureDifference
		{
			get { return temperatureDifference; }
			set { this.Set(ref temperatureDifference, value); }
		}

		public DevicePower Power
		{
			get { return power; }
			set { this.Set(ref power, value); }
		}

		public double CaculateResult
		{
			get { return caculateResult; }
			set { this.Set(ref caculateResult, value); }
		}

		public string Name
		{
			get { return name; }
			set { this.Set(ref name, value); }
		}

		public DeviceSize Size
		{
			get { return size; }
			set { this.Set(ref size, value); }
		}
	}

	/// <summary>
	/// 设备尺寸，单位mm
	/// </summary>
	public class DeviceSize : ViewModelBase
	{
		private int w;
		private int h;
		private int d;
		private double surfaceArea;

		private void ResetSurfaceArea()
		{
			SurfaceArea = w + h + d;
		}

		public double SurfaceArea
		{
			get { return surfaceArea; }
			set { this.Set(ref surfaceArea, value); }
		}

		public int D
		{
			get { return d; }
			set { this.Set(ref d, value); ResetSurfaceArea(); }
		}

		public int H
		{
			get { return h; }
			set { this.Set(ref h, value); ResetSurfaceArea(); }
		}

		public int W
		{
			get { return w; }
			set { this.Set(ref w, value); ResetSurfaceArea(); }
		}
	}
}