using System;
using Windows.Storage.Pickers;

namespace LabUniversalStructure.ViewModels
{
    partial class MainPageVm
    {
        private async void PickFile(FileOpenPicker openPicker)
        {
            var file = await openPicker.PickSingleFileAsync();
            SetImage(file);
        }
    }
}
