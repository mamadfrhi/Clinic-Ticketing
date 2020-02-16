using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Security.Cryptography;
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications; // Notifications library
using Microsoft.QueryStringDotNET; // QueryString.NET
using Windows.Data.Xml.Dom;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Globalization;
using Windows.UI.StartScreen;
using System.Threading;


namespace Clinic_App
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        private const String APP_ID = "Microsoft.Samples.DesktopToastsSample";
        string title = "Andrew sent you a picture";
        string content = "Check this out, Happy Canyon in Utah!";
        string image = "https://unsplash.it/360/202?image=883";
        string logo = "ms-appdata:///local/Andrew.jpg";

        private void button2_Click(object sender, EventArgs e)
        {
    //        ToastVisual visual = new ToastVisual()
    //        {
    //            BindingGeneric = new ToastBindingGeneric()
    //            {
    //                Children =
    //    {
    //        new AdaptiveText()
    //        {
    //            Text = title
    //        },

    //        new AdaptiveText()
    //        {
    //            Text = content
    //        },

    //        new AdaptiveImage()
    //        {
    //            Source = image
    //        }
    //    },

    //                AppLogoOverride = new ToastGenericAppLogo()
    //                {
    //                    Source = logo,
    //                    HintCrop = ToastGenericAppLogoCrop.Circle
    //                }
    //            }
    //        };

    //        // In a real app, these would be initialized with actual data
    //        int conversationId = 384928;

    //        // Construct the actions for the toast (inputs and buttons)
    //        ToastActionsCustom actions = new ToastActionsCustom()
    //        {
    //            Inputs =
    //{
    //    new ToastTextBox("tbReply")
    //    {
    //        PlaceholderContent = "Type a response"
    //    }
    //},

    //            Buttons =
    //{
    //    new ToastButton("Reply", new QueryString()
    //    {
    //        { "action", "reply" },
    //        { "conversationId", conversationId.ToString() }

    //    }.ToString())
    //    {
    //        ActivationType = ToastActivationType.Background,
    //        ImageUri = "Assets/Reply.png",

    //        // Reference the text box's ID in order to
    //        // place this button next to the text box
    //        TextBoxId = "tbReply"
    //    },

    //    new ToastButton("Like", new QueryString()
    //    {
    //        { "action", "like" },
    //        { "conversationId", conversationId.ToString() }

    //    }.ToString())
    //    {
    //        ActivationType = ToastActivationType.Background
    //    },

    //    new ToastButton("View", new QueryString()
    //    {
    //        { "action", "viewImage" },
    //        { "imageUrl", image }

    //    }.ToString())
    //}
    //        };

    //        // Now we can construct the final toast content
    //        ToastContent toastContent = new ToastContent()
    //        {
    //            Visual = visual,
    //            Actions = actions,

    //            // Arguments when the user taps body of toast
    //            Launch = new QueryString()
    //{
    //    { "action", "viewConversation" },
    //    { "conversationId", conversationId.ToString() }

    //}.ToString()
    //        };

    //        // And create the toast notification
    //        var toast = new ToastNotification(toast.Content);


    //        ToastNotificationManager.CreateToastNotifier().Show(toast);
            //ToastNotificationManager.CreateToastNotifier(APP_ID).Show(toast);


        }
        

        //public async Task<bool> ShowToastAsync()
        //{
        //    var request = new ToastRequest
        //    {
        //        ToastTitle = "DesktopToast WPF Sample",
        //        ToastBody = "This is a toast test.",
        //        ToastLogoFilePath = string.Format("file:///{0}", Path.GetFullPath("toast128.png")),
        //        ShortcutFileName = "DesktopToast.Wpf.lnk",
        //        ShortcutTargetFilePath = Assembly.GetExecutingAssembly().Location,
        //        AppId = "DesktopToast.Wpf",
        //    };

        //    var result = await ToastManager.ShowAsync(request);

        //    return (result == ToastResult.Activated);
        //}
        private void radRibbonBar1_Click(object sender, EventArgs e)
        {
            //radApplicationMenu1.ContextMenu.Show();
            radApplicationMenu1.ShowDropDown();
        }
        

        private void radMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        List<string> ls = new List<string>();
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //long a = 0;

            //for (int i = 0; i < 9999999; i++)
            //{
            //    a++;
            //    ls.Add(a.ToString());
            //}
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("OK");
        }
        
        
    }
}
