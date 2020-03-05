using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace project.wpf.f.icooling._2002.Extensions
{
	public class MutiConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return System.Convert.ToDouble(value) * System.Convert.ToDouble(parameter);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return System.Convert.ToDouble(value) / System.Convert.ToDouble(parameter);
		}
	}

	public class SimpleAddConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			double result = System.Convert.ToDouble(values[0]);
			parameter = parameter ?? "+";
			switch (parameter)
			{
				case "+":
					for (var i = 1; i < values.Length; i++) result += System.Convert.ToDouble(values[i]);
					break;

				case "-":
					for (var i = 1; i < values.Length; i++) result -= System.Convert.ToDouble(values[i]);
					break;

				case "*":
					for (var i = 1; i < values.Length; i++) result *= System.Convert.ToDouble(values[i]);
					break;

				case "/":
					for (var i = 1; i < values.Length; i++) result /= System.Convert.ToDouble(values[i]);
					break;
			}
			return System.Convert.ToString(result);
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			object[] a = new object[1];
			a[0] = (double)0.0;
			return a;
		}
	}
}