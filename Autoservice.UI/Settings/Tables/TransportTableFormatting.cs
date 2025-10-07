using Common.Formatting.Tables;
using System.Collections.Generic;
using System.Text;

namespace Autoservice.UI.Settings.Tables
{
    public static class TransportTableFormatting
    {
        public static string[][] ToDataJaggedArray(this IList<TransportModel> models)
        {
            string[][] values = new string[models.Count][];
            for (int i = 0; i < models.Count; i++)
            {
                var model = models[i];
                values[i] = new string[TransportTableSettings.Current.ColumnsCount];
                values[i][(int)TransportTableColumn.Id] = model.Id.ToString();
                values[i][(int)TransportTableColumn.Make] = model.Make;
                values[i][(int)TransportTableColumn.Model] = model.Model;
                values[i][(int)TransportTableColumn.Number] = model.Number;
                values[i][(int)TransportTableColumn.Description] = model.Description;
                values[i][(int)TransportTableColumn.OwnerKey] = model.OwnerKey;
                values[i][(int)TransportTableColumn.ParentKey] =
                string.IsNullOrEmpty(model.ParentKey)
                    ? ""
                    : $"{model.ParentKey} ({model.ParentMake} {model.ParentModel})";

            }
            return values;
        }

        public static string ToTable(this IList<TransportModel> models, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(TransportTableSettings.Current, borderStyle);
        }

        public static string ToTable(this IList<TransportModel> models, bool[] visibles, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(TransportTableSettings.Current, visibles, borderStyle);
        }

        public static string ToTable(this IList<TransportModel> models, int visibility, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(TransportTableSettings.Current, visibility, borderStyle);
        }
    }
}