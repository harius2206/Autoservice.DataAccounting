using Common.Formatting.Tables;
using System.Collections.Generic;
using System.Text;

namespace Autoservice.UI.Settings.Tables
{
    public static class MeintenanceTableFormatting
    {
        public static string[][] ToDataJaggedArray(this IList<MeintenanceModel> models)
        {
            string[][] values = new string[models.Count][];
            for (int i = 0; i < models.Count; i++)
            {
                var model = models[i];
                values[i] = new string[MeintenanceTableSettings.Current.ColumnsCount];
                values[i][(int)MeintenanceTableColumn.Id] = model.Id.ToString();
                values[i][(int)MeintenanceTableColumn.Transport] = model.TransportKey;
                values[i][(int)MeintenanceTableColumn.Service] = model.ServiceKey;
                values[i][(int)MeintenanceTableColumn.Date] = model.Date?.ToString("yyyy-MM-dd") ?? "";
                values[i][(int)MeintenanceTableColumn.Cost] = model.Cost?.ToString("F2") ?? "";
            }
            return values;
        }

        public static string ToTable(this IList<MeintenanceModel> models, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(MeintenanceTableSettings.Current, borderStyle);
        }

        public static string ToTable(this IList<MeintenanceModel> models, bool[] visibles, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(MeintenanceTableSettings.Current, visibles, borderStyle);
        }

        public static string ToTable(this IList<MeintenanceModel> models, int visibility, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(MeintenanceTableSettings.Current, visibility, borderStyle);
        }
    }
}