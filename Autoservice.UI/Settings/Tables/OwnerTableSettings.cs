using System;
using Common.Formatting.Tables;

namespace Autoservice.UI.Settings.Tables
{
    public static class OwnerTableSettings
    {
        public static TableSettings Current;

        static OwnerTableSettings()
        {
            IniTableSettings();
        }

        private static void IniTableSettings()
        {
            string header = "Власники";
            int columnCount = Enum.GetValues(typeof(OwnerTableColumn)).Length;
            string[] headers = new string[columnCount];
            IniColumnHeaders(headers);
            int[] widthes = new int[columnCount];
            IniColumnWidthes(widthes);
            Current = new TableSettings(header, headers, widthes);
        }

        private static void IniColumnHeaders(string[] headers)
        {
            headers[(int)OwnerTableColumn.Id] = "№";
            headers[(int)OwnerTableColumn.Name] = "Ім'я власника";
            headers[(int)OwnerTableColumn.Email] = "Електронна пошта";
            headers[(int)OwnerTableColumn.Address] = "Адреса";
        }

        private static void IniColumnWidthes(int[] widthes)
        {
            widthes[(int)OwnerTableColumn.Id] = 6;
            widthes[(int)OwnerTableColumn.Name] = 20;
            widthes[(int)OwnerTableColumn.Email] = 30;
            widthes[(int)OwnerTableColumn.Address] = 25;
        }
    }
}