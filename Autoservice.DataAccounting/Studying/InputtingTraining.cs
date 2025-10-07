using System;
using Common.ConsoleIO;
using Autoservice.UI.Console.IO;
using Autoservice.UI.Settings;
using Autoservice.UI.Formatting.Simple;

namespace Autoservice.DataAccounting.Studying
{
    internal class InputtingTraining
    {
        internal static void Run()
        {
            Console.WriteLine("\n --- InputtingTraining ---");
            StudyNumbersInputting();
            StudyOwnerDataInputting();
        }

        private static void StudyNumbersInputting()
        {
            Console.WriteLine("\n --- StudyNumbersInputting ---");

            int id = Inputting.InputInt32("Ідентифікатор об'єкта сутності");
            Console.WriteLine("\tid:\t{0}", id);

            id = Inputting.InputInt32("Ідентифікатор об'єкта сутності");
            Console.WriteLine("\tid:\t{0}", id);
        }

        private static void StudyOwnerDataInputting()
        {
            Console.WriteLine("\n --- StudyOwnerDataInputting ---");

            OwnerModel model = new OwnerModel();

            Console.WriteLine("Введіть дані власника");
            Inputting.OutInputtingPrompt();
            model.Name = DataInputting.InputOwnerName();
            model.Email = DataInputting.InputEmail();
            model.Address = DataInputting.InputAddress();
            Console.WriteLine(model.ToDataString());
        }
    }
}