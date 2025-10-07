using System;
using System.IO;
using System.Text;

namespace Common.IO
{
    public static class TextIo
    {
        static string s_startMarker = "<[";
        static string s_endMarker = "]>";

        public static string ReadMarkedText(StreamReader sr)
        {
            string s = GetValue(sr.ReadLine());
            int pos = s.IndexOf(s_startMarker);
            if (pos == -1)
            {
                s = sr.ReadLine();
                pos = s.IndexOf(s_startMarker);
            }
            if (pos == -1)
            {
                return null;
            }
            return ReadMarkedText(sr, s, pos);
        }

        private static string ReadMarkedText(StreamReader sr, string s, int pos)
        {
            StringBuilder sb = new StringBuilder();
            s = s.Substring(pos + s_startMarker.Length);
            if (s[0] == '\n')
            {
                s = s.Substring(1);
            }
            while (true)
            {
                pos = s.IndexOf(s_endMarker);
                if (pos == -1)
                {
                    sb.AppendLine(s);
                }
                else
                {
                    sb.AppendLine(s.Substring(0, pos));
                    break;
                }
                s = sr.ReadLine();
            }
            if (sb.Length > 0)
            {
                sb.Length--;
            }
            return sb.ToString();
        }

        public static string GetCaption(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return null;
            }
            int pos = s.IndexOf(":");
            if (pos == -1)
            {
                return s.Trim();
            }
            return s.Substring(0, pos).Trim();
        }

        public static string GetValue(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return null;
            }
            int pos = s.IndexOf(":");
            if (pos == -1)
            {
                return null;
            }
            if (pos == s.Length)
            {
                return null;
            }
            return s.Substring(pos + 1).Trim();
        }
    }
}