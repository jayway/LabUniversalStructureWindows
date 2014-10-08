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
    partial class MainPageVm :BaseVm
    {
        public BitmapImage Image { get; set; }

        public void GetImage()
        {
            var openPicker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.PicturesLibrary
            };
            openPicker.FileTypeFilter.Add(".jpg");
            PickFile(openPicker);
        }

        public async void SetImage(StorageFile file)
        {
            try
            {
                var stream = await file.OpenReadAsync();
                Image = new BitmapImage();
                Image.SetSource(stream);
            }
            catch (Exception e)
            {
                // Handle error
            }            
        }
    }
}
