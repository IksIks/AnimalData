using Microsoft.Extensions.Configuration;
using System.IO;
using System.Windows;

namespace AnimalData.Connection
{
    internal class ConnectString
    {
        public static string GetConnectionString()
        {
            IConfigurationRoot configaration;
            var builder = new ConfigurationBuilder();
            try
            {
                configaration = builder.SetBasePath(Directory.GetCurrentDirectory() + "\\Connection").AddJsonFile("Connection.json").Build();
                return configaration.GetConnectionString("PGSQL");
            }
            catch (Exception)
            {
                MessageBox.Show("Отсутсвцет файл с настройками подключения к БД", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return "";
            }
            finally
            {
                Application.Current.Shutdown();
            }
        }
    }
}