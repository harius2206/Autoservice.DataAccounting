using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Formatting.Tables.Bordered {

    /// <summary>
    /// Клас методів створення обрамленого табличного представлення даних
    /// на основі вмісту масивув масивів рядкових значень
    /// </summary>
    public static class BorderedTableCreation {

        /// <summary>
        /// Орієнтовна максимальна довжина рядка таблиці.
        /// Використовується для обчислення початкового розміру 
        /// буфера об'єкта класу StringBuilder
        /// </summary>
        public static int MaxRowLength = 200;


        /// <summary>
        /// Створює і повертає табличне представлення даних з рамкою заданого стилю
        /// </summary>
        /// <param name="values">масив даних для комірок таблиці</param>
        /// <param name="widthes">масив ширин стовпців таблиці</param>
        /// <param name="charSet">набір символів рамки таблиці</param>
        /// <param name="header">заголовок таблиці</param>
        /// <param name="headers">масив заголовків стовпців таблиці</param>
        /// <param name="indent">відступ до таблиці зліва</param>
        /// <param name="allLines">ознака відображення усіх ліній таблиці</param>
        /// <returns>табличне представлення даних</returns>
        public static string ToTable(this string[][] values, int[] widthes,
                BorderCharSet charSet, string header = null, string[] headers = null, 
                string indent = " ", bool allLines = false) {

            string format = widthes.CreateTableFormat(charSet, indent);
            StringBuilder sb = new StringBuilder(values.Length * MaxRowLength);
            if (header != null) {
                sb.AppendFormat("{0}{1}\n", indent, header);
            }
            sb.Append(ToTopLine(widthes, charSet, indent));
            if(headers != null) {
                sb.AppendFormat(format, headers);
                sb.Append(ToMiddleLine(widthes, charSet, indent));
            }
            for (int i = 0; i < values.Length; i++) {
                sb.AppendFormat(format, values[i]);
                if (allLines && i < values.Length - 1) {
                    sb.Append(ToMiddleLine(widthes, charSet, indent));
                }
            }
            sb.Append(ToBottomLine(widthes, charSet, indent));

            return sb.ToString();
        }
        // Як запобігти відображенню верхнього і нижнього рядків рамки,
        // якщо вони прожні?


        /// <summary>
        /// Створює і повертає рядок формату для формування рядків таблиці 
        /// </summary>
        /// <param name="widthes">масив ширин стовпців таблиці</param>
        /// <param name="charSet">набір символів рамки таблиці</param>
        /// <param name="indent">відступ до таблиці зліва</param>
        /// <returns></returns>
        public static string CreateTableFormat(this IEnumerable<int> widthes,
                BorderCharSet charSet, string indent = " ") {
            StringBuilder sb = new StringBuilder(MaxRowLength);
            sb.AppendFormat("{0}{1}", indent, charSet.VO);
            int i = 0;
            foreach (var w in widthes) {
                sb.AppendFormat("{{{0},{1}}}{2}", i++, w, charSet.VI);
            }
            //sb.Length--;
            sb[sb.Length - 1] = charSet.VO;
            sb.AppendLine();
            return sb.ToString();
        }

        private static string ToTopLine(int[] widthes, BorderCharSet charSet,
                string indent) {
            StringBuilder sb = new StringBuilder(MaxRowLength);
            sb.AppendFormat("{0}{1}", indent, charSet.LT);
            int count = widthes.Length - 1;
            int i = 0;
            for (; i < count; i++) {
                sb.AppendFormat("{0}{1}", 
                    new string(charSet.HO, Math.Abs(widthes[i])), 
                    charSet.IT);
            }
            sb.AppendFormat("{0}{1}\n", 
                new string(charSet.HO, Math.Abs(widthes[i])), 
                charSet.RT);
            return sb.ToString();
        }

        private static string ToMiddleLine(int[] widthes, BorderCharSet charSet,
                string indent) {
            StringBuilder sb = new StringBuilder(MaxRowLength);
            sb.AppendFormat("{0}{1}", indent, charSet.LI);
            int count = widthes.Length - 1;
            int i = 0;
            for (; i < count; i++) {
                sb.AppendFormat("{0}{1}", 
                    new string(charSet.HI, Math.Abs(widthes[i])), 
                    charSet.II);
            }
            sb.AppendFormat("{0}{1}\n", 
                new string(charSet.HI, Math.Abs(widthes[i])), 
                charSet.RI);
            return sb.ToString();
        }

        private static string ToBottomLine(int[] widthes, BorderCharSet charSet,
                string indent) {
            StringBuilder sb = new StringBuilder(MaxRowLength);
            sb.AppendFormat("{0}{1}", indent, charSet.LB);
            int count = widthes.Length - 1;
            int i = 0;
            for (; i < count; i++) {
                sb.AppendFormat("{0}{1}", 
                    new string(charSet.HO, Math.Abs(widthes[i])), 
                    charSet.IB);
            }
            sb.AppendFormat("{0}{1}\n", 
                new string(charSet.HO, Math.Abs(widthes[i])), 
                charSet.RB);
            return sb.ToString();
        }


    }
}
