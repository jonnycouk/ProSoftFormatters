using System;

namespace ProSoft.Formatters
{
    public class String
    {
        public static string TidyCase(string baseString)
        {
            string processingString = baseString.ToLower(); // Force to lowercase first
            bool uppercaseLetter = false;
            string processingChar = System.String.Empty;
            string outputString = System.String.Empty;
            int counter = 0;
            int processingStringLength = processingString.Length;

            while (counter < processingStringLength)
            {
                processingChar = processingString.Substring(counter, 1);

                if (uppercaseLetter)
                    processingChar = processingChar.ToUpper();

                if (counter == 0)
                    processingChar = processingChar.ToUpper();

                uppercaseLetter = ((processingChar == " ") // After a Space 
                                   || (processingChar == "(") // After an OPENING bracket
                                   || (processingChar == "-") // After a Hyphen
                                   || (processingChar == "[") // After a Square OPENING bracket                           
                                   || (processingChar == "&") // After an Ampersand                          
                                   || (processingChar == "+") // After a Plus
                                   || (processingChar == "!") // After an Exclamation
                                   || (processingChar == ",") // After a Comma - NOT FULL STOP for File Extensions!
                                   || (processingChar == ".") // After a Full Stop - added for "X." contacts in phone book
                    );

                outputString += processingChar;
                counter++;
            }
            return outputString;
        }
    }
}
