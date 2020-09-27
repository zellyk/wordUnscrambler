﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wordUnscrambler
{
    public class Program
    {

        private static readonly FileReader fileReader = new FileReader();
        private static readonly WordMatcher wordMatcher = new WordMatcher();



        static void Main(string[] args)
        {

            try
            {


                Console.WriteLine(Constant.fileSelectionMessage);

                string option = Console.ReadLine() ?? throw new Exception("String is empty");

                switch (option.ToUpper())
                {
                    case "F":
                        Console.WriteLine(Constant.fileNameMessage);
                        ExecuteScrambledWordsInFileScenario();
                        break;
                    case "M":
                        Console.WriteLine(Constant.userInputFormatMessage);
                        ExecuteScrambledWordsManualEntryScenario();
                        break;
                    default:
                        Console.WriteLine(Constant.optionNotRecognized);
                        break;

                }

                // Optional for now (when you have no loop) >>>>>>>>>> take out when finished. 
                Console.ReadKey();

            }

            catch (Exception e)
            {
                Console.WriteLine(Constant.errorMessage + e.Message);

            }



        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            string fileName = Console.ReadLine();
            string[] scrambledWords = fileReader.Read(fileName);
            DisplayMatchedScrambledWords(scrambledWords);

        }


        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            // get user input - comma seperated string containing scrambled words.
            // cat , dog , etc

            // extract words into a string

            // call DisplayMatchedScrambledWords passing the scrambled words string array



        }



        private static void DisplayMatchedScrambledWords(string[] scrambledWords)
        {
            string[] wordList = fileReader.Read(@"wordlist.txt");  // put in a constant file. Capital letters, readonly.

            List<MatchedWord> matchedWords = wordMatcher.Match(scrambledWords, wordList);


            // rules: use a formatter to display eg {0}{1}...
            // rule use IIF to determine if matchedWords is empty or not.....
            // if empty - display no words found message. 
            // if not empty - display the matches.... use "foreach" with the list of matchedWords



        }
        

    }

}
