namespace ModLogger;

public class CreatePath
{
	public static string LOG_PATH { get; private set; } = "";
	public static string LOG_FILE { get; private set; } = "";

	public static void Create()
	{
		try
		{
			string projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			LOG_PATH = Path.Combine(projectRoot, "logs");

			if (!Directory.Exists(LOG_PATH))
			{
				Directory.CreateDirectory(LOG_PATH);
			}

			LOG_FILE = Path.Combine(LOG_PATH, DateAndTime.DATE + ".log");
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			throw;
		}
	}
}
