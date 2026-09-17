static class MColoredText
{
	public static string GetColoredText(ConsoleColor color, string message, bool IsLine = false)
	{
		if (!IsLine)
		{
			Console.ForegroundColor = color;
			Console.Write(message);
			Console.ResetColor();
		}
	}
}