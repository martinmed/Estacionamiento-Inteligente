// ------------------------------------------------------------------------------
//  Copyright © 2017 Esri. All rights reserved.
//  Author: John Doherty
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using PCLTest.Core;
using Esri.ArcGISRuntime.Mapping;
namespace PCLTest.Shared
{
	/// <summary>
	/// Map content page. Implements IMapContentPage for IOC.
	/// </summary>
	public partial class MapContentPage : ContentPage, IMapContentPage
	{
		public MapContentPage()
		{
			InitializeComponent();
			Title = "Display a map";

			// Create the UI, setup the control references and execute initialization 
			Initialize();
		}

		private void Initialize()
		{
			// Create new Map with basemap
			Map myMap = new Map(Basemap.CreateImagery());

			// Assign the map to the MapView
			MyMapView.Map = myMap;
		}
	}
}
