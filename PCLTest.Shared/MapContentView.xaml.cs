// ------------------------------------------------------------------------------
//  Copyright © 2017 Esri. All rights reserved.
//  Author: John Doherty
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Esri.ArcGISRuntime.Mapping;
using PCLTest.Core;
using Xamarin.Forms;
using Esri.ArcGISRuntime.Geometry;
using Esri;
using Esri.ArcGISRuntime.Symbology;

using Esri.ArcGISRuntime.UI;


namespace PCLTest.Shared
{
	/// <summary>
	/// Map content view. Implements IMapContentView for IOC.
	/// </summary>
	public partial class MapContentView : ContentView, IMapContentView
	{
		public MapContentView()
		{
			InitializeComponent();
			// Create the UI, setup the control references and execute initialization 
			Initialize();
		}



		private void Initialize()
        {
            // Create new Map with basemap
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateOpenStreetMap();

            // Create initial map location and reuse the location for graphic
            MapPoint initialPoint = new MapPoint(-8082080, -4685290, SpatialReferences.WebMercator);
            Viewpoint initialViewpoint = new Viewpoint(initialPoint, 7500);

            MapPoint parking1Point = new MapPoint(-8080012, -4684412, SpatialReferences.WebMercator);

            // Set initial viewpoint
            myMap.InitialViewpoint = initialViewpoint;

            // Provide used Map to the MapView
            MyMapView.Map = myMap;

            // Create overlay to where graphics are shown
            GraphicsOverlay overlay = new GraphicsOverlay();

            // Add created overlay to the MapView
            MyMapView.GraphicsOverlays.Add(overlay);

            // create a new PictureMarkerSymbol with an image file stored online (.png, .jpg, .bmp)
            var picUrl = @"https://image.flaticon.com/icons/png/512/8/8129.png";
            PictureMarkerSymbol picMarkerSym = new PictureMarkerSymbol(new Uri(picUrl));
            picMarkerSym.Height= 60;
            picMarkerSym.Width = 60;
            picMarkerSym.OffsetY = 30;
            

            // Add a new graphic with a central point that was created earlier
            Graphic graphicWithSymbol = new Graphic(parking1Point, picMarkerSym);
            overlay.Graphics.Add(graphicWithSymbol);
        }
    }
}
