﻿using Microsoft.Extensions.Configuration;
using System.IO;
using System.Windows;

namespace AnimalData.Connection
{
    internal static class ConnectString
    {
        public static string GetConnectionString()
        {
            string returnableString = default;
            IConfigurationRoot configaration;
            var builder = new ConfigurationBuilder();
            //configaration = builder.SetBasePath(Directory.GetCurrentDirectory() + "\\Connection").AddJsonFile("Connection.json").Build();
            //returnableString = configaration.GetConnectionString("PGSQL");
            //return returnableString;
            try
            {
                configaration = builder.SetBasePath(Directory.GetCurrentDirectory() + "\\Connection").AddJsonFile("Connection.json").Build();
                returnableString = configaration.GetConnectionString("PGSQL");
                return returnableString;
            }
            catch (Exception)
            {
                MessageBox.Show("Отсутсвует файл с настройками подключения к БД", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return returnableString = "";
            }
            finally
            {
                if (String.IsNullOrEmpty(returnableString))
                    Application.Current.Shutdown();
            }
        }
    }
}