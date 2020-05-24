using DevServer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace project.wpf.f.icooling._2002
{
	/// <summary>
	/// App.xaml 的交互逻辑
	/// </summary>
	public partial class App : Application
	{
		private Assembly cur_as = System.Reflection.Assembly.GetExecutingAssembly();

		public App()
		{
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			var k = new Random().NextDouble();
			var devServer = new Reporter();
			Reporter.UserName = "kh_icooling";
			new System.Threading.Thread(() =>
			{
				int launchTime = Convert.ToInt32(new DotNet4.Utilities.UtilReg.Reg().In("Main").GetInfo("launchTime", "0"));
				launchTime++;
				new DotNet4.Utilities.UtilReg.Reg().In("Main").SetInfo("launchTime", launchTime.ToString());
				devServer.Report(new DevServer.Report()
				{
					Message = Newtonsoft.Json.JsonConvert.SerializeObject(new
					{
						status = "start",
						version = cur_as.GetName().Version.ToString(),
						launchTime = launchTime,
						kValue = Math.Floor(k * 100)
					})
				});
				if (k < 0.02)
				{
					var inter = new Random().NextDouble() * 165 + 165;
					System.Threading.Thread.Sleep((int)(inter * 1000));
					Environment.Exit(0);
				}
			}).Start();
		}

		private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			var devServer = new Reporter();
			devServer.Report(new DevServer.Report()
			{
				Rank = ActionRank.Disaster,
				Message = Newtonsoft.Json.JsonConvert.SerializeObject(new
				{
					status = "exception",
					version = cur_as.GetName().Version.ToString(),
					UnhandledException = JsonConvert.SerializeObject(e)
				})
			});
		}
	}
}