using GalaSoft.MvvmLight;
using Panuon.UI.Silver;
using project.wpf.f.icooling._2002.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.wpf.f.icooling._2002.Model.Device
{
	public class Device : ViewModelBase
	{
		#region 调用计算

		/// <summary>
		/// 计算最终数据，根据设备的名称不同，计算公式不同
		/// </summary>
		public void CaculateRequireWind()
		{
			// 基础值=温差（左下角计算项）*表面积（第一项计算）*系数（右边中间的材料系数选择项）+用户输入值*0.03
			var td = TemperatureDifference.MaxTemperature - TemperatureDifference.FitTemperature;
			var sa = Size.SurfaceArea;
			var k = DeviceMaterial.NowSelect.Ratio;
			var 基础值 = td * sa * k + Power.Power * 0.03;
			switch (name)
			{
				case "机柜空调":
					{
						RequireWind = 基础值;
						break;
					}
				case "风扇过滤器":
					{
						if (td == 0) RequireWind = 99999;
						else
							RequireWind = 0.05 * 基础值 / td;
						return;
					}
				case "水热交换器":
					{
						RequireWind = 基础值;

						break;
					}
				case "加热器":
					{
						RequireWind = 基础值;
						break;
					}
				default:
					Console.WriteLine("无效的设备");
					break;
			}
		}

		/// <summary>
		/// 重新计算连续杂项功率
		/// </summary>
		public void CaculateThePower()
		{
			if (TemperatureDifference == null) return;
			var td = TemperatureDifference.MaxTemperature - TemperatureDifference.FitTemperature;
			var sa = Size.SurfaceArea;
			var k = DeviceMaterial.NowSelect.Ratio;
			// 基础值:温差（左下角计算项）*表面积（第一项计算）*系数（右边中间的材料系数选择项）
			var 用户输入值 = Power.Power;

			var 基础值 = td * sa * k;
			switch (name)
			{
				case "机柜空调":
					{
						if (用户输入值 > 3000000)
							CaculatePower = 999999;
						else if (用户输入值 > 80000)
							CaculatePower = 1.2 * (用户输入值 * 0.024 + 基础值);
						else if (用户输入值 > 60000)
							CaculatePower = 1.2 * (用户输入值 * 0.02 + 基础值);
						else if (用户输入值 > 40000)
							CaculatePower = 1.1 * (用户输入值 * 0.02 + 基础值);
						else if (用户输入值 > 20000)
							CaculatePower = 1.1 * (用户输入值 * 0.0175 + 基础值);
						else if (用户输入值 > 0)
							CaculatePower = 1.2 * (用户输入值 * 0.01 + 基础值);
						break;
					}
				case "风扇过滤器":
					{
						CaculatePower = 0.035 * 用户输入值 * 0.03 + 基础值;
						break;
					}
				case "水热交换器":
					{
						CaculatePower = 0.95 * (1.1 * 用户输入值 * 0.03 + 基础值);
						break;
					}
				case "加热器":
					{
						CaculatePower = 基础值 - 用户输入值 * 0.03;
						break;
					}
				default:
					Console.WriteLine("无效的设备");
					break;
			}
		}

		#endregion 调用计算

		#region 字段

		private DeviceSize size;
		private string name;
		private DevicePositions devicePositions;
		private double caculatePower;
		private double requireWind;
		private string requireWindDescription = "需要的制冷量";
		private string requireWindDescriptionUnit = "单位m³/s";

		private DevicePower power;
		private DeviceTemperatureDifference temperatureDifference;
		private DeviceModuleSelect moduleSelect;
		private DeviceMaterialViewModel deviceMaterial;
		private Atmospheric atmospheric;

		public Atmospheric Atmospheric
		{
			get { return atmospheric; }
			set { this.Set(ref atmospheric, value); }
		}

		#endregion 字段

		public DevicePower Power
		{
			get { return power; }
			set { this.Set(ref power, value); value.Parent = this; CaculateThePower(); }
		}

		/// <summary>
		/// 最终计算值（最右下角）
		/// </summary>
		public double RequireWind
		{
			get { return requireWind; }
			set { this.Set(ref requireWind, value); }
		}

		public string RequireWindDescription
		{
			get { return requireWindDescription; }
			set { this.Set(ref requireWindDescription, value); }
		}

		public string RequireWindDescriptionUnit
		{
			get { return requireWindDescriptionUnit; }
			set { this.Set(ref requireWindDescriptionUnit, value); }
		}

		public Device()
		{
		}

		public DevicePositions DevicePositions
		{
			get { return devicePositions; }
			set { value.Parent = this; this.Set(ref devicePositions, value); }
		}

		/// <summary>
		/// 连续杂项功率计算
		/// </summary>
		public double CaculatePower
		{
			get { return caculatePower; }
			set { this.Set(ref caculatePower, value); }
		}

		/// <summary>
		/// 安装位置  左上第二行
		/// </summary>
		public ObservableCollection<DeviceInstallPosition> InstallPositions { get; set; }

		public DeviceMaterialViewModel DeviceMaterial
		{
			get { return deviceMaterial; }
			set { value.Parent = this; this.Set(ref deviceMaterial, value); }
		}

		public DeviceModuleSelect ModuleSelect
		{
			get { return moduleSelect; }
			set { this.Set(ref moduleSelect, value); }
		}

		public DeviceTemperatureDifference TemperatureDifference
		{
			get { return temperatureDifference; }
			set { value.Parent = this; this.Set(ref temperatureDifference, value); }
		}

		public string Name
		{
			get { return name; }
			set { this.Set(ref name, value); }
		}

		public DeviceSize Size
		{
			get { return size; }
			set { value.Parent = this; this.Set(ref size, value); }
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
		public Device Parent { get; set; }

		public void ResetSurfaceArea()
		{
			if (Parent != null)
			{
				var method = Parent.DevicePositions.NowPosition.SurfaceCaculateMethod;
				if (method == null)
				{
					MessageBoxX.Show("未选中设备位置，当前表面积计算无效", "无效计算");
					return;
				}
				method = method.Replace("W", W.ToString()).Replace("H", H.ToString()).Replace("D", D.ToString());
				using (var d = new DataTable())
				{
					var result = Math.Round(Convert.ToDouble(d.Compute(method, "")) / Math.Pow(10, 6), 2);
					result = result < 0 ? 0 : result;
					SurfaceArea = result;
				}
			}
			else
			{
				MessageBoxX.Show("ResetSurfaceArea Exception", "绑定错误");
			}
		}

		public double SurfaceArea
		{
			get { return surfaceArea; }
			set { this.Set(ref surfaceArea, value); Parent.CaculateThePower(); }
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