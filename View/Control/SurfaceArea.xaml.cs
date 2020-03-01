using Panuon.UI.Silver;
using project.wpf.f.icooling._2002.Controller;
using project.wpf.f.icooling._2002.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project.wpf.f.icooling._2002.View.Control
{
	/// <summary>
	/// 表面积的交互逻辑
	/// </summary>
	public partial class SurfaceAreaView : UserControl
	{
		public SurfaceAreaView()
		{
			InitializeComponent();
			UpdateVisualEffect();
		}

		private void UpdateVisualEffect()
		{
			switch (Helper.Tier)
			{
				case 1:
				case 2:
					//AnimationHelper.SetSlideInFromBottom(GrpPalette, true);
					//GroupBoxHelper.SetShadowColor(GrpPalette, Colors.LightGray);
					//GroupBoxHelper.SetShadowColor(GrpCode, Colors.LightGray);
					break;
			}
		}
	}
}