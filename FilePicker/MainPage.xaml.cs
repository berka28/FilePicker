using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage.Pickers;
using Windows.Storage;
using Newtonsoft.Json;
using FilePicker.Models;
using System.Collections.ObjectModel;
using CsvParse;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FilePicker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
           this.InitializeComponent();
        }


        private async void btnJson_Click(object sender, RoutedEventArgs e)
        {
            var picker = new FileOpenPicker();
            picker.ViewMode = PickerViewMode.List;
            picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            picker.FileTypeFilter.Add(".json");

            StorageFile file = await picker.PickSingleFileAsync();
            string text = await FileIO.ReadTextAsync(file);
            List<Figures> DeserializedProducts = JsonConvert.DeserializeObject<List<Figures>>(text);

            ListViewJson.ItemsSource = DeserializedProducts;
        }

        private ObservableCollection<string> CsvRows = new ObservableCollection<string>();

        private async void btnCsv_Click(object sender, RoutedEventArgs e)
        {
            var openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.List;
            openPicker.FileTypeFilter.Add(".csv");

            var file = await openPicker.PickSingleFileAsync();
            CsvRows.Clear();
           /* using (CsvParse.CsvFileReader csvReader = new CsvParse.CsvFileReader(await file.OpenStreamForReadAsync())
            {
                CsvParse.CsvRow row = new CsvParse.CsvRow();

            {
                string newRow = "";
                for (int i = 0; i < RowDefinitio; i++)
                {
                    newRow +=[i] + ",";
                }

                CsvRows.Add(newRow);
            }
           */
        }
           

        private async void btnXml_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.List;
            openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            openPicker.FileTypeFilter.Add(".xml");

            StorageFile file = await openPicker.PickSingleFileAsync();
        }
    }
}
