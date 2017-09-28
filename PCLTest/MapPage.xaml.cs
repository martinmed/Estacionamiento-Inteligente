// ------------------------------------------------------------------------------
//  Copyright © 2017 Esri. All rights reserved.
//  Author: John Doherty
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using FreshTinyIoC;
using PCLTest.Core;
using Xamarin.Forms;

namespace PCLTest
{
	public partial class MapPage : ContentPage
	{
		public MapPage()
		{
			InitializeComponent();
			var mapContentView = FreshTinyIoCContainer.Current.Resolve<IMapContentView>() as ContentView;
			if (mapContentView != null)
			{
				mapContentView.HorizontalOptions = LayoutOptions.Fill;
				mapContentView.VerticalOptions = LayoutOptions.Fill;
				this.mainGrid.Children.Add(mapContentView, 0, 0);
			}
		}
	}
}
