// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace watchthis.iOS.watchthisappExtension
{
    [Register ("InterfaceController")]
    partial class InterfaceController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton btnDictate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton btnRecord { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblDictatedText { get; set; }

        [Action ("BtnDictate_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnDictate_Activated ();

        [Action ("BtnRecord_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnRecord_ActivatedAsync ();

        void ReleaseDesignerOutlets ()
        {
            if (btnDictate != null) {
                btnDictate.Dispose ();
                btnDictate = null;
            }

            if (btnRecord != null) {
                btnRecord.Dispose ();
                btnRecord = null;
            }

            if (lblDictatedText != null) {
                lblDictatedText.Dispose ();
                lblDictatedText = null;
            }
        }
    }
}