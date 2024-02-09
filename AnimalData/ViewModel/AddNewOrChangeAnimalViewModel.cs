using AnimalData.DBdataProvider;
using AnimalData.Factory;
using AnimalData.Infrastructure.Command;
using AnimalData.Model.BaseClass;
using AnimalData.ViewModel.Base;
using System.Windows;
using System.Windows.Input;

namespace AnimalData.ViewModel
{
    internal class AddNewOrChangeAnimalViewModel : ViewModelBase
    {
        private int id;
        private string animalName;
        private byte lifeExpectancy;
        private int weight;
        private DataProvider dataProvider;
        private AnimalFactory animalFactory;
        private readonly List<string> animalType;

        public string SelectedItemComboBox { get; set; }

        public string AnimalName
        {
            get { return animalName; }
            set { Set(ref animalName, value); }
        }

        public byte LifeExpectancy
        {
            get { return lifeExpectancy; }
            set { Set(ref lifeExpectancy, value); }
        }

        public int Weight
        {
            get { return weight; }
            set { Set(ref weight, value); }
        }

        public List<string> AnimalType
        {
            get { return animalType; }
        }

        public AddNewOrChangeAnimalViewModel()
        {
            animalType = new() { "Млекопитающие", "Птицы", "Земноводные", "Новый неизвестный тип" };
            animalFactory = new AnimalFactory();
            dataProvider = new DataProvider();
            MainWindowViewModel.ChangeAnimalDataEvent += MainWindowViewModel_ChangeAnimalDataEvent;
            AddAnimalToDBCommand = new LambdaCommand(OnAddAnimalToDBCommandExecuted, CanAddAnimalToDBCommandExecute);
            CloseWindowCommand = new LambdaCommand(OnCloseWindowCommandExecuted, CanCloseWindowCommandExecute);
            ChangeAnimalDataCommand = new LambdaCommand(OnChangeAnimalDataCommandExecuted, CanChangeAnimalDataCommandExecute);
        }

        private void MainWindowViewModel_ChangeAnimalDataEvent(ChordalType animal)
        {
            id = animal.Id;
            AnimalName = animal.AnimalName;
            LifeExpectancy = animal.LifeExpectancy;
            Weight = animal.Weight;
        }

        //---------------------------------------------------------------------------------------------

        #region Команда добавление нового животного

        public ICommand AddAnimalToDBCommand { get; }

        private bool CanAddAnimalToDBCommandExecute(object p)
        {
            if (String.IsNullOrEmpty(AnimalName) || LifeExpectancy <= 0
                                                 || Weight <= 0
                                                 || String.IsNullOrEmpty(SelectedItemComboBox)) return false;
            return true;
        }

        private void OnAddAnimalToDBCommandExecuted(object p)
        {
            var animal = animalFactory.GetNewAnimal(SelectedItemComboBox, AnimalName, LifeExpectancy, Weight);
            dataProvider.AddToDB(animal);
            Application.Current.Windows[1].Close();
        }

        #endregion Команда добавление нового животного

        //------------------------------------------------------------------------------

        #region Команда закрытия окна

        public ICommand CloseWindowCommand { get; }

        private bool CanCloseWindowCommandExecute(object p) => true;

        private void OnCloseWindowCommandExecuted(object p)
        {
            Application.Current.Windows[1].Close();
        }

        #endregion Команда закрытия окна

        //--------------------------------------------------------------------------------

        public ICommand ChangeAnimalDataCommand { get; }

        private bool CanChangeAnimalDataCommandExecute(object p)
        {
            if (String.IsNullOrEmpty(AnimalName) || LifeExpectancy <= 0
                                                 || Weight <= 0
                                                 || String.IsNullOrEmpty(SelectedItemComboBox)) return false;
            return true;
        }

        private void OnChangeAnimalDataCommandExecuted(object p)
        {
            var animal = animalFactory.GetNewAnimal(SelectedItemComboBox, AnimalName, LifeExpectancy, Weight, id);
            dataProvider.UpdateAnimalData(animal);
            Application.Current.Windows[1].Close();
        }
    }
}