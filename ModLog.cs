namespace ModLogger
{
	public class ModLog
	{
        /*
         * @public
         *
         * @params {string msg}
         */
        public static void Error(string msg)
        {
            WriteMessage(ConsoleColor.Red, $"error", $"{msg}");
        }

        /*
         * @public
         *
         * @params {string msg}
         */
        public static void Info(string msg)
        {
            WriteMessage(ConsoleColor.Cyan, $"info", $"{msg}");
        }

        /*
         * @public
         *
         * @params {string msg}
         */
        public static void Debug(string msg)
        {
            WriteMessage(ConsoleColor.Green, $"debug", $"{msg}");
        }

        /*
         * @public
         *
         * @params {string msg}
         */
        public static void Log(string msg)
        {
            WriteMessage(ConsoleColor.White, $"log", $"{msg}");
        }

        /*
		 * @public
		 *
		 * @params {string msg}
		 */
        public static void Warn(string msg)
        {
            WriteMessage(ConsoleColor.Yellow, $"warn", $"{msg}");
        }

        /*
		 * @private
		 *
		 * @params {string msg}
		 * @params {ConsoleColor color}
		 */
        private static void WriteMessage(ConsoleColor colorType, string type, string msg)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");

            Console.ForegroundColor = colorType;
            Console.Write(type);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] ");

            Console.ResetColor();
            Console.Write(msg + "\n");

            Console.ResetColor();

            CreatePath.Create();
            WriteLog(msg, CreatePath.LOG_FILE);
        }

        /*
		 * @private
		 *
		 * @params {string msg}
		 * @params {string path}
		 */
        private static void WriteLog(string msg, string path)
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(path, append: true)) {
					writer.WriteLine($"[{DateAndTime.dateAndTime.Replace("_", ":")}]: {msg ?? "Undefined"}");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
};

