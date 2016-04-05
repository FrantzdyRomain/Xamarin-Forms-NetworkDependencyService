using System;
using System.Collections.Generic;

using Xamarin.Forms;
using DeviceNetwork.DeviceStateInterface;

namespace DeviceNetwork
{
	public partial class MainPage : ContentPage
	{
		 
		public MainPage ()
		{
			InitializeComponent ();
		}

		 
		public void clickedButton(Object sender,
			EventArgs e){
			//
			 
			bool internetActive = DependencyService.Get<IDeviceState>().isNetworkReachable ();
			this.DisplayAlert ("Device Network", internetActive.ToString(), "OK");
		}

	}
}

