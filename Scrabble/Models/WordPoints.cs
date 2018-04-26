using System;
using System.Collections.Generic;

namespace ScrabbleScoreboard;
{
  public class WordScore
  {
    private static _alphaChar;
    private static Dictionary<string, int> _word = new Dictionary<string, int>() { {["A", "E", "I", "O", "U", "L", "N", "R", "S", "T"  ], 1}, {["D", "G"], 2}, {["B", "C", "M", "P"], 3}, {["F", "H", "V", "W", "Y"], 4}, {"K", 5}, {["J", "X"], 8}, {["Q", "Z"], 10} };

    public void WordScore(string letter)
    {
      _alphaChar = letter;
    }
    public void SetWord(string word)
    {
      _word = word;
    }
    public static string GetWord()
    {
      return _word;
    }
    public void SetWordTotal(string word)
    {
      for(var i=0; i<word.Length; i++){
        _alphaChar += word.Split("");
        for(var j=0; j<_alphaChar.Length; j++){
          if (_word.Contains(_alphaChar[j])){
            return _word[_alphaChar[j]];
          }

        }
      }

    }

  }
}
