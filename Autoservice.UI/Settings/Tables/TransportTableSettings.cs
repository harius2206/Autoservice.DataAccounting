using System;
using Common.Formatting.Tables;

namespace Autoservice.UI.Settings.Tables
{
    public static class TransportTableSettings
    {
        public static TableSettings Current;

        static TransportTableSettings()
        {
            IniTableSettings();
        }

        private static void IniTableSettings()
        {
            string header = "Транспорт";
            int columnCount = Enum.GetValues(typeof(TransportTableColumn)).Length;
            string[] headers = new string[columnCount];
            IniColumnHeaders(headers);
            int[] widthes = new int[columnCount];
            IniColumnWidthes(widthes);
            Current = new TableSettings(header, headers, widthes);
        }

        private static void IniColumnHeaders(string[] headers)
        {
            headers[(int)TransportTableColumn.Id] = "№";
            headers[(int)TransportTableColumn.Make] = "Марка";
            headers[(int)TransportTableColumn.Model] = "Модель";
            headers[(int)TransportTableColumn.Number] = "Номер";
            headers[(int)TransportTableColumn.Description] = "Опис";
            headers[(int)TransportTableColumn.OwnerKey] = "Власник";
            headers[(int)TransportTableColumn.ParentKey] = "Батьківський транспорт"; 

        }

        private static void IniColumnWidthes(int[] widthes)
        {
            widthes[(int)TransportTableColumn.Id] = 6;
            widthes[(int)TransportTableColumn.Make] = 14;
            widthes[(int)TransportTableColumn.Model] = 14;
            widthes[(int)TransportTableColumn.Number] = 10;
            widthes[(int)TransportTableColumn.Description] = 15;
            widthes[(int)TransportTableColumn.OwnerKey] = 25;
            widthes[(int)TransportTableColumn.ParentKey] = 25; 

        }
    }
}