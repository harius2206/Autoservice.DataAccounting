namespace Common.Formatting.Tables.Bordered {

    /// <summary>
    /// Набір символів для формування рамки таблиці
    /// </summary>
    public class BorderCharSet {
    //public struct BorderCharSet { // ???

        /// <summary>
        /// лівий кутовий символ верхньої лінії
        /// </summary>
        public readonly char LT = '┌';
        public readonly char LI = '├';
        public readonly char LB = '└';
        public readonly char IT = '┬';
        public readonly char II = '┼';
        public readonly char IB = '┴';
        public readonly char RT = '┐';
        public readonly char RI = '┤';
        public readonly char RB = '┘';
        public readonly char HO = '─';
        public readonly char VO = '│';
        public readonly char HI = '─';
        public readonly char VI = '│';

        /// <summary>
        /// Ініціалізує набір символів для формування рамки таблиці 
        /// у відповідності з ініціалізаторами 
        /// </summary>
        public BorderCharSet() { }

        /// <summary>
        /// Ініціалізує новий набір символів для формування рамки таблиці
        /// </summary>
        /// <param name="lT">лівий кутовий символ верхньої лінії</param>
        /// <param name="iT">символ перетину внутрішньої і верхньої ліній</param>
        /// <param name="rT">правий кутовий символ верхньої лінії</param>
        /// <param name="lI">лівий символ внутрішньої лінії</param>
        /// <param name="iI">символ перетину внутрішніх ліній</param>
        /// <param name="rI">правий символ внутрішньої лінії</param>
        /// <param name="lB">лівий кутовий символ нижньої лінії</param>
        /// <param name="iB">символ перетину внутрішньої і нижньої ліній</param>
        /// <param name="rB">правий кутовий символ нижньої лінії</param>
        /// <param name="hO">символ горизонтальної зовнішньої лінії</param>
        /// <param name="vO">символ вертикальної зовнішньої лінії</param>
        /// <param name="hI">символ горизонтальної внутрішньої лінії</param>
        /// <param name="vI">символ вертикальної внутрішньої лінії</param>
        public BorderCharSet(char lT, char iT, char rT, char lI, char iI, char rI,
                             char lB, char iB, char rB, char hO, char vO, char hI, char vI) {
            LT = lT;
            IT = iT;
            RT = rT;
            LI = lI;
            II = iI;
            RI = rI;
            LB = lB;
            IB = iB;
            RB = rB;
            HO = hO;
            VO = vO;
            HI = hI;
            VI = vI;
        }
    }

}
