using System;
using System.Collections.Generic;
using System.Text;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using LabUniversalStructure.Common;

namespace LabUniversalStructure.ViewModels
{
    class MainPageWinVm : MainPageVm
    {
        public override async void PickFile(FileOpenPicker openPicker)
        {
            var file = await openPicker.PickSingleFileAsync();
            SetImage(file);
        }
    }
}
