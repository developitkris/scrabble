using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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

    [TestMethod]
    public void GetChar_ReturnsChar_String()
    {
      
    }
  }
}
