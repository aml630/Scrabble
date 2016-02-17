using System.Collections.Generic;
using System;
using System.Linq;

namespace PalindromeNS.Objects
{
  public class Palindrome
    {
        private string _phrase;


        public Palindrome (string phrase)
        {
          _phrase = phrase;

        }

        public string Reverse()
        {
          string inversePhrase;

          char[] phraseArray = _phrase.ToCharArray();
          var reverse = phraseArray.Reverse();

          inversePhrase = string.Join("", reverse);
          Console.WriteLine(inversePhrase);
          return inversePhrase;
        }


  }
}
