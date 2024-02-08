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
        private ObservableCollection<ChordalType>? animalTypes;
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
            animalTypes = new ObservableCollection<ChordalType>();
            dbProvider = new DataProvider();
            GetDataFromDBCommand = new LambdaCommand(OnGetDataFromDBCommandExecuted, CanGetDataFromDBCommandExecute);
            AddNewAnimalCommand = new LambdaCommand(OnAddNewAnimalCommandExecuted, CanAddNewAnimalCommandExecute);
            DeleteAnimalCommand = new LambdaCommand(OnDeleteAnimalCommandExecuted, CanDeleteAnimalCommandExecute);
        }

        //-------------------------------------------------------------------------------------------------------

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

        //-------------------------------------------------------------------------------------------------------

        #region Добавление нового животного

        public ICommand AddNewAnimalCommand { get; }

        private bool CanAddNewAnimalCommandExecute(object p)
        {
            if (!AnimalTypes.Any()) return false;
            return true;
        }

        private void OnAddNewAnimalCommandExecuted(object p)
        {
            AddNewAnimal AddNewAnimalWindow = new AddNewAnimal();
            DataProvider.DataChange += DbProvider_DataChange;
            AddNewAnimalWindow.ShowDialog();
            DataProvider.DataChange -= DbProvider_DataChange;
        }

        #endregion Добавление нового животного

        //-------------------------------------------------------------------------------------------------------

        public ICommand DeleteAnimalCommand { get; }

        private bool CanDeleteAnimalCommandExecute(Object p)
        {
            if (AnimalTypes.Any() && p is ChordalType) return true;
            return false;
        }

        private void OnDeleteAnimalCommandExecuted(Object p)
        {
            DataProvider.DataChange += DbProvider_DataChange;
            dbProvider.DeleteAnimalFromDB(p as ChordalType);
            DataProvider.DataChange -= DbProvider_DataChange;
        }

        //------------------------------------------------------------------------------------------------------------------

        public ICommand ChangeAnimalDataCommand { get; }
        //private bool

        private async void DbProvider_DataChange()
        {
            AnimalTypes = new ObservableCollection<ChordalType>(await dbProvider.GetDataFromDB());
        }
    }
}