static class MConsole
{
	static void ClearConsoleLine(int cursorTop)
	{
		Console.SetCursorPosition(0, cursorTop);
		Console.Write(new string(' ', Console.WindowWidth));
		Console.SetCursorPosition(0, cursorTop);
	}
}