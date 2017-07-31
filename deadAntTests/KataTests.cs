using NUnit.Framework;

namespace deadAnt.Tests
{
	[TestFixture()]
	public class KataTests
	{
		[TestCase(null, ExpectedResult = 0, TestName = "Input_null_shouldBe_0")]
		[TestCase("ant ant ant ant", ExpectedResult = 0, TestName = "Input_ant ant ant ant_shouldBe_0")]
		[TestCase("ant anantt aantnt", ExpectedResult = 2, TestName = "Input_ant anantt aantnt_shouldBe_0")]
		[TestCase("ant ant .... a nt", ExpectedResult = 1, TestName = "Input_ant ant .... a nt_shouldBe_0")]
		public int DeadAntCountTest(string input)
		{
			return Kata.DeadAntCount(input);
		}
	}
}