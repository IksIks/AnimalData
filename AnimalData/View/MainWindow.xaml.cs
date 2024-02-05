using AnimalData.DBContext;
using AnimalData.Model;
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
            //    t.Birds.Add(new Bird { AnimalName = "Bird", LifeExpectancy = 8, Weight = 7 });
            //    t.Mammals.Add(new Mammal { AnimalName = "Mammal", LifeExpectancy = 4, Weight = 3 });
            //    t.Amphibians.Add(new Amphibian { AnimalName = "Amphibian", LifeExpectancy = 4, Weight = 3 });

            //    t.SaveChanges();
            //}
        }
    }
}