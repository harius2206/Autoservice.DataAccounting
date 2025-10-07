using Common.Formatting.Tables;
using System.Collections.Generic;
using System.Text;

namespace Autoservice.UI.Settings.Tables
{
    public static class OwnerTableFormatting
    {
        public static string[][] ToDataJaggedArray(this IList<OwnerModel> models)
        {
            string[][] values = new string[models.Count][];
            for (int i = 0; i < models.Count; i++)
            {
                var model = models[i];
                values[i] = new string[OwnerTableSettings.Current.ColumnsCount];
                values[i][(int)OwnerTableColumn.Id] = model.Id.ToString();
                values[i][(int)OwnerTableColumn.Name] = model.Name;
                values[i][(int)OwnerTableColumn.Email] = model.Email;
                values[i][(int)OwnerTableColumn.Address] = model.Address;
            }
            return values;
        }

        public static string ToTable(this IList<OwnerModel> models, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(OwnerTableSettings.Current, borderStyle);
        }

        public static string ToTable(this IList<OwnerModel> models, bool[] visibles, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(OwnerTableSettings.Current, visibles, borderStyle);
        }

        public static string ToTable(this IList<OwnerModel> models, int visibility, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = models.ToDataJaggedArray();
            return values.ToTable(OwnerTableSettings.Current, visibility, borderStyle);
        }
    }
}