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
        private ChordalClass dsd = new Bird();

        public MainWindowViewModel()
        {
            dsd.AnimalName = "vc";
        }
    }
}