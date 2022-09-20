using System;
using System.Linq;

namespace Word.Pal
{
	public class Palindrome
	{
		public string Palin { get; set; }

		public Palindrome(string palin)
		{
			Palin = palin;
		}

		public bool IsPalindrome()
		{
			char[] palinArray = new char[Palin.Length];
      char[] reversedPalinArray = new char[palinArray.Length];
			palinArray = Palin.ToCharArray(0, Palin.Length);
			Array.Copy(palinArray, reversedPalinArray, palinArray.Length);
			Array.Reverse(reversedPalinArray);
			return (palinArray.SequenceEqual(reversedPalinArray));
		}
	}
}