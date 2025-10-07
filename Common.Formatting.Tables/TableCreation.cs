using Common.Formatting.Tables.Bordered;
using Common.Formatting.Tables.Customizable;

namespace Common.Formatting.Tables {
    public static class TableCreation {

        /// <summary>
        /// Створює і повертає табличне представлення даних з рамкою заданого стилю
        /// </summary>
        /// <param name="values">масив даних для комірок таблиці</param>
        /// <param name="settings">налаштування таблиці та її елементів</param>
        /// <param name="borderStyle">стиль рамки таблиці</param>
        /// <param name="allLines">ознака відображення усіх ліній таблиці</param>
        /// <returns>табличне представлення даних</returns>
        public static string ToTable(this string[][] values, TableSettings settings, 
            BorderStyle borderStyle = BorderStyle.Single, bool allLines = false) {

            return ToTable(values, settings.ColumnWidthes, settings.TableHeader,
                settings.ColumnHeaders, borderStyle, TableSettings.Indent, allLines);
        }


        /// <summary>
        /// Створює і повертає табличне представлення даних з рамкою заданого стилю
        /// </summary>
        /// <param name="values">масив даних для комірок таблиці</param>
        /// <param name="widthes">масив ширин стовпців таблиці</param>
        /// <param name="header">заголовок таблиці</param>
        /// <param name="headers">масив заголовків стовпців таблиці</param>
        /// <param name="borderStyle">стиль рамки таблиці</param>
        /// <param name="indent">відступ до таблиці зліва</param>
        /// <param name="allLines">ознака відображення усіх ліній таблиці</param>
        /// <returns>табличне представлення даних</returns>
        public static string ToTable(this string[][] values, int[] widthes, 
            string header = null, string[] headers = null, 
            BorderStyle borderStyle = BorderStyle.Single,
            string indent = " ", bool allLines = false) {

            BorderCharSet charSet = borderStyle.ToBorderCharSet();
            return BorderedTableCreation.ToTable(values, widthes, charSet, 
                header, headers, indent, allLines);
        }

        //-----------------------------------------------------------------------

        /// <summary>
        /// Створює і повертає табличне представлення даних з рамкою заданого стилю
        /// та можливістю вибору стовпців, які будуть включені у таблицю
        /// </summary>
        /// <param name="values">масив даних для комірок таблиці</param>
        /// <param name="settings">налаштування таблиці та її елементів</param>
        /// <param name="visibles">масив ознак включення стовпців у таблицю</param>
        /// <param name="borderStyle">стиль рамки таблиці</param>
        /// <param name="allLines">ознака відображення усіх ліній таблиці</param>
        /// <returns></returns>
        public static string ToTable(this string[][] values, TableSettings settings,
            bool[] visibles, BorderStyle borderStyle = BorderStyle.Single,
            bool allLines = false) {

            return ToTable(values, settings.ColumnWidthes, visibles,
                settings.TableHeader, settings.ColumnHeaders, borderStyle,
                TableSettings.Indent, allLines);
        }

        /// <summary>
        /// Створює і повертає табличне представлення даних з рамкою заданого стилю
        /// та можливістю вибору стовпців, які будуть включені у таблицю
        /// </summary>
        /// <param name="values">масив даних для комірок таблиці</param>
        /// <param name="widthes">масив ширин стовпців таблиці</param>
        /// <param name="visibles">масив ознак включення стовпців у таблицю</param>
        /// <param name="header">заголовок таблиці</param>
        /// <param name="headers">масив заголовків стовпців таблиці</param>
        /// <param name="borderStyle">стиль рамки таблиці</param>
        /// <param name="indent">відступ до таблиці зліва</param>
        /// <param name="allLines">ознака відображення усіх ліній таблиці</param>
        /// <returns>табличне представлення даних</returns>
        public static string ToTable(this string[][] values, int[] widthes,
            bool[] visibles, string header = null, string[] headers = null,
            BorderStyle borderStyle = BorderStyle.Single,
            string indent = " ", bool allLines = false) {

            LineCharSet[] lineCharSets = borderStyle.ToLineCharSets();
            return CustomizableTableCreation.ToTable(values, widthes, visibles,
                lineCharSets, header, headers, indent, allLines);
        }

        //-----------------------------------------------------------------------

        /// <summary>
        /// Створює і повертає табличне представлення даних з рамкою заданого стилю
        /// та можливістю вибору стовпців, які будуть включені у таблицю
        /// </summary>
        /// <param name="values">масив даних для комірок таблиці</param>
        /// <param name="settings">налаштування таблиці та її елементів</param>
        /// <param name="visibility">число, біти якого визначають включення 
        /// стовпців у таблицю</param>
        /// <param name="borderStyle">стиль рамки таблиці</param>
        /// <param name="allLines">ознака відображення усіх ліній таблиці</param>
        /// <returns></returns>
        public static string ToTable(this string[][] values, TableSettings settings,
            int visibility, BorderStyle borderStyle = BorderStyle.Single,
            bool allLines = false) {

            return ToTable(values, settings.ColumnWidthes, visibility, 
                settings.TableHeader, settings.ColumnHeaders, borderStyle,
                TableSettings.Indent, allLines);
        }

        /// <summary>
        /// Створює і повертає табличне представлення даних з рамкою заданого стилю
        /// та можливістю вибору стовпців, які будуть включені у таблицю
        /// </summary>
        /// <param name="values">масив даних для комірок таблиці</param>
        /// <param name="widthes">масив ширин стовпців таблиці</param>
        /// <param name="visibility">число, біти якого визначають включення 
        /// стовпців у таблицю</param>
        /// <param name="header">заголовок таблиці</param>
        /// <param name="headers">масив заголовків стовпців таблиці</param>
        /// <param name="borderStyle">стиль рамки таблиці</param>
        /// <param name="indent">відступ до таблиці зліва</param>
        /// <param name="allLines">ознака відображення усіх ліній таблиці</param>
        /// <returns>табличне представлення даних</returns>
        public static string ToTable(this string[][] values, int[] widthes, 
            int visibility, string header = null, string[] headers = null, 
            BorderStyle borderStyle = BorderStyle.Single,
            string indent = " ", bool allLines = false) {

            int count = values[0].Length;
            bool[] visibles = visibility.BitsToBoolArray(count);
            LineCharSet[] lineCharSets = borderStyle.ToLineCharSets();
            return CustomizableTableCreation.ToTable(values, widthes, visibles,
                lineCharSets, header, headers, indent, allLines);
        }

        /// <summary>
        /// Створює і повертає масив логічних значень 
        /// на основі значень бітів цілого числа
        /// </summary>
        /// <param name="value">ціле число, що використовується як набір бітів</param>
        /// <param name="size">розмір масиву, який потрібно створити</param>
        /// <returns>масив логічних значень</returns>
        public static bool[] BitsToBoolArray(this int value, int size) {
            bool[] arr = new bool[size];
            for (int i = 0; i < size; i++) {
                arr[i] = ((value >> i) & 1) == 1;
            }
            return arr;
        }
        // Самостійнео реалізувати зворотне перетворення

    }
}
