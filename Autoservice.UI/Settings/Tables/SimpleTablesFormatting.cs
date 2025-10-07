using System;
using System.Collections.Generic;
using System.Text;

namespace AutoService.UI.Tables
{
    public static class SimpleTablesFormatting
    {
        public static string ToTable(this List<OwnerModel> models, string header = null)
        {
            if (header == null)
                header = "Власники";
            if (models == null || models.Count == 0)
                return $" {header}\n (дані відсутні)";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            string format = " {0,5} {1,-20} {2,-30} {3,-30}\n";
            sb.AppendFormat(format, "Id", "Ім'я", "Електронна пошта", "Адреса");
            sb.AppendFormat(" {0}\n", new string('-', 90));
            foreach (var model in models)
            {
                sb.AppendFormat(format,
                    model.Id,
                    model.Name,
                    model.Email,
                    model.Address
                );
            }
            sb.Length--;
            return sb.ToString();
        }

        public static string ToTable(this List<ServiceModel> models, string header = null)
        {
            if (header == null)
                header = "Послуги";
            if (models == null || models.Count == 0)
                return $" {header}\n (дані відсутні)";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            string format = " {0,5} {1,-20} {2,10} {3,10} {4,15}\n";
            sb.AppendFormat(format, "Id", "Назва", "Ціна", "Тривалість", "Гарантійний період");
            sb.AppendFormat(" {0}\n", new string('-', 80));
            foreach (var model in models)
            {
                sb.AppendFormat(format,
                    model.Id,
                    model.Name,
                    model.Price,
                    model.Duration,
                    model.WarrantyPeriod
                );
            }
            sb.Length--;
            return sb.ToString();
        }

        public static string ToTable(this List<TransportModel> models, string header = null)
        {
            if (header == null)
                header = "Транспорт";
            if (models == null || models.Count == 0)
                return $" {header}\n (дані відсутні)";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            string format = " {0,5} {1,-15} {2,-15} {3,-15} {4,-20} {5,-20}\n";
            sb.AppendFormat(format, "Id", "Марка", "Модель", "Номер", "Власник", "Опис");
            sb.AppendFormat(" {0}\n", new string('-', 100));
            foreach (var model in models)
            {
                sb.AppendFormat(format,
                    model.Id,
                    model.Make,
                    model.Model,
                    model.Number,
                    model.OwnerKey,
                    model.Description
                );
            }
            sb.Length--;
            return sb.ToString();
        }
        public static string ToTable(this List<MeintenanceModel> models, string header = null)
        {
            if (header == null)
                header = "Обслуговування";
            if (models == null || models.Count == 0)
                return $" {header}\n (дані відсутні)";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            string format = " {0,5} {1,-12} {2,-12} {3,-12} {4,12} {5,10} {6,-20}\n";
            sb.AppendFormat(format, "Id", "Транспорт", "Послуга", "Дата", "Вартість", "Примітка", "Ключ");
            sb.AppendFormat(" {0}\n", new string('-', 95));
            foreach (var model in models)
            {
                sb.AppendFormat(format,
                    model.Id,
                    model.TransportKey,
                    model.ServiceKey,
                    model.Date.HasValue ? model.Date.Value.ToString("yyyy-MM-dd") : "",
                    model.Cost.HasValue ? model.Cost.Value.ToString("F2") : "",
                    model.Note,
                    model.Key
                );
            }
            sb.Length--;
            return sb.ToString();
        }
    }
}