using System;
using Autoservice.UI.Models;

namespace Autoservice.UI.Formatting.Simple
{

    public static class ModelsFormatting
    {
        public static string ToDataString(this STO model)
        {
            return string.Format(
                "\t Назва СТО: {0}\n" +
                "\t Код станції: {1}\n" +
                "\t Адреса: {2}\n" +
                "\t Максимум машин: {3}\n" +
                "\t Площа: {4}\n" +
                "\t Кількість працівників: {5}\n" +
                "\t Рік заснування: {6}\n",
                model.Name,
                model.StationID,
                model.Adress,
                model.MaxCars,
                model.Area,
                model.WorkersCount,
                model.Year
            );
        }

        public static string ToDataString(this Transport model)
        {
            return string.Format(
                "\t Марка: {0}\n" +
                "\t Модель: {1}\n" +
                "\t Номер за держзразком: {2}\n" +
                "\t Тип кузова: {3}\n" +
                "\t Вага: {4}",
                model.Mark,
                model.Model,
                model.Numb,
                model.BType,
                model.Mass
            );
        }
    }
}