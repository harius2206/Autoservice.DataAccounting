
namespace Common.Formatting.Tables.Customizable {
    public static class LineCharSets {

        public static LineCharSet[] None = new LineCharSet[] {
            new LineCharSet(' ', ' ', ' ', ' ' ),
            new LineCharSet(' ', ' ', ' ', ' ' ),
            new LineCharSet(' ', ' ', ' ', ' ' ),
            new LineCharSet(' ', ' ', ' ', ' ' ),
        };
        // Як запобігти відображенню прожніх верхнього і нижнього рядків рамки?

        public static LineCharSet[] Single = new LineCharSet[] {
            new LineCharSet('┌', '┬', '┐', '─' ),
            new LineCharSet('├', '┼', '┤', '─' ),
            new LineCharSet('└', '┴', '┘', '─' ),
            new LineCharSet('│', '│', '│', ' ' ),
        };

        public static LineCharSet[] InnerHorizontalSingle = new LineCharSet[] {
            new LineCharSet(' ', ' ', ' ', ' ' ),
            new LineCharSet(' ', '─', ' ', '─' ),
            new LineCharSet(' ', ' ', ' ', ' ' ),
            new LineCharSet(' ', ' ', ' ', ' ' ),
        };

        public static LineCharSet[] Rounded = new LineCharSet[] {
            new LineCharSet('╭', '┬', '╮', '─' ),
            new LineCharSet('├', '┼', '┤', '─' ),
            new LineCharSet('╰', '┴', '╯', '─' ),
            new LineCharSet('│', '│', '│', ' ' ),
        };

        public static LineCharSet[] Double = new LineCharSet[] {
            new LineCharSet('╔', '╦', '╗', '═' ),
            new LineCharSet('╠', '╬', '╣', '═' ),
            new LineCharSet('╚', '╩', '╝', '═' ),
            new LineCharSet('║', '║', '║', ' ' ),
        };

        public static LineCharSet[] OuterDouble = new LineCharSet[] {
            new LineCharSet('╔', '╤', '╗', '═' ),
            new LineCharSet('╟', '┼', '╢', '─' ),
            new LineCharSet('╚', '╧', '╝', '═' ),
            new LineCharSet('║', '│', '║', ' ' ),
        };

        public static LineCharSet[] HorizontalDouble = new LineCharSet[] {
            new LineCharSet('╒', '╤', '╕', '═' ),
            new LineCharSet('╞', '╪', '╡', '═' ),
            new LineCharSet('╘', '╧', '╛', '═' ),
            new LineCharSet('│', '│', '│', ' ' ),
        };

        public static LineCharSet[] InnerHorizontalDouble = new LineCharSet[] {
            new LineCharSet('┌', '┬', '┐', '─' ),
            new LineCharSet('╞', '╪', '╡', '═' ),
            new LineCharSet('└', '┴', '┘', '─' ),
            new LineCharSet('│', '│', '│', ' ' ),
        };

        public static LineCharSet[] OuterVerticalDouble = new LineCharSet[] {
                    new LineCharSet('╓', '┬', '╖', '─' ),
                    new LineCharSet('╟', '┼', '╢', '─' ),
                    new LineCharSet('╙', '┴', '╜', '─' ),
                    new LineCharSet('║', '│', '║', ' ' ),
        };

        //public static LineCharSet[]  = new LineCharSet[] {
        //    new LineChars('', '', '', '' ),
        //    new LineChars('', '', '', '' ),
        //    new LineChars('', '', '', '' ),
        //    new LineChars('', '', '', '' ),
        //};

    }
}
