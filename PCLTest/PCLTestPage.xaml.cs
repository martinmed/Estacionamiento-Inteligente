// ------------------------------------------------------------------------------
//  Copyright © 2017 Esri. All rights reserved.
//  Author: John Doherty
// ------------------------------------------------------------------------------

using Xamarin.Forms;
using PCLTest.Core;

namespace PCLTest
{
	public partial class PCLTestPage : ContentPage
	{
		public PCLTestPage()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the button click to show map page
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			// Resolve the map page using DI
			var page = FreshTinyIoC.FreshTinyIoCContainer.Current.Resolve<IMapContentPage>();
			// Show the page
			this.Navigation.PushModalAsync(page as Page);
		}
		/// <summary>
		/// Handles the button click to show map page with map content view
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			// Resolve the map page with map content view
			var page = new MapPage();
			// Show the page
			this.Navigation.PushModalAsync(page);
		}
	}
}
