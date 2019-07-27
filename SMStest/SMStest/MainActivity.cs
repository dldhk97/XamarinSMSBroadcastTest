using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Provider;
using Android;
using Android.Telephony;

namespace SMStest
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button button1;
        Button button2;
        Button button3;

        EditText editText1;
        EditText editText2;

        const int REQUEST_PERMISSION_CALLBACK = 3;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);
            button3 = FindViewById<Button>(Resource.Id.button3);
            editText1 = FindViewById<EditText>(Resource.Id.textInputEditText1);
            editText2 = FindViewById<EditText>(Resource.Id.textInputEditText2);

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            RequestPermissions(new string[] {
                Manifest.Permission.BroadcastSms,
                Manifest.Permission.ReadSms,
                Manifest.Permission.ReceiveSms,
                Manifest.Permission.SendSms,
                Manifest.Permission.BroadcastWapPush,
                Manifest.Permission.ReceiveWapPush,
                Manifest.Permission.SendRespondViaMessage,
                Manifest.Permission.WriteSms,
                Manifest.Permission.ReceiveMms,
            }, REQUEST_PERMISSION_CALLBACK);
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Set as Default SMS app", ToastLength.Short).Show();
            Intent intent = new Intent(Telephony.Sms.Intents.ActionChangeDefault);
            intent.PutExtra(Telephony.Sms.Intents.ExtraIsDefaultSmsApp, Application.Context.ApplicationInfo.PackageName);
            StartActivity(intent);
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            SmsManager sm = SmsManager.Default;
            string address = editText1.Text;
            string message = editText2.Text;
            sm.SendTextMessage(address, null, message, null, null);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}