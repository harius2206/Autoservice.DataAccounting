//using System;
//using System.Collections.Generic;

//namespace Common.Processing.Types {
//    public static class CrudModesInfo {
//        public static string[] NamesArray { get; private set; }

//        public static int Count { get; private set; }

//        static CrudModesInfo() {
//            NamesArray = Enum.GetNames(typeof(CrudMode));
//            Count = NamesArray.Length;
//            CreateHeaders();
//            CreateCaptions();
//        }

//        static readonly Dictionary<CrudMode, string> _headersDictionary =
//            new Dictionary<CrudMode, string> {
//                { CrudMode.None, "Немає дії" },
//                { CrudMode.Creation, "Створення" },
//                { CrudMode.Reading, "Перегляд" },
//                { CrudMode.Updating, "Редагування" }, // "Зміна", "Поновлення"
//                { CrudMode.Deleting, "Видалення" },
//        };

//        public static string ToHeader(this CrudMode mode) {
//            return _headersDictionary[mode];
//        }

//        public static string[] HeadersArray { get; private set; }

//        private static void CreateHeaders() {
//            string[] headers = new string[Count];
//            for (int i = 0; i < Count; i++) {
//                headers[i] = ((CrudMode)i).ToHeader();
//            }
//            HeadersArray = headers;
//        }

//        static readonly Dictionary<CrudMode, string> _captions =
//            new Dictionary<CrudMode, string> {
//                { CrudMode.None, "Немає дії" },
//                { CrudMode.Creation, "Створити" },
//                { CrudMode.Reading, "Показати" },
//                { CrudMode.Updating, "Редагувати" }, // "Змінити", "Поновити"
//                { CrudMode.Deleting, "Видалити" },
//        };

//        public static string ToCaption(this CrudMode mode) {
//            return _captions[mode]; 
//        }

//        public static string[] CaptionsArray { get; private set; }

//        private static void CreateCaptions() {
//            string[] captions = new string[Count];
//            for (int i = 0; i < Count; i++) {
//                captions[i] = ((CrudMode)i).ToCaption();
//            }
//            CaptionsArray = captions;
//        }



//    }
//}
