using AnimalData.DBContext;
using AnimalData.Model;
using System.Windows;

namespace AnimalData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (AnimalDBContext t = new AnimalDBContext())
            {
                t.ChordalClasses.Add(new Bird { AnimalName = "nvfdjvhjsdv", LifeExpectancy = 8, Weight = 7 });
                t.ChordalClasses.Add(new Bird { AnimalName = "gggggg", LifeExpectancy = 4, Weight = 3 });

                t.SaveChanges();
            }
        }
    }
}