using System;
using Common.Formatting;

namespace Autoservice.UI.Formatting.Simple
{
    public static class ModelsFormatting
    {
        public static int ValueIndentLength = 12;

        public static string ToDataString(this OwnerModel model)
        {
            string indent = new string(' ', ValueIndentLength);
            return string.Format(
                "{0}Власник: {1}\n" +
                "{0}E-mail: {2}\n" +
                "{0}Адреса доставки: {3}\n",
                indent,
                model.Name,
                model.Email,
                model.Address.ToTextBlocks(ValueIndentLength, true)
            );
        }

        public static string ToDataString(this TransportModel model)
        {
            string indent = new string(' ', ValueIndentLength);
            return string.Format(
                "{0}Номер за держзразком: {1}\n" +
                "{0}Марка: {2}\n" +
                "{0}Модель: {3}\n" +
                "{0}Опис: {4}\n" +
                "{0}Власник: {5}\n" +
                "{0}Батьківський транспорт: {6}",
                indent,
                model.Number,
                model.Make,
                model.Model,
                model.Description,
                model.OwnerKey,
                model.ParentKey
            );
        }

        public static string ToDataString(this ServiceModel model)
        {
            string indent = new string(' ', ValueIndentLength);
            return string.Format(
                "{0}Ім'я: {1}\n" +
                "{0}Ціна: {2}\n" +
                "{0}Час виконання: {3}\n" +
                "{0}Гарантійний період: {4}\n",
                indent,
                model.Name,
                model.Price,
                model.Duration,
                model.WarrantyPeriod
            );
        }
    }
}