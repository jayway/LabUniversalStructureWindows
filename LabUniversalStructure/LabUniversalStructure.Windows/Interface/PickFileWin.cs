using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using LabUniversalStructure.ViewModels;

namespace LabUniversalStructure.Interface
{
    class PickFileWin : IPickFile
    {
        public async void PickFile(FileOpenPicker openPicker, MainPageVm vm)
        {
            var file = await openPicker.PickSingleFileAsync();
            vm.SetImage(file);
        }
    }
}
