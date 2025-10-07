using System;
using System.Text;

namespace Common.Formatting.Tables {

    /// <summary>
    /// Представляє налаштування табличного представлення даних
    /// </summary>
    public class TableSettings {

        static string s_indent = " ";

        /// <summary>
        /// Повертає рядок, що визначає відступ до таблиці зліва
        /// </summary>
        public static string Indent {
            get { return s_indent; }
        }

        /// <summary>
        /// Встановлює і повертає довжину рядка, що визначає відступ до таблиці зліва
        /// </summary>
        public static int IndentLength {
            get { return s_indent.Length; }
            set {
                if(value < 0) {
                    throw new ArgumentOutOfRangeException("IndentLength.value",
                        value, "Довжина рядка не може бути від'ємною.");
                }
                s_indent = new string(' ', value);
            }
        }

        /// <summary>
        /// Кількість стовпців таблиці
        /// </summary>
        public readonly int ColumnsCount;

        /// <summary>
        /// Встановлює і повертає текст заголовку таблиці
        /// </summary>
        public string TableHeader { get; set; }

        /// <summary>
        /// Масив ширин стовпців таблиці
        /// </summary>
        public readonly int[] ColumnWidthes;

        /// <summary>
        /// Масив заголовків стовпців таблиці
        /// </summary>
        public readonly string[] ColumnHeaders;

        /// <summary>
        /// Ініціалізує поля об'єкта, що визначають налаштування таблиці
        /// </summary>
        /// <param name="tableHeader">заголовок таблиці</param>
        /// <param name="columnHeaders">масив заголовків стовпців таблиці</param>
        /// <param name="columnWidthes">масив ширин стовпців таблиці</param>
        /// <exception cref="InvalidOperationException">неспівпадіння кількості 
        /// заголовків стовпців та кількості їх ширин</exception>
        public TableSettings(string tableHeader, string[] columnHeaders, int[] columnWidthes) {
            ColumnsCount = columnHeaders.Length;
            if (ColumnsCount != columnWidthes.Length) {
                throw new InvalidOperationException("Кількість заголовків стовпців таблиці {0} " +
                    "не співпадає з кількість значень їх ширин {1}.");
            }
            TableHeader = tableHeader;
            ColumnHeaders = columnHeaders;
            ColumnWidthes = columnWidthes;
        }

        /// <summary>
        /// Створення рядка певного формату 
        /// на основі значень налаштувань таблиці 
        /// з метою їх збереження у текстовому файлі
        /// </summary>
        /// <param name="settings">налаштування таблиці</param>
        /// <returns>рядок з даними про налаштування таблиці</returns>
        public static string CreateDataString(TableSettings settings) {
            StringBuilder sb = new StringBuilder();
            sb.Append(settings.TableHeader);
            sb.AppendLine(string.Join(" ", settings.ColumnWidthes));
            sb.AppendLine(string.Join("\n", settings.ColumnHeaders));
            return sb.ToString();
        }

        /// <summary>
        /// Створення об'єкта налаштувань таблиці 
        /// на основі вмісту рядка зі значеннями налаштувань,
        /// формат якого визначається методом CreateDataString
        /// </summary>
        /// <param name="dataString">рядок з даними про налаштування таблиці</param>
        /// <returns>об'єкт, що зберігає налаштування таблиці</returns>
        public static TableSettings ParseDataString(string dataString) {
            string[] lines = dataString.Split(new char[] { '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);
            string header = lines[0];
            string[] widthesStrings = lines[1].Split();
            int[] widthes = Array.ConvertAll(widthesStrings,
                 el => Convert.ToInt32(el));
            string[] headers = new string[widthesStrings.Length];
            Array.Copy(lines, 1, headers, 0, headers.Length);
            return new TableSettings(header, headers, widthes);
        }

    }
}
