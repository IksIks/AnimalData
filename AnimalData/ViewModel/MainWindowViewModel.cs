using AnimalData.DBdataProvider;
using AnimalData.Infrastructure.Command;
using AnimalData.Model.BaseClass;
using AnimalData.View;
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
            dbProvider = new DataProvider();
            GetDataFromDBCommand = new LambdaCommand(OnGetDataFromDBCommandExecuted, CanGetDataFromDBCommandExecute);
            AddNewAnimalCommand = new LambdaCommand(OnAddNewAnimalCommandExecuted, CanAddNewAnimalCommandExecute);
        }

        #region Команда загрузки базы

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

        #endregion Команда загрузки базы

        public ICommand AddNewAnimalCommand { get; }

        private bool CanAddNewAnimalCommandExecute(object p)
        {
            // if (AnimalTypes.Count == 0) return false;
            return true;
        }

        private void OnAddNewAnimalCommandExecuted(object p)
        {
            AddNewAnimal AddNewAnimalWindow = new AddNewAnimal();
            AddNewAnimalWindow.ShowDialog();
        }
    }
}