using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android;
using Android.Provider;

namespace SMStest
{
    [BroadcastReceiver(Label = "MMSReceiver", Enabled = true, Permission = Manifest.Permission.BroadcastSms)]
    [IntentFilter(new string[] { Telephony.Sms.Intents.SmsDeliverAction })]
    public class MMSReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Toast.MakeText(context, "MMSReceiver Intent!", ToastLength.Short).Show();
        }
    }
}