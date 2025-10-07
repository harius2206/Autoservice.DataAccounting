using System;
using Common.Formatting.Tables;

namespace Autoservice.UI.Settings.Tables
{
    public static class MeintenanceTableSettings
    {
        public static TableSettings Current;

        static MeintenanceTableSettings()
        {
            IniTableSettings();
        }

        private static void IniTableSettings()
        {
            string header = "Обслуговування";
            int columnCount = Enum.GetValues(typeof(MeintenanceTableColumn)).Length;
            string[] headers = new string[columnCount];
            IniColumnHeaders(headers);
            int[] widthes = new int[columnCount];
            IniColumnWidthes(widthes);
            Current = new TableSettings(header, headers, widthes);
        }

        private static void IniColumnHeaders(string[] headers)
        {
            headers[(int)MeintenanceTableColumn.Id] = "№";
            headers[(int)MeintenanceTableColumn.Transport] = "Транспорт";
            headers[(int)MeintenanceTableColumn.Service] = "Послуга";
            headers[(int)MeintenanceTableColumn.Date] = "Дата";
            headers[(int)MeintenanceTableColumn.Cost] = "Вартість";
        }

        private static void IniColumnWidthes(int[] widthes)
        {
            widthes[(int)MeintenanceTableColumn.Id] = 6;
            widthes[(int)MeintenanceTableColumn.Transport] = 18;
            widthes[(int)MeintenanceTableColumn.Service] = 18;
            widthes[(int)MeintenanceTableColumn.Date] = 12;
            widthes[(int)MeintenanceTableColumn.Cost] = 10;
        }
    }
}