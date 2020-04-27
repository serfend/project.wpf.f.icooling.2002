using GalaSoft.MvvmLight;
using Panuon.UI.Silver.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace project.wpf.f.icooling._2002.Model
{
	/// <summary>
	/// 条目
	/// </summary>
	public class TabControllViewItemModel : ViewModelBase
	{
		public TabControllViewItemModel(string header, string tag, string icon = null)
		{
			Header = header;
			Tag = tag;
			Icon = icon;
		}

		private object content;

		public object Content
		{
			get { return content; }
			set { this.Set(nameof(Content), ref content, value); }
		}

		public string Icon { get; set; }

		public string Header { get; set; }

		public string Tag { get; set; }

		public Visibility Visibility
		{
			get => _visibility;
			set { this.Set(nameof(Visibility), ref _visibility, value); }
		}

		private Visibility _visibility = Visibility.Visible;
	}
}