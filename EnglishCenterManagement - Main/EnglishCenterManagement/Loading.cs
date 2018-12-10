using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraSplashScreen;

namespace EnglishCenterManagement
{
    class Loading
    {
        static bool isdisplayed = false;
        public static void ShowLoading()
        {
            if (isdisplayed) return;
            isdisplayed = true;
            SplashScreenManager.ShowForm(typeof(WaitingForm));
        }
        public static void ShowReportLoading()
        {
            if (isdisplayed) return;
            isdisplayed = true;
            SplashScreenManager.ShowForm(typeof(ReportWaitingForm));
        }        
        public static void HideLoading()
        {
            if (!isdisplayed) return;
            SplashScreenManager.CloseForm();
            isdisplayed = false;
        }
    }
}
