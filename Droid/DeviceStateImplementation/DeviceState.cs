using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Net;
using Android.Telephony;
using Android.Renderscripts;
using Android.Util;
using Android.Nfc;
using DeviceNetwork.DeviceStateInterface;
//
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceNetwork.Droid.DeviceState))]
namespace DeviceNetwork.Droid
{
	public class DeviceState:IDeviceState
	{

		public bool isNetworkReachable(){
			bool isNetworkActive;// = false;
			Context context = Xamarin.Forms.Forms.Context;//UPS.MobileX.Droid.UPSMobileMainActivity.Instance.ApplicationContext;

			ConnectivityManager cm = (ConnectivityManager)context.GetSystemService (Context.ConnectivityService);
			NetworkInfo activeConnection = cm.ActiveNetworkInfo;


			isNetworkActive = (activeConnection != null) && activeConnection.IsConnected;


			return isNetworkActive;


		}
	}
}

