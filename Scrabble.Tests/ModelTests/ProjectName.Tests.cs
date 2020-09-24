using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class LetterTests
  {
    [TestMethod]
    public void ScoreTotal_CreateScoreFromWord_Integer()
    {
      Letter newWord = new Letter();
      Assert.AreEqual(11, newWord.LetterScore("foobar"));
    }

  }

}