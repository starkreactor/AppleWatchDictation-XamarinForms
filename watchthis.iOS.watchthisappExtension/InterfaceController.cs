using System;

using WatchKit;
using Foundation;

namespace watchthis.iOS.watchthisappExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
        partial void BtnDictate_Activated()
        {
			var suggest = new string[0];
            PresentTextInputController(suggest, WatchKit.WKTextInputMode.Plain, (result) =>
			{
				// action when the "text input" is complete
				if (result != null && result.Count > 0)
				{
					var enteredText = result.GetItem<NSObject>(0).ToString();
                    lblDictatedText.SetText(enteredText);
					Console.WriteLine(enteredText);
				}
			});        }

        partial void BtnClear_Activated()
        {
			lblDictatedText.SetText("");
        }

        protected InterfaceController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }
    }
}
