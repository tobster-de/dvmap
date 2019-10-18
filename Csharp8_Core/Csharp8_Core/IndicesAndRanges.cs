using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App
{
    
    class IndicesAndRanges
    {
        public void Funky()
        {
            var words = new string[]
                        {
                            // index from start    index from end
                            "The",    // 0                   ^9
                            "quick",  // 1                   ^8
                            "brown",  // 2                   ^7
                            "fox",    // 3                   ^6
                            "jumped", // 4                   ^5
                            "over",   // 5                   ^4
                            "the",    // 6                   ^3
                            "lazy",   // 7                   ^2
                            "dog"     // 8                   ^1
                        };            // 9 (or words.Length) ^0

            // Fehler  CS0518 Der vordefinierte Typ "System.Index" ist nicht definiert oder importiert.
            Console.WriteLine($"The last word is {words[^1]}");
            
            // Fehler  CS0518 Der vordefinierte Typ "System.Range" ist nicht definiert oder importiert.
            var quickBrownFox = words[1..4];
        }

    }
    
}
