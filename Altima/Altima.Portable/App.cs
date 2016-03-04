using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Altima.Views;
using Prism.Unity;
using Xamarin.Forms;

namespace Altima
{
	public class App : PrismApplication
	{
	    protected override void OnInitialized()
	    {
	        NavigationService.Navigate("RootPage/CommonNavigationPage/AboutPage");
	    }

	    protected override void RegisterTypes()
	    {
	        Container.RegisterTypeForNavigation<RootPage>();
	        Container.RegisterTypeForNavigation<CommonNavigationPage>();
	        Container.RegisterTypeForNavigation<RootPage>();
	    }
	}
}
