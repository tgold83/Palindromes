using System;
using System.Collections.Generic;
using Word.Pal;

namespace Word
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Input a word and we'll tell you if it's a palindrome!");
			string userInput = Console.ReadLine();
			Palindrome palin = new Palindrome(userInput);
			if (palin.IsPalindrome() == true)
			{
				Console.WriteLine(userInput + " is indeed a palindrome");
			}
			else
			{
				Console.WriteLine("I regret to inform you " + userInput + " is not a palindrome.  1 Like = 1 Prayer.");
			}
		}
	}
}