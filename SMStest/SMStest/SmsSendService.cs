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
    [Service(Label = "SmsSendService", Permission = Manifest.Permission.SendRespondViaMessage, Exported = true)]
    [IntentFilter(new[] { "android.intent.action.RESPOND_VIA_MESSAGE"}, Categories = new[] { "android.intent.category.DEFAULT" }, DataSchemes = new[] { "sms", "smsto", "mms", "mmsto" })]
    public class SmsSendService : Service
    {
        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        public override bool OnUnbind(Intent intent)
        {
            return base.OnUnbind(intent);
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
        }

        public string GetTimeStamp()
        {
            return "TIMESTAMP";
        }
    }
}