using System;
using System.Text;

namespace Common.Formatting.Tables.Customizable {

    /// <summary>
    /// Клас методів створення табличного представлення даних
    /// на основі вмісту масивув масивів рядкових значень
    /// з можливістю визначення його розширених налаштувань
    /// </summary>
    public static class CustomizableTableCreation {

        /// <summary>
        /// Орієнтовна максимальна довжина рядка таблиці.
        /// Використовується для обчислення початкового розміру 
        /// буфера об'єкта класу StringBuilder
        /// </summary>
        public static int MaxRowLength = 200;

        /// <summary>
        /// Створює і повертає табличне представлення даних з рамкою заданого стилю
        /// та можливістю вибору стовпців, які будуть включені у таблицю
        /// </summary>
        /// <param name="values">масив даних для комірок таблиці</param>
        /// <param name="widthes">масив ширин стовпців таблиці</param>
        /// <param name="visibles">масив ознак включення стовпців у таблицю</param>
        /// <param name="header">заголовок таблиці</param>
        /// <param name="headers">масив заголовків стовпців таблиці</param>
        /// <param name="lineCharSets">масив наборів символів таблиці</param>
        /// <param name="indent">відступ до таблиці зліва</param>
        /// <param name="allLines">ознака відображення усіх ліній таблиці</param>
        /// <returns>табличне представлення даних</returns>
        /// <exception cref="ArgumentException">не співпадання розмірів 
        /// вхідних масивів</exception>
        public static string ToTable(string[][] values, int[] widthes,
            bool[] visibles, LineCharSet[] lineCharSets, string header = null,
            string[] headers = null,
            string indent = " ", bool allLines = false) {

            int rowCount = values.Length;
            int columnCount = values[0].Length;
            if (widthes.Length != columnCount && headers.Length != columnCount) {
                throw new ArgumentException("Не рівні розміри вхідних масивів");
            }
            StringBuilder sb = new StringBuilder((rowCount + 4) * MaxRowLength);
            if(header != null) {
                sb.AppendFormat("{0}{1}\n", indent, header);
            }
            sb.Append(CreateLine(widthes, indent,
                lineCharSets[(int)LineKind.TopLine], visibles));
            if (headers != null) {
                sb.Append(CreateTextLine(headers, widthes,
                    indent, lineCharSets[(int)LineKind.TextLine], visibles));
                sb.Append(CreateLine(widthes, indent,
                    lineCharSets[(int)LineKind.MiddleLine], visibles));
            }
            for (int i = 0; i < rowCount; i++) {
                sb.Append(CreateTextLine(values[i], widthes,
                    indent, lineCharSets[(int)LineKind.TextLine], visibles));
                if (allLines && i < rowCount - 1) {
                    sb.Append(CreateLine(widthes, indent,
                        lineCharSets[(int)LineKind.MiddleLine], visibles));
                }
            }
            sb.Append(CreateLine(widthes, indent,
                lineCharSets[(int)LineKind.BottomLine], visibles));
            return sb.ToString();
        }
        // Як запобігти відображенню верхнього і нижнього рядків рамки,
        // якщо вони прожні?


        private static string CreateTextLine(string[] values, int[] widthes,
            string indent, LineCharSet charSet, bool[] visibles) {
            StringBuilder sb = new StringBuilder(MaxRowLength);
            sb.AppendFormat("{0}{1}", indent, charSet.L);
            for (int i = 0; i < widthes.Length; i++) {
                if (visibles[i]) {
                    string value = values[i] ?? "";
                    if (widthes[i] > 0) {
                        sb.AppendFormat("{0}{1}", value.PadLeft(widthes[i]), 
                            charSet.I);
                    }
                    else {
                        sb.AppendFormat("{0}{1}", value.PadRight(-widthes[i]), 
                            charSet.I);
                    }
                }
            }
            sb[sb.Length - 1] = charSet.R;
            sb.AppendLine();
            return sb.ToString();
        }

        private static string CreateLine(int[] widthes, string indent, 
                LineCharSet charSet, bool[] visibles) {
            StringBuilder sb = new StringBuilder(MaxRowLength);
            sb.AppendFormat("{0}{1}", indent, charSet.L);
            for (int i = 0; i < widthes.Length; i++) {
                if (visibles[i]) {
                    sb.AppendFormat("{0}{1}", 
                        new string(charSet.H, Math.Abs(widthes[i])), 
                        charSet.I);
                }
            }
            sb[sb.Length - 1] = charSet.R;
            sb.AppendLine();
            return sb.ToString();
        }

    }
}
