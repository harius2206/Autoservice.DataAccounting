using System;
using System.Linq;
using Common.Collection;
using Common.Data.IO.Interfaces;
using Common.Interfaces.Extensions;

namespace Autoservice.Data.Formatting
{
    public static class FormattingMethods
    {
        public static string ToDataString(this IDataSet dataSet, string header = null)
        {
            if (header == null)
                header = "ПО \"Автосервіс\"";

            return string.Concat(
                header == null ? "" : header + "\n",
                dataSet.Owners.ToLineList(" Власники"), "\n",
                dataSet.Transports.ToLineList(" Транспортні засоби"), "\n",
                dataSet.Services.ToLineList(" Послуги"), "\n",
                dataSet.Maintenances.ToLineList(" Обслуговування")
            );
        }

        public static string ToStatisticsString(this IDataSet dataSet, string header = null)
        {
            return $"{header ?? "Статистичні дані про об'єкти ПО"}\n" +
                   $" Представлено:\n" +
                   $"{dataSet.Owners.Count(),7} власників\n" +
                   $"{dataSet.Transports.Count(),7} транспортних засобів\n" +
                   $"{dataSet.Services.Count(),7} послуг\n" +
                   $"{dataSet.Maintenances.Count(),7} обслуговувань";
        }

        public static string ToKeyList(this IDataSet dataSet, string header = null)
        {
            return $"{header ?? "Список значень ключових полів об'єктів ПО"}\n" +
                   $"{dataSet.Owners.ToKeyList(" Власники")}\n" +
                   $"{dataSet.Transports.ToKeyList(" Транспортні засоби")}\n" +
                   $"{dataSet.Services.ToKeyList(" Послуги")}\n" +
                   $"{dataSet.Maintenances.ToKeyList(" Обслуговування")}";
        }
    }
}