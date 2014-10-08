using System;
using System.Collections.Generic;
using System.Text;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.System.UserProfile;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using LabUniversalStructure.Common;

namespace LabUniversalStructure.ViewModels
{
    class MainPagePhoneVm : MainPageVm
    {
        public override void PickFile(FileOpenPicker openPicker)
        {
            openPicker.PickSingleFileAndContinue();
        }
    }
}
