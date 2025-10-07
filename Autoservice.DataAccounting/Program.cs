using Common.ConsoleIO;
using System;
using System.Configuration;

namespace Autoservice.DataAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Autoservice.DataAccounting";

            ConsoleSettings.SetConsoleParam();

            Console.WriteLine(" Дослідження роботи програмних засобів");

            //ModelsTraining.Run();
            //ListsSetTraining.Run();
            //Console.ReadKey(true);

            //s_simpleBrowser.Run();
            //RunBrowsing();
        }

        //static SimpleBrowser s_simpleBrowser = new SimpleBrowser();

        //private static void RunBrowsing()
        //{
        //    s_simpleBrowser.DirectoryName = ConfigurationManager.AppSettings.Get("DataDirectoryName");
        //    s_simpleBrowser.FileName = ConfigurationManager.AppSettings.Get("DataFileName");
        //    s_simpleBrowser.Run();
        //}
    }
}