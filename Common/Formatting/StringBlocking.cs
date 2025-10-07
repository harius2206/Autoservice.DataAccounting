using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Formatting
{
    public static class StringBlocking
    {
        public static int MaxLineLength;

        static StringBlocking()
        {
            MaxLineLength = Console.WindowWidth - 1;
        }

        public static string ToTextBlock(this string text, string indent, bool fromNewLine = false, int cursorPosition = 0, StringBuilder sb = null)
        {
            if (text == null)
                return null;

            if (sb == null)
                sb = new StringBuilder(text.Length * 2);

            if (fromNewLine)
                sb.AppendLine();

            int pos = 0;
            int len = MaxLineLength - indent.Length - 1 - cursorPosition;

            while (pos < text.Length)
            {
                sb.Append(indent);
                if (text.Length - pos >= len)
                {
                    int lastSpace = text.LastIndexOf(' ', pos + len, len);
                    if (lastSpace > pos)
                    {
                        sb.AppendFormat("{0}\n", text.Substring(pos, lastSpace - pos));
                        pos = lastSpace + 1;
                    }
                    else
                    {
                        sb.AppendFormat("{0}\n", text.Substring(pos, len));
                        pos += len;
                    }
                }
                else
                {
                    sb.Append(text.Substring(pos));
                    pos = text.Length;
                }
                len = MaxLineLength - indent.Length - 1; // Reset length for subsequent lines
            }

            return sb.ToString();
        }

        public static string ToTextBlock(this string text, int indentLength, bool fromNewLine = false, int cursorPosition = 0, StringBuilder sb = null)
        {
            string indent = new string(' ', indentLength);
            return ToTextBlock(text, indent, fromNewLine, cursorPosition, sb);
        }

        public static string ToTextBlocks(this string text, string indent, bool fromNewLine = false, int cursorPosition = 0)
        {
            if (text == null)
                return null;

            StringBuilder sb = new StringBuilder(text.Length * 2);
            if (fromNewLine)
                sb.AppendLine();

            string[] strings = text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in strings)
            {
                str.ToTextBlock(indent, false, cursorPosition, sb);
                sb.AppendLine();
                cursorPosition = 0; // Reset cursor position for subsequent paragraphs
            }
            sb.Length--; // Видаляємо останній зайвий символ нового рядка

            return sb.ToString();
        }

        public static string ToTextBlocks(this string text, int indentLength, bool fromNewLine = false, int cursorPosition = 0)
        {
            string indent = new string(' ', indentLength);
            return ToTextBlocks(text, indent, fromNewLine, cursorPosition);
        }
    }
}