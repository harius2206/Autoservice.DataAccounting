using Common.Formatting.Tables;
using System.Collections.Generic;

namespace Autoservice.UI.Settings.Tables
{
    public static class ServiceTableFormatting
    {
        public static string[][] ToDataJaggedArray(this IList<ServiceModel> models)
        {
            string[][] values = new string[models.Count][];
            for (int i = 0; i < models.Count; i++)
            {
                var model = models[i];
                values[i] = new string[ServiceTableSettings.Current.ColumnsCount];
                values[i][(int)ServiceTableColumn.Id] = model.Id.ToString();
                values[i][(int)ServiceTableColumn.Name] = model.Name;
                values[i][(int)ServiceTableColumn.Price] = model.Price.HasValue ? model.Price.Value.ToString("F2") : string.Empty;
                values[i][(int)ServiceTableColumn.Duration] = model.Duration.HasValue ? model.Duration.Value.ToString() : string.Empty;
                values[i][(int)ServiceTableColumn.Periodicity] = model.WarrantyPeriod.HasValue ? model.WarrantyPeriod.Value.ToString() : string.Empty;
            }
            return values;
        }

        public static string ToTable(this IList<ServiceModel> models, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(ServiceTableSettings.Current, borderStyle);
        }

        public static string ToTable(this IList<ServiceModel> models, bool[] visibles, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(ServiceTableSettings.Current, visibles, borderStyle);
        }

        public static string ToTable(this IList<ServiceModel> models, int visibility, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(ServiceTableSettings.Current, visibility, borderStyle);
        }
    }
}