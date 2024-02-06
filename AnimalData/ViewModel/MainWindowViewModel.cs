using AnimalData.Command;
using AnimalData.DBdataProvider;
using AnimalData.Model.BaseClass;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AnimalData.ViewModel
{
    internal class MainWindowViewModel
    {
        private readonly DataProvider dbProvider;

        public ObservableCollection<ChordalType> AnimalTypes { get; set; }

        public MainWindowViewModel()
        {
            GetDataFromDBCommand = new LambdaCommand(OnGetDataFromDBCommandExecuted, CanGetDataFromDBCommandExecute);
            dbProvider = new DataProvider();
        }

        public ICommand GetDataFromDBCommand { get; }

        private bool CanGetDataFromDBCommandExecute(object p)
        {
            return true;
        }

        private async void OnGetDataFromDBCommandExecuted(object p)
        {
            AnimalTypes = new ObservableCollection<ChordalType>(await dbProvider.GetDataFromDB());
        }
    }
}