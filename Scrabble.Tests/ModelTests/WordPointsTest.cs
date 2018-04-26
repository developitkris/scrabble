using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScoreboard.Models;

namespace ScrabbleScoreboard.Tests
{
  [TestClass]
  public class WordScore
  {
    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string input= "supercalifragilisticexpialidocious";
      Word newWord = new Word(input);
      newWord.Save();

      string result = newWord.GetWord();

      Assert.AreEqual(input, result);
    }
  }
}
