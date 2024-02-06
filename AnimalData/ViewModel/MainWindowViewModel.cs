using AnimalData.DBdataProvider;
using AnimalData.Model.BaseClass;
using System.Collections.ObjectModel;

namespace AnimalData.ViewModel
{
    internal class MainWindowViewModel
    {
        public ObservableCollection<ChordalType> AnimalTypes { get; set; }

        public MainWindowViewModel()
        {
            DataProvider t = new DataProvider();
            //AnimalTypes = new ObservableCollection<ChordalType>(t.GetDataFromDB());
        }
    }
}