using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program.Pal;

namespace Program.Pal.Test
{
	[TestClass]
	public class PalindromeTest
	{
		[TestMethod]
    public void Palindrome_IsPalindrome_True()
    {
      Palindrome pal = new Palindrome("racecar");
			Assert.AreEqual(true, pal.IsPalindrome());
			// split string into array
			// reverse array
			// check if array == reverseArray; if true, palindrome, if false, nah
    }
	}
}