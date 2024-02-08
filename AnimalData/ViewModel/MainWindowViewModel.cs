using AnimalData.Command;
using AnimalData.DBdataProvider;
using AnimalData.Model.BaseClass;
using AnimalData.ViewModel.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AnimalData.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private DataProvider dbProvider;
        private ObservableCollection<ChordalType> animalTypes;
        private string connectionState = "Red";

        public string ConnectionState
        {
            get { return connectionState; }
            set { Set(ref connectionState, value); }
        }

        public ObservableCollection<ChordalType> AnimalTypes
        {
            get { return animalTypes; }
            set { Set(ref animalTypes, value); }
        }

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
            ConnectionState = "Green";
        }
    }
}