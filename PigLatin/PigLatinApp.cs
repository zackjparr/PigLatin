using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class PigLatinApp
    {
        public string PigPhrase { get; set; }
        public PigLatinApp(string input)
        {
            PigPhrase = input.ToLower();
        }

        public bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; //previous code would never pass the vowel through as true

            foreach(char v in vowels) // this code iterates through each letter and validates
            {
                if(c == v)
                {
                    return true;
                }
            }
            return false;
        }

        public string ToPigLatin()
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            string word = PigPhrase; //removed string word from ToPigLatin and used the class property instead
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return word;
                    }
                }

            }

            bool noVowels = true;
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }

            if (noVowels)
            {
                return word;
            }

            char firstLetter = word[0];
            string output = "placeholder";
            if (IsVowel(firstLetter) == true)
            {
                output = word + "ay";
            }
            else
            {
                int vowelIndex = -1;
                //Handle going through all the consonants
                for (int i = 0; i <= word.Length; i++)
                {
                    if (IsVowel(word[i]) == true)
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                string sub = word.Substring(vowelIndex); //elimated the +1 - 1 from index, did not grab correct char
                string postFix = word.Substring(0, vowelIndex);

                output = sub + postFix + "ay";
            }

            return output;
        }
    }
}
