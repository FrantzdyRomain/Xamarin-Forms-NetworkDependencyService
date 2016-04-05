using System;


using UIKit;
using NetworkExtension;
using Foundation;

using Xamarin.Forms;
using DeviceNetwork.DeviceStateInterface;
using DeviceNetwork.iOS.Network;
 
[assembly: Dependency(typeof(DeviceNetwork.iOS.DeviceState))]
namespace DeviceNetwork.iOS
{
	public class DeviceState:IDeviceState
	{
		public DeviceState ()
		{
		}

		public bool isNetworkReachable(){
			bool hasInternet = true;
			Network.NetworkStatus internetStatus = Reachability.InternetConnectionStatus();

			if(internetStatus == Network.NetworkStatus.NotReachable){
				hasInternet = false;

			}


			return hasInternet;

		}
	}
}

