using AnimalData.DBContext;
using AnimalData.Model;
using AnimalData.Model.BaseClass;
using System.Reflection;
using System.Windows;

namespace AnimalData
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //using (AnimalDBContext t = new())
            //{
            //    t.TableAnimals.Add(new Bird("Дрозд", 8, 7));
            //    t.TableAnimals.Add(new Mammal("Слон", 4, 3));
            //    t.TableAnimals.Add(new Amphibian("Крокодил", 4, 3));

            //    t.SaveChanges();
            //}
        }
    }
}