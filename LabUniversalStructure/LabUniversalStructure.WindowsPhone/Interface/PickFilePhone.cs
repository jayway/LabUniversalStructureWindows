using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using LabUniversalStructure.ViewModels;

namespace LabUniversalStructure.Interface
{
    public class PickFilePhone : IPickFile
    {
        public void PickFile(FileOpenPicker openPicker, MainPageVm vm)
        {
            openPicker.PickSingleFileAndContinue();
        }
    }
}
