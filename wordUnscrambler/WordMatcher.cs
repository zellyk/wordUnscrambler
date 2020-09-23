using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordlist)
        {

            List<MatchedWord> matchedWords = new List<MatchedWord>();

            foreach (string scrambledWord in scrambledWords)
            {

                foreach (string word in wordlist)
                {

                    if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {

                        // matchedWords.Add(BuildMatchedWord(scrambledWord, word));


                        matchedWords.Add(new MatchedWord() { ScrambledWord = scrambledWord, Word = word });



                    }
                    else 
                    { }
                
                }
            }

            return null;
        }

        MatchedWord BuildMatchedWord(string scrambledWord, string word)
        {

            MatchedWord matchedWord = new MatchedWord()
            {

                ScrambledWord = scrambledWord,
                Word = word

            };


            return matchedWord;

        }






    }
}
