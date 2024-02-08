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
            //    t.TableAnimals.Add(new Bird { AnimalName = "Bird", LifeExpectancy = 8, Weight = 7 });
            //    t.TableAnimals.Add(new Mammal { AnimalName = "Mammal", LifeExpectancy = 4, Weight = 3 });
            //    t.TableAnimals.Add(new Amphibian { AnimalName = "Amphibian", LifeExpectancy = 4, Weight = 3 });

            //    t.SaveChanges();
            //}
        }
    }
}