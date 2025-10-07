using Common.Formatting.Tables.Bordered;
using Common.Formatting.Tables.Customizable;
using System;
using System.Collections.Generic;

namespace Common.Formatting.Tables {

    /// <summary>
    /// Визначає характеристики та елементи рамок таблиць для різних стилів
    /// </summary>
    public static class BorderStylesInfo {

        /// <summary>
        /// Повертає набір елементів перечислення BorderStyle у вигляді масиву
        /// </summary>
        public static Array Values {
            get { return Enum.GetValues(typeof(BorderStyle)); }
        }

        /// <summary>
        /// Повертає назви стилів рамок таблиці для вказаного елементу перечислення BorderStyle
        /// </summary>
        /// <param name="borderStyle">константа, що визначає стиль рамки</param>
        /// <returns>назва стилю рамки</returns>
        /// <exception cref="NotImplementedException">для заданого стилю назва не визначена</exception>
        public static string ToCaption(this BorderStyle borderStyle) {
            switch (borderStyle) {
                case BorderStyle.None: return "без рамки";
                case BorderStyle.Single: return "одинарні лінії";
                case BorderStyle.InnerHorizontalSingle: return "лише внутрішні горизонтальні одинарні лінії";
                case BorderStyle.Rounded: return "закруглена рамка";
                case BorderStyle.Double: return "подвійні лінії";
                case BorderStyle.OuterDouble: return "подвійні зовнішні лінії";
                case BorderStyle.HorizontalDouble: return "подвійні горизонтальні лінії";
                case BorderStyle.InnerHorizontalDouble: return "подвійні вінутрішні горизонтальні лінії";
                case BorderStyle.OuterVerticalDouble: return "подвійні зовнішні вертикальні лінії";
                default: throw new NotImplementedException(borderStyle.ToString());
            }
        }

        /// <summary>
        /// Повертає набір символів для формування горизонтальної лінії або рядка таблиці
        /// для вказаного елементу перечислення BorderStyle
        /// </summary>
        /// <param name="borderStyle">константа, що визначає стиль рамки</param>
        /// <returns>набір символів для формування горизонтальної лінії або рядка таблиці</returns>
        public static LineCharSet[] ToLineCharSets(this BorderStyle borderStyle) {
            return _lineCharSetDictionary[borderStyle];
        }

        private static Dictionary<BorderStyle, LineCharSet[]> _lineCharSetDictionary
                = new Dictionary<BorderStyle, LineCharSet[]>() {
            { BorderStyle.None, LineCharSets.None },
            { BorderStyle.Single, LineCharSets.Single },
            { BorderStyle.InnerHorizontalSingle, LineCharSets.InnerHorizontalSingle },
            { BorderStyle.Rounded, LineCharSets.Rounded },
            { BorderStyle.Double, LineCharSets.Double },
            { BorderStyle.OuterDouble, LineCharSets.OuterDouble },
            { BorderStyle.HorizontalDouble, LineCharSets.HorizontalDouble },
            { BorderStyle.OuterVerticalDouble, LineCharSets.OuterVerticalDouble },
            //{ BorderStyle., LineCharSets. },
        };

        /// <summary>
        /// Повертає набір символів для формування рамки таблиці
        /// для вказаного елементу перечислення BorderStyle
        /// </summary>
        /// <param name="borderStyle">константа, що визначає стиль рамки</param>
        /// <returns>набір символів для формування рамки таблиці</returns>
        public static BorderCharSet ToBorderCharSet(this BorderStyle borderStyle) {
            return _borderCharSetDictionary[borderStyle];
        }

        private static Dictionary<BorderStyle, BorderCharSet> _borderCharSetDictionary
                = new Dictionary<BorderStyle, BorderCharSet> {
            { BorderStyle.None, BorderCharSets.None },
            { BorderStyle.Single, BorderCharSets.Single },
            { BorderStyle.InnerHorizontalSingle, BorderCharSets.InnerHorizontalSingle },
            { BorderStyle.Rounded, BorderCharSets.Rounded },
            { BorderStyle.Double, BorderCharSets.Double },
            { BorderStyle.OuterDouble, BorderCharSets.OuterDouble },
            { BorderStyle.HorizontalDouble, BorderCharSets.HorizontalDouble },
            { BorderStyle.InnerHorizontalDouble, BorderCharSets.InnerHorizontalDouble },
            { BorderStyle.OuterVerticalDouble, BorderCharSets.OuterVerticalDouble },
            //{ BorderStyle., BorderCharSets. },
        };
        // ╨╥
    }
}
