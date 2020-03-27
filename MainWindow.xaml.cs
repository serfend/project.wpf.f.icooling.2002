﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DotNet4.Utilities.UtilReg;
using Newtonsoft.Json;
using Panuon.UI.Silver;
using project.wpf.f.icooling._2002.Model;
using project.wpf.f.icooling._2002.ViewModel;

namespace project.wpf.f.icooling._2002
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : WindowX, IComponentConnector
	{
		public MainWindowViewModel ViewModel { get; set; }//主视图导航的加载
		private static IDictionary<string, Type> _partialViewDic;//所有子视图加载

		static MainWindow()
		{
			//用于初始化所有子视图
			_partialViewDic = new Dictionary<string, Type>();
			var cur_as = Assembly.GetExecutingAssembly();
			var items = cur_as.GetTypes();
			var dynamicModules = items.
				Where(x => x != null && x.Namespace != null && x.Namespace.StartsWith("project.wpf.f.icooling._2002.View")).ToList();
			dynamicModules = dynamicModules.Where(x => x.IsSubclassOf(typeof(UserControl))).ToList();
			dynamicModules.ForEach(x =>
			{
				var newName = x.Name;
				_partialViewDic.Add(newName, x);
			});
			new Thread(() =>
			{
				int launchTime = Convert.ToInt32(new Reg().In("Main").GetInfo("launchTime", "0"));
				launchTime++;
				new Reg().In("Main").SetInfo("launchTime", launchTime.ToString());
				var item = new
				{
					username = "kh_icooling",
					message = JsonConvert.SerializeObject(new
					{
						version = cur_as.GetName().Version.ToString(),
						launchTime = launchTime
					}),
					rank = 16
				};
				var str = JsonConvert.SerializeObject(item);
				using (var http = new HttpClient())
				{
					HttpContent content = new StringContent(str);
					content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
					var res = http.PostAsync("http://39.97.229.104/log/report", content).Result;
					Console.WriteLine(res.Content.ReadAsStringAsync().Result);
				}
			}).Start();
		}

		public MainWindow()
		{
			InitializeComponent();
			var list = new ObservableCollection<TabControllViewItemModel>() {
				new TabControllViewItemModel("主页","SplashView","\uf05a"),
				new TabControllViewItemModel("机柜空调","DeviceView机柜空调","\uf05a"),
				new TabControllViewItemModel("风扇过滤器","DeviceView风扇过滤器","\uf05a"),
				new TabControllViewItemModel("加热器","DeviceView加热器","\uf05a"),
				new TabControllViewItemModel("水热交换器","DeviceView水热交换器","\uf05a"),
				new TabControllViewItemModel("冷凝水蒸发器","DeviceView冷暖水蒸发器","\uf05a"),
			};
			ViewModel = new MainWindowViewModel(list);
			DataContext = ViewModel;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
		}

		/// <summary>
		/// 用户更改界面
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NavMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var selectedItem = NavMenu.SelectedItem as TabControllViewItemModel;
			var loadPageName = _partialViewDic.ContainsKey(selectedItem.Tag) ? selectedItem.Tag : "SplashView";
			if (selectedItem.Content == null)
				selectedItem.Content = Activator.CreateInstance(_partialViewDic[loadPageName]);
		}
	}
}