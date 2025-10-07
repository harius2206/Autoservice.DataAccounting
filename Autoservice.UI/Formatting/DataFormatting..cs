using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autoservice.UI.Formatting.Simple;

namespace Autoservice.UI.Formatting
{
    public static class DataFormatting
    {
        public static string ToStatisticsString(this ModelsListsSet listsSet, string header = null)
        {
            if (header == null)
                header = "Статистичні дані про об'єкти ПО";

            if (listsSet == null || listsSet.IsEmpty())
            {
                return string.Format("{0}\n (дані відсутні)", header);
            }

            return string.Format("{0}\n" +
                                 " Представлено:\n" +
                                 "{1,7} {2}\n" +
                                 "{3,7} {4}",
                                 header,
                                 listsSet.OwnerModels.Count, GetCorrectForm(listsSet.OwnerModels.Count, "власник", "власники", "власників"),
                                 listsSet.TransportModels.Count, GetCorrectForm(listsSet.TransportModels.Count, "транспортний засіб", "транспортні засоби", "транспортних засобів"));
        }

        private static string GetCorrectForm(int count, string singular, string few, string many)
        {
            if (count == 1)
                return singular;
            else if (count >= 2 && count <= 4)
                return few;
            else
                return many;
        }

        public static string ToDataString(this List<OwnerModel> models, string header = null)
        {
            if (header == null)
            {
                header = "Власники";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            foreach (var model in models)
            {
                sb.AppendLine(model.ToDataString());
            }
            return sb.ToString();
        }

        public static string ToDataString(this List<TransportModel> models, string header = null)
        {
            if (header == null)
            {
                header = "Транспортні засоби";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            foreach (var model in models)
            {
                sb.AppendLine(model.ToDataString());
                sb.AppendLine(); // Додаємо порожній рядок між транспортними засобами
            }
            return sb.ToString();
        }

        public static string ToDataString(this ModelsListsSet listsSet)
        {
            return string.Concat("Інформація про власників та транспортні засоби\n",
                                 listsSet.OwnerModels.ToDataString(),
                                 listsSet.TransportModels.ToDataString());
        }
    }
}