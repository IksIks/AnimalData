using AnimalData.DBdataProvider;
using AnimalData.Factory;
using AnimalData.Infrastructure.Command;
using AnimalData.ViewModel.Base;
using System.Windows;
using System.Windows.Input;

namespace AnimalData.ViewModel
{
    internal class AddNewAnimalViewModel : ViewModelBase
    {
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

        public AddNewAnimalViewModel()
        {
            animalType = new() { "Млекопитающие", "Птицы", "Земноводные", "Новый неизвестный тип" };
            animalFactory = new AnimalFactory();
            dataProvider = new DataProvider();
            AddAnimalToDBCommand = new LambdaCommand(OnAddAnimalToDBCommandExecuted, CanAddAnimalToDBCommandExecute);
            CloseWindowAddNewAnimalCommand = new LambdaCommand(OnCloseWindowAddNewAnimalCommandExecuted, CanCloseWindowAddNewAnimalCommandExecute);
        }

        //---------------------------------------------------------------------------------------------

        #region Добавление нового животного

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
        }

        #endregion Добавление нового животного

        //------------------------------------------------------------------------------

        public ICommand CloseWindowAddNewAnimalCommand { get; }

        private bool CanCloseWindowAddNewAnimalCommandExecute(object p) => true;

        private void OnCloseWindowAddNewAnimalCommandExecuted(object p)
        {
            Application.Current.Windows[1].Close();
        }
    }
}