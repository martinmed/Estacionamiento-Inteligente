// ------------------------------------------------------------------------------
//  Copyright © 2017 Esri. All rights reserved.
//  Author: John Doherty
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using PCLTest.Core;
using PCLTest.Shared;
using UIKit;
using FreshTinyIoC;

namespace PCLTest.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			// IMapContentPage test;
			// Register the map page with the IOC
			FreshTinyIoC.FreshTinyIoCContainer.Current.Register<IMapContentPage, MapContentPage>();
			FreshTinyIoC.FreshTinyIoCContainer.Current.Register<IMapContentView, MapContentView>();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
