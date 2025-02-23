namespace ModLogger
{
	public class DateAndTime
	{
		static DateTime now = DateTime.Now;

		public static string DATE = now.ToString("dd_MM_yyyy");
		public static string dateAndTime = now.ToString("dd_MM_yyyy_HH_mm_ss");
	}
};

