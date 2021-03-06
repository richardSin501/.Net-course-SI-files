﻿using System;

namespace SI._01.SortString
{
	internal class SortString
	{
		private static void Main(string[] args)
		{
			const string str =
				"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\n" +
				"Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.\n" +
				"Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
			string[] words = str.Split();

			Array.Sort(words);
			var sortedString = string.Join(" ", words);
			Console.WriteLine(sortedString);
			Console.ReadKey();
		}
	}
}