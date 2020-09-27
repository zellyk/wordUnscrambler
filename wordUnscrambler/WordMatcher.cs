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
                    {
                        char[] WordArray;
                        char[] ScrambeledArray;

                        WordArray = word.ToCharArray();
                        ScrambeledArray = scrambledWord.ToCharArray();

                        Array.Sort(WordArray);
                        Array.Sort(ScrambeledArray);

                        string ScrambeledS = new string(WordArray);
                        string WordS = new string(ScrambeledArray);

                        if(ScrambeledS == WordS)
                        {
                            matchedWords.Add(new MatchedWord() { ScrambledWord = scrambledWord, Word = word });
                        }

                    }
                
                }
            }

            return matchedWords;
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
