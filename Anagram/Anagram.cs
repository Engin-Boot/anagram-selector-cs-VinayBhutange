using System;
using System.Collections.Generic;
using System.Linq;


namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2)
        {
            //Insert the correct implementation here

            //check length of both words
            if(word1.Length != word2.Length)
            {
                return false;
            }

            //convert words to character array
            char[] word1Sort = word1.ToLower().ToCharArray();
            char[] word2Sort = word2.ToLower().ToCharArray();

            //sort the character array
            Array.Sort(word1Sort);
            Array.Sort(word2Sort);

            //comapre both array and return result
            return (word1Sort.SequenceEqual(word2Sort));
            
        }
        public List<string> SelectAnagrams(string word, List<string> candidates)
        {
            //Insert the correct implementation here

            //create a list for anagram candidate
            List<string> anagramCandidates = new List<string>();

            foreach(string candidate in candidates)
            {
                if (WordPairIsAnagram(word, candidate))
                {
                    anagramCandidates.Add(candidate);
                }
            }

            return anagramCandidates;

        }
    }
}
