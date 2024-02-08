using AnimalData.Model.BaseClass;
using AnimalData.ViewModel.Base;

namespace AnimalData.ViewModel
{
    internal class AddNewAnimalViewModel : ViewModelBase
    {
        private IEnumerable<ChordalType?> animalType;

        public IEnumerable<ChordalType?> AnimalType
        {
            get { return animalType; }
            set { Set(ref animalType, value); }
        }

        public AddNewAnimalViewModel()
        {
        }
    }
}