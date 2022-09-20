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
			Assert.AreEqual(true, pal.IsPalindrome(pal.Palin));
    }
	}
}