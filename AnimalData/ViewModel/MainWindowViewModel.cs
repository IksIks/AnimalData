using AnimalData.Model;
using System.Collections.ObjectModel;

namespace AnimalData.ViewModel
{
    internal class MainWindowViewModel
    {
        public ObservableCollection<ChordalType> AnimalTypes { get; set; }
    }
}