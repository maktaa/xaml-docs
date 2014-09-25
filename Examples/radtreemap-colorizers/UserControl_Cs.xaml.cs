using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radtreemap-colorizers_1
   public MainPage()
	{
		InitializeComponent();
		treeMap1.ItemsSource = this.GetData();
	}

	public List<GdpInfo> GetData()
	{
		List<GdpInfo> data = new List<GdpInfo>()
		{
			new GdpInfo(){Country = "Austria", Gdp= 385.1},
			new GdpInfo(){Country ="Belgium" , Gdp=468.6},
			new GdpInfo(){Country ="Brazil" , Gdp=1749},
			new GdpInfo(){Country ="Canada" , Gdp=1565},
			new GdpInfo(){Country ="China" , Gdp=5308},
			new GdpInfo(){Country ="Denmark" , Gdp=318.1},
			new GdpInfo(){Country ="France" , Gdp=2669},
			new GdpInfo(){Country ="Germany" , Gdp=3402},
			new GdpInfo(){Country ="Greece" , Gdp=329},
			new GdpInfo(){Country ="India" , Gdp=1290},
			new GdpInfo(){Country ="Indonesia", Gdp=593.3},
			new GdpInfo(){Country ="Iran", Gdp=346.6},
			new GdpInfo(){Country ="Italy", Gdp=2107},
			new GdpInfo(){Country ="Japan", Gdp=5179},
			new GdpInfo(){Country ="Mexico", Gdp=1021},
			new GdpInfo(){Country ="Netherlands", Gdp=804.7},
			new GdpInfo(){Country ="Norway", Gdp=410.3},
			new GdpInfo(){Country ="Poland", Gdp=467.3},
			new GdpInfo(){Country ="Russia", Gdp=1250},
		};
		return data;
	}
  }
    public class GdpInfo
    {
        public string Country { get; set; }
        public double Gdp { get; set; }
    }
#endregion
}