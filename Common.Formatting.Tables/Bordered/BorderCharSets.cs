namespace Common.Formatting.Tables.Bordered {
    /// <summary>
    /// Формує набори символів рамок різних стилів
    /// </summary>
    public static class BorderCharSets {

        /// <summary>
        /// Набір символів для рамки з одинарних ліній
        /// </summary>
        public static readonly BorderCharSet Single = new BorderCharSet();

        /// <summary>
        /// Набір символів для таблиці без рамки
        /// </summary>
        public static BorderCharSet None = 
            new BorderCharSet(' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ');

        // Як запобігти відображенню прожніх верхнього і нижнього рядків рамки?

        /// <summary>
        /// Набір символів для таблиці лише з внутрішніми горизонтальними пініями
        /// </summary>
        public static BorderCharSet InnerHorizontalSingle = 
            new BorderCharSet(' ', ' ', ' ', ' ', '─', ' ', ' ', ' ', ' ', ' ', ' ', '─', ' ');

        /// <summary>
        /// Набір символів для рамки з одинарних ліній із заокругленими кутами
        /// </summary>
        public static  BorderCharSet Rounded = 
            new BorderCharSet('╭', '┬', '╮', '├', '┼', '┤', '╰', '┴', '╯', '─', '│', '─', '│') {
        };

        /// <summary>
        /// Набір символів для рамки з подвійних ліній
        /// </summary>
        public static BorderCharSet Double = 
            new BorderCharSet('╔', '╦', '╗', '╠', '╬', '╣', '╚', '╩', '╝', '═', '║', '═', '║');

        public static BorderCharSet OuterDouble = 
            new BorderCharSet('╔', '╤', '╗', '╟', '┼', '╢', '╚', '╧', '╝', '═', '║', '─', '│');

        public static BorderCharSet HorizontalDouble = 
            new BorderCharSet('╒', '╤', '╕', '╞', '╪', '╡', '╘', '╧', '╛', '═', '│', '═', '│');

        public static BorderCharSet InnerHorizontalDouble = 
            new BorderCharSet('┌', '┬', '┐', '╞', '╪', '╡', '└', '┴', '┘', '─', '│', '═', '│');

        public static BorderCharSet OuterVerticalDouble = 
            new BorderCharSet('╓', '┬', '╖', '╟', '┼', '╢', '╙', '┴', '╜', '─', '║', '─', '│');

        //public static BorderCharSet  = 
        //    new BorderChars('', '', '', '', '', '', '', '', '', '', '');

    }
}
