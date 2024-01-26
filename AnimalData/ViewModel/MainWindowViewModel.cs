using AnimalData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalData.ViewModel
{
    internal class MainWindowViewModel
    {
        private ChordalType dsd = new Bird();

        public MainWindowViewModel()
        {
            dsd.AnimalName = "vc";
        }
    }
}