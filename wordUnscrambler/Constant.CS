using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordUnscrambler
{
    struct Constant
    {
        //Literal Strings replacement

        public const string fileSelectionMessage = "Enter the scrambled words manually or as a file: f = file, m = manual";
        public const string fileNameMessage = "Enter the full path and filename >";
        public const string userInputFormatMessage = "Enter word(s) separated by a comma";
        public const string optionNotRecognized = "The entered option was not recognized";
        public const string errorMessage = "Sorry an error has occurred.. ";
        public const string wordsNotFoundMessage = "No match found...";
        public const string matchFoundMessage = "Match found for {0}: {1}";
        public const string restartMessage = "Would you like to continue? Y/N";
        public const string emptyString = "String is empty";


    }
}
