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
			WriteMessage($"[ERROR] {msg}", ConsoleColor.Red);
		}

		/*
		 * @public
		 *
		 * @params {string msg}
		 */
		public static void Info(string msg)
		{
			WriteMessage($"[INFO] {msg}", ConsoleColor.Blue);
		}

		/*
		 * @public
		 *
		 * @params {string msg}
		 */
		public static void Debug(string msg)
		{
			WriteMessage($"[DEBUG] {msg}", ConsoleColor.Green);
		}

		/*
		 * @public
		 *
		 * @params {string msg}
		 */
		public static void Log(string msg)
		{
			WriteMessage($"[LOG] {msg}", ConsoleColor.White);
		}

		/*
		 * @public
		 *
		 * @params {string msg}
		 */
		public static void Warn(string msg)
		{
			WriteMessage($"[WARN] {msg}", ConsoleColor.Yellow);
		}

		/*
		 * @private
		 *
		 * @params {string msg}
		 * @params {ConsoleColor color}
		 */
		private static void WriteMessage(string msg, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(msg);

			CreatePath.Create();

			WriteLog(msg, CreatePath.LOG_FILE);
			Console.ResetColor();
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

