namespace CS_Tetris
{
    class ColoredWriter // ColoredWriter
    {
        /// <summary>
        /// You need to first enter your color and then the text for just this text to be corlored
        /// Fx.
        /// Color.Text(ConsoleColor.Yellow, "This is Yellow :D");
        /// </summary>
        public static void WriteLine(ConsoleColor Color, string Text)
        //You need to first enter your color and then the text for just this text to be corlored
        //Fx.
        //Color.Text(ConsoleColor.Yellow, "This is Yellow :D");
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Text);
            Console.ResetColor();
        }

        /// <summary>
        /// You need to first enter your color and then the text for just this text to be corlored
        /// Fx.
        /// Color.Text(ConsoleColor.Yellow, "This is Yellow :D"); on same line
        /// </summary>
        public static void Write(ConsoleColor Color, string Text)
        //You need to first enter your color and then the text for just this text to be corlored
        //Fx.
        //Color.Text(ConsoleColor.Yellow, "This is Yellow :D"); on same line
        {
            Console.ForegroundColor = Color;
            Console.Write(Text);
            Console.ResetColor();
        }
        public static void SetText(ConsoleColor Color)
        //This is Used for setting a serten color
        //Fx.
        //Color.SetText(ConsoleColor.Red); Console.WriteLine("This is Red :D");
        {
            Console.ForegroundColor = Color;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        public static void SetBackground(ConsoleColor Color)
        //This is Used for setting a serten color
        //Fx.
        //Not sure about this yet---
        {
            Console.BackgroundColor = Color;
        }
        public static void Reset()
        //This is Used to reset any Colors set
        //Fx.
        //Color.Reset
        {
            Console.ResetColor();
        }

        public static ConsoleColor GetColor()
        //This is used to get any color you can use for ConsoleColor
        //Fx.
        //Color1 = Color.GetColor; Color.Text(Color, "Hey this is your color :D");
        {
            int DoWhile = 1;
            string? str = "";
            do
            {
                str = Console.ReadLine();
                string[] Colors = GetAllColors();
                foreach (string color in Colors)
                {
                    if (color == str) DoWhile = 0;
                }
            } while (DoWhile == 1);
            if (str == null) throw new ArgumentException("string can not be null");
            ConsoleColor Color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), str, true);
            return Color;
        }
        public static string[] GetAllKnowColors()
        //This is to get a whole list of all colors poseble in C#
        //Fx.
        //Color.GetAllColors(); *string[] of all the colors
        {
            string[] colors = Enum.GetNames(typeof(System.Drawing.KnownColor));
            return colors;
        }
        public static string[] GetAllColors()
        //This is to get all the colors wich is used for ConsoleColor
        //Fx.
        //Color.GetAllColors(); *string[] of all the colors
        {
            string[] AllColors = { "Lime", "Green", "Aqua", "Blue", "Navy", "Purple", "Pink", "Red", "Orange", "Yellow" };
            return AllColors;
        }
    }
}