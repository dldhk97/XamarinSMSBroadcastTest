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
using Android.Provider;
using Android;

namespace SMStest
{
    [BroadcastReceiver(Label = "PushServiceReceiver", Enabled = true, Permission = Manifest.Permission.BroadcastWapPush)]
    [IntentFilter(new string[] { Telephony.Sms.Intents.WapPushDeliverAction }, DataHost ="application/vnd.wap.mms-message")]
    public class PushServiceReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Toast.MakeText(context, "PushServiceReceiver Intent!", ToastLength.Short).Show();
        }
    }
}