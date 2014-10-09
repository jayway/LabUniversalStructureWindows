using System;
using System.Collections.Generic;
using System.Text;
using Windows.Storage.Pickers;
using LabUniversalStructure.ViewModels;

namespace LabUniversalStructure.Interface
{
    public interface IPickFile
    {
        void PickFile(FileOpenPicker openPicker, MainPageVm vm);
    }
}
