using System;
using Common.Formatting.Tables;

namespace Autoservice.UI.Settings.Tables
{
    public static class ServiceTableSettings
    {
        public static TableSettings Current;

        static ServiceTableSettings()
        {
            IniTableSettings();
        }

        private static void IniTableSettings()
        {
            string header = "Сервіси";
            int columnCount = Enum.GetValues(typeof(ServiceTableColumn)).Length;
            string[] headers = new string[columnCount];
            IniColumnHeaders(headers);
            int[] widthes = new int[columnCount];
            IniColumnWidthes(widthes);
            Current = new TableSettings(header, headers, widthes);
        }

        private static void IniColumnHeaders(string[] headers)
        {
            headers[(int)ServiceTableColumn.Id] = "№";
            headers[(int)ServiceTableColumn.Name] = "Назва";
            headers[(int)ServiceTableColumn.Price] = "Ціна";
            headers[(int)ServiceTableColumn.Duration] = "Тривалість";
            headers[(int)ServiceTableColumn.Periodicity] = "Гарантія";
        }

        private static void IniColumnWidthes(int[] widthes)
        {
            widthes[(int)ServiceTableColumn.Id] = 6;
            widthes[(int)ServiceTableColumn.Name] = 20;
            widthes[(int)ServiceTableColumn.Price] = 10;
            widthes[(int)ServiceTableColumn.Duration] = 15;
            widthes[(int)ServiceTableColumn.Periodicity] = 15;
        }
    }
}